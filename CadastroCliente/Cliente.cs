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
        public int Id { get; set; }
        public string data { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string nomesocial { get; set; }
        public bool estrangeiro { get; set; }
        public TipoCliente tipocliente { get; set; }
        public endereco EnderecoCliente { get; set; }
        public etinia etnia { get; set; }
       public generos generos { get; set; }
       
    }
   
}
 

   
