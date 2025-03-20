using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDCommerceBCC.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Loja { get; set; }
        public string Produto { get; set; }
        public DateTime Data { get; set; }
    }
}
