## MangaEntry
An object the holds manga data to be added or updated in a specific user manga list.

| Property Type | Property Name | Property Description |
| ------------- | ------------- | -------------------- |
| [System.Int32] | ReadChapters | The count of chapters you've read from this manga. |
| [System.Int32] | ReadVolumes | The count of volumes you've read from this manga. |
| [MALAPI.MangaListStatus] | Status | The status of the anime `Reading, Completed, Dropped, Onhold or PlanToRead`. |
| [MALAPI.EntryScore] | Score | The score you give this anime. |
| [System.Int32] | ScoreInt | The score you give this anime as int (1-10). |
| [System.Int32] | TimesReread | The count of times you've reread the manga. |
| [System.Int32] | RereadValue | Current reread chapter. |
| [System.DateTime] | DateStart | The date you've started reading this manga. |
| [System.String] | DateStartStr | The date you've started reading this manga as a string format `mmddyyyy`. |
| [System.DateTime] | DateEnd | The date you've finished reading this manga. |
| [System.String] | DateEndStr | The date you've finished reading this manga as a string format `mmddyyyy`. |
| [System.Int32] | Priority | The manga priority on the list |
| [System.Int32] | EnableDiscussion | Enable manga discussion `0 = Disabled, 1 = Enabled`. |
| [System.Int32] | EnableRereading | Enable manga rewatching `0 = Disabled, 1 = Enabled`. |
| [System.String] | Comments | Comments about this manga. |
| [System.String] | ScanGroup | Unknown. |
| [System.String] | RetailVolumes | Unknown. |


[System.String]: <https://msdn.microsoft.com/en-us/library/system.string(v=vs.110).aspx>
[System.Int32]: <https://msdn.microsoft.com/en-us/library/system.int32(v=vs.80).aspx>
[System.DateTime]: <https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx>
[MALAPI.AnimeListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animeliststatus>
[MALAPI.MangaListStatus]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#mangaliststatus>
[MALAPI.EntryScore]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#entryscore>
[MALAPI.AnimeType]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/Enumerations.md#animetype>
