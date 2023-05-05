using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco2
{
    internal class ContaBancaria
    {
        //Definição de Propriedade
        public int NumConta { get; } //não pode alterar.
        public string Titular { get; set; }
        public double Saldo { get; private set; } //pode ser acessado a partir de outra classe, mas só altera dentro da classe conta bancária.

        public static double Taxa = 5.00; //taxa fixa.

        //Construtores

        //esse construtor permite instanciar contas bancárias apenas com o número de conta e titular.
        public ContaBancaria(int numConta,  string titular)
        {
            NumConta = numConta;
            Titular = titular;
        }

        //esse construtor permite instanciar uma conta a partir do numero de conta, titular e saldo inicial.
        public ContaBancaria(int numConta, string titular, double saldo) : this(numConta, titular)
        {
            Saldo = saldo;
        }

        //Secção de Métodos

        //Este método permite o depósito de dinheiro na conta.
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        //Este método permite o levantamento de dinheiro na conta.
        public void Levantamento(double quantia)
        {
            Saldo -= (quantia + Taxa);
        }

        //permite o print das informações corretamente.
        public override string ToString()
        {
            return "Número conta: " + NumConta + ", Titular da conta: " + Titular + ", Saldo: " + Saldo.ToString("F2") + " euros.";
        }


    }
}
