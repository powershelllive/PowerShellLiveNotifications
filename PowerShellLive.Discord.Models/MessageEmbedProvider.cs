using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// Providers are only used internally by Discord.
    /// Unless this code is being used internally by Discord, any properties or parameters accepting this type should be <see cref="null"/> or undefined.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-provider-structure"/>.
    /// For information about internal use see <see href="https://github.com/discord/discord-api-docs/issues/596#issuecomment-387584815"/>.
    /// </summary>
    public class MessageEmbedProvider : IMessageEmbedProvider
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Creates a <see cref="MessageEmbedProvider"/>
        /// </summary>
        public MessageEmbedProvider(){}
    }
}