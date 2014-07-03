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
public static partial class MVC_Receiving
{
    static readonly ReceivingClass s_Receiving = new ReceivingClass();
    public static ReceivingClass Receiving { get { return s_Receiving; } }
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class ReceivingClass
    {
        public readonly string Name = "Receiving";
        public DcmsMobile.Receiving.Areas.Receiving.Controllers.AutoCompleteController AutoComplete = new DcmsMobile.Receiving.Areas.Receiving.Controllers.T4MVC_AutoCompleteController();
        public DcmsMobile.Receiving.Areas.Receiving.Controllers.HomeController Home = new DcmsMobile.Receiving.Areas.Receiving.Controllers.T4MVC_HomeController();
        public DcmsMobile.Receiving.Areas.Receiving.Controllers.RadController Rad = new DcmsMobile.Receiving.Areas.Receiving.Controllers.T4MVC_RadController();
        public T4MVC.Receiving.SharedController Shared = new T4MVC.Receiving.SharedController();
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



namespace Links_Receiving
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string jquery_2_0_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.0.3.min.js") ? Url("jquery-2.0.3.min.js") : Url("jquery-2.0.3.js");
        public static readonly string jquery_2_0_3_min_js = Url("jquery-2.0.3.min.js");
        public static readonly string jquery_ui_1_10_0_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-ui-1.10.0.min.js") ? Url("jquery-ui-1.10.0.min.js") : Url("jquery-ui-1.10.0.js");
        public static readonly string jquery_ui_1_10_0_min_js = Url("jquery-ui-1.10.0.min.js");
        public static readonly string jquery_mobile_1_4_2_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.mobile-1.4.2.min.js") ? Url("jquery.mobile-1.4.2.min.js") : Url("jquery.mobile-1.4.2.js");
        public static readonly string jquery_mobile_1_4_2_min_js = Url("jquery.mobile-1.4.2.min.js");
        public static readonly string jquery_validate_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.min.js") ? Url("jquery.validate.min.js") : Url("jquery.validate.js");
        public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
        public static readonly string jquery_validate_unobtrusive_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.validate.unobtrusive.min.js") ? Url("jquery.validate.unobtrusive.min.js") : Url("jquery.validate.unobtrusive.js");
        public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
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
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Content/themes/Start1.10.0/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string ui_bg_flat_55_999999_40x100_png = Url("ui-bg_flat_55_999999_40x100.png");
                    public static readonly string ui_bg_flat_75_aaaaaa_40x100_png = Url("ui-bg_flat_75_aaaaaa_40x100.png");
                    public static readonly string ui_bg_glass_45_0078ae_1x400_png = Url("ui-bg_glass_45_0078ae_1x400.png");
                    public static readonly string ui_bg_glass_55_f8da4e_1x400_png = Url("ui-bg_glass_55_f8da4e_1x400.png");
                    public static readonly string ui_bg_glass_75_79c9ec_1x400_png = Url("ui-bg_glass_75_79c9ec_1x400.png");
                    public static readonly string ui_bg_gloss_wave_45_e14f1c_500x100_png = Url("ui-bg_gloss-wave_45_e14f1c_500x100.png");
                    public static readonly string ui_bg_gloss_wave_50_6eac2c_500x100_png = Url("ui-bg_gloss-wave_50_6eac2c_500x100.png");
                    public static readonly string ui_bg_gloss_wave_75_2191c0_500x100_png = Url("ui-bg_gloss-wave_75_2191c0_500x100.png");
                    public static readonly string ui_bg_inset_hard_100_fcfdfd_1x100_png = Url("ui-bg_inset-hard_100_fcfdfd_1x100.png");
                    public static readonly string ui_icons_0078ae_256x240_png = Url("ui-icons_0078ae_256x240.png");
                    public static readonly string ui_icons_056b93_256x240_png = Url("ui-icons_056b93_256x240.png");
                    public static readonly string ui_icons_d8e7f3_256x240_png = Url("ui-icons_d8e7f3_256x240.png");
                    public static readonly string ui_icons_e0fdff_256x240_png = Url("ui-icons_e0fdff_256x240.png");
                    public static readonly string ui_icons_f5e175_256x240_png = Url("ui-icons_f5e175_256x240.png");
                    public static readonly string ui_icons_f7a50d_256x240_png = Url("ui-icons_f7a50d_256x240.png");
                    public static readonly string ui_icons_fcd113_256x240_png = Url("ui-icons_fcd113_256x240.png");
                }
            
                public static readonly string jquery_ui_min_css = Url("jquery-ui.min.css");
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Areas {
        private const string URLPATH = "~/Areas";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Receiving {
            private const string URLPATH = "~/Areas/Receiving";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Content {
                private const string URLPATH = "~/Areas/Receiving/Content";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Autocomplete_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Autocomplete.partial.min.css") ? Url("Autocomplete.partial.min.css") : Url("Autocomplete.partial.css");
                     
                public static readonly string Guided_Receiving_pps = Url("Guided Receiving.pps");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class images {
                    private const string URLPATH = "~/Areas/Receiving/Content/images";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string a1_gif = Url("a1.gif");
                    public static readonly string ajax_loader_gif = Url("ajax-loader.gif");
                    public static readonly string calendar_gif = Url("calendar.gif");
                }
            
                public static readonly string Receiving_all_css_bundle = Url("Receiving-all.css.bundle");
                public static readonly string Receiving_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receiving-all.min.css") ? Url("Receiving-all.min.css") : Url("Receiving-all.css");
                     
                public static readonly string Receiving_all_min_css = Url("Receiving-all.min.css");
                public static readonly string Receiving_mobile_all_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receiving-mobile-all.min.css") ? Url("Receiving-mobile-all.min.css") : Url("Receiving-mobile-all.css");
                     
                public static readonly string Receiving_mobile_all_min_css = Url("Receiving-mobile-all.min.css");
                public static readonly string Receiving_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receiving.partial.min.css") ? Url("Receiving.partial.min.css") : Url("Receiving.partial.css");
                     
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Sounds {
                    private const string URLPATH = "~/Areas/Receiving/Content/Sounds";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string _1_mp3 = Url("1.mp3");
                    public static readonly string _10_mp3 = Url("10.mp3");
                    public static readonly string _2_mp3 = Url("2.mp3");
                    public static readonly string _3_mp3 = Url("3.mp3");
                    public static readonly string _4_mp3 = Url("4.mp3");
                    public static readonly string _5_mp3 = Url("5.mp3");
                    public static readonly string _6_mp3 = Url("6.mp3");
                    public static readonly string _7_mp3 = Url("7.mp3");
                    public static readonly string _8_mp3 = Url("8.mp3");
                    public static readonly string _9_mp3 = Url("9.mp3");
                    public static readonly string error_wav = Url("error.wav");
                    public static readonly string PalletChange_wav = Url("PalletChange.wav");
                    public static readonly string palletscan_wav = Url("palletscan.wav");
                    public static readonly string scan_wav = Url("scan.wav");
                    public static readonly string warning_wav = Url("warning.wav");
                }
            
                public static readonly string standardized_partial_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/standardized.partial.min.css") ? Url("standardized.partial.min.css") : Url("standardized.partial.css");
                     
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Controllers {
                private const string URLPATH = "~/Areas/Receiving/Controllers";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Scripts {
                private const string URLPATH = "~/Areas/Receiving/Scripts";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string AutoComplete_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/AutoComplete.min.js") ? Url("AutoComplete.min.js") : Url("AutoComplete.js");
                public static readonly string AutoComplete_min_js = Url("AutoComplete.min.js");
                public static readonly string AutoComplete_min_js_map = Url("AutoComplete.min.js.map");
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Home {
                    private const string URLPATH = "~/Areas/Receiving/Scripts/Home";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string HandleScan_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/HandleScan.partial.min.js") ? Url("HandleScan.partial.min.js") : Url("HandleScan.partial.js");
                    public static readonly string PalletTabs_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PalletTabs.partial.min.js") ? Url("PalletTabs.partial.min.js") : Url("PalletTabs.partial.js");
                    public static readonly string PrintCarton_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/PrintCarton.partial.min.js") ? Url("PrintCarton.partial.min.js") : Url("PrintCarton.partial.js");
                    public static readonly string Receiving_all_js_bundle = Url("Receiving-all.js.bundle");
                    public static readonly string Receiving_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receiving-all.min.js") ? Url("Receiving-all.min.js") : Url("Receiving-all.js");
                    public static readonly string Receiving_all_min_js = Url("Receiving-all.min.js");
                    public static readonly string Receiving_all_min_js_map = Url("Receiving-all.min.js.map");
                    public static readonly string Receiving_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receiving.partial.min.js") ? Url("Receiving.partial.min.js") : Url("Receiving.partial.js");
                    public static readonly string ReceivingCore_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ReceivingCore.partial.min.js") ? Url("ReceivingCore.partial.min.js") : Url("ReceivingCore.partial.js");
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Rad {
                    private const string URLPATH = "~/Areas/Receiving/Scripts/Rad";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string ListEdit_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ListEdit.partial.min.js") ? Url("ListEdit.partial.min.js") : Url("ListEdit.partial.js");
                    public static readonly string Rad_all_js_bundle = Url("Rad-all.js.bundle");
                    public static readonly string Rad_all_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Rad-all.min.js") ? Url("Rad-all.min.js") : Url("Rad-all.js");
                    public static readonly string Rad_all_min_js = Url("Rad-all.min.js");
                    public static readonly string Rad_all_min_js_map = Url("Rad-all.min.js.map");
                }
            
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Views {
                private const string URLPATH = "~/Areas/Receiving/Views";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Home {
                    private const string URLPATH = "~/Areas/Receiving/Views/Home";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Rad {
                    private const string URLPATH = "~/Areas/Receiving/Views/Rad";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Shared {
                    private const string URLPATH = "~/Areas/Receiving/Views/Shared";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                    public static class DisplayTemplates {
                        private const string URLPATH = "~/Areas/Receiving/Views/Shared/DisplayTemplates";
                        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    }
                
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


