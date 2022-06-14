public class Exercise1
{
	public static void Main()
	{
		string line = "I'm Danielle and my Audi is a bit old lol";
		string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
		string word = "";
		int ctr = 0;

		foreach (String s in words)
		{
			if (s.Length > ctr)
			{
				word = s;
				ctr = s.Length;
			}
		}

		Console.WriteLine(word);
	}



}