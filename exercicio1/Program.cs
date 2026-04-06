//Crie um programa para calcular o volume de uma caixa retangular

using System.Security.Cryptography;

class Cabecalho
{
    public static void ExibirCabelho()
    {
        System.Console.WriteLine("------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        System.Console.WriteLine("Calculadora Retângulo");
        Console.ResetColor();
        System.Console.WriteLine("------------------------------------------");
        System.Console.WriteLine("Calcule o volume de uma caixa retangular:");
        System.Console.WriteLine("------------------------------------------");
    }
}
class Retangulo
{
    public decimal Comprimento;
    public decimal Largura;
    public decimal Altura;

    public decimal CalcularVolume()
    {
        return Comprimento * Largura * Altura;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Cabecalho.ExibirCabelho();

            Retangulo caixa = new Retangulo();

            Console.Write("Digite o comprimento da caixa: ");
            caixa.Comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a largura da caixa: ");
            caixa.Largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura da caixa: ");
            caixa.Altura = Convert.ToDecimal(Console.ReadLine());            

            decimal volume = caixa.CalcularVolume();

            Console.WriteLine($"\nO volume da caixa retangular é {volume}.");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();

            if (!JogadorDesejaContinuar())
            {
                Console.WriteLine("Encerrando o programa...");
                Thread.Sleep(1000);
                break;
            }
        }
    }

    static bool JogadorDesejaContinuar()
    {
        Console.Write("Deseja calcular outro retângulo? (s/N): ");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;

        else
        return true;   
    }
}
