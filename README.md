# myanimelistAPI-wrapper
This is a C# API Wrapper for myanimelist, it's fairly easy to use(and to implement one yourself).

# Requirements
.NET Framework 4.6.2

# How to use
Just create an instance of MALAPI.API and use any of the methods available below.


# Features
<table>
	<tr>
		<td>Method</td>
		<td>Description</td>
		<td>Authentication</td>
	</tr>
	<tr>
		<td><b>GetUserListAsync</b></td>
		<td>Retrieves anime/manga list for specific user</td>
		<td>Not Required</td>
	</tr>
	<tr>
		<td><b>SearchForAsync</b></td>
		<td>Searches myanimelist for anime/manga</td>
		<td>Required</td>
	</tr>
	<tr>
		<td><b>AddAnime</b></td>
		<td>Adds anime to specific user's list</td>
		<td>Required</td>
	</tr>
	<tr>
		<td><b>AddManga</b></td>
		<td>Adds manga to specific user's list</td>
		<td>Required</td>
	</tr>
	<tr>
		<td><b>UpdateAnime</b></td>
		<td>Updates existing anime in user's list</td>
		<td>Required</td>
	</tr>
	<tr>
		<td><b>UpdateManga</b></td>
		<td>Updates existing manga in user's list</td>
		<td>Required</td>
	</tr>
		<tr>
		<td><b>DeleteAnime</b></td>
		<td>Deletes existing anime from user's list</td>
		<td>Required</td>
	</tr>
	<tr>
		<td><b>DeleteManga</b></td>
		<td>Deletes existing manga from user's list</td>
		<td>Required</td>
	</tr>
</table>
