using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_de_Informatica_NET10
{
    //CLASSE PRODUTO FORNECEDOR
    internal class ProdutoFornecedor
    {
        public Produto Produto { get; set; }

        public decimal PrecoAtual { get; set; }

        public ProdutoFornecedor(Produto produto)
        {
            Produto = produto ?? throw new ArgumentNullException(nameof(produto));
        }
    }
}
