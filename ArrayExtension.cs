using System.Linq;

public static class ArrayExtension
{
	// C# 7.0 and later, otherwise use Tuple<int, T> and Tuple.Create()
	public static (int, T)[] Enumerate<T>(this T[] input)
	{
		(int, T)[] output = new (int, T)[input.Count()];
		for (int index = 0; index < input.Count(); index++)
		{
			output[index] = (index, input[index]);
		}
		return output;
	}
}
