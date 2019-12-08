using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace MS_lab3
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }


        static void Water( int i)
        {
            Console.ReadLine();
        }
    }
}
