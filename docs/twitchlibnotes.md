# TwitchLib Notes

## WebHook Callbacks

[Documentation](https://github.com/TwitchLib/TwitchLib.Webhook)

It looks like this library is still not useful for Azure Functions.
I dug into the code and I don't see a good way of reusing it in the project.
Much of the library depends very heavily on being used in an ASP.NET MVC project.
It also features an opinionated config location instead of accepting an IOptions.
It may also be that I'm just not skilled enough to understand how to dice this up and reuse it.

In any case, the previous project's code for this was solid.
In googling how to resolved this problem one of my own videos was a top result where I dug into this last time.
Rather than wasting more time on this problem again, we'll just use the code from the previous project.

It may be worth reusing the [models](https://github.com/TwitchLib/TwitchLib.Webhook/tree/master/src/TwitchLib.Webhook/Models) in that project.
However, it would be ideal if those models were a separate library and not part of the webhook library.
At the very least, we can borrow the code for the models and attribute.

## GetTwitchWebhookSubscriptions()

In the previous project's TwitchClient, this method was used to retrieve a list of current webhook subscriptions.
This is used primarily to ensure new or expired subscriptions have been registered.
This wraps the [`webhook/subscriptions`](https://dev.twitch.tv/docs/api/reference/#get-webhook-subscriptions) endpoint.

In TwitchLib, this is accomplished with [`TwitchLib.Api.Helix.Webhooks.GetWebhookSubscriptionsAsync()`](https://github.com/TwitchLib/TwitchLib.Api/blob/a4de07db8f7a4bb516021aa9cd0ea5921e90f05a/TwitchLib.Api.Helix/Webhooks.cs#L19).

TwitchLib does not offer an auto pagination option.
The original project hard coded 100 results without auto pagination either.
We will need to implement auto pagination to prevent a ticking time bomb.

## GetTwitchStreamUserId()

This returns the Twitch ID for a username.
It's only relevant in the `SubscriptionActionTwitchStreamWebhook()` method which is used for either subscribing or unsubscribing from a stream go-live callback.
This is used because we use the twitch username in configuration, but the ID is required for the webhook topic.
It may be better just to require IDs instead of names as we do that already for Discord.
Though, it does not look like Twitch provides a convenient way for a user to get their ID.

TwitchLib implements this in [`TwitchLib.Api.Helix.Users.GetUsersAsync()`](https://github.com/TwitchLib/TwitchLib.Api/blob/a4de07db8f7a4bb516021aa9cd0ea5921e90f05a/TwitchLib.Api.Helix/Users.cs#L19).

## SubscriptionActionTwitchStreamWebhook()

This performs a subscribe or unsubscribe webhook action.

TwitchLib implements this in [`TwitchLib.Api.Helix.Webhooks.StreamUpDownAsync()`](https://github.com/TwitchLib/TwitchLib.Api/blob/a4de07db8f7a4bb516021aa9cd0ea5921e90f05a/TwitchLib.Api.Helix/Webhooks.cs#L77).

## GetGame()

This is used to get game information from a game ID.

TwitchLib implements this in [`TwitchLib.Api.Helix.Games.GetGames()`](https://github.com/TwitchLib/TwitchLib.Api/blob/a4de07db8f7a4bb516021aa9cd0ea5921e90f05a/TwitchLib.Api.Helix/Games.cs#L19).
