using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IMessageEmbedImage
    {
        [JsonPropertyName("url")]
        string Url { get; set; }

        [JsonPropertyName("proxy_url")]
        string ProxyUrl { get; set; }

        [JsonPropertyName("height")]
        int Height { get; set; }

        [JsonPropertyName("width")]
        int Width { get; set; }
    }
}