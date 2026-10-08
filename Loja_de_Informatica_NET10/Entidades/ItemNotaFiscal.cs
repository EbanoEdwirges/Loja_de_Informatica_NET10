using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica_NET10
{
    //ITEM NOTA FICAL
    internal class ItemNotaFiscal
    {
        public Produto Produto { get; set; }

        public decimal PrecoUnitario { get; set; }

        public int Quantidade { get; set; }

        public decimal SubTotal { get; set; }

        public ItemNotaFiscal(Produto produto)
        {
            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
        }
    }
}
