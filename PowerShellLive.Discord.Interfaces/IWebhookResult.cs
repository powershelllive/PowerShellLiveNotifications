using System.Net.Http;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IWebhookResult<MessageEmbedTypeEnum>
    {
        IWebhookOptions WebhookOptions { get; set; }
        IWebhookMessage<MessageEmbedTypeEnum> WebhookMessage { get; set; }
        HttpResponseMessage HttpResponseMessage { get; set; }

        string ResponseBody { get; set; }
        bool IsSuccess { get; set; }
    }
}