using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Message to send to Discord Webhook.
    /// Represents a message sent in a channel within Discord.
    /// See <see href="https://discord.com/developers/docs/resources/webhook#execute-webhook-jsonform-params"/>.
    /// </summary>
    /// <typeparam name="TMessageEmbedType">Enum type used for the Embed "Type" property of <see cref="IMessageEmbed{TMessageEmbedType}"/>.</typeparam>
    public interface IWebhookMessage<TMessageEmbedType>
    {
        /// <value>The message contents (up to 2000 characters).</value>
        [JsonPropertyName("content")]
        string Content { get; set; }

        /// <value>
        /// Up to 10 rich content embeds.
        /// See <see cref="IMessageEmbed{TMessageEmbedType}"/>.
        /// </value>
        [JsonPropertyName("embeds")]
        IList<IMessageEmbed<TMessageEmbedType>> Embeds { get; set; }
    }
}