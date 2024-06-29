using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFixação2.Entites.Enums;
using ProjetoFixação2.Entites;
using System.Globalization;

namespace ProjetoFixação2.Entites
{
    internal class Pedido
    {
        public DateTime Momento { get; set; }
        public EnumStatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensPedido> ItemPedidos { get; set; } = new List<ItensPedido>();

        public Pedido()
        {

        }

        public Pedido(DateTime momento, EnumStatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }
        public void AdicionarItem(ItensPedido pedido)
        {
            ItemPedidos.Add(pedido);
        }
        public void RemoverItem(ItensPedido pedido)
        {
            ItemPedidos.Remove(pedido);
        }
        
        public double Total()
        {
            double som = 0;
            foreach (var item in ItemPedidos)
            {
                som += item.SubTotal();
            }
            return som;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Horario do pedido: ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Status do pedido: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Cliente: ");
            sb.Append(Cliente.NomeCliente);
            sb.Append(" - ");
            sb.Append(Cliente.DataNacimento.ToString("dd/MM/yyyy"));
            sb.Append(" - ");
            sb.AppendLine(Cliente.Email);
            sb.AppendLine("Itens do pedido: ");
            
            foreach (ItensPedido it in ItemPedidos)
            {
                sb.AppendLine(it.ToString());
            }
            sb.Append("Total do pedido: ");
            sb.Append("R$ ");
            sb.AppendLine(Total().ToString("f2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}

