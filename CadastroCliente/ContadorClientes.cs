using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    public class ContadorClientes
    {
        private static int contador = 0;
        public static int Contador
        {
            get { return contador; }
        }

       
        public static void Incrementar()
        {
            contador++;
        }

      
        public static void Resetar()
        {
            contador = 0;
        }
    }
}

