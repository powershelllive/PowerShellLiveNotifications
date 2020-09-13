using System;

namespace PowerShellLive.Discord.Interfaces
{
    /// <summary>
    /// Options for a discord webhook service.
    /// </summary>
    public interface IWebhookOptions
    {
        /// <value>The URL of the Discord Webhook the service will use.</value>
        Uri WebhookUri { get; set; }
    }
}