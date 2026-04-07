//Crie um programa para calcular o volume de uma lata de óleo

class Calcular
{
    public double raio;
    public double altura;
    public double CalcularVolume()
    {
        double volume = Math.PI * Math.Pow(raio, 2) * altura;

        return volume;
    }
}
class Program
{
    static void Main (string[] args)
    {
        while (true)
        {
            Console.Clear();
            Calcular lata = new Calcular();

            Console.Write("Digite o raio da lata: ");
            lata.raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da lata: ");
            lata.altura = Convert.ToDouble(Console.ReadLine());

            double volume = lata.CalcularVolume();

            Console.WriteLine($"Volume da lata: {volume:f2}");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();
        }
    }
}