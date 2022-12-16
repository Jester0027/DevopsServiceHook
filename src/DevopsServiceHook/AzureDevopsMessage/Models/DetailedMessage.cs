namespace DevopsServiceHook.AzureDevopsMessage.Models;

public sealed record DetailedMessage
{
    public string Text { get; set; }
    public string Html { get; set; }
    public string Markdown { get; set; }
}