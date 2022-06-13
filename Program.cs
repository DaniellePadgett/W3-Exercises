public class Exercise1
{
	public static void Main()
	{
		string name;
		int nameIndex = 0;
		Console.Write("Input a string : ");
		name = Console.ReadLine();
		if (name.Length >= 1)
		{
			var s = name.Substring(0, 1);
			Console.WriteLine(s + name + s);
		}
	}
}
