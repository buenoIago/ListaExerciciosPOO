//Crie um programa para calcular o volume de uma esfera
class Esfera
{
    public double raio;
    public double CalcularVolume()
    { 
        double pi = 3.14;
        double raioCubo = raio * raio * raio;

        return (4.0 / 3.0) * pi * raioCubo;
    }
}
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Esfera esfera = new Esfera();

            System.Console.Write("Digite o raio da esfera: ");
            esfera.raio = Convert.ToDouble(Console.ReadLine());

            double volume = esfera.CalcularVolume();

            System.Console.WriteLine($"O volume da esfera é: {volume:f2}");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();
        }  
    }
}