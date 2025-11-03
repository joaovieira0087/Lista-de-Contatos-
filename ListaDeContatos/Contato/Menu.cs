using ListaDeContatos.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos.Contato
{
    

    public class Menu
    {
        

        //public void VerificarDados()
        //{
        //    var contatos = new List<DadosCadastrais>();

        //    DadosCadastrais dadosCadastraisVerificacao = new DadosCadastrais();
        //}

        public void ExibirMenu()
        {
            Console.WriteLine("----- Menu de Contatos -----");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Listar Contatos");
            Console.WriteLine("3. Buscar Contato");
            Console.WriteLine("4. Sair");
            Console.Write("Selecione uma opção: ");
        }
    }
}
