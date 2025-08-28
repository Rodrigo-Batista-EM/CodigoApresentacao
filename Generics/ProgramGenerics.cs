namespace Generics
{
    // Classe genérica com restrição: T precisa ser uma struct (tipo por valor)
    class CaixaValor<T> where T : struct
    {
        public T Valor;

        public CaixaValor(T valor)
        {
            Valor = valor;
        }

        public T ObterValor()
        {
            return Valor;
        }
    }

    // Classe genérica com restrição: T precisa ser uma classe (tipo por referência)
    class CaixaReferencia<T> where T : class
    {
        public T Valor;

        public CaixaReferencia(T valor)
        {
            Valor = valor;
        }

        public T ObterValor()
        {
            return Valor;
        }
    }

    // Classe genérica com restrição: T precisa ter um construtor sem parâmetros
    class Instanciador<T> where T : new()
    {
        public T CriarInstancia()
        {
            return new T();
        }
    }

    // Classe de exemplo para uso com new()
    class Pessoa
    {
        public string Nome = "Sem Nome";
    }

    internal class ProgramGenericsRestricoes
    {
        static void Main(string[] args)
        {
            // ===== GENERICS COM RESTRIÇÕES =====

            // T : struct
            CaixaValor<int> caixaInt = new CaixaValor<int>(42);
            int valorInt = caixaInt.ObterValor();
            // valorInt = 42

            // T : class
            CaixaReferencia<string> caixaTexto = new CaixaReferencia<string>("Texto");
            string valorTexto = caixaTexto.ObterValor();
            // valorTexto = "Texto"

            // T : new()
            Instanciador<Pessoa> instanciadorPessoa = new Instanciador<Pessoa>();
            Pessoa novaPessoa = instanciadorPessoa.CriarInstancia();
            string nome = novaPessoa.Nome;
            // nome = "Sem Nome"

            // Garante que o tipo tenha um construtor vazio para ser instanciado
        }
    }
}
