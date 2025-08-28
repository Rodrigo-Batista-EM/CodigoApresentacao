using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class PessoaLINQ
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }
    }

    internal class ProgramLINQ
    {
        static void Main(string[] args)
        {
            List<PessoaLINQ> pessoas = new List<PessoaLINQ>
            {
                new PessoaLINQ { Nome = "Ana", Idade = 28, Profissao = "Designer" },
                new PessoaLINQ { Nome = "Bruno", Idade = 35, Profissao = "Programador" },
                new PessoaLINQ { Nome = "Carlos", Idade = 22, Profissao = "Programador" },
                new PessoaLINQ { Nome = "Diana", Idade = 30, Profissao = "Gerente" },
                new PessoaLINQ { Nome = "Eduardo", Idade = 40, Profissao = "Designer" }
            };

            // ===== WHERE =====
            var maiores30 = pessoas.Where(p => p.Idade > 30).ToList();

            // ===== SELECT =====
            var nomes = pessoas.Select(p => p.Nome).ToList();

            // ===== ORDERBY =====
            var ordenadoPorIdade = pessoas.OrderBy(p => p.Idade).ToList();

            // ===== GROUPBY =====
            var porProfissao = pessoas.GroupBy(p => p.Profissao);

            // ===== ALL / ANY =====
            bool todosAdultos = pessoas.All(p => p.Idade >= 18); //true
            bool temGerente = pessoas.Any(p => p.Profissao == "Gerente"); //true

            // ===== COUNT =====
            int qtdProgramadores = pessoas.Count(p => p.Profissao == "Programador"); 

            // ===== DISTINCT =====
            var profissoesUnicas = pessoas.Select(p => p.Profissao).Distinct().ToList();
            // Remove profissões repetidas

            // ===== AVERAGE =====
            double mediaIdade = pessoas.Average(p => p.Idade);
            // Média da idade das pessoas

            // ===== AGGREGATE =====
            string nomesConcatenados = pessoas
                .Select(p => p.Nome)
                .Aggregate((acc, nome) => acc + ", " + nome);
            // Junta todos os nomes com vírgula

            // ===== EXCEPT =====
            var listaA = new List<string> { "Ana", "Carlos", "Eduardo" };
            var listaB = new List<string> { "Carlos", "Eduardo" };
            var apenasEmA = listaA.Except(listaB).ToList(); // ["Ana"]

            // ===== SKIP =====
            var semOsDoisPrimeiros = pessoas.Skip(2).ToList();
            // Pula os dois primeiros da lista

            // ===== JOIN =====
            var salarios = new List<(string Nome, decimal Salario)>
            {
                ("Ana", 3000),
                ("Bruno", 5000),
                ("Carlos", 4000)
            };

            var pessoasComSalario = pessoas
                .Join(
                    salarios,
                    pessoa => pessoa.Nome,
                    salario => salario.Nome,
                    (pessoa, salario) => new
                    {
                        pessoa.Nome,
                        pessoa.Profissao,
                        salario.Salario
                    }
                )
                .ToList();

            // Agora tenho uma lista com Nome, Profissão e Salário
        }
    }
}
