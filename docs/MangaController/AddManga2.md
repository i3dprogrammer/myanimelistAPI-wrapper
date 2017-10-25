## AddManga
Adds found manga search entry to the authenticated user's list.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [MangaSearchEntry] | addedManga | The manga search entry you found. |
| [MangaListStatus] | mangaId | The status of the manga Reading, Completed, Onhold, Dropped or PlanToRead. |

### Returns
System.String represnting the state of adding "Created" or detailed error message.

-------

## AddMangaAsync
Adds found manga search entry to the authenticated user's list asynchronously.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [MangaSearchEntry] | addedManga | The manga search entry you found. |
| [MangaListStatus] | mangaId | The status of the manga Reading, Completed, Onhold, Dropped or PlanToRead. |

### Returns
System.String represnting the state of adding "Created" or detailed error message.

[MangaSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaSearch.md#mangasearchentry>
[MangaListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#mangaliststatus>
