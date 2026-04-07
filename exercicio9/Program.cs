// Crie um programa para calcular a média harmônica das notas de um aluno

using System.Diagnostics.CodeAnalysis;

class Calcular
{
    public decimal n1;
    public decimal n2;
    public decimal n3;
    public decimal n4;
    public decimal CalcularMediaHarmonica()
    {
        decimal mediaHarmonica = 4 / ((1.0m / n1) + (1.0m / n2) + (1.0m / n3) + (1.0m / n4));
        return mediaHarmonica;
    }
}
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Calcular mediaHarmonica = new Calcular();
    
            Console.Write("Digite a primeira nota: ");
            mediaHarmonica.n1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            mediaHarmonica.n2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            mediaHarmonica.n3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Digite a quarta nota: ");
            mediaHarmonica.n4 = Convert.ToDecimal(Console.ReadLine());
    
            decimal resultadoMediaHarmonica = mediaHarmonica.CalcularMediaHarmonica();
    
            Console.WriteLine($"A média harmônica é {resultadoMediaHarmonica:f2}");
    
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();
        }
    }
}