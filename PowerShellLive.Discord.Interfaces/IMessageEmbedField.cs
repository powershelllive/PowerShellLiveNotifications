using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IMessageEmbedField
    {
        [JsonPropertyName("name")]
        string Name { get; set; }

        [JsonPropertyName("value")]
        string Value { get; set; }

        [JsonPropertyName("inline")]
        bool IsInline { get; set; }
    }
}