# Description
A C# Wrapper for myanimelist main API. It contains async and sync methods for all available API calls by myanimelist. Check documentation and examples below.

# Getting started
* Download [MALAPIv2.0.0 (45.0 KB)](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/releases/download/v2.0.0/MALAPIv2.0.0.zip) - Requires .NET Framework 4.5

# Sample examples
<h3>Example 1</h3>

```cs
var api = new MALAPI.API("USERNAME", "PASSWORD");
var searchResult = api.SearchController.SearchForAnime("Full Metal");
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
var list = api.UsersController.GetUserAnimeList("3dprogrammer");
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
var searchResult = await api.SearchController.SearchForAnimeAsync("Bakuman");
foreach (var entry in searchResult.Entries)
{
	//This is the exact same as the bottom one.
	if (entry.EntryType == MALAPI.AnimeType.TV)
	{
		var anime = new MALAPI.Dto.AnimeEntry();
		anime.Status = MALAPI.AnimeListStatus.Completed;
		anime.Score = MALAPI.EntryScore.Masterpiece;
		var result = await api.AnimeController.AddAnimeAsync(anime, entry.Id);
		Console.WriteLine(result); //Created or detailed error message.
	}

	//OR
	if (entry.EntryType == MALAPI.AnimeType.TV)
	{
		var result = await api.AnimeController.AddAnimeAsync(entry, MALAPI.AnimeListStatus.Completed);
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

## MALAPI.API
This is the main API object you deal with the entire time. You use it to manage all the Controllers.

| API Controllers |
| ----------------- |
| [AnimeController] | 
| [UsersController] |
| [MangaController] |
| [SearchController] |

There's 2 constructors available for this class.

```cs
var api = new MALAPI.API()
```

Initializes new mal client without any authentication. Using Controllers that requires authentication such as AnimeController / SearchController with throw an exception.

```cs 
var api = new MALAPI.API("USERNAME","PASSWORD")
```
Initializes new authenticated myanimelist client.

### AnimeController
A controller to managa myanimelist anime API. <br/><b>Requires API authentication.</b>

| Method name | Method description |
| ----------- | ------------------ |
| [AddAnime](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/AddAnime1.md#addanime) | Adds anime entry to specific user's list. |
| [AddAnime](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/AddAnime2.md#addanime) | Adds found anime search entry to specific user's list. |
| [AddAnimeAsync](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/AddAnime1.md#addanimeasync) | Adds anime entry to specific user's list asynchronously. |
| [AddAnimeAsync](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/AddAnime2.md#addanimeasync) | Adds found anime search entry to specific user's list asynchronously. |
| [UpdateAnime] | Updates existing anime in user's list. |
| [UpdateAnimeAsync] | Updates existing anime in user's list asynchronously. |
| [DeleteAnime] | Deletes existing anime from user's list. |
| [DeleteAnimeAsync] |  Deletes existing anime from user's list asynchronously. |

### MangaController
A controller to manage myanimelist manga API. <br/><b>Requires API authentication.</b>

| Method name | Method description |
| ----------- | ------------------ |
| [AddManga](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/AddManga1.md#addmanga) | Adds manga entry to specific user's list. |
| [AddManga](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/AddManga2.md#addmanga) | Adds found manga search entry to specific user's list. |
| [AddMangaAsync](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/AddManga1.md#addmangaasync) | Adds manga entry to specific user's list asynchronously. |
| [AddMangaAsync](https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/AddManga2.md#addmangaasync) | Adds found manga search entry to specific user's list asynchronously. |
| [UpdateManga] | Updates existing manga in user's list. |
| [UpdateMangaAsync] | Updates existing manga in user's list asynchronously. |
| [DeleteManga] | Deletes existing manga from user's list. |
| [DeleteMangaAsync] |  Deletes existing manga from user's list asynchronously. |

### SearchController
A controller to manage myanimelist search API. <br/><b>Requires API authentication.</b>

| Method name | Method description |
| ----------- | ------------------ |
| [SearchForAnime] | Searches myanimelist for anime. |
| [SearchForAnimeAsync] | Searches myanimelist for anime asynchronously. |
| [SearchForManga] | Searches myanimelist for manga. |
| [SearchForMangaAsync] | Searches myanimelist for manga asynchronously. |


### UsersController
A controller to manage myanimelist user lists API. <br/><b>Doesn't require API authentication.</b>

| Method name | Method description |
| ----------- | ------------------ |
| [GetUserAnimeList] | Retrieves anime list for specific user. |
| [GetUserAnimeListAsync] | Retrieves anime list for specific user asynchronously. |
| [GetUserMangaList] | Retrieves manga list for specific user. |
| [GetUserMangaListAsync] | Retrieves manga list for specific user asynchronously. |

[AnimeController]: <#animecontroller>
[MangaController]: <#mangacontroller>
[UsersController]: <#userscontroller>
[SearchController]: <#searchcontroller>

[AddAnime]: <#addanime>
[AddAnimeAsync]: <#addanimeasync>
[UpdateAnime]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/UpdateAnime.md#updateanime>
[UpdateAnimeAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/UpdateAnime.md#updateanimeasync>
[DeleteAnime]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/DeleteAnime.md#deleteanime>
[DeleteAnimeAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/AnimeController/DeleteAnime.md#deleteanimeasync>

[AddManga]: <#addmanga>
[AddMangaAsync]: <#addmangaasync>
[UpdateManga]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/UpdateManga.md#updatemanga>
[UpdateMangaAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/UpdateManga.md#updatemangaasync>
[DeleteManga]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/DeleteManga.md#deletemanga>
[DeleteMangaAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/MangaController/DeleteManga.md#deletemangaasync>

[SearchForAnime]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/SearchController/Search.md#searchforanime>
[SearchForAnimeAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/SearchController/Search.md#searchforanimeasync>
[SearchForManga]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/SearchController/Search.md#searchformanga>
[SearchForMangaAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/SearchController/Search.md#searchformangaasync>

[GetUserAnimeList]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/UsersController/Users.md#getuseranimelist>
[GetUserAnimeListAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/UsersController/Users.md#getuseranimelistasync>
[GetUserMangaList]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/UsersController/Users.md#getusermangalist>
[GetUserMangaListAsync]: <https://github.com/i3dprogrammer/myanimelistAPI-wrapper/blob/master/docs/UsersController/Users.md#getusermangalistasync>
