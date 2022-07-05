using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Bank
{
    internal class Conta
    {
        private Tipoconta Tipoconta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        public Conta(string nome, double saldo, double credito, Tipoconta tipoconta)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Tipoconta = tipoconta;
        }

        public bool alterarSaldo(double saldo)
        {
            this.Saldo = saldo;
            return true;
        }
        public double mostrarSaldo() { return this.Saldo; }
        public double mostrarCredito() { return this.Credito; }
        public bool sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                this.Saldo -= valorSaque;
                Console.WriteLine("O Saldo atual da conta de:{0} é {1}", this.Nome, this.Saldo);
                return true;
            }
        }
        public void depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("O Saldo atual da conta de:{0} é {1}", this.Nome, this.Saldo);
        }
        public void tranferir(double valorTranferencia, Conta contaDestino)
        {
            if (this.sacar(valorTranferencia)){
                contaDestino.depositar(valorTranferencia);
            }
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta: " + this.Tipoconta + " | ";
            retorno += "Nome: " + this.Nome + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito + " | ";
            return retorno;
        }



    }
}
