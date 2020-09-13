using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Additional fields to add to an embed.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-field-structure"/>.
    /// </summary>
    public interface IMessageEmbedField
    {
        /// <value>Name of the field.</value>
        [JsonPropertyName("name")]
        string Name { get; set; }

        /// <value>Value of the field.</value>
        [JsonPropertyName("value")]
        string Value { get; set; }

        /// <value>Whether or not this field should display inline</value>
        [JsonPropertyName("inline")]
        bool IsInline { get; set; }
    }
}