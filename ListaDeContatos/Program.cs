using System;
using System.Numerics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using ListaDeContatos.Contato;


namespace ListaDeContatos
{
    class Program
    {
        public static void Main(string[] args)
        {
            DadosCadastrais dadosCadastrais = new DadosCadastrais();

            dadosCadastrais.SalvarDadosIniciais();
        }
    }
}

