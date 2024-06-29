using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFixação2.Entites
{
    internal class ItensPedido
    {
        public int Quantidade {  get; set; }
        public double Preco {  get; set; }
        public Produto Produto { get; set; }

        public ItensPedido()
        {

        }

        public ItensPedido(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Produto.Nome + ", R$ " + Produto.Preco.ToString("f2", CultureInfo.InvariantCulture) + ", Quantidade: " +
                  Quantidade + ", Subtotal: R$" + SubTotal().ToString("f2", CultureInfo.InvariantCulture);
             
        }
    }
}
