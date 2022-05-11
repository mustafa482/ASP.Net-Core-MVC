using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Extensions
{
   static public class Extensions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper,string name,string value = "",string placeHolder = "")
        {
            return htmlHelper.TextBox(name, value, new
            {
                style = "background-color:White; color:black;font-size:11px;",
                @class = "form-input",
                placeholder = placeHolder

            });
        }
    }
}
