using System;
using PowerShellLive.Discord.Interfaces;

namespace PowerShellLive.Discord
{
    public class WebhookOptions : IWebhookOptions
    {
        public Uri WebhookUri { get; set; }

        public WebhookOptions(){}
    }
}