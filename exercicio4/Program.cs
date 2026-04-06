/*Crie um programa para calcular o consumo de combustível por Km. Deverá ser
informado a kilometragem Inicial e Final do Percurso do Veículo. Deverá ser
informado o Consumo de Combustível*/

class Consumo
{
    public decimal combustivelConsumido;
    public decimal distanciaPercorrida;
    public decimal kmInicial;
    public decimal kmFinal;

    public decimal CalcularDistanciaPercorrida()
    {
        return distanciaPercorrida = kmFinal - kmInicial;
    }
    public decimal CalcularConsumoPorKm()
    {
        return distanciaPercorrida / combustivelConsumido;
    }
}
class program
{
    static void Main (string[] args)
    {
        while (true)
        {
        Console.Clear();

        Consumo calculo = new Consumo();

        System.Console.Write("Informe a quantidade de combustível gasto: ");
        calculo.combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

        System.Console.Write("Informe o km inicial da viagem: ");
        calculo.kmInicial = Convert.ToDecimal(Console.ReadLine());

        System.Console.Write("Informe o km final da viagem: ");
        calculo.kmFinal = Convert.ToDecimal(Console.ReadLine());

        decimal KmPercorrido = calculo.CalcularDistanciaPercorrida();

        decimal CombustivelConsumido = calculo.CalcularConsumoPorKm();

        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Foi consumido {CombustivelConsumido} por km².");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Pressione ENTER para continuar");
        Console.WriteLine("------------------------------------------");

        Console.ReadLine();
        }
    }
}