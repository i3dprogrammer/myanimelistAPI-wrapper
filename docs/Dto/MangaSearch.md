## MangaSearchResult
The object returned when searching for specific anime query.

| Property Type | Property Name | Property Description |
| ------------- | ------------- | -------------------- |
| List<[MangaSearchEntry]> | Entries | List of entries found by the search or a null list if nothing is found.|

## MangaSearchEntry
This is a manga search entry result that holds information about one search result.

| Property Type | Property Name | Property Description |
| ------------- | ------------- | -------------------- |
| System.Int32 | Id | Manga id in database. |
| System.String | Title | Manga title |
| System.String | EnglishTitle |  Manga english title if found. |
| System.String | Synonyms | Manga synonyms titles if found. |
| System.Int32 | Chapters | Manga total chapters count. |
| System.Int32 | Volumes | Manga total volumes count. |
| System.Single | Score | Manga score by total members. |
| System.String | EntryType | Manga type Manhwa, Manga, etc... |
| System.String | Status | Manga status Finished, Publishing, Hiatus, etc... |
| System.DateTime | StartDate | Manga start date if known, or 0 Ticks if not. |
| System.String | StartDateStr | Manga start date as a string format `dd-mm-yyyy`. |
| System.DateTime | EndDate | Manga end date if known, or 0 ticks if not. |
| System.String | EndDateStr | Manga end date as a string format `dd-mm-yyyy`. |
| System.String | Synopsis | Manga story description. |
| System.String | ImageLink | Manga image link. |

[MangaSearchEntry]: <#mangasearchentry>
[System.String]: <https://msdn.microsoft.com/en-us/library/system.string(v=vs.110).aspx>
[System.Int32]: <https://msdn.microsoft.com/en-us/library/system.int32(v=vs.80).aspx>
[System.DateTime]: <https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx>
[AnimeType]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animetype>
[System.Single]: <https://msdn.microsoft.com/en-us/library/system.single(v=vs.80).aspx>
[List]: <https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx>
