// <auto-generated />
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
namespace T4MVC.Inquiry
{
    public class SharedViewsController
    {

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _boxListPartial = "_boxListPartial";
                public readonly string _layoutBootstrap = "_layoutBootstrap";
                public readonly string _layoutInquiry = "_layoutInquiry";
                public readonly string _recentPoListPartial = "_recentPoListPartial";
                public readonly string typeahead_css = "typeahead.css";
            }
            public readonly string _boxListPartial = "~/Areas/Inquiry/SharedViews/_boxListPartial.cshtml";
            public readonly string _layoutBootstrap = "~/Areas/Inquiry/SharedViews/_layoutBootstrap.cshtml";
            public readonly string _layoutInquiry = "~/Areas/Inquiry/SharedViews/_layoutInquiry.cshtml";
            public readonly string _recentPoListPartial = "~/Areas/Inquiry/SharedViews/_recentPoListPartial.cshtml";
            public readonly string typeahead_css = "~/Areas/Inquiry/SharedViews/typeahead.css.bundle";
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
