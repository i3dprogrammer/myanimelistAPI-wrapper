## AnimeSearchResult
The object returned when searching for specific anime query.

| Property Type | Property Name | Property Description |
| ------------- | ------------- | -------------------- |
| [List]<[AnimeSearchEntry]> | Entries | List of entries found by the search or a null list if nothing is found.|

## AnimeSearchEntry
This is a anime search entry result that holds information about one search result.

| Property Type | Property Name | Property Description |
| ------------- | ------------- | -------------------- |
| [System.Int32] | Id | Anime id in database. |
| [System.String] | Title | Anime title |
| [System.String] | EnglishTitle |  Anime english title if found. |
| [System.String] | Synonyms | Anime synonyms titles if found. |
| [System.Int32] | EpisodesCount | Anime total episodes count if known. |
| [System.Single] | Score | Anime score by total members. |
| [MALAPI.AnimeType] | EntryType | Anime type TV, OVA, ONA, etc... |
| [System.String] | Status | Anime status Finished, Airing, etc... |
| [System.DateTime] | StartDate | Anime start date if known, or 0 Ticks if not. |
| [System.String] | StartDateStr | Anime start date as a string format `dd-mm-yyyy`. |
| [System.DateTime] | EndDate | Anime end date if known, or 0 ticks if not. |
| [System.String] | EndDateStr | Anime end date as a string format `dd-mm-yyyy`. |
| [System.String] | Synopsis | Anime story description. |
| [System.String] | ImageLink | Anime image link. |

[AnimeSearchEntry]: <#animesearchentry>
[System.String]: <https://msdn.microsoft.com/en-us/library/system.string(v=vs.110).aspx>
[System.Int32]: <https://msdn.microsoft.com/en-us/library/system.int32(v=vs.80).aspx>
[System.DateTime]: <https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx>
[MALAPI.AnimeType]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animetype>
[System.Single]: <https://msdn.microsoft.com/en-us/library/system.single(v=vs.80).aspx>
[List]: <https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx>
