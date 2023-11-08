using Entities.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Services.Contracts;


namespace ReaneaShopApp.Infrastructure.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "products")]
    public class LatestProductTagHelper : TagHelper
    {
        private readonly IServiceManager _manager;

        public LatestProductTagHelper(IServiceManager manager)
        {
            _manager = manager;
        }

        [HtmlAttributeName("number")]
        public int Number { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder div = new TagBuilder("div");
            div.Attributes.Add("class", "my-3");

            TagBuilder h6 = new TagBuilder("h6");
            h6.Attributes.Add("class", "lead");

            TagBuilder icon = new TagBuilder("i");
            icon.Attributes.Add("class", "fa fa-box text-secondary");

            h6.InnerHtml.AppendHtml(icon);
            h6.InnerHtml.AppendHtml(" Son Eklenen");

            TagBuilder ul = new TagBuilder("ul");

            var products = _manager.ProductService.GetLatestProducts(Number, false);
            foreach (Product prd in products)
            {
                TagBuilder li = new TagBuilder("li");

                TagBuilder a = new TagBuilder("a");
                a.Attributes.Add("href", $"/product/get/{prd.ProductId}");
                a.InnerHtml.AppendHtml(prd.ProductName);

                li.InnerHtml.AppendHtml(a);
                ul.InnerHtml.AppendHtml(li);
            }

            div.InnerHtml.AppendHtml(h6);
            div.InnerHtml.AppendHtml(ul);
            output.Content.AppendHtml(div);
        }
    }
}