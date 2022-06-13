public class Exercise1
{
	public static void Main()
	{



		Console.WriteLine(RemoveString("Danielle", 1));
		Console.WriteLine(RemoveString("Danielle", 7));
		Console.WriteLine(RemoveString("Danielle", 0));
	}
	public static string RemoveString(string name, int n)
	{
		return name.Remove(n, 1);



	}
}