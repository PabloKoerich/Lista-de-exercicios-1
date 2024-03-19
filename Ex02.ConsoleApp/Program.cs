namespace Ex02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaFahrenheist, temperaturaCelsius;



            Console.WriteLine("Digite e temperatura em graus Fahrenheit: ");

            temperaturaFahrenheist = Convert.ToDecimal(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheist - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: " +  temperaturaCelsius);
            Console.ReadLine();
        }   
    }
}
