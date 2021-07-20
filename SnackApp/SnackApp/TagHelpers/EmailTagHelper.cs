using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SnackApp.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        // prop
        public string Endereco { get; set; }
        public string Conteudo { get; set; }

        // override
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Endereco);
            output.Content.SetContent(Conteudo);
        }
    }
}