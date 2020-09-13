using System.Threading.Tasks;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Discord Webhook service.
    /// Used to send messages to Discord webhooks.
    /// This services is intended to be used by dependency injection.
    /// See <see href="https://discord.com/developers/docs/resources/webhook"/>.
    /// </summary>
    /// <typeparam name="TMessageEmbedType">Enum type used for the Embed "Type" property of <see cref="IMessageEmbed{TMessageEmbedType}"/>.</typeparam>
    public interface IWebhookService<TMessageEmbedType>
    {
        /// <summary>
        /// Executes a Discord webhook by asynchronously sending a <see cref="IWebhookMessage{TMessageEmbedType}"/> payload.
        /// </summary>
        /// <param name="Message">A <see cref="IWebhookMessage{TMessageEmbedType}"/> containing the webhook payload.</param>
        /// <returns></returns>
        Task<IWebhookResult<TMessageEmbedType>> SendMessageAsync(IWebhookMessage<TMessageEmbedType> Message);
    }
}