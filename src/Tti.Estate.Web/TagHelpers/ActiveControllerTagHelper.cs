using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Text.Encodings.Web;

namespace Tti.Estate.Web.TagHelpers
{
    [HtmlTargetElement("a", Attributes = ClassAttributeName)]
    public class ActiveControllerTagHelper : TagHelper
    {
        private const string ClassAttributeName = "asp-active-class";

        [HtmlAttributeName("asp-controller")]
        public string Controller { get; set; }

        [HtmlAttributeName(ClassAttributeName)]
        public string Class { get; set; } = "active";

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Controller))
            {
                var currentController = ViewContext.RouteData.Values["Controller"].ToString();

                if (string.Equals(Controller, currentController, StringComparison.OrdinalIgnoreCase))
                {
                    output.AddClass(Class, HtmlEncoder.Default);
                }
            }
        }
    }
}
