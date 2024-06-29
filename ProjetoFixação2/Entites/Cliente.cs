using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFixação2.Entites
{
    internal class Cliente
    {
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public DateTime DataNacimento { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nomecliente, string email, DateTime dataNacimento)
        {
            NomeCliente = nomecliente;
            Email = email;
            DataNacimento = dataNacimento;
        }
        public override string ToString()
        {
            return NomeCliente + ", " + DataNacimento.ToString("dd/MM/yyyy") + " - " + Email;
        }
    }
}
