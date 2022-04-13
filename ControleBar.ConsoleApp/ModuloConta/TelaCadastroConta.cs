using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.ModuloPedido;
using ControleBar.ConsoleApp.ModuloProduto;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class TelaCadastroConta : TelaBase
    {
        decimal total = 0;
        List<Produto> produtos;

        public TelaCadastroConta(string titulo) : base(titulo)
        {
        }

        public void AdicionarPedido()
        {
            MostrarTitulo("Adicionando pedidos");

        }

        public decimal TotalConta()
        {
            foreach (Produto produto in produtos)
            {
                total += produto.Preco;
            }
            return total;
        }
    }


}

