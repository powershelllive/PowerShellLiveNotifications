using System.Text.Json.Serialization;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// Video information.
    /// This field is only used when retreiving embed data.
    /// Any properties or parameters accepting this type should be <see cref="null"/> or undefined.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-video-structure"/>.
    /// </summary>
    public class MessageEmbedVideo : IMessageEmbedVideo
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Creates a <see cref="MessageEmbedVideo"/>.
        /// </summary>
        public MessageEmbedVideo(){}
    }
}