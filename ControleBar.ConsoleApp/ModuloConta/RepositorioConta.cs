using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase<Conta>
    {
        public bool RegistraFechamento(Conta conta)
        {
            conta.FecharConta();
            return true;
        }

    }
}
