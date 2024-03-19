namespace Ex07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o saláro base do vendedor: ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas do vendedor: ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o percentual sobre a comissão de vendas (em %):");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());

            double comissao = (percentualComissao / 100) * totalVendas;
            double salarioTotal = salarioBase + comissao;

            Console.WriteLine("O salário toral é de: " + salarioTotal);
            Console.ReadLine();





        }
    }
}
