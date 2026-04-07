//Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

class calcular
{
    public double nota1;
    public double peso1;
    public double nota2;
    public double peso2;

    public double CalcularMediaPonderada()
    {
        double calculoMediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        return calculoMediaPonderada;
    }
}
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            calcular mediaPonderada = new calcular();
            
            Console.Write("Digite a nota da prova 1: ");
            mediaPonderada.nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da prova 1: ");
            mediaPonderada.peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da prova 2: ");
            mediaPonderada.nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da prova 2: ");
            mediaPonderada.peso2 = Convert.ToDouble(Console.ReadLine());

            double calculoMediaPonderada = mediaPonderada.CalcularMediaPonderada();

            Console.WriteLine($"Média ponderada: {calculoMediaPonderada:f2}");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();
        }
    }
}