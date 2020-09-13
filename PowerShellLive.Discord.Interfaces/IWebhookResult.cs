using System.Net.Http;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Result from a webhook execution.
    /// </summary>
    /// <typeparam name="TMessageEmbedType">Enum type used for the Embed "Type" property of <see cref="IMessageEmbed{TMessageEmbedType}"/>.</typeparam>
    public interface IWebhookResult<TMessageEmbedType>
    {
        /// <value>
        /// The options that were used to execute the webhook.
        /// See <see cref="IWebhookOptions"/>.
        /// </value>
        IWebhookOptions WebhookOptions { get; set; }

        /// <value>
        /// The message that was used to construct the webhook payload.
        /// See <see cref="IWebhookMessage{TMessageEmbedType}"/>.
        /// </value>
        IWebhookMessage<TMessageEmbedType> WebhookMessage { get; set; }

        /// <value>The HTTP Response from the webhook execution.</value>
        HttpResponseMessage HttpResponseMessage { get; set; }

        /// <value>
        /// The message body from thewebhook execution response.
        /// This will be empty unless there was an error.
        /// </value>
        string ResponseBody { get; set; }

        /// <value>Whether or not the webhook execution was successfull.</value>
        bool IsSuccess { get; set; }
    }
}