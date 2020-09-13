using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// A Discord webhook message embed.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object"/>
    /// </summary>
    /// <typeparam name="TMessageEmbedType">Enum type used for the Embed "Type" property.</typeparam>
    public interface IMessageEmbed<TMessageEmbedType>
    {
        /// <value>The title of the embed.</value>
        [JsonPropertyName("title")]
        string Title { get; set; }

        /// <value><see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-types">Type of embed</see> (always "rich" for webhook embeds)</value>
        [JsonPropertyName("type")]
        TMessageEmbedType Type { get; set; }

        /// <value>Description of embed.</value>
        [JsonPropertyName("description")]
        string Description { get; set; }

        /// <value>Url of embed.</value>
        [JsonPropertyName("url")]
        string Url { get; set; }

        /// <value>ISO8601 timestamp timestamp of embed content.</value>
        [JsonPropertyName("timestamp")]
        DateTime Timestamp { get; set; }

        /// <value>Color code of the embed</value>
        [JsonPropertyName("color")]
        int Color { get; set; }

        /// <value>Footer information. See <see cref="IMessageEmbedFooter"/></value>
        /// <see cref="IMessageEmbedFooter"/>
        [JsonPropertyName("footer")]
        IMessageEmbedFooter Footer { get; set; }

        /// <value>Image information. See <see cref="IMessageEmbedImage"/></value>
        /// <see cref="IMessageEmbedImage"/>
        [JsonPropertyName("image")]
        IMessageEmbedImage Image { get; set; }

        /// <value>Thumbnail information. See <see cref="IMessageEmbedImage"/></value>
        /// <see cref="IMessageEmbedImage"/>
        [JsonPropertyName("thumbnail")]
        IMessageEmbedImage Thumbnail { get; set; }

        /// <value>Video information.
        /// This will be ignored when submitted to a webhook.
        /// It is only used when retrieving Embed data.
        /// See <see cref="IMessageEmbedVideo"/></value>
        /// <see cref="IMessageEmbedVideo"/>
        [JsonPropertyName("video")]
        IMessageEmbedVideo Video { get; set; }

        /// <value>Provider information.
        /// See <see cref="IMessageEmbedProvider"/>.
        /// This should be null or undefined.
        /// This property is only useful internally to Discord and will be ignored.</value>
        /// <see cref="IMessageEmbedProvider"/>
        [JsonPropertyName("provider")]
        IMessageEmbedProvider Provider { get; set; }

        /// <value>Author information. See <see cref="IMessageEmbedAuthor"/></value>
        /// <see cref="IMessageEmbedAuthor"/>
        [JsonPropertyName("author")]
        IMessageEmbedAuthor Author { get; set; }

        /// <value>Fields information. See <see cref="IMessageEmbedField"/></value>
        /// <see cref="IMessageEmbedField"/>
        [JsonPropertyName("fields")]
        IList<IMessageEmbedField> Fields { get; set; }
    }
}