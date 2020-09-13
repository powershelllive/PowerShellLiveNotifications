using System;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord
{
    /// <summary>
    /// Options for a discord webhook service.
    /// </summary>
    public class WebhookOptions : IWebhookOptions
    {
        public Uri WebhookUri { get; set; }

        /// <summary>
        /// Creates a <see cref="WebhookOptions"/>.
        /// </summary>
        public WebhookOptions(){}
    }
}