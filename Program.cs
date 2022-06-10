public class Exercise1
{
	public static void Main()
	{

		double celsius;
		double kelvin;
		double fahrenheit;

		Console.Write("Please enter any temperature below\n");
		celsius = Convert.ToDouble(Console.ReadLine());

		kelvin = celsius + 273.15;
		fahrenheit = (celsius / 5) * 9 + 32;


		Console.Write($"Kelvin = {kelvin}\n");
		Console.Write($"Fahrenheit  = {fahrenheit}\n");


	}
}