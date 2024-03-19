namespace EX06.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal temperaturaFahrenheist, temperaturaCelsius;

            Console.WriteLine("Digite e temperatura em graus Celsius: ");

            temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

            temperaturaCelsius = (temperaturaCelsius * 9/5 ) + 32;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + temperaturaCelsius);
            Console.ReadLine();
            
        }
    }
}
