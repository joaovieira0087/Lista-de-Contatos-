using ListaDeContatos.model;
using ListaDeContatos.Model;

namespace ListaDeContatos.Contato
{
    public class ProcessamentoDadosCadastrais
    {
        public DadosCadastrais SalvarDadosIniciais()
        {
            var dados = new DadosCadastrais();

            Console.WriteLine("Bem-vindo");
            Console.WriteLine("Primeiro precisamos cadastrar seu contato");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome e Telefone são obrigatórios.");
            Console.WriteLine("Sobrenome e Email são opcionais (ENTER para pular).");
            Console.WriteLine();

            // NOME (obrigatório: 2 a 100)
            dados.Nome = LerObrigatorio("Nome", 2, 100);

            dados.sexo = Sexo("Sexo", 1, 20);

            // SOBRENOME (opcional: se vazio, N/A)
            var s = LerOpcional("Sobrenome");
            dados.SobreNome = string.IsNullOrWhiteSpace(s) ? "N/A" : s;

            // TELEFONE (obrigatório simples)
            dados.Telefone = LerObrigatorio("Telefone", 8, 20);

            // EMAIL (opcional)
            dados.Email = LerOpcional("Email");

            return dados;
        }

        private static string LerObrigatorio(string label, int min, int max)
        {
            while (true)
            {
                Console.Write($"Digite o {label}: ");
                var valor = (Console.ReadLine() ?? "").Trim();
                if (valor.Length >= min && valor.Length <= max) return valor;

                Console.WriteLine($"Insira um {label} válido (entre {min} e {max} caracteres).");
            }
        }

        private static string Sexo(string label, int min, int max)
        {
            while (true)
            {
                Console.Write($"Digite {label}");
            }
        }

        private static string LerOpcional(string label)
        {
            Console.Write($"Digite o {label} (opcional): ");
            return (Console.ReadLine() ?? "").Trim();
        }
    }
}
