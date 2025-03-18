using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class ClienteTipo
    {
        public ClienteTipo Tipo { get; set; }

        enum TipoCliente
        {

            PF,
            PJ
        }
    }
}
