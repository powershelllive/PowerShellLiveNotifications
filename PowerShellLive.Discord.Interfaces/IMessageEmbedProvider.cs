using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IMessageEmbedProvider
    {
        [JsonPropertyName("name")]
        string Name { get; set; }

        [JsonPropertyName("url")]
        string Url { get; set; }
    }
}