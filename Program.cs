public class Exercise1
{
	public static void Main()
	{

		int int1;
		int int2;

		Console.WriteLine("Input first integer : ");
		int1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Input second integer : ");
		int2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Check if one is negative and one is positive:");
		Console.WriteLine((int1 < 0 && int2 > 0) || (int1 > 0 && int2 < 0));
	}
}
