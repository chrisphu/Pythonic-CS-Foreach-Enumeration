using System.Linq;

public static class ArrayExtension
{
	// C# 7.0 and later, otherwise use Tuple<int, T> and Tuple.Create()
	public static (int, T)[] Enumerate<T>(this T[] values)
	{
		(int, T)[] indexesValues = new (int, T)[values.Count()];
		for (int index = 0; index < values.Count(); index++)
		{
			ivs[index] = (index, values[index]);
		}
		return indexesValues;
	}
}
