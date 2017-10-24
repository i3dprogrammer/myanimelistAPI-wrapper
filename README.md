# Description
A C# Wrapper for myanimelist main API. It contains async and sync methods for all available API calls by myanimelist. Check documentation and examples below.

# Getting started
* Download [MALAPIv2.0.0 (45.0 KB)](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/releases/download/v2.0.0/MALAPIv2.0.0.zip) - Requires .NET Framework 4.5

# Sample examples
<h3>Example 1</h3>

```cs
var api = new MALAPI.API("USERNAME", "PASSWORD");
var searchResult = api.Search.SearchForAnime("Full Metal");
foreach (var entry in searchResult.Entries)
{
	if (entry.StartDate.Ticks == 0) //If there's no start date.
		Console.WriteLine($"{entry.Title} -> Not yet aired.");
	else if (entry.EndDate.Ticks == 0) //If there's no end date.
		Console.WriteLine($"{entry.Title} -> {entry.StartDate.ToShortDateString()} to unknown.");
	else
		Console.WriteLine($"{entry.Title} -> {entry.StartDate.ToShortDateString()} to {entry.EndDate.ToShortDateString()}");
}
```

In the above example we search for `Full Metal` and print the result based on their start/end dates. <br/>
We use Search Controller, as Search requires myanimelist authentication we've used API Constructor with username and password.

<hr/>

<h3>Example 2</h3>

```cs
var api = new MALAPI.API(); //Doesn't require authentication.
var list = api.Users.GetUserAnimeList("3dprogrammer");
Console.WriteLine($"{list.Info.DaysSpentWatching} days watching anime.");
foreach (var entry in list.Animes)
{
	    Console.WriteLine($"{entry.SeriesTitle} - {entry.MyStatus} # {entry.MyScore}");
}
```

Here we get `3dprogrammer` user anime list, print out the total days he spent watching anime and print `3dprogrammer` anime list in a nice fashion. <br/>
We use Users Controller which doesn't require authentication. (Here you can use either one of the constructors, both will function the same).

<hr/>

<h3>Example 3</h3>

```cs
var api = new MALAPI.API("USERNAME", "PASSWORD");
var searchResult = await api.Search.SearchForAnimeAsync("Bakuman");
foreach (var entry in searchResult.Entries)
{
	//This is the exact same as the bottom one.
	if (entry.EntryType == MALAPI.AnimeType.TV)
	{
		var anime = new MALAPI.Dto.AnimeEntry();
		anime.Status = MALAPI.AnimeListStatus.Completed;
		anime.Score = MALAPI.EntryScore.Masterpiece;
		var result = await api.Anime.AddAnimeAsync(anime, entry.Id);
		Console.WriteLine(result); //Created or detailed error message.
	}

	//OR
	if (entry.EntryType == MALAPI.AnimeType.TV)
	{
		var result = await api.Anime.AddAnimeAsync(entry, MALAPI.AnimeListStatus.Completed);
		Console.WriteLine(result); //Created or detailed error message.
	}
}
```

In the last example we use async method to search asynchronously for the anime `Bakuman` and then add it to our list if the type of the anime series is `MALAPI.AnimeType.TV`. By two different ways
<ul>
	<li>Create the AnimeEntry ourself and populate it with data then add it to the list. </li>
	<li>Or just add the search result entry.</li>
</ul>

<b>Note that you should use either one of the methods above in the example to add anime, using two will only result in error message.</b>

We Use the Anime/Manga Controllers to Add, Update or Delete entries from the authenticated user's list.

# Documentation

| API Controllers | |
| ----------------- | ----------------- |
| [AnimeController] | [MangaController] |
| [UsersController] | [SearchController] |

### AnimeController
A controller to managa myanimelist anime API.

| Method name | Method description |
| ----------- | ------------------ |
| [AddAnime] | Adds anime entry to specific user's list. |
| [AddAnime] | Adds found anime search entry to specific user's list. |
| [AddAnimeAsync] | Adds anime entry to specific user's list asynchronously. |
| [AddAnimeAsync] | Adds found anime search entry to specific user's list asynchronously. |
| [UpdateAnime] | Updates existing anime in user's list. |
| [UpdateAnimeAsync] | Updates existing anime in user's list asynchronously. |
| [DeleteAnime] | Deletes existing anime from user's list. |
| [DeleteAnimeAsync] |  Deletes existing anime from user's list asynchronously. |


#### AddAnime
Adds anime entry to specific user's list.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [MALAPI.Dto.AnimeEntry] addedAnime | The anime entry you want to add to the list.|
| [System.Int32] animeId | The id of the anime entry. |

##### Returns
[System.String] represnting the state of adding "Created" or detailed error message.

#### AddAnime
Adds found anime search entry to specific user's list.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [MALAPI.Dto.AnimeSearchEntry] searchEntry | The anime search entry you found.|
| [MALAPI.AnimeListStatus] status | The status of the anime Watching, Completed, Onhold, Dropped or PlanToWatch. |

##### Returns
[System.String] represnting the state of adding "Created" or detailed error message.

#### AddAnimeAsync
Adds anime entry to specific user's list asynchronously.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [MALAPI.Dto.AnimeEntry] addedAnime | The anime entry you want to add to the list.|
| [System.Int32] animeId | The id of the anime entry. |

##### Returns
[System.String] represnting the state of adding "Created" or detailed error message.

#### AddAnimeAsync
Adds found anime search entry to specific user's list asynchronously.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [MALAPI.Dto.AnimeSearchEntry] searchEntry | The anime search entry you found.|
| [MALAPI.AnimeListStatus] status | The status of the anime Watching, Completed, Onhold, Dropped or PlanToWatch. |

##### Returns
[System.String] represnting the state of adding "Created" or detailed error message.

#### UpdateAnime
Updates existing anime in user's list.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [MALAPI.Dto.AnimeEntry] newAnimeInfo | The updated anime entry. |
| [System.Int32] animeId | the ID of the anime entry you want to update. |

##### Returns
[System.String] represnting the state of updating "Updated" or detailed error message.

#### UpdateAnimeAsync
Updates existing anime in user's list asynchronously.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [MALAPI.Dto.AnimeEntry] newAnimeInfo | The updated anime entry. |
| [System.Int32] animeId | the ID of the anime entry you want to update. |

##### Returns
[System.String] represnting the state of updating "Updated" or detailed error message.

#### DeleteAnime
Deletes existing anime from user's list.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [System.Int32] animeId | The anime entry ID to delete from the list. |

##### Returns
[System.String] represnting the state of deleting "Deleted" or detailed error message.

#### DeleteAnimeAsync
Deletes existing anime from user's list asynchronously.

##### Parameters

| Name | Description |
| ---- | ----------- |
| [System.Int32] animeId | The anime entry ID to delete from the list. |

##### Returns
[System.String] represnting the state of deleting "Deleted" or detailed error message.

[System.String]: <https://msdn.microsoft.com/en-us/library/system.string(v=vs.110).aspx>
[System.Int32]: <https://msdn.microsoft.com/en-us/library/system.int32(v=vs.80).aspx>
[MALAPI.Dto.AnimeEntry]: <#animeentry>
[MALAPI.Dto.AnimeSearchEntry]: <#animesearchentry>
[AnimeController]: <#animecontroller>
[MangaController]: <#mangacontroller>
[UsersController]: <#userscontroller>
[SearchController]: <#searchcontroller>
[AddAnime]: <#addanime>
[AddAnimeAsync]: <#addanimeasync>
[UpdateAnime]: <#updateanime>
[UpdateAnimeAsync]: <#updateanimeasync>
[DeleteAnime]: <#deleteanime>
[DeleteAnimeAsync]: <#deleteanimeasync>
