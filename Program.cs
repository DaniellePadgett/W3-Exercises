public class Exercise1
{
	public static void Main()
	{

		int number1, number2, number3;
		Console.Write("\nInput the First Number : ");
		number1 = int.Parse(Console.ReadLine());
		Console.Write("\nInput the Second Number : ");
		number2 = int.Parse(Console.ReadLine());
		Console.Write("\nInput the Third Number : ");
		number3 = int.Parse(Console.ReadLine());

		Console.Write("\nFirst Number multiplied by 2: " + number1 * 2);
		Console.Write("\nSecond Number multiplied by 3: " + number2 * 3);
		Console.Write("\nThird Number multiplied by 6: " + number3 * 6);
		Console.Read();

	}
}