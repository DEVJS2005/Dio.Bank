using System;

namespace Dio.Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta("JS", 10000000, 15115161651, Tipoconta.pessoaFisica);
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
