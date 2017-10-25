## AddAnime
Adds anime entry to specific user's list.

### Parameters

| Type | Name | Description |
| -------------- | ---- | ----------- |
| [AnimeEntry] | addedAnime | The anime entry you want to add to the list.|
| System.Int32 | animeId | The id of the anime entry. |

### Returns
System.String represnting the state of adding "Created" or detailed error message.

--------

## AddAnimeAsync
Adds anime entry to specific user's list asynchronously.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [AnimeEntry] | addedAnime | The anime entry you want to add to the list.|
| System.Int32 | animeId | The id of the anime entry. |

### Returns
System.String represnting the state of adding "Created" or detailed error message.

[AnimeEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeEntry.md#animeentry>
