using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta  //Herança
    {
        public override double CalcularValorTarifaManutencao() //Sobrescrita de método
        {
            return Saldo * 0.2;
        }
    }
}
