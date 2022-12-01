# Pythonic C# foreach enumeration
This is a C# extension function for Pythonic foreach enumeration. C# snippets below assume `using System.Linq`. Extension function at [ArrayExtensions.cs](ArrayExtensions.cs).

## Python 'foreach' enumeration
Python allows easy access to current loop index by calling intrinsic enumerate function on looped array.
```py
for index, value in enumerate(values):
	# index and value called easily
	print(index, value)
```

## How is index currently accessed in C#?
Either loop index range and refer to indexed element in array (reasonably clean):
```cs
for (int index = 0; index < values.Count(); index++)
{
	// values[index] to refer to value, or declare value = values[index]
}
```
Or declare the index outside the loop (not so much):
```cs
int index = 0;
foreach (var value in values)
{
	// index needs to be incremented
	index++;
}
```

## How does this extension function look like in use?
Like so! Also shown in [Example.cs](Example.cs).
```cs
foreach (var (index, value) in values.Enumerate())
{
	// index and value called easily
}
```

## Miscellaneous
* Through a bit more searching, I learned after writing this that this same question was better answered back in [2017 on Stack Overflow](https://stackoverflow.com/questions/7389047/is-there-an-equivalent-to-pythons-enumerate-for-net-ienumerable). Some of the key differences are:
	* Their solution is more robust by being an IEnumerable extension rather than an array extension. This extends functionality to other IEnumerable classes such as lists.
	* Their solution uses a more elegant `yield return` to insert `(index, value)` tuples into their IEnumerable. In contrast, my code starts by initializing an empty array of a given size and then looping through the range of the array to assign the tuples. This at the time of writing felt like a natural solution but now seems limited in comparison.
* Is this really better than looping the index range and referring to the indexed element in the array? Probably not, but I think it's pretty. 🙂
