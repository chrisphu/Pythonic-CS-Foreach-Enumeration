# Pythonic C# foreach enumeration
This is a C# extension function for Pythonic foreach enumeration. C# snippets below assume `using System.Linq`.

## Python 'foreach'
Python allows easy access to current loop index by enumerating the looped array.
```py
for index, value in enumerate(values):
	# index and value called easily
	print(index, value)
```

## How is it currently done in C#?
Either loop index range and refer to indexed element in array (reasonably clean):
```cs
for (int i = 0; i < values.Count(); i++)
{
	// values[i] to refer to value, or declare value = values[i]
}
```
Or declare the index outside the loop (not so much):
```cs
int index = 0;
foreach (var value in values)
{
	// index needs to be incremented
	i++;
}
```

## How does this extension function look like in use?
Like so!
```cs
foreach (var (index, value) in values.Enumerate())
{
	// index and value called easily
}
```
