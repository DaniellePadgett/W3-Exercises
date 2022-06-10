public class Exercise1
{
	public static void Main()
	{

		int number1, number2, number3, number4, average;
		Console.Write("\nInput your first chosen number : ");
		number1 = int.Parse(Console.ReadLine());

		Console.Write("\nInput your second chosen number : ");
		number2 = int.Parse(Console.ReadLine());

		Console.Write("\nInput your third chosen number : ");
		number3 = int.Parse(Console.ReadLine());

		Console.Write("\nInput your fourth chosen number : ");
		number4 = int.Parse(Console.ReadLine());

		average = (number1 + number2 + number3 + number4) / 4;

		Console.Write($"The average of {number1}, {number2}, {number3} and {number4} is: {average} \n");

		Console.Read();

	}
}