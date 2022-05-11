using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication1.TagHelpers
{
    //[HtmlTargetElement("email")]
    public class EmailTagHelpers:TagHelper
    {
        //Eger elementin adinin class adinin olmasini istemesen yuxaridaki kimi deyismelisen.
        public string Mail { get; set; }

        public string Display { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagName = "a";
            output.Attributes.Add("href", Mail);
            output.Content.Append(Display);
            base.Process(context, output);
            
        }
    }
}
