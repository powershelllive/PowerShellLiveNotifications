using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IWebhookMessage<MessageEmbedTypeEnum>
    {
        [JsonPropertyName("content")]
        string Content { get; set; }

        [JsonPropertyName("embeds")]
        IList<IMessageEmbed<MessageEmbedTypeEnum>> Embeds { get; set; }
    }
}