//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

using System.Security.Cryptography.X509Certificates;

class Cabecalho
{
    public static void ExibirCabelho()
    {
        System.Console.WriteLine("------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        System.Console.WriteLine("Conversor de Celsius para Fahrenheit:");
        Console.ResetColor();
        System.Console.WriteLine("------------------------------------------");
        System.Console.WriteLine("Converta a temperatura de Celsius para Fahrenheit");
        System.Console.WriteLine("------------------------------------------");
    }
}

class Temperatura
{
    public decimal Celsius;

    public decimal Converter()
    {
        return 1.8m * Celsius + 32;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();

            Cabecalho.ExibirCabelho();

            Temperatura temp = new Temperatura();

            System.Console.Write("Digite a temperatura em graus celsius: ");
            temp.Celsius = Convert.ToDecimal(Console.ReadLine());

            decimal fahrenheit = temp.Converter();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{temp.Celsius} °C convertido para Fahrenheit é {fahrenheit} °F.");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("------------------------------------------");

            Console.ReadLine();

            if (!DesejaContinuar())
            {
                Console.WriteLine("Encerrando o programa...");
                break;
            }

            Cabecalho.ExibirCabelho();
        }
    }
    static bool DesejaContinuar()
    {
        Console.Write("Deseja converter outra temperatura? (s/N): ");
        string? opcao = Console.ReadLine()?.ToUpper();

        return opcao == "S";
    }
}