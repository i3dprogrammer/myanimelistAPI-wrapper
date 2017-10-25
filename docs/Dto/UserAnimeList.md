## UserAnimeList
The object returned when getting a specific user anime list.

### Properties
| Type | Name | Description |
| ---- | ---- | ----------- |
| [AnimeListInfo] | Info | Information about the user anime list. |
| List<[AnimeListEntry]> | Animes | The animes in that user list. |

## AnimeListInfo
Object that contains information about specific user anime list.

### Properties
| Type | Name | Description |
| ---- | ---- | ----------- |
| System.Int32 | Id | User Id |
| System.String | Name | User name |
| System.Int32 | WatchingCount | Currently watching animes count. |
| System.Int32 | CompletedCount | Animes completed count. |
| System.Int32 | OnholdCount | Animes onhold count. |
| System.Int32 | DroppedCount | Animes dropped count. |
| System.Int32 | PlanToWatchCount | Animes planned to watch count. |
| System.Single | DaysSpentWatching | Days user spent watching anime. |

## AnimeListEntry
Anime entry in the user list.

### Properties
| Type | Name | Description |
| ---- | ---- | ----------- |
| System.Int32 | SeriesId | Anime ID in the database. |
| System.String | SeriesTitle | Anime series title. |
| System.String | SeriesSynonyms | Synonyms titles for that anime. |
| [AnimeType] | SeriesType | Series type `TV, OVA, ONA, Music, Special, Movie...` |
| System.Int32 | SeriesTypeInt | Series type as integer 0=TV, etc... |
| System.Int32 | SeriesEpisodesCount | Series total episodes count. |
| System.String | SeriesStatus | Series status Finished, Airing, Not aired, cancelled... |
| System.DateTime | SeriesStartDate | The start air date of anime series, or 0 Ticks if it's unknown. |
| System.String | SeriesStartDateStr | The start air date of anime series as string format `dd-mm-yyyy`. |
| System.DateTime | SeriesEndDate | The end date of anime series, or 0 Ticks if it's unknown. |
| System.String | SeriesEndDateStr | The end date of anime series as string format `dd-mm-yyyy`. |
| System.String | SeriesImage | Anime series image link. |
| System.Int32 | MyId | This anime entry ID in database. |
| System.Int32 | MyWatchedEpisodesCount | Your Watched episodes count. |
| System.DateTime | MyStartDate | The date you started watching the anime series, or 0 Ticks if it's unknown. |
| System.String | MyStartDateStr | The date you started watching the anime series as string format `dd-mm-yyyy`. |
| System.DateTime | MyEndDate | The date you finished watching the anime series, or 0 Ticks if it's unknown. |
| System.String | MyEndDateStr | The date you finished watching the anime series as string format `dd-mm-yyyy`. |
| [EntryScore] | MyScore | The score you gave this anime series `Bad, Good, Masterpiece, etc...` . |
| System.Int32 | MyScoreInt | The score you give this anime as int `0=None, 1=Bad, 10=Masterpiece, etc...` |
| [AnimeListStatus] | MyStatus | The anime entry status Watching, Completed, Dropped, Onhold and PlanToWatch. |
| System.Int32 | MyStatusInt | The status of the anime. 0=Watching, 1=Completed, Dropped, Onhold and PlanToWatch. |
| System.Int32 | MyRewatchingCount | The number of times you rewatched this anime series. |
| System.String | MyRewatchingCountStr | The number of times you rewatched this anime series as string. |
| System.Int32 | MyReawtchingEp | Your current rewatch episode number. |
| System.Int64 | MyLastUpdated | The last time you updated this anime entry. |
| System.String | MyTags | Unknown. |

[AnimeListInfo]: <#useranimeinfo>
[AnimeListEntry]: <#useranimeentry>
[AnimeSearchResult]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeSearch.md#animesearchresult>
[AnimeSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/AnimeSearch.md#animesearchentry>
[MangaSearchResult]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaSearch.md#mangasearchresult>
[MangaSearchEntry]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Dto/MangaSearch.md#mangasearchentry>

[AnimeListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animeliststatus>
[MangaListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#mangaliststatus>
[EntryScore]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#entryscore>
[AnimeType]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animetype>
