using ProjetoFixação2.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoFixação2.Entites.Enums;
using ProjetoFixação2.Entites;
using System.Globalization;

namespace ProjetoFixação2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com dados do cliente: ");
            Console.Write("Nome: ");
            string nomecliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime momento = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nomecliente,email,momento);
            Console.WriteLine();
            Console.WriteLine("Entre com dados do pedido: ");
            Console.Write("Status: ");
            EnumStatusPedido status = (EnumStatusPedido)Enum.Parse(typeof(EnumStatusPedido),Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.WriteLine();
            Console.Write("Quantos pedidos gostaria de adicionar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Pedido N{0}",i);
                Console.Write("Nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nome, preco);

                Console.Write("Quantidade: ");
                int quantidade =int.Parse(Console.ReadLine());
               
                ItensPedido itens = new ItensPedido(quantidade,preco,produto);

                pedido.AdicionarItem(itens);
                Console.WriteLine();
            }
            Console.WriteLine("Resumo do pedido: ");
            Console.WriteLine(pedido);
            Console.ReadLine();

        }
    }
}
