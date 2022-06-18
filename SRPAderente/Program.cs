using System;

namespace SRPAderente
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            pedido.IncluirPedido();
            pedido.DeletaPedido();
        }
    }
}
