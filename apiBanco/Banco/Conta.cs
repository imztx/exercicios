using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public string Nome { get; set; }

        public double Taxa { get; set; }

        //public Conta(int numero, double saldo, string nome)
        //{
        //    Numero = numero;
        //    Saldo = saldo;
        //    Nome = nome;
        //}

        public virtual double CalcularValorTarifaManutencao()
        {
            var calculo = Saldo * 0.1;
            return calculo;
        }

        public virtual bool Saca(double valor)
        {
            if (valor<= Saldo)
            {
                Saldo -= valor;
                return true;
                
            }
            return false;

        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Transfere(Conta contaDestino, double valor)
        {
            //Conta destino = new Conta();
            contaDestino.Saldo += valor;
        }
    }
}
