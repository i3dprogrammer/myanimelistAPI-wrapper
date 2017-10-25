## AddManga
Adds manga entry to the authenticated user's list

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [MangaEntry] | addedManga | The new added manga entry to the list. |
| System.Int32 | mangaId | The ID of the new added manga. |

### Returns
System.String represnting the state of adding "Created" or detailed error message.

-------

## AddMangaAsync
Adds manga entry to the authenticated user's list asynchronously.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [MangaEntry] | addedManga | The new added manga entry to the list. |
| System.Int32 | mangaId | The ID of the new added manga. |

### Returns
System.String represnting the state of adding "Created" or detailed error message.

[MangaEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaEntry.md#mangaentry>
