# Pythonic C# foreach enumeration
This is a C# extension function for Pythonic foreach enumeration. C# snippets below assume `using System.Linq`. Extension function at [ArrayExtension.cs](ArrayExtension.cs).

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
* Normally I would name the static class `Utils.cs` instead of `ArrayExtension.cs`; and use the variable name `i` instead of `index`. The use of `index` here is primarily intended for immediate readability.
* Through a bit more searching, I learned after writing this that this same question was answered back in [2017 on Stack Overflow](https://stackoverflow.com/questions/7389047/is-there-an-equivalent-to-pythons-enumerate-for-net-ienumerable). Some of the key differences are:
	* Their solution is more robust by being an IEnumerable extension rather than an array extension. This extends functionality to other IEnumerable classes such as lists.
	* Their solution loops the input and uses `yield return` to insert an `(index, value)` tuple per input element into their IEnumerable. In contrast, I have to start by initializing an array size and having a desired range of indexes be looped rather than looping the input itself. This is of course because my extension was written with array in mind rather than IEnumerable.
	* Although I am content with the readability and straightforwardness of my extension, their solution is definitely more robust and is worth upgrading to if the user needs to also enumerate lists. In fact, given that the extension function backend is not seen when using `Enumerate()`, there is almost no reason not to upgrade.
* Is this really better than looping the index range and referring to the indexed element in the array? Probably not, but I think it's pretty. 🙂
