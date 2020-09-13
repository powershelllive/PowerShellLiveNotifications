using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// Text and/or icon to display in the footer of the Embed.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-footer-structure"/>.
    /// </summary>
    public class MessageEmbedFooter : IMessageEmbedFooter
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [JsonPropertyName("proxy_icon_url")]
        public string ProxyIconUrl { get; set; }

        /// <summary>
        /// Creates a <see cref="MessageEmbedFooter"/>.
        /// </summary>
        public MessageEmbedFooter(){}
    }
}