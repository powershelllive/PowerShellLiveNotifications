using System.Collections.Generic;
using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// Message to send to Discord Webhook.
    /// Represents a message sent in a channel within Discord.
    /// See <see href="https://discord.com/developers/docs/resources/webhook#execute-webhook-jsonform-params"/>.
    /// </summary>
    public class WebhookMessage : IWebhookMessage<MessageEmbedType>
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("embeds")]
        public IList<IMessageEmbed<MessageEmbedType>> Embeds { get; set; }

        /// <summary>
        /// Creates a <see cref="WebhookMessage"/>.
        /// </summary>
        public WebhookMessage(){}
    }
}