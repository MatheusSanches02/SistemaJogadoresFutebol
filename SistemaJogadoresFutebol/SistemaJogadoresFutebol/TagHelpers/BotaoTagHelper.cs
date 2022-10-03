using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SistemaJogadoresFutebol.TagHelpers
{
    public class BotaoTagHelper : TagHelper
    {
        public string? Texto { get; set; }
        public string? Class { get; set; } = "btn btn-success";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Attributes.SetAttribute("class", Class);
            output.Attributes.SetAttribute("type", "submit");
            output.Content.SetContent(Texto);
        }
    }
}
