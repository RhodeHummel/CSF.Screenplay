﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CSF.Screenplay.Reporting.Resources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionFormats {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionFormats() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("ExceptionFormats", typeof(ExceptionFormats).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string DuplicateScenarioInReportBuilder {
            get {
                return ResourceManager.GetString("DuplicateScenarioInReportBuilder", resourceCulture);
            }
        }
        
        internal static string NoMatchingScenarioInReportBuilder {
            get {
                return ResourceManager.GetString("NoMatchingScenarioInReportBuilder", resourceCulture);
            }
        }
        
        internal static string ScenarioAlreadyFinalised {
            get {
                return ResourceManager.GetString("ScenarioAlreadyFinalised", resourceCulture);
            }
        }
        
        internal static string PerformableWasRequiredInBuilderStack {
            get {
                return ResourceManager.GetString("PerformableWasRequiredInBuilderStack", resourceCulture);
            }
        }
        
        internal static string PerformableDoesNotMatchExpectedPerformance {
            get {
                return ResourceManager.GetString("PerformableDoesNotMatchExpectedPerformance", resourceCulture);
            }
        }
        
        internal static string ReportableMustBeGainAbilityOrPerformance {
            get {
                return ResourceManager.GetString("ReportableMustBeGainAbilityOrPerformance", resourceCulture);
            }
        }
        
        internal static string TracableEventIdMustBePositiveInteger {
            get {
                return ResourceManager.GetString("TracableEventIdMustBePositiveInteger", resourceCulture);
            }
        }
    }
}