namespace Casts
{
    // Interface: define um contrato
    interface ITrabalhavel
    {
        void Trabalhar();
    }

    // Classe abstrata: base com comportamento parcial
    abstract class Pessoa : ITrabalhavel
    {
        public string Nome; // Referência no heap

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public abstract void Trabalhar(); // Força implementação
    }

    class Programador : Pessoa
    {
        public Programador(string nome) : base(nome) { }

        public override void Trabalhar()
        {
            // Output: "{Nome} está programando"
        }
    }

    class Designer : Pessoa
    {
        public Designer(string nome) : base(nome) { }

        public override void Trabalhar()
        {
            // Output: "{Nome} está desenhando interfaces"
        }
    }

    // Struct: tipo por valor
    struct Ponto2D
    {
        public int X;
        public int Y;

        public Ponto2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Alocado na stack se for variável local
    }

    internal class ProgramPOO
    {
        static void Main(string[] args)
        {
            // ===== STACK VS HEAP =====

            int idade = 30;
            // Valor tipo primitivo: armazenado diretamente na Stack

            Programador dev = new Programador("Lucas");
            // 'dev' é referência (guardada na Stack), objeto real está no Heap

            Ponto2D ponto = new Ponto2D(3, 4);
            // Struct armazenada totalmente na Stack (tipo por valor)

            // ===== BOXING E UNBOXING =====

            int numero = 123;
            object obj = numero; // BOXING: valor (Stack) convertido para object (Heap)

            int outroNumero = (int)obj; // UNBOXING: retorno para tipo valor (Stack)

            // Atenção: unboxing incorreto causa exceção em tempo de execução
            // ex: double erro = (double)obj; // Lança InvalidCastException

            // ===== POO, POLIMORFISMO E INTERFACES =====

            Pessoa p1 = new Designer("Ana");
            Pessoa p2 = new Programador("Carlos");

            // Polimorfismo: mesmo tipo base, comportamentos diferentes
            p1.Trabalhar(); // Output: "Ana está desenhando interfaces"
            p2.Trabalhar(); // Output: "Carlos está programando"

            // Interface: qualquer classe que implementa pode ser usada como ITrabalhavel
            ITrabalhavel trabalhador = p2;
            trabalhador.Trabalhar(); // Output: "Carlos está programando"

            // DOWNCAST seguro com verificação
            if (p1 is Designer)
            {
                Designer d = (Designer)p1; // Conversão segura (heap -> referência real)
            }

            // UPCAST implícito (seguro)
            Programador prog = new Programador("Roberto");
            Pessoa pessoaUpcast = prog; // Upcast automático (Programador -> Pessoa)
        }
    }
}
