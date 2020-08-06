using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Ex_video_60
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c;

            Console.Write("Digite o número da conta: ");
            int n_conta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial <s/n>? ");
            char r_d = char.Parse(Console.ReadLine());
            if (r_d == 's' || r_d == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double d_i = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(n_conta, titular, d_i);
            }
            else
            {
                c = new ContaBancaria(n_conta, titular);
            }

            Console.WriteLine("\nDados da conta:\nConta {0}, Titular: {1}, Saldo: R$ {2}", c.Numero,
            c.Titular, c.Saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n");

            Console.Write("Digite o valor do depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(dep);

            Console.WriteLine(c + "\n");

            Console.Write("Digite o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);

            Console.WriteLine(c);

        }
    }
}