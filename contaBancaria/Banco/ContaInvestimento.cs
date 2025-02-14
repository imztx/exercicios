using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaInvestimento : Conta
    {
        public override double CalcularValorTarifaManutencao()
        {
            return Saldo * 0.5;
        }
    }
}
