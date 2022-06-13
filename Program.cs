public class Exercise1
{
	public static void Main()
	{



		Console.WriteLine(remove_char("Danielle", 1));
		Console.WriteLine(remove_char("Danielle", 7));
		Console.WriteLine(remove_char("Danielle", 0));
	}
	public static string remove_char(string name, int n)
	{
		return name.Remove(n, 1);



	}
}