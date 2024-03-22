using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVCDemo
{
    public static class CustomHelperClass
    {
        public static IHtmlString CustomImage(this HtmlHelper helper, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'></ img>", src, alt)); 
        }
    }
}