using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IMessageEmbedFooter
    {
        [JsonPropertyName("text")]
        string Text { get; set; }

        [JsonPropertyName("icon_url")]
        string IconUrl { get; set; }

        [JsonPropertyName("proxy_icon_url")]
        string ProxyIconUrl { get; set; }
    }
}