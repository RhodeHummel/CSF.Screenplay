﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSF.Screenplay.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionFormats {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionFormats() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CSF.Screenplay.Resources.ExceptionFormats", typeof(ExceptionFormats).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ability type must implement `{0}&apos;..
        /// </summary>
        internal static string AbilityMustImplementType {
            get {
                return ResourceManager.GetString("AbilityMustImplementType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not have the ability {1}..
        /// </summary>
        internal static string ActorIsMissingAnAbility {
            get {
                return ResourceManager.GetString("ActorIsMissingAnAbility", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All actors must have a name..
        /// </summary>
        internal static string ActorMustHaveAName {
            get {
                return ResourceManager.GetString("ActorMustHaveAName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All actors must have an identifier which references the current scenario..
        /// </summary>
        internal static string ActorMustHaveAScenarioId {
            get {
                return ResourceManager.GetString("ActorMustHaveAScenarioId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is already an actor named &apos;{0}&apos; contained within the current {1}. Duplicates are not permitted..
        /// </summary>
        internal static string DuplicateActorsNotAllowedInCast {
            get {
                return ResourceManager.GetString("DuplicateActorsNotAllowedInCast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The integration configuration type must implement `{0}&apos;..
        /// </summary>
        internal static string IntegrationConfigTypeMustImplementCorrectInterface {
            get {
                return ResourceManager.GetString("IntegrationConfigTypeMustImplementCorrectInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no actor currently in the spotlight..
        /// </summary>
        internal static string MustBeAnActorInTheSpotlight {
            get {
                return ResourceManager.GetString("MustBeAnActorInTheSpotlight", resourceCulture);
            }
        }
    }
}
