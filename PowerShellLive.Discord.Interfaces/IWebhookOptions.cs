using System;

namespace PowerShellLive.Discord.Interfaces
{
    public interface IWebhookOptions
    {
        Uri WebhookUri { get; set; }
    }
}