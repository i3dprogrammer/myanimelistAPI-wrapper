## AddAnimeAsync
Adds found anime search entry to specific user's list asynchronously.

### Parameters

| Name | Description |
| ---- | ----------- |
| [MALAPI.Dto.AnimeSearchEntry] searchEntry | The anime search entry you found.|
| [MALAPI.AnimeListStatus] status | The status of the anime Watching, Completed, Onhold, Dropped or PlanToWatch. |

### Returns
[System.String] represnting the state of adding "Created" or detailed error message.

[System.String]: <https://msdn.microsoft.com/en-us/library/system.string(v=vs.110).aspx>
[System.Int32]: <https://msdn.microsoft.com/en-us/library/system.int32(v=vs.80).aspx>
[System.DateTime]: <https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx>
[System.Single]: <https://msdn.microsoft.com/en-us/library/system.single(v=vs.80).aspx>

[MALAPI.Dto.AnimeEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeEntry.md#animeentry>
[MALAPI.Dto.MangaEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeEntry.md#mangaentry>

[MALAPI.Dto.AnimeSearchResult]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeSearch.md#animesearchresult>
[MALAPI.Dto.AnimeSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeSearch.md#animesearchentry>
[MALAPI.Dto.MangaSearchResult]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaSearch.md#mangasearchresult>
[MALAPI.Dto.MangaSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaSearch.md#mangasearchentry>

[MALAPI.AnimeListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animeliststatus>
[MALAPI.MangaListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#mangaliststatus>
[MALAPI.EntryScore]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#entryscore>
[MALAPI.AnimeType]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animetype>
