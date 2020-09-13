using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// Image to display in the Embed.
    /// When submitting to a webhook, only the <c>Url</c> is required.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-image-structure"/>.
    /// </summary>
    public class MessageEmbedImage : IMessageEmbedImage
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("proxy_url")]
        public string ProxyUrl { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Creates a <see cref="MessageEmbedImage"/>.
        /// </summary>
        public MessageEmbedImage(){}
    }
}