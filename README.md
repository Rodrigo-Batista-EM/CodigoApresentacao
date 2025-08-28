1.(Conversão de Tipos)
1.1.(Conversão Implicita) Conversões implícitas são conversões que não precisam de cast ou função de conversão, o próprio compilador 
faz a conversão, isso ocorre quando a conversão é segura, ou seja, não existe risco de perder dados, no exemplo 
long tem capacidade maior que int, então a conversão é feita pelo próprio compilador.

1.2.(Caso de float/long) Neste exemplo o long tem capacidade "maior" que o float, porem devido a forma como o float funciona 
(guarda numeros aproximados) ele consegue armazenar numeros maiores,  apesar de existir a possibilidade de perder 
dados o compilador faz a conversão.

1.3.(Conversões Explicitas) As conversões explicitas precisam de casts ou funções de conversão, ja que nessas conversões existem 
chances de perder dados, precisam ser feitas manualmente, essas conversões não são seguras.

1.4.(parse e tryParse) O parse retorna o valor se o formato for correto, caso não seja lança FormatException, o tryParse() retora true
 se a conversão der certo e o valor convertido fica na cariavel out, caso for falso, out recebe valor padrão do tipo.
 
 3. (POO)
 3.1(Interface) Uma interface é um contrato, qualquer um que implemente ele, precisa fornecer uma versão do metodo, elas não apresentam
 codigo, apenas a assinatura da função.
 
 3.2(Abstract) Uma classe abstrata serve como uma base, ela pode impletar o codigo, ou pode ficar sem implementação,
deixando com que suas classes "filhas" sejam obrigadas a implementar, nesse caso, pessoa é uma classe abstrata, ela implementa a 
interface ITrabalhavel, como ela não implementou nada ao trabalhar(), quem herdar sera obrigado a implementar.

3.3(Heap VS Stack) stack é um tipo de memoria linear e organizado, seu gerenciamento é automatico e controlado pela linguagem, elas armazenam
tipos por valor, variaveis são removidas automaticamente quando o escopo acaba, e seu escopo é limitado. Ja a heap é desorganizada e flexivel,
é gerenciada pelo garbage colector, armazena tipos por referencia, objetos permanecem na memoria ate que o gabage colector os limpe.

3.4(struct vs classe) A estrutura basica das duas são iguais, as diferenças estão nas funcionalidades, classes são tipos de referencia,
ou seja, são armazenados na memoria heap, ja structs são do tipo valor, logo são armazenados na memoria stack, classes suportam heranças,
structs não suportam, classes são usados para objetos complexos, e structs são usados para dados pequenos e temporarios.

3.5(boxing e unboxing) O boxing nada mais é que pegar um valor da memoria stack e colocar em um objeto na memoria heap, e o unboxing é quando
voce tira de dentro de um objeto e transforma para seu valor original.

3.6(Upcast e Downcast) Upcasting é converter um objeto de uma classe derivada para sua classe base ou interface, é seguro e feito implicitamente, permite
trabalhar com abstrações, é muito util para polimorfismo. Ja o Downcast é o opostso, convertar uma classe base para sua derivada, é arriscado,
exige cast explicito e lança InvalidCastException em tempo de execução se o tipo nao for compativel.

3.7(is e as) o Is teste se um objeto é de um tipo sem fazer conversão, o as tenta fazer um downcast e retorna o objeto convertido, ou null se falhar.

4(GENERICS)
4.1() Generics no C# permitem que voce crie classes, interfaces, metodos e tipos parametrizados, ou seja, voce escreve um codigo reutilizavel, que pode
trabalhar com diferentes tipos, mantendo a segurança de tipos e a performance. Antes dos genericos era comum usar object para armazenar qualquer tipo,
pois isso perdia a segurança do tipo e isso tem um custo de performance muito alto, os genericos evitam isso, pois mantem o tipo original, com a checagem
de tipo em tempo de compilação.

5(LINQ)
5.1() LINQ é uma forma que temos de fazer consultas em coleções(listas, arrays, banco de dados, XML) com a sintaxe parecida com SQL porem de forma na linguagem C#.
5.2(Execução adiada e imediata) 
