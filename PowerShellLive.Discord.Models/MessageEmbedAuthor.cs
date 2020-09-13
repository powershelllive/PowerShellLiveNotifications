using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// The author of an Embed.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-author-structure"/>
    /// </summary>
    public class MessageEmbedAuthor : IMessageEmbedAuthor
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("icon_url")]
        public string IconUrl { get; set; }

        [JsonPropertyName("proxy_icon_url")]
        public string ProxyIconUrl { get; set; }

        /// <summary>
        /// Creates a <see cref="MessageEmbedAuthor"/>
        /// </summary>
        public MessageEmbedAuthor(){}
    }
}