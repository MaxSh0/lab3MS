// lab3MO.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <valarray>
#include <fstream>
#include <cmath>
const bool PenaltyFunctionMethod = false; // если true - используем метод штрафных функций, иначе - барьерных 
const int dimension = 2;
using namespace std;
typedef std::valarray<double> point;

int num_f = 0;
point x, x1;

//------------------------------------------------------------------------------------функция розенброка


//double function(point x)
//{
//  num_f++;
//  return 100.*(std::pow(x[1] - x[0]*x[0], 2.)) + std::pow(1. - x[0], 2.);
//}

//------------------------------------------------------------------------------------ ещё одна тестовая, совсем простая)
//double function(point x)
//{
//  num_f++;
//  return 5*x[0]*x[0] + 4*x[1]*x[1] + 1.;
//}
//-------------------------------------------------------------------------------------------------------------------------


double G(point x)//функция ограничения
{
	double limit;
	limit = 2 - x[0]* x[0] - x[1]* x[1] ;
	return limit;
};

//--------------------------------------------------------------------------------------------

double GPenalty(point x)//штрафная функция
{
	double g;
	//g = 0.5 * (G(x) + fabs(G(x)));
	g = pow(0.5*(G(x) + fabs(G(x))), 2);
	return g;
};

double GBarrier(point x)//барьерная функция
{
	double g;
	//g = -1. / G(x);
	g = -std::log(-G(x));
	return g;
}

//-----------------------------------------------------------------------------------функция из задания
double function(point A)
{
	num_f++;
	return A[0] * A[0] + A[1] * A[1];
		// -(1. / (1. + std::pow((A[0] - 2) / 3., 2.) + std::pow((A[1] - 2) / 3., 2.)) +
		//3. / (1. + std::pow(A[0] - 1., 2.) + std::pow((A[1] - 1) / 2., 2.)));
};
//-----------------------------------------------------------------------------------

double Q(point x, double r)//вспомогательная функция
{
	double f;
	if (PenaltyFunctionMethod)
		f = function(x) + r * GPenalty(x);
	else
		f = function(x) + r * GBarrier(x);
	return f;
};

point h(dimension);
double EPS = 1.e-10;

void HookeJeevesMethod(double r)
{
	int not_found = 1;
	int is_sample = 0;  // Индикатор поиска по образцу
	int iter_n = 0;

	point c(dimension), b(dimension), q(dimension);
	double f_x, f_s;

	h[0] = 0.1;
	h[1] = 0.1;
	b = x;

	while (h[0] > EPS)
	{

		++iter_n;
		f_s = Q(x, r);
		for (int i = 0; i < dimension; ++i)
		{
			f_x = Q(x, r);
			c = x;
			c[i] += h[i]; //шаг в положит. направлении i-ой коорд.

			if (Q(c, r) < f_x)
			{
				x = c;
				not_found = 0;
			}
			else
			{
				c[i] -= 2 * h[i]; //шаг в отриц. напр. i-ой корд.
				if (Q(c, r) < f_x)
				{
					x = c;
					not_found = 0;
				}
				else
					not_found = 1;
			}
		}
		if (is_sample)
		{
			if (not_found || !(Q(x, r) < Q(q, r)))
			{
				//вернуться к базовой точке
				x = q;
				b = q;
				is_sample = 0;
				continue;
			}
			else
			{
				b = q; //запомнить новую базовую точку
			}
		}
		else
		{
			if (not_found)
			{
				h *= 0.1; //если исслед. поиск законч. неудачей - уменьшить шаг
				continue;
			}
		}
		//поиск по образцу     
		q = x;
		x = 2. * x - b;
		is_sample = 1;
	}
}

double change_r(double &r)
{
	if (PenaltyFunctionMethod)
		r = r * 10.;
	else
		r /= 2.;
	return r;
}

double norm(point x)
{
	return std::sqrt((x * x).sum());
}

int main()
{
	std::ofstream res("rez.csv");
	res.precision(12);
	double r = (PenaltyFunctionMethod ? 0.1 : 1.);
	int k = 1;

	std::ifstream in("x0.txt");
	x.resize(dimension);
	x1.resize(dimension);

	for (int i = 0; i < dimension; i++)
	{
		in >> x1[i];
	}
	x = x1;
	point error(dimension);
	double norma;
	do
	{
		//x = x1;
		HookeJeevesMethod(r);
		error = x1 - x;
		x1 = x;
		norma = norm(error);
		cout << k << ";" << x[0] << ";" << x[1] << ";" << r << ";\n";
		r = change_r(r);
		k++;
	} while (norma > EPS);// условие выхода из цикла- по заданной точности 

						   //res << k - 1 << " " << num_f << " " << x[0] << " " << x[1] << " " << function(x) << std::endl;
	res << k - 1 << ";" << num_f << ";" << x[0] << ";" << x[1] << ";" << function(x) << ";\n";
	return 0;
}