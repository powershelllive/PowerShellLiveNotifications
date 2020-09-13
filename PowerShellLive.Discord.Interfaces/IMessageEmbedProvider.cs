using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Providers are only used internally by Discord.
    /// Unless this code is being used internally by Discord, any properties or parameters accepting this type should be <see cref="null"/> or undefined.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-provider-structure"/>.
    /// For information about internal use see <see href="https://github.com/discord/discord-api-docs/issues/596#issuecomment-387584815"/>.
    /// </summary>
    public interface IMessageEmbedProvider
    {
        /// <value>Name of provider.</value>
        [JsonPropertyName("name")]
        string Name { get; set; }

        /// <value>URL of provider.</value>
        [JsonPropertyName("url")]
        string Url { get; set; }
    }
}