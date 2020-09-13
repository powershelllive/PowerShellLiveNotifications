namespace PowerShellLive.Discord.Models
{
    /// <summary>
    /// The type of embed.
    /// Webhooks should always be set to <c>rich</c>.
    /// Embed types are "loosely defined" and, for the most part, are not used by our clients for rendering.
    /// Embed attributes power what is rendered.
    /// Embed types should be considered deprecated and might be removed in a future API version.
    /// See <see href="https://discord.com/developers/docs/resources/channel#embed-object-embed-types"/>.
    /// </summary>
    public enum MessageEmbedType
    {
        /// <summary>Generic embed rendered from embed attributes.</summary>
        rich,

        /// <summary>Image embed.</summary>
        image,

        /// <summary>Video embed.</summary>
        video,

        /// <summary>Animated gif image embed rendered as a video embed.</summary>
        gifv,

        /// <summary>Article embed.</summary>
        article,

        /// <summary>Link embed.</summary>
        link
    }
}