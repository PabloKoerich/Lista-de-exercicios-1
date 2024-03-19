namespace Ex01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal comprimento, largura, altura, volume;

            Console.WriteLine("Digite o comprimento da caixa.");
            comprimento = Convert.ToDecimal (Console.ReadLine());


            Console.WriteLine("Digite a largura da caixa.");
            largura = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Digite a altura da caixa.");
            altura = Convert.ToDecimal(Console.ReadLine());

            
            volume = comprimento  * altura * largura;

            Console.WriteLine("O volume da caixa é: " + volume);
            Console.ReadLine();

                   
        }   
    }
}
