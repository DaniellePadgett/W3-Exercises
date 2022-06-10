public class Exercise1
{
	public static void Main()
	{

		int number1;
		Console.Write("\nInput your chosen Number : ");
		number1 = int.Parse(Console.ReadLine());

		Console.Write($"{number1} x 0 equals: {number1 * 0} \n");
		Console.Write($"{number1} x 1 equals: {number1 * 1} \n");
		Console.Write($"{number1} x 2 equals: {number1 * 2} \n");
		Console.Write($"{number1} x 3 equals: {number1 * 3} \n");
		Console.Write($"{number1} x 4 equals: {number1 * 4} \n");
		Console.Write($"{number1} x 5 equals: {number1 * 5} \n");
		Console.Write($"{number1} x 6 equals: {number1 * 6} \n");
		Console.Write($"{number1} x 7 equals: {number1 * 7} \n");
		Console.Write($"{number1} x 8 equals: {number1 * 8} \n");
		Console.Write($"{number1} x 9 equals: {number1 * 9} \n");
		Console.Write($"{number1} x 10 equals: {number1 * 10} \n");

		Console.Read();

	}
}