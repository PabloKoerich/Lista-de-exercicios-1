namespace Ex04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region INPUT de dados:

            double quilometragemInicial, quilometragemfinal, distanciaPercorrida, consumoCombustivel;
            Console.WriteLine("Digite a quilomeragem inicial");
            quilometragemInicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem Final:");
            quilometragemfinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustivel (em Litros): ");
            consumoCombustivel = Convert.ToDouble(Console.ReadLine());
            #endregion

            #region Processamento
            distanciaPercorrida = quilometragemfinal - quilometragemInicial;

            double consumoPorKM = consumoCombustivel / distanciaPercorrida;
            #endregion

            #region OUTPUT de dados:
            Console.WriteLine("O consumo médiode combustivel por KM é de:" + consumoPorKM);

            Console.ReadLine();

            #endregion
        }
    }
}
