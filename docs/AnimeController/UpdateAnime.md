## UpdateAnime
Updates existing anime in user's list.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [AnimeEntry] | newAnimeInfo | The updated anime entry. |
| System.Int32 | animeId | the ID of the anime entry you want to update. |

### Returns
System.String represnting the state of updating "Updated" or detailed error message.

----------

## UpdateAnimeAsync
Updates existing anime in user's list asynchronously.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [AnimeEntry] | newAnimeInfo | The updated anime entry. |
| System.Int32 | animeId | the ID of the anime entry you want to update. |

### Returns
System.String represnting the state of updating "Updated" or detailed error message.

[AnimeEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeEntry.md#animeentry>
