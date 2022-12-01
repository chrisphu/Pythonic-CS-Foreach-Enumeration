using static ArrayExtensions;

public static class Example
{
	public static void Main()
	{
		int[] values = new int[] {2, 4, 6};

		foreach(var (index, value) in values.Enumerate())
		{
			// Debug.Log() for use in Unity
			
			Debug.Log(index);
			// output: 0, 1, 2
			
			Debug.Log(value);
			// output: 2, 4, 6
		}
	}
}
