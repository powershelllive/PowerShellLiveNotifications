using System.Collections.Generic;
using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    public class WebhookMessage : IWebhookMessage<MessageEmbedType>
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("embeds")]
        public IList<IMessageEmbed<MessageEmbedType>> Embeds { get; set; }

        public WebhookMessage(){}
    }
}