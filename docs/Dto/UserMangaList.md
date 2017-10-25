## UserMangaList
The object returned when getting a specific user manga list.

### Properties
| Type | Name | Description |
| ---- | ---- | ----------- |
| [MangaListInfo] | Info | Information about the user anime list. |
| List<[MangaListEntry]> | Mangas | The animes in that user list. |

## MangaListInfo
Object that contains information about specific user manga list.

### Properties
| Type | Name | Description |
| ---- | ---- | ----------- |
| System.Int32 | Id | User Id |
| System.String | Name | User name |
| System.Int32 | ReadingCount | Currently reading mangas count. |
| System.Int32 | CompletedCount | Mangas completed count. |
| System.Int32 | OnholdCount | Mangas onhold count. |
| System.Int32 | DroppedCount | Mangas dropped count. |
| System.Int32 | PlanToReadCount | Mangas planned to watch count. |
| System.Single | DaysSpentReading | Days user spent reading manga. |

## MangaListEntry
manga entry in the user list.

### Properties
| Type | Name | Description |
| ---- | ---- | ----------- |
| System.Int32 | SeriesId | Manga ID in the database. |
| System.String | SeriesTitle | Manga series title. |
| System.String | SeriesSynonyms | Synonyms titles for that Manga. |
| System.Int32 | SeriesType | Represents Series type `Manhwa, Manga, etc...` |
| System.Int32 | SeriesChaptersCount | Manga total chapters count. |
| System.Int32 | SeriesVolumesCount | Manga total volumes count. |
| System.Int32 | SeriesStatus | Manga status Finished, Publishing, Hiatus... |
| System.DateTime | SeriesStartDate | The start publishing date of manga series, or 0 Ticks if it's unknown. |
| System.String | SeriesStartDateStr | The start publishing date of manga series as string format `dd-mm-yyyy`. |
| System.DateTime | SeriesEndDate | The end date of manga series, or 0 Ticks if it's unknown. |
| System.String | SeriesEndDateStr | The end date of manga series as string format `dd-mm-yyyy`. |
| System.String | SeriesImage | Manga series image link. |
| System.Int32 | MyId | This manga entry ID in database. |
| System.Int32 | MyReadChapters | Your read chapters count. |
| System.Int32 | MyReadVolumes | Your read volumes count. |
| System.DateTime | MyStartDate | The date you started reading the manga series, or 0 Ticks if it's unknown. |
| System.String | MyStartDateStr | The date you started reading the manga series as string format `dd-mm-yyyy`. |
| System.DateTime | MyEndDate | The date you finished reading the manga series, or 0 Ticks if it's unknown. |
| System.String | MyEndDateStr | The date you finished reading the manga series as string format `dd-mm-yyyy`. |
| [EntryScore] | MyScore | The score you gave this manga series `Bad, Good, Masterpiece, etc...` . |
| System.Int32 | MyScoreInt | The score you give this manga as int `0=None, 1=Bad, 10=Masterpiece, etc...` |
| [MangaListStatus] | MyStatus | The manga entry status `Watching, Completed, Dropped, Onhold or PlanToWatch`. |
| System.Int32 | MyStatusInt | The status of the manga `0=Reading, 1=Completed, Dropped, Onhold or PlanToRead`. |
| System.Int32 | MyRereadingCount | The number of times you reread the manga series. |
| System.String | MyRereadingCountStr | The number of times you reread this manga series as string. |
| System.Int32 | MyRereadingChapter | Your current reread chapter number. |
| System.Int64 | MyLastUpdated | The last time you updated this manga entry. |
| System.String | MyTags | Unknown. |

[MangaListInfo]: <#mangalistinfo>
[MangaListEntry]: <#mangalistentry>
[AnimeSearchResult]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeSearch.md#animesearchresult>
[AnimeSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeSearch.md#animesearchentry>
[MangaSearchResult]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaSearch.md#mangasearchresult>
[MangaSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaSearch.md#mangasearchentry>

[AnimeListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animeliststatus>
[MangaListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#mangaliststatus>
[EntryScore]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#entryscore>
[AnimeType]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animetype>
