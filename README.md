# myanimelistAPI-wrapper
This is a C# API Wrapper for myanimelist, it's fairly easy to use. Check below for documentation.

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
<hr/>
In the above example we search for `Full Metal` and print the result based on their start/end dates. <br/>
We use Search Controller, as Search requires myanimelist authentication we've used API Constructor with username and password.

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
