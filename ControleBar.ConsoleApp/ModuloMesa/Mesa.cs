using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.ModuloConta;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int Numero { get; set; }

        public Mesa(int numero)
        {
        Numero = numero;
        }
        public override string ToString()
        {
            return "Id: " + id;
        }
    }
}
