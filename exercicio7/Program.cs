/*Crie um programa para calcular o salário total de um vendedor. Deverá ser
informado o salário base e o total de vendas. A comissão é calculada com um
percentual (informado pelo usuário) sobre o total de vendas.*/

using System.Security.Cryptography.X509Certificates;

class Salario
{
    public decimal salarioBase;
    public decimal totalVendas;
    public decimal percentual;
    public decimal comissao;

    public decimal CalcularComissao()
    {
        comissao = totalVendas * (percentual / 100);
        decimal salarioTotal = salarioBase + comissao;

        return salarioTotal;
    }
}
class Program
{
    static void Main (string[] args)
    {
        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("CONTADOR DE COMISSÃO");
            System.Console.WriteLine("--------------------------");

            Salario salario = new Salario();

            Console.Write("Digite o salário base: ");
            salario.salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade de vendas: ");
            salario.totalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o percentual de comissão: ");
            salario.percentual = Convert.ToDecimal(Console.ReadLine());

            decimal salarioTotal = salario.CalcularComissao();

            Console.WriteLine($"A comisssão é {salario.comissao}. O total do salário do mês é : {salarioTotal}");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();  
        } 
    }
}