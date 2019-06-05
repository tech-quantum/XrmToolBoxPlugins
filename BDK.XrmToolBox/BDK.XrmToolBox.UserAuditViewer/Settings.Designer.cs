﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDK.XrmToolBox.UserAuditViewer {
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
    internal class Settings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Settings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BDK.XrmToolBox.UserAuditViewer.Settings", typeof(Settings).Assembly);
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
        ///   Looks up a localized string similar to &lt;fetch&gt;
        ///  &lt;entity name=&quot;systemuser&quot; &gt;
        ///    &lt;all-attributes/&gt;
        ///    &lt;filter type=&quot;and&quot; &gt;
        ///      &lt;condition attribute=&quot;isdisabled&quot; operator=&quot;eq&quot; value=&quot;0&quot; /&gt;
        ///      &lt;condition attribute=&quot;accessmode&quot; operator=&quot;eq&quot; value=&quot;0&quot; /&gt;
        ///    &lt;/filter&gt;
        ///  &lt;/entity&gt;
        ///&lt;/fetch&gt;.
        /// </summary>
        internal static string FetchXml_EnabledUsers {
            get {
                return ResourceManager.GetString("FetchXml_EnabledUsers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;fetch count=&quot;1&quot; &gt;
        ///  &lt;entity name=&quot;audit&quot; &gt;
        /// &lt;attribute name=&quot;createdon&quot;  /&gt;
        ///    &lt;filter&gt;
        ///      &lt;condition attribute=&quot;operation&quot; operator=&quot;eq&quot; value=&quot;4&quot; /&gt;
        ///      &lt;condition attribute=&quot;objectid&quot; operator=&quot;eq&quot; value=&quot;{0}&quot; /&gt;
        ///    &lt;/filter&gt;
        ///    &lt;order attribute=&quot;createdon&quot; descending=&quot;true&quot; /&gt;
        ///  &lt;/entity&gt;
        ///&lt;/fetch&gt;.
        /// </summary>
        internal static string FetchXml_LastLoginCheck {
            get {
                return ResourceManager.GetString("FetchXml_LastLoginCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;fetch count=&quot;50&quot; page=&quot;{1}&quot; paging-cookie=&quot;{2}&quot; returntotalrecordcount=&quot;true&quot; &gt;
        ///  &lt;entity name=&quot;audit&quot; &gt;
        ///    &lt;all-attributes/&gt;
        ///    &lt;filter&gt;
        ///      &lt;condition attribute=&quot;operation&quot; operator=&quot;eq&quot; value=&quot;4&quot; /&gt;
        ///      &lt;condition attribute=&quot;objectid&quot; operator=&quot;eq&quot; value=&quot;{0}&quot; /&gt;
        ///    &lt;/filter&gt;
        ///    &lt;order attribute=&quot;createdon&quot; descending=&quot;true&quot; /&gt;
        ///  &lt;/entity&gt;
        ///&lt;/fetch&gt;.
        /// </summary>
        internal static string FetchXml_UserLogin {
            get {
                return ResourceManager.GetString("FetchXml_UserLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;fetch count=&quot;50&quot; page=&quot;{1}&quot; paging-cookie=&quot;{2}&quot; returntotalrecordcount=&quot;true&quot;&gt;
        ///  &lt;entity name=&quot;audit&quot; &gt;
        ///    &lt;all-attributes/&gt;
        ///    &lt;filter&gt;
        ///      &lt;condition attribute=&quot;operation&quot; operator=&quot;neq&quot; value=&quot;4&quot; /&gt;
        ///      &lt;condition attribute=&quot;userid&quot; operator=&quot;eq&quot; value=&quot;{0}&quot; /&gt;
        ///    &lt;/filter&gt;
        ///    &lt;order attribute=&quot;createdon&quot; descending=&quot;true&quot; /&gt;
        ///  &lt;/entity&gt;
        ///&lt;/fetch&gt;.
        /// </summary>
        internal static string FetchXml_UserTransactions {
            get {
                return ResourceManager.GetString("FetchXml_UserTransactions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;fetch&gt;
        ///  &lt;entity name=&quot;savedquery&quot; &gt;
        ///    &lt;attribute name=&quot;name&quot; /&gt;
        ///    &lt;attribute name=&quot;savedqueryid&quot; /&gt;
        ///    &lt;attribute name=&quot;isdefault&quot; /&gt;
        ///    &lt;filter type=&quot;and&quot; &gt;
        ///      &lt;condition attribute=&quot;returnedtypecode&quot; operator=&quot;eq&quot; value=&quot;8&quot; /&gt;
        ///      &lt;condition attribute=&quot;querytype&quot; operator=&quot;eq&quot; value=&quot;0&quot; /&gt;
        ///    &lt;/filter&gt;
        ///  &lt;/entity&gt;
        ///&lt;/fetch&gt;.
        /// </summary>
        internal static string FetchXml_UserViews {
            get {
                return ResourceManager.GetString("FetchXml_UserViews", resourceCulture);
            }
        }
    }
}
