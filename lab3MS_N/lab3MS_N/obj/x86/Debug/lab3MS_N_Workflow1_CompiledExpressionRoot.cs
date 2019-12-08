namespace lab3MS_N {
    
    #line 14 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 15 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 16 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 17 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 18 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\mshak_000\source\repos\lab3MS_N\lab3MS_N\Workflow1.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow1 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow1_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext1 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext2 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext3 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext4 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext5 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext6 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext7 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext8 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext9 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext10 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext11 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext12 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext13 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext14 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext15 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext16 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext17 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext18 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext19 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext20 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext21 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext22 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 8);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext23 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext23.ValueType___Expr23Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext1 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext2 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Workflow1_TypedDataContext3 refDataContext3 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext4 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext5 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext6 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext7 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext8 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext9 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext9.ValueType___Expr9Get();
            }
            if ((expressionId == 10)) {
                Workflow1_TypedDataContext4 refDataContext10 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext11 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext12 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext13 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext14 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext15 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext16 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Workflow1_TypedDataContext5 refDataContext17 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext17.GetLocation<string>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext18 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext18.ValueType___Expr18Get();
            }
            if ((expressionId == 19)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext19 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext20 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext21 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext22 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext23 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "\"\";") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Активное состояние \\nВыберите действие:\\n 1 - Команда паузы\\n 2 - Команда выхода" +
                            "\";") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine();") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Nastya") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Nastya == \"1\";") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nВыполняется команда паузы\"") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Nastya == \"2\";") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nВыполняется команда завершения процесса\";") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Неактивное состояние \\nВыберите действие:\\n 1 - Переход в активное состояние\\n 2" +
                            " - Команда выхода\";") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine();") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Nastya") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Nastya == \"1\";") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nПереход в активное состояние\"") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Nastya == \"2\";") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nВыходим из приложения\";") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Пауза \\nВыберите действие:\\n 1 - Вернуться в активное состояние\\n 2 - Команда за" +
                            "вершения процесса\";") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine();") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Nastya") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Nastya == \"2\";") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nВыполняется команда выхода\";") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Nastya == \"1\";") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"\\nПереход в активное состояние\";") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Все , это конец, приплыли тапочки к дивану\";") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Time;") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1 : Workflow1_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow1_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1_ForReadOnly : Workflow1_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow1_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2 : Workflow1_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan Time;
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Nastya {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Time = ((System.TimeSpan)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((1 + locationsOffset), this.Time);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Nastya") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Time") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2_ForReadOnly : Workflow1_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected System.TimeSpan Time;
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string Nastya {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 216 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          "";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 216 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
          "";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Time = ((System.TimeSpan)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Nastya") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Time") 
                            || (locationReferences[(offset + 1)].Type != typeof(System.TimeSpan)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 50 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  Nastya;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 50 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                  Nastya;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 50 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                
                  Nastya = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 44 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                "Активное состояние \nВыберите действие:\n 1 - Команда паузы\n 2 - Команда выхода";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 44 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                "Активное состояние \nВыберите действие:\n 1 - Команда паузы\n 2 - Команда выхода";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 55 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  Console.ReadLine();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 55 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                  Console.ReadLine();;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 191 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              Nastya == "1";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 191 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
              Nastya == "1";;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 186 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "\nВыполняется команда паузы";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 186 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                  "\nВыполняется команда паузы";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 203 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              Nastya == "2";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr6Get() {
                
                #line 203 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
              Nastya == "2";;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 198 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "\nВыполняется команда завершения процесса";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 198 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                  "\nВыполняется команда завершения процесса";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 100 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Nastya;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 100 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                                  Nastya;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(string value) {
                
                #line 100 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                
                                  Nastya = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 94 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                "Неактивное состояние \nВыберите действие:\n 1 - Переход в активное состояние\n 2 - Команда выхода";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 94 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                                "Неактивное состояние \nВыберите действие:\n 1 - Переход в активное состояние\n 2 - Команда выхода";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 105 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Console.ReadLine();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 105 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                                  Console.ReadLine();;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 121 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Nastya == "1";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr11Get() {
                
                #line 121 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                              Nastya == "1";;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 116 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "\nПереход в активное состояние";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 116 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                                  "\nПереход в активное состояние";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 151 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                              Nastya == "2";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 151 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                              Nastya == "2";;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 146 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "\nВыходим из приложения";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 146 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                                  "\nВыходим из приложения";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 75 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          Nastya;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 75 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                          Nastya;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(string value) {
                
                #line 75 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                
                          Nastya = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 69 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                        "Пауза \nВыберите действие:\n 1 - Вернуться в активное состояние\n 2 - Команда завершения процесса";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 69 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                        "Пауза \nВыберите действие:\n 1 - Вернуться в активное состояние\n 2 - Команда завершения процесса";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 80 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          Console.ReadLine();;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 80 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                          Console.ReadLine();;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 165 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Nastya == "2";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr18Get() {
                
                #line 165 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                      Nastya == "2";;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 160 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          "\nВыполняется команда выхода";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 160 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                          "\nВыполняется команда выхода";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 177 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Nastya == "1";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr20Get() {
                
                #line 177 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                      Nastya == "1";;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 172 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                          "\nПереход в активное состояние";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 172 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                          "\nПереход в активное состояние";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext6 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext6_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 131 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                        "Все , это конец, приплыли тапочки к дивану";;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 131 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                                        "Все , это конец, приплыли тапочки к дивану";;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 136 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<System.TimeSpan>> expression = () => 
                                        Time;;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.TimeSpan @__Expr23Get() {
                
                #line 136 "C:\USERS\MSHAK_000\SOURCE\REPOS\LAB3MS_N\LAB3MS_N\WORKFLOW1.XAML"
                return 
                                        Time;;
                
                #line default
                #line hidden
            }
            
            public System.TimeSpan ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
