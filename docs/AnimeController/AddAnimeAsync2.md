## AddAnimeAsync
Adds found anime search entry to specific user's list asynchronously.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [AnimeSearchEntry] | searchEntry | The anime search entry you found.|
| [AnimeListStatus] | status | The status of the anime Watching, Completed, Onhold, Dropped or PlanToWatch. |

### Returns
System.String represnting the state of adding "Created" or detailed error message.

[AnimeSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeSearch.md#animesearchentry>
[AnimeListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animeliststatus>
