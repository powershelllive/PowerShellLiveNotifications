using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Video information.
    /// This field is only used when retreiving embed data.
    /// Any properties or parameters accepting this type should be <see cref="null"/> or undefined.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-video-structure"/>.
    /// </summary>
    public interface IMessageEmbedVideo
    {
        /// <value>Source url of video.</value>
        [JsonPropertyName("url")]
        string Url { get; set; }

        /// <value>Height of video.</value>
        [JsonPropertyName("height")]
        int Height { get; set; }

        /// <value>Width of video.</value>
        [JsonPropertyName("width")]
        int Width { get; set; }
    }
}