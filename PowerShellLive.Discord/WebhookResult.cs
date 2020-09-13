using System.Net.Http;
using PowerShellLive.Discord.Interfaces;
using PowerShellLive.Discord.Models;

namespace PowerShellLive.Discord
{
    /// <summary>
    /// Result from a webhook execution.
    /// </summary>
    public class WebhookResult : IWebhookResult<MessageEmbedType>
    {
        public IWebhookOptions WebhookOptions { get; set; }
        public IWebhookMessage<MessageEmbedType> WebhookMessage { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }
        public string ResponseBody { get; set; }
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Creates a <see cref="WebhookResult"/>.
        /// </summary>
        public WebhookResult(){}

    }
}