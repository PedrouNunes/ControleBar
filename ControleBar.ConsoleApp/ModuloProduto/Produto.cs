using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; } = 0m;

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome do Produto: " + Nome + Environment.NewLine +
                "Preço do produto: R$" + Preco + Environment.NewLine;
        }
}
}
