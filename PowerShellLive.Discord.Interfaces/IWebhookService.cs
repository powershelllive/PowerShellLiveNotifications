using System.Threading.Tasks;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IWebhookService<MessageEmbedTypeEnum>
    {
        Task<IWebhookResult<MessageEmbedTypeEnum>> SendMessageAsync(IWebhookMessage<MessageEmbedTypeEnum> Message);
    }
}