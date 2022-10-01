using System.Linq;

public static class ArrayExtension
{
	// C# 7.0 and later, otherwise use Tuple<int, T> and Tuple.Create()
	public static (int, T)[] Enumerate<T>(this T[] values)
	{
		(int, T)[] indexValueTuples = new (int, T)[values.Count()];
		for (int index = 0; index < values.Count(); index++)
		{
			indexValueTuples[index] = (index, values[index]);
		}
		return indexValueTuples;
	}
}
