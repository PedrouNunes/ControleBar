using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.ModuloProduto;


namespace ControleBar.ConsoleApp.ModuloPedido
{
    public class Pedido 
    {
        List<Produto> produtos;
        int total;

        public int CalcularPedido()
        {
            foreach (Produto produto in produtos)
            {
                produto.Preco += total;
            }
            return (int)total;
        }
    }
}
