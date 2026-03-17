using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppStart.CustomHelpers
{
    public static class CustomHelper
    {
        public static MvcHtmlString SubmitButton(this HtmlHelper htmlHelper, string name, object value)
        {
            string btn = $"<input type='submit' value='{value}' name='{name}'/>";
            return new MvcHtmlString(btn);
        }
    }
}