using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaDeContatos.Contato
{
    public class DadosCadastrais
    {
        string Nome { get; set; }
        string SobreNome { get; set; }
        string Telefone { get; set; }
        string Email { get; set; }

        public void SalvarDadosIniciais()
        {
            Console.WriteLine("Bem-vindo");
            Console.WriteLine("Primeiro precisamos Cadastrar seu contato");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome e Telefone são obrigatórios.");
            Console.WriteLine("Sobrenome e Email não são Obrigatótios apenas digite enter caso não quera prencher");

            Console.Write("Digite o Nome:");
            Nome = Console.ReadLine();
            if (Nome == "" || Nome.Length < 2 || Nome.Length >= 100)
            {
                Console.WriteLine("insira um valor válido para o Nome");
                Console.Write("Digite o Nome: ");
                Nome = Console.ReadLine();
            }



            Console.Write("Digite o Sobrenome:");
            SobreNome = Console.ReadLine();
            if (SobreNome == "")
            {
                SobreNome = "N/A";
            }



            int numero;
            Console.Write("Digite o Telefone: ");
            do
            {
                
                Telefone = Console.ReadLine();
                if (Telefone == "" || Telefone.Length < 8 || Telefone.Length > 15)
                {
                    Console.WriteLine("Numero incorreto");
                    Console.WriteLine("Seu Numero deve conter entre 8 a 15 digitos");
                    Console.Write("Digite o Telefone: ");
                    Telefone = Console.ReadLine();
                }
                    //if (!int.TryParse(Telefone, out numero))
                    //{
                    //    Console.WriteLine("Numero incorreto");
                    //    Console.WriteLine("digite novalmente seu numero usando o exemplo - 11111111111");
                    //    Console.Write("Digite o Telefone: ");
                    //}
            } while (!int.TryParse(Telefone, out numero));
            Console.WriteLine("Você digitou o número: " + numero);

            
            
            
            bool isValid = false;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            do
            {
                Console.Write("Digite seu e-mail: ");
                Email = Console.ReadLine();

                if (Regex.IsMatch(Email, emailPattern, RegexOptions.IgnoreCase))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("O e-mail digitado é inválido. Por favor, tente novamente.");
                }
            } while (!isValid);

            Console.WriteLine($"\nO e-mail '{Email}' foi validado com sucesso!");
        }
    }
}

   
