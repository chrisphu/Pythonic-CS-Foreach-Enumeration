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
Normally I would name the static class `Utils.cs` instead of `ArrayExtension.cs`; and also abbreviate index, value, and values as i, v, and vs (consequently indexesValues as ivs).
Is this really better than looping the index range and referring to the indexed element in the array? Probably not, but I think it's pretty. 🙂
