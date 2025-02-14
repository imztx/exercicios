using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaCorrente : Conta
    {
        public override bool Saca(double valor)
        {
            double calculo = Saldo - 0.20;
            return base.Saca(valor);
        }
    }
}
