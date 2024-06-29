using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFixação2.Entites.Enums
{
    internal enum EnumStatusPedido : int
    {
        PagamentoPendete = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3,
    }
}
