public class Exercise1
{
	public static void Main()
	{
		Console.WriteLine(CharacterSwap("Danielle"));
		Console.WriteLine(CharacterSwap("Padgett"));
		Console.WriteLine(CharacterSwap("x"));
	}
	public static string CharacterSwap(string namePosition)
	{
		return namePosition.Length > 1
			? namePosition.Substring(namePosition.Length - 1) + namePosition.Substring(1, namePosition.Length - 2) + namePosition.Substring(0, 1) : namePosition;
	}
}
