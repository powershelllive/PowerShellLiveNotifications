using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Text and/or icon to display in the footer of the Embed.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-footer-structure"/>.
    /// </summary>
    public interface IMessageEmbedFooter
    {
        /// <value>Footer text.</value>
        [JsonPropertyName("text")]
        string Text { get; set; }

        /// <value>URL of footer icon (only supports http(s) and attachments).</value>
        [JsonPropertyName("icon_url")]
        string IconUrl { get; set; }

        /// <value>A proxied url of footer icon.
        /// This will be ignored when submitted to a webhook.
        /// It is only used when retrieving Embed data.</value>
        [JsonPropertyName("proxy_icon_url")]
        string ProxyIconUrl { get; set; }
    }
}