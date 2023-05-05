using Banco2;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        ContaBancaria cb;

        Console.WriteLine("Indique o número da conta: ");
        int numConta = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Indique o nome do titular da conta: ");
        string titular = Console.ReadLine();

        Console.WriteLine("Haverá depósito inicial (s/n)?: ");
        char resposta = Convert.ToChar(Console.ReadLine());

        if (resposta == 's' || resposta == 'S')
        {
            Console.WriteLine("Qual o valor do depósito incial? ");
            double depositoInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb = new ContaBancaria(numConta, titular, depositoInicial);
        }
        else
        {
            cb = new ContaBancaria(numConta, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(cb);
        Console.WriteLine();
        Console.WriteLine("Entre com o valor para depósito: ");
        double quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        cb.Deposito(quantia);
        Console.WriteLine("Dados da conta atualizados: " + cb);
        Console.WriteLine();
        Console.WriteLine("Entre com o valor para levantamento: ");
        quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        cb.Levantamento(quantia);
        Console.WriteLine("Dados da conta atualizados: " + cb);


        //uso do set
        Console.WriteLine();
        cb.Titular = "Maria";
        Console.WriteLine(cb);


    }
}