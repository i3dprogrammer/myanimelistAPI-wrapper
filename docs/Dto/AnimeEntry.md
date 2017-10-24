## AnimeEntry
An object the holds anime data to be added or updated in a specific user anime list.

| Property Name | Property Description |
| ------------- | -------------------- |
| [System.Int32] WatchedEpisodes | The count of episodes you watched from this anime. |
| [MALAPI.AnimeListStatus] Status | The status of the anime `Watching, Completed, Dropped, Onhold or PlatToWatch`. |
| [MALAPI.EntryScore] Score | The score you give this anime. |
| [System.Int32] ScoreInt | The score you give this anime as int (1-10). |
| [System.Int32] StorageType | Unknown. |
| [System.Int32] StorageValue | Unknown. |
| [System.Int32] TimesRewatched | The count of times you've rewatched this anime. |
| [System.Int32] RewatchValue | Current rewatch episode. |
| [System.DateTime] DateStart | The date you started watching this anime. |
| [System.String] DateStartStr | The date you started watching this anime as string format `mmddyyyy`. |
| [System.DateTime] DateEnd | The date you finished watching this anime. |
| [System.String] DateEndStr | he date you finished watching this anime as string format `mmddyyyy`. |
| [System.Int32] Priority | The anime priority on the list. |
| [System.Int32] EnableDiscussion | Enable anime discussion `0 = Disabled, 1 = Enabled`. |
| [System.Int32] EnableRewatching | Enable anime rewatching `0 = Disabled, 1 = Enabled`. |
| [System.String] Comments | Comments about this anime. |
| [System.String] Tags | Unknown. |


[System.String]: <https://msdn.microsoft.com/en-us/library/system.string(v=vs.110).aspx>
[System.Int32]: <https://msdn.microsoft.com/en-us/library/system.int32(v=vs.80).aspx>
[System.DateTime]: <https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx>
[MALAPI.AnimeListStatus]: <#>
[MALAPI.EntryScore]: <#>
