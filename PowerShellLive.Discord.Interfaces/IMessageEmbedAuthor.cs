using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// The author of an Embed.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-author-structure"/>
    /// </summary>
    public interface IMessageEmbedAuthor
    {
        /// <value>Name of author.</value>
        [JsonPropertyName("name")]
        string Name { get; set; }

        /// <value>URL of author.</value>
        [JsonPropertyName("url")]
        string Url { get; set; }

        /// <value>URL of author icon (only supports http(s) and attachments)</value>
        [JsonPropertyName("icon_url")]
        string IconUrl { get; set; }

        /// <value>A proxied URL of author icon.
        /// This will be ignored when submitted to a webhook.
        /// It is only used when retrieving Embed data.</value>
        [JsonPropertyName("proxy_icon_url")]
        string ProxyIconUrl { get; set; }
    }
}