# Azure Functions

## Deprecated Functions from Previous Project

The following functions will not be ported:

+ DiscordEventHandler
  + This function was used to send messages to discord webhooks.
  Will no longer be implemented as a separate function to simplify.
+ DiscordScheduledEventNotifier
  + This was only ever used for Twitch Event notifications.
+ TwitchChannelEventLookup
  + This was only ever used for Twitch Event notifications.
+ TwitchChannelEventProcess
  + This was only ever used for Twitch Event notifications.
+ TwitchScheduledGetSubscriptions
  + This was only ever used for Twitch Event notifications.
+ TwitchStreamEventHandler
  + This was a queue based function that requeued callback events.
  This logic will no longer be a separate function.
+ TwitchSubscriptionAdd
  + This was a queue based function that created twitch webhook subscriptions.
  This logic will no longer be a separate function.
+ TwitchSubscriptionRemove
  + This was a queue based function that removed twitch webhook subscriptions.
  This logic will no longer be a separate function.
+ TwitterEventHandler
  + This function was used to tweet twitter messages.
  Will no longer be implemented as a separate function to simplify.
+ TwitterScheduledEventNotifier
  + This was only ever used for Twitch Event notifications.

## TwitchScheduledSubscriptionRegistration

This function will trigger subscription assurance.
Subscriptions have to be actively maintained and re-subscribed when they expire.
This is done by examining the configuration for the desired subscriptions, diffing them against the actual subscriptions on twitch, resubscribing any from desired state missing from Twitch, and unsubscribing from any no longer present in desired state but present on Twitch.

The logic needs to be implemented between the Common and Twitch libraries.

## TwitchWebhookCallback (Previously TwitchWebhookIngestion)

This function is the callback endpoint a twitch webhook subscription calls.
When a subscribed event occurs, twitch will send the event to this endpoint.
[Twitch documentation](https://dev.twitch.tv/docs/api/webhooks-reference#topic-stream-changed).

In the previous project, an attempt was made to keep the function app stateless.
To accomplish this, we included the Twitch username, Twitter username, and Discord ID in the callback URL.
While a neat workaround, it also made the function very inflexible and the config file less user friendly.
We ended up needing to have some form of state tracking anyway.
This time, a cache mechanism needs to be added to the common library with the ability to retrieve that info based on Twitch ID.
