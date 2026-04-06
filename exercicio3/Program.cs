// Crie um programa para calcular o volume de um Cilindro

class Cilindro
{
    public decimal calculo;
    public decimal raio;
    public decimal altura;

    public decimal CalcularAreaBase()
    {
        return 3.14m * raio * raio;
    }
}

class Program
{
    static void Main(string[] args)
    { 
        Console.Clear();

        Cilindro cilindro = new Cilindro();

        Console.Write("Digite o raio do cilindro: ");
        cilindro.raio = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Digite a altura do cilindro: ");
        cilindro.altura = Convert.ToDecimal(Console.ReadLine());

        decimal areaBase = cilindro.CalcularAreaBase();
        
        Console.WriteLine($"O volume do cilindro é: {areaBase.ToString("F2")} cm³");

        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Pressione ENTER para continuar");
        Console.WriteLine("------------------------------------------");
        
        Console.ReadLine();
    }
}