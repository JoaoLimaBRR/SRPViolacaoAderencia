using System;
using System.Collections.Generic;
using System.Text;

namespace SRPAderente
{
    class Pedido
    {
        private readonly ILogger _logger;

        public Pedido()
        {
            _logger = new Logger();
        }

        public void IncluirPedido()
        {
            try
            {
                _logger.GravaLog("Incluindo pedido");
                EnviarEmail email = new EnviarEmail("teste", "teste", "teste", "teste");
                email.Enviar();
            }
            catch (Exception ex)
            {
                _logger.GravaLog("ERRO AO INCLUIR PEDIDO: " + ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                _logger.GravaLog("Deletando pedido");
                //Codigo para deletar o pedido gerado
            }
            catch (Exception ex)
            {
                _logger.GravaLog("ERRO AO DELETAR PEDIDO: " + ex.Message);
            }
        }
    }
}
