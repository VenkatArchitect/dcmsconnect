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
        public DcmsMobile.Receiving.Areas.Receiving.Home.HomeController Home = new DcmsMobile.Receiving.Areas.Receiving.Home.T4MVC_HomeController();
        public DcmsMobile.Receiving.Areas.Receiving.Rad.RadController Rad = new DcmsMobile.Receiving.Areas.Receiving.Rad.T4MVC_RadController();
        public T4MVC.Receiving.SharedViewsController SharedViews = new T4MVC.Receiving.SharedViewsController();
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



namespace Links_Receiving
{

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Areas {
        private const string URLPATH = "~/Areas";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static partial class Receiving {
            private const string URLPATH = "~/Areas/Receiving";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Home {
                private const string URLPATH = "~/Areas/Receiving/Home";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string Guided_Receiving_pps = Url("Guided Receiving.pps")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Guided Receiving.pps");
                public static readonly string Guided_Receiving_ppsx = Url("Guided Receiving.ppsx")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Guided Receiving.ppsx");
                public static readonly string ProcessEditor_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/ProcessEditor.min.js") ? Url("ProcessEditor.min.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/ProcessEditor.min.js") : Url("ProcessEditor.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/ProcessEditor.js");
                        public static readonly string ProcessEditor_min_js_map = Url("ProcessEditor.min.js.map")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/ProcessEditor.min.js.map");
                public static readonly string Receiving_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Receiving.min.js") ? Url("Receiving.min.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Receiving.min.js") : Url("Receiving.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Receiving.js");
                        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Repository {
                    private const string URLPATH = "~/Areas/Receiving/Home/Repository";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                }
            
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public static class Sounds {
                    private const string URLPATH = "~/Areas/Receiving/Home/Sounds";
                    public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                    public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                    public static readonly string Error_mp3 = Url("Error.mp3")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Error.mp3");
                    public static readonly string success_mp3 = Url("success.mp3")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/success.mp3");
                }
            
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class Receiving {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class Rad {
                private const string URLPATH = "~/Areas/Receiving/Rad";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string _addSpotCheck_partial_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_addSpotCheck.partial.min.js") ? Url("_addSpotCheck.partial.min.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/_addSpotCheck.partial.min.js") : Url("_addSpotCheck.partial.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/_addSpotCheck.partial.js");
                        public static readonly string Index_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Index.min.js") ? Url("Index.min.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Index.min.js") : Url("Index.js")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Index.js");
                        public static readonly string Index_min_js_map = Url("Index.min.js.map")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/Index.min.js.map");
            }
        
        }
    }

    public static partial class Areas {
    
        public static partial class Receiving {
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class SharedViews {
                private const string URLPATH = "~/Areas/Receiving/SharedViews";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string ajax_loader_gif = Url("ajax-loader.gif")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/ajax-loader.gif");
                public static readonly string typeahed_css = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/typeahed.min.css") ? Url("typeahed.min.css")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/typeahed.min.css") : Url("typeahed.css")+"?"+T4MVCHelpers.TimestampString(URLPATH + "/typeahed.css");
                        }
        
        }
    }
    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Areas 
        {
            public static partial class Receiving 
            {
                public static partial class Home 
                {
                    public static partial class Repository 
                    {
                        public static class Assets
                        {
                        }
                    }
                    public static partial class Sounds 
                    {
                        public static class Assets
                        {
                        }
                    }
                    public static class Assets
                    {
                        public const string Receiving_js = "~/Areas/Receiving/Home/Receiving.js"; 
                    }
                }
            }
        }
        public static partial class Areas 
        {
            public static partial class Receiving 
            {
                public static partial class Rad 
                {
                    public static class Assets
                    {
                        public const string _addSpotCheck_partial_js = "~/Areas/Receiving/Rad/_addSpotCheck.partial.js"; 
                    }
                }
            }
        }
        public static partial class Areas 
        {
            public static partial class Receiving 
            {
                public static partial class SharedViews 
                {
                    public static class Assets
                    {
                    }
                }
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


