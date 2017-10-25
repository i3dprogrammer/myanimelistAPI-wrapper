## UpdateManga
Updates existing manga in authenticated user's list.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [MangaEntry] | newMangaInfo | The updated manga object. |
| System.Int32 | mangaId | The ID of the manga you want to update. |

### Returns
System.String represnting the state of Updating "Updated" or detailed error message.

------

## UpdateMangaAsync
Updates existing manga in authenticated user's list asynchronously.

### Parameters

| Type | Name | Description |
| ---- | ---- | ----------- |
| [MangaEntry] | newMangaInfo | The updated manga object. |
| System.Int32 | mangaId | The ID of the manga you want to update. |

### Returns
System.String represnting the state of Updating "Updated" or detailed error message.

[MangaEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaEntry.md#mangaentry>
