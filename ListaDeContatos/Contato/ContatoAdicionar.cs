using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos.Contato
{
    public  class ContatoAdicionar
    {
        string Nome { get; set; }
        string SobreNome { get; set; }
        string Telefone { get; set; }
        string Email { get; set; }
        string Endereco { get; set; }
        public DadosCadastrais DadosCadastrais { get; set; }
    }
}
