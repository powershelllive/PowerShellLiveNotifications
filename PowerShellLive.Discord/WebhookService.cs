using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PowerShellLive.Discord.Interfaces;
using PowerShellLive.Discord.Models;


namespace PowerShellLive.Discord
{
    /// <summary>
    /// Discord Webhook service.
    /// Used to send messages to Discord webhooks.
    /// This services is intended to be used by dependency injection.
    /// See <see href="https://discord.com/developers/docs/resources/webhook"/>.
    /// </summary>
    /// <seealso cref="IWebhookService{TMessageEmbedType}"/>
    public class WebhookService : IWebhookService<MessageEmbedType>
    {
        private HttpClient _httpClient;
        private ILogger<WebhookService> _logger;
        private IOptions<WebhookOptions> _config;

        private JsonSerializerOptions jsonOptions;

        /// <summary>
        /// Creates a <see cref="WebhookService"/>.
        /// </summary>
        /// <param name="httpClient">A <see cref="HttpClient"/> used for sending messages to a Discord Webhook.</param>
        /// <param name="logger">An <see cref="ILogger{TCategoryName}"/> used for logging operations.</param>
        /// <param name="config"> An <see cref="IOptions{TOptions}"/> of <see cref="WebhookOptions"/> used to configure the webhook service.</param>
        public WebhookService(
            HttpClient httpClient,
            ILogger<WebhookService> logger,
            IOptions<WebhookOptions> config)
        {
            _httpClient = httpClient;
            _logger = logger;
            _config = config;

            jsonOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            jsonOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
        }

        public async Task<IWebhookResult<MessageEmbedType>> SendMessageAsync(IWebhookMessage<MessageEmbedType> Message)
        {
            var httpMessageBody = JsonSerializer.Serialize(Message, jsonOptions);

            _logger.LogInformation($"SendMessageAsync httpMessageBody: {httpMessageBody}");

            var httpMessage = new HttpRequestMessage()
            {
                RequestUri = _config.Value.WebhookUri,
                Content = new StringContent(httpMessageBody, Encoding.UTF8, MediaTypeNames.Application.Json),
                Method = HttpMethod.Post
            };

            try
            {
                var httpResponse = await _httpClient.SendAsync(httpMessage, HttpCompletionOption.ResponseContentRead);

                if(!httpResponse.IsSuccessStatusCode)
                {
                    _logger.LogError($"SendMessageAsync Request Failed");
                }

                _logger.LogInformation($"SendMessageAsync Success: {httpResponse.IsSuccessStatusCode}");
                _logger.LogInformation($"SendMessageAsync StatusCode: {httpResponse.StatusCode}");
                _logger.LogInformation($"SendMessageAsync ReasonPhrase: {httpResponse.ReasonPhrase}");
            
                var responseBody = await httpResponse.Content.ReadAsStringAsync();
                _logger.LogInformation($"SendMessageAsync Response:");
                _logger.LogInformation(responseBody);

                return new WebhookResult
                {
                    HttpResponseMessage = httpResponse,
                    ResponseBody = responseBody,
                    WebhookMessage = Message,
                    WebhookOptions = _config.Value,
                    IsSuccess = httpResponse.IsSuccessStatusCode
                };
            }
            catch (System.Exception e)
            {
                _logger.LogError(e,"SendMessageAsync Request Failed with exception");
                throw e;
            }
            
        }
    }
}