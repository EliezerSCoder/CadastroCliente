using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class Cliente
    {
        public Cliente dados {  get; set; }

        public string Nome { get; set; }
        public int id { get; set; }
        public string data { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string nomesocial { get; set; }
        public bool estrangeiro { get; set; }
        public ClienteTipo tipocliente { get; set; }
        public endereco endereco { get; set; }
        public etnia etnia { get; set; }
       public generos generos { get; set; } 
    }
   
}
