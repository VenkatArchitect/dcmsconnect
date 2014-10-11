﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
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
public static partial class MVC_PieceReplenish
{
    static readonly PieceReplenishClass s_PieceReplenish = new PieceReplenishClass();
    public static PieceReplenishClass PieceReplenish { get { return s_PieceReplenish; } }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class PieceReplenishClass
    {
        public readonly string Name = "PieceReplenish";
        public DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.AutoCompleteController AutoComplete = new DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.T4MVC_AutoCompleteController();
        public DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.DiagnosticController Diagnostic = new DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.T4MVC_DiagnosticController();
        public DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.HomeController Home = new DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.T4MVC_HomeController();
        public DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.RestockController Restock = new DcmsMobile.PieceReplenish.Areas.PieceReplenish.Controllers.T4MVC_RestockController();
        public T4MVC.PieceReplenish.SharedController Shared = new T4MVC.PieceReplenish.SharedController();
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



namespace Links_PieceReplenish
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
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/Start1.10.0/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
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
        public static partial class PieceReplenish {
            private const string URLPATH = "~/Areas/PieceReplenish";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Scripts {
                private const string URLPATH = "~/Areas/PieceReplenish/Scripts";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string AutoComplete_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AutoComplete.min.js") ? Url("AutoComplete.min.js") : Url("AutoComplete.js");
                public static readonly string AutoComplete_min_js_map = Url("AutoComplete.min.js.map");
                public static readonly string Pallet_desktop_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Pallet-desktop.min.js") ? Url("Pallet-desktop.min.js") : Url("Pallet-desktop.js");
                public static readonly string Pallet_desktop_min_js_map = Url("Pallet-desktop.min.js.map");
                public static readonly string PieceReplenish_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PieceReplenish.min.js") ? Url("PieceReplenish.min.js") : Url("PieceReplenish.js");
                public static readonly string PieceReplenish_min_js_map = Url("PieceReplenish.min.js.map");
                public static readonly string RedirectToChoice_js_bundle = Url("RedirectToChoice.js.bundle");
                public static readonly string RedirectToChoice_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/RedirectToChoice.min.js") ? Url("RedirectToChoice.min.js") : Url("RedirectToChoice.js");
                public static readonly string RedirectToChoice_min_js_map = Url("RedirectToChoice.min.js.map");
                public static readonly string RedirectToChoice_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/RedirectToChoice.partial.min.js") ? Url("RedirectToChoice.partial.min.js") : Url("RedirectToChoice.partial.js");
                public static readonly string RedirectToChoice_partial_min_js_map = Url("RedirectToChoice.partial.min.js.map");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class PieceReplenish {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Content {
                private const string URLPATH = "~/Areas/PieceReplenish/Content";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string AutoComplete_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AutoComplete.min.css") ? Url("AutoComplete.min.css") : Url("AutoComplete.css");
                     
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Areas/PieceReplenish/Content/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string a1_gif = Url("a1.gif");
                }
            
                public static readonly string PieceReplenish_all_css_bundle = Url("PieceReplenish-all.css.bundle");
                public static readonly string PieceReplenish_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PieceReplenish-all.min.css") ? Url("PieceReplenish-all.min.css") : Url("PieceReplenish-all.css");
                     
                public static readonly string PieceReplenish_mobile_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PieceReplenish-mobile-all.min.css") ? Url("PieceReplenish-mobile-all.min.css") : Url("PieceReplenish-mobile-all.css");
                     
                public static readonly string PieceReplenish_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PieceReplenish.partial.min.css") ? Url("PieceReplenish.partial.min.css") : Url("PieceReplenish.partial.css");
                     
                public static readonly string Replenishment_pptx = Url("Replenishment.pptx");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Sounds {
                    private const string URLPATH = "~/Areas/PieceReplenish/Content/Sounds";
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
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Scripts {}
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Styles {}
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
#pragma warning restore 1591, 3008, 3009


