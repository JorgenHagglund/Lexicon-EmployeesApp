using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;

namespace EmployeesApp.Web.TagHelpers;
[HtmlTargetElement("bootstrap")]
public class BootstrapTagHelper : TagHelper
{
    public string Message { get; set; }

    //
    // Summary:
    //     Synchronously executes the Microsoft.AspNetCore.Razor.TagHelpers.TagHelper with
    //     the given context and output.
    //
    // Parameters:
    //   context:
    //     Contains information associated with the current HTML tag.
    //
    //   output:
    //     A stateful HTML element used to generate an HTML tag.
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "link";
        output.TagMode = TagMode.SelfClosing;
        output.Attributes.Add("rel", "stylesheet");
        output.Attributes.Add("type", "text/css");
        output.Attributes.Add("href", "https://cdn.jsdelivr.net/npm/bootstrap@5.3.6/dist/css/bootstrap.min.css");
        // Hanterar ev. specialtecken så de visas korrekt i JavaScript
        //string encodedMessage = JavaScriptEncoder.Default.Encode(Message);
        //output.Content.SetHtmlContent($"alert('{encodedMessage}');");
    }

}
