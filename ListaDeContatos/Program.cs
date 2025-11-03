using System;
using System.Numerics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using ListaDeContatos.Contato;
using ListaDeContatos.model;


namespace ListaDeContatos
{
    class Program
    {
        public static void Main(string[] args)
        {
            var contatos = new List<DadosCadastrais>();

            var proc = new ProcessamentoDadosCadastrais();

            DadosCadastrais novo = proc.SalvarDadosIniciais();



            //DadosCadastrais dadosCadastrais = new DadosCadastrais();

            //dadosCadastrais.SalvarDadosIniciais();

            //Console.WriteLine("Cadastro Concluindo com sucesso");

            //dadosCadastrais.MostrarDadosCadastrais();




        }
    }
}

