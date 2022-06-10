public class Exercise1
{
	public static void Main()
	{

		int number1, number2;
		Console.Write("\nInput the First Number : ");
		number1 = int.Parse(Console.ReadLine());
		Console.Write("\nInput the Second Number : ");
		number2 = int.Parse(Console.ReadLine());

		Console.Write($"Adding your chosen two numbers together equals: {number1 + number2} \n");
		Console.Write($"Subtracting your chosen two numbers equals: {number1 - number2} \n");
		Console.Write($"Multiplying your chosen two numbers equals: {number1 * number2} \n");
		Console.Write($"Dividing your chosen two numbers equals: {number1 / number2} \n");

		Console.Read();

	}
}