using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloPedido;
using ControleBar.ConsoleApp.ModuloProduto;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Garcom garcom;
        public Mesa mesa;
        public Pedido pedido;
        public Produto produto;
        private bool contaAberta;

        public Conta(Mesa mesa, Garcom garcom)
        {
            this.mesa = mesa;
            this.garcom = garcom;

            AbrirConta();
        }

        public override string ToString()
        {
            return "Numero da mesa" + mesa.Numero + Environment.NewLine +
                "Nome do produto: " + produto.Nome + Environment.NewLine +
                "Garçom da mesa: " + garcom.Nome;
        }

        public void AbrirConta()
        {
            if (!contaAberta)
            {
                contaAberta = true;
            }
        }

        public void FecharConta()
        {
            if (contaAberta)
            {
                contaAberta = false;
            }

        }

    }
}

