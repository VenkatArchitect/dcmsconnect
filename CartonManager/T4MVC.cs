﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC_CartonManager
{
    static readonly CartonManagerClass s_CartonManager = new CartonManagerClass();
    public static CartonManagerClass CartonManager { get { return s_CartonManager; } }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class CartonManagerClass
    {
        public readonly string Name = "CartonManager";
        public DcmsMobile.CartonManager.Areas.CartonManager.Controllers.AutoCompleteController AutoComplete = new DcmsMobile.CartonManager.Areas.CartonManager.Controllers.T4MVC_AutoCompleteController();
        public DcmsMobile.CartonManager.Areas.CartonManager.Controllers.HomeController Home = new DcmsMobile.CartonManager.Areas.CartonManager.Controllers.T4MVC_HomeController();
        public DcmsMobile.CartonManager.Areas.CartonManager.Controllers.LocatingController Locating = new DcmsMobile.CartonManager.Areas.CartonManager.Controllers.T4MVC_LocatingController();
        public T4MVC.CartonManager.SharedController Shared = new T4MVC.CartonManager.SharedController();
    }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}
[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_JsonResult : System.Web.Mvc.JsonResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links_CartonManager
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string jquery_2_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.min.js") ? Url("jquery-2.1.1.min.js") : Url("jquery-2.1.1.js");
        public static readonly string jquery_ui_1_10_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.0.min.js") ? Url("jquery-ui-1.10.0.min.js") : Url("jquery-ui-1.10.0.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class themes {
            private const string URLPATH = "~/Content/themes";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Start1_10_0 {
                private const string URLPATH = "~/Content/themes/Start1.10.0";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string jquery_ui_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui.min.css") ? Url("jquery-ui.min.css") : Url("jquery-ui.css");
            }
        
        }
    
    }


    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Areas {
        private const string URLPATH = "~/Areas";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class CartonManager {
            private const string URLPATH = "~/Areas/CartonManager";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Scripts {
                private const string URLPATH = "~/Areas/CartonManager/Scripts";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string AdvanceUi_all_js_bundle = Url("AdvanceUi-all.js.bundle");
                public static readonly string AdvanceUi_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AdvanceUi-all.min.js") ? Url("AdvanceUi-all.min.js") : Url("AdvanceUi-all.js");
                public static readonly string AdvanceUi_all_min_js_map = Url("AdvanceUi-all.min.js.map");
                public static readonly string AdvanceUi_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AdvanceUi.partial.min.js") ? Url("AdvanceUi.partial.min.js") : Url("AdvanceUi.partial.js");
                public static readonly string AutoComplete_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AutoComplete.partial.min.js") ? Url("AutoComplete.partial.min.js") : Url("AutoComplete.partial.js");
                public static readonly string CartonEditor_all_js_bundle = Url("CartonEditor-all.js.bundle");
                public static readonly string CartonEditor_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartonEditor-all.min.js") ? Url("CartonEditor-all.min.js") : Url("CartonEditor-all.js");
                public static readonly string CartonEditor_all_min_js_map = Url("CartonEditor-all.min.js.map");
                public static readonly string CartonEditor_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartonEditor.partial.min.js") ? Url("CartonEditor.partial.min.js") : Url("CartonEditor.partial.js");
                public static readonly string CommonPalletize_all_js_bundle = Url("CommonPalletize-all.js.bundle");
                public static readonly string CommonPalletize_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CommonPalletize-all.min.js") ? Url("CommonPalletize-all.min.js") : Url("CommonPalletize-all.js");
                public static readonly string CommonPalletize_all_min_js_map = Url("CommonPalletize-all.min.js.map");
                public static readonly string CommonPalletize_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CommonPalletize.partial.min.js") ? Url("CommonPalletize.partial.min.js") : Url("CommonPalletize.partial.js");
                public static readonly string DestPallet_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/DestPallet.partial.min.js") ? Url("DestPallet.partial.min.js") : Url("DestPallet.partial.js");
                public static readonly string HandleScan_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/HandleScan.partial.min.js") ? Url("HandleScan.partial.min.js") : Url("HandleScan.partial.js");
                public static readonly string Index_mobile_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Index-mobile-all.min.js") ? Url("Index-mobile-all.min.js") : Url("Index-mobile-all.js");
                public static readonly string Index_mobile_all_min_js_map = Url("Index-mobile-all.min.js.map");
                public static readonly string InitScan_mobile_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/InitScan-mobile-all.min.js") ? Url("InitScan-mobile-all.min.js") : Url("InitScan-mobile-all.js");
                public static readonly string InitScan_mobile_all_min_js_map = Url("InitScan-mobile-all.min.js.map");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class CartonManager {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Content {
                private const string URLPATH = "~/Areas/CartonManager/Content";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Autocomplete_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Autocomplete.partial.min.css") ? Url("Autocomplete.partial.min.css") : Url("Autocomplete.partial.css");
                public static readonly string CartonManager_all_css_bundle = Url("CartonManager-all.css.bundle");
                public static readonly string CartonManager_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartonManager-all.min.css") ? Url("CartonManager-all.min.css") : Url("CartonManager-all.css");
                public static readonly string CartonManager_mobile_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartonManager-mobile-all.min.css") ? Url("CartonManager-mobile-all.min.css") : Url("CartonManager-mobile-all.css");
                public static readonly string Common_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Common.partial.min.css") ? Url("Common.partial.min.css") : Url("Common.partial.css");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Areas/CartonManager/Content/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string a1_gif = Url("a1.gif");
                    public static readonly string ajax_loader_gif = Url("ajax-loader.gif");
                }
            
                public static readonly string Site_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Site.partial.min.css") ? Url("Site.partial.min.css") : Url("Site.partial.css");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Sounds {
                    private const string URLPATH = "~/Areas/CartonManager/Content/Sounds";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string Error_wav = Url("Error.wav");
                    public static readonly string success_wav = Url("success.wav");
                    public static readonly string warning_wav = Url("warning.wav");
                }
            
                public static readonly string standardized_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/standardized.partial.min.css") ? Url("standardized.partial.min.css") : Url("standardized.partial.css");
            }
        
        }
    }
    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static class Assets
            {
                public const string jquery_2_1_1_js = "~/Scripts/jquery-2.1.1.js"; 
                public const string jquery_ui_1_10_0_js = "~/Scripts/jquery-ui-1.10.0.js"; 
                public const string jquery_validate_js = "~/Scripts/jquery.validate.js"; 
                public const string jquery_validate_unobtrusive_js = "~/Scripts/jquery.validate.unobtrusive.js"; 
            }
        }
        public static partial class Content 
        {
            public static partial class themes 
            {
                public static partial class Start1_10_0 
                {
                    public static class Assets
                    {
                        public const string jquery_ui_css = "~/Content/themes/Start1.10.0/jquery-ui.css";
                    }
                }
                public static class Assets
                {
                }
            }
            public static class Assets
            {
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114


