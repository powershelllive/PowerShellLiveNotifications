using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    public class MessageEmbedFooter : IMessageEmbedFooter
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [JsonPropertyName("proxy_icon_url")]
        public string ProxyIconUrl { get; set; }

        public MessageEmbedFooter(){}
    }
}