using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// Additional fields to add to an embed.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-field-structure"/>.
    /// </summary>
    public class MessageEmbedField : IMessageEmbedField
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("inline")]
        public bool IsInline { get; set; }

        /// <summary>
        /// Creates a <see cref="MessageEmbedField"/>.
        /// </summary>
        public MessageEmbedField(){}
    }
}