using static ArrayExtensions;

public static class Example
{
	public static void Main()
	{
		int[] values = new int[] {2, 4, 6};

		foreach(var (index, value) in values.Enumerate())
		{
			// Substitute Debug.Log() if outside Unity i.e. Console.WriteLine() instead
			
			Debug.Log(index);
			// output: 0, 1, 2
			
			Debug.Log(value);
			// output: 2, 4, 6
		}
	}
}
