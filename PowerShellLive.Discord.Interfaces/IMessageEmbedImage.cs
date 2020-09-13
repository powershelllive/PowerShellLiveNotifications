using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Image to display in the Embed.
    /// When submitting to a webhook, only the <c>Url</c> is required.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-image-structure"/>.
    /// </summary>
    public interface IMessageEmbedImage
    {
        /// <value>Source url of image (only supports http(s) and attachments).</value>
        [JsonPropertyName("url")]
        string Url { get; set; }

        /// <value>A proxied url of the image.
        /// This will be ignored when submitted to a webhook.
        /// It is only used when retrieving Embed data.</value>
        [JsonPropertyName("proxy_url")]
        string ProxyUrl { get; set; }

        /// <value>Height of image.
        /// This will be ignored when submitted to a webhook.
        /// It is only used when retrieving Embed data.</value>
        [JsonPropertyName("height")]
        int Height { get; set; }

        /// <value>Width of image.
        /// This will be ignored when submitted to a webhook.
        /// It is only used when retrieving Embed data.</value>
        [JsonPropertyName("width")]
        int Width { get; set; }
    }
}