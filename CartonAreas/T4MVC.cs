﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
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
public static partial class MVC_CartonAreas
{
    static readonly CartonAreasClass s_CartonAreas = new CartonAreasClass();
    public static CartonAreasClass CartonAreas { get { return s_CartonAreas; } }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class CartonAreasClass
    {
        public readonly string Name = "CartonAreas";
        public DcmsMobile.CartonAreas.Areas.CartonAreas.Controllers.AutoCompleteController AutoComplete = new DcmsMobile.CartonAreas.Areas.CartonAreas.Controllers.T4MVC_AutoCompleteController();
        public DcmsMobile.CartonAreas.Areas.CartonAreas.Controllers.HomeController Home = new DcmsMobile.CartonAreas.Areas.CartonAreas.Controllers.T4MVC_HomeController();
        public T4MVC.CartonAreas.SharedController Shared = new T4MVC.CartonAreas.SharedController();
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



namespace Links_CartonAreas
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string jquery_2_1_1_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.1.min.js") ? Url("jquery-2.1.1.min.js") : Url("jquery-2.1.1.js");
        public static readonly string jquery_ui_1_10_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.0.min.js") ? Url("jquery-ui-1.10.0.min.js") : Url("jquery-ui-1.10.0.js");
        public static readonly string jquery_mobile_1_4_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mobile-1.4.2.min.js") ? Url("jquery.mobile-1.4.2.min.js") : Url("jquery.mobile-1.4.2.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Content {
        private const string URLPATH = "~/Content";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string jquery_mobile_1_4_2_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mobile-1.4.2.min.css") ? Url("jquery.mobile-1.4.2.min.css") : Url("jquery.mobile-1.4.2.css");
             
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
    public static class Areas {
        private const string URLPATH = "~/Areas";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class CartonAreas {
            private const string URLPATH = "~/Areas/CartonAreas";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Content {
                private const string URLPATH = "~/Areas/CartonAreas/Content";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Autocomplete_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Autocomplete.partial.min.css") ? Url("Autocomplete.partial.min.css") : Url("Autocomplete.partial.css");
                     
                public static readonly string CartonAreas_all_css_bundle = Url("CartonAreas-all.css.bundle");
                public static readonly string CartonAreas_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartonAreas-all.min.css") ? Url("CartonAreas-all.min.css") : Url("CartonAreas-all.css");
                     
                public static readonly string CartonAreas_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartonAreas.partial.min.css") ? Url("CartonAreas.partial.min.css") : Url("CartonAreas.partial.css");
                     
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Areas/CartonAreas/Content/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string a1_gif = Url("a1.gif");
                    public static readonly string ajax_loader_gif = Url("ajax-loader.gif");
                    public static readonly string BOL_jpg = Url("BOL.jpg");
                }
            
                public static readonly string standardized_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/standardized.partial.min.css") ? Url("standardized.partial.min.css") : Url("standardized.partial.css");
                     
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Controllers {
                private const string URLPATH = "~/Areas/CartonAreas/Controllers";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Scripts {
                private const string URLPATH = "~/Areas/CartonAreas/Scripts";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string AutoComplete_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AutoComplete.partial.min.js") ? Url("AutoComplete.partial.min.js") : Url("AutoComplete.partial.js");
                public static readonly string CartonArea_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/CartonArea-all.min.js") ? Url("CartonArea-all.min.js") : Url("CartonArea-all.js");
                public static readonly string CartonArea_all_min_js_map = Url("CartonArea-all.min.js.map");
                public static readonly string Index_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Index-all.min.js") ? Url("Index-all.min.js") : Url("Index-all.js");
                public static readonly string Index_all_min_js_map = Url("Index-all.min.js.map");
                public static readonly string ManageCartonAreas_all_js_bundle = Url("ManageCartonAreas-all.js.bundle");
                public static readonly string ManageCartonAreas_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageCartonAreas-all.min.js") ? Url("ManageCartonAreas-all.min.js") : Url("ManageCartonAreas-all.js");
                public static readonly string ManageCartonAreas_all_min_js_map = Url("ManageCartonAreas-all.min.js.map");
                public static readonly string ManageCartonAreas_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManageCartonAreas.partial.min.js") ? Url("ManageCartonAreas.partial.min.js") : Url("ManageCartonAreas.partial.js");
                public static readonly string ManagePickingAreas_all_js_bundle = Url("ManagePickingAreas-all.js.bundle");
                public static readonly string ManagePickingAreas_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManagePickingAreas-all.min.js") ? Url("ManagePickingAreas-all.min.js") : Url("ManagePickingAreas-all.js");
                public static readonly string ManagePickingAreas_all_min_js_map = Url("ManagePickingAreas-all.min.js.map");
                public static readonly string ManagePickingAreas_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ManagePickingAreas.partial.min.js") ? Url("ManagePickingAreas.partial.min.js") : Url("ManagePickingAreas.partial.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Views {
                private const string URLPATH = "~/Areas/CartonAreas/Views";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Home {
                    private const string URLPATH = "~/Areas/CartonAreas/Views/Home";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Shared {
                    private const string URLPATH = "~/Areas/CartonAreas/Views/Shared";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                public static readonly string Web_config = Url("Web.config");
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
		 if (IsProduction())
        {
            if (virtualPath.EndsWith(".js") && !virtualPath.EndsWith(".min.js"))
            {
                path = path.Replace(".js", ".min.js");
            }
            else if (virtualPath.EndsWith(".css") && !virtualPath.EndsWith(".min.css"))
            {
                path = path.Replace(".css", ".min.css");
            }
        }
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
#pragma warning restore 1591


