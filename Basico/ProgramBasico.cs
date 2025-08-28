using System.Xml;

namespace Basico
{
    internal class ProgramBasico
    {
        static void Main(string[] args)
        {
            // CONVERSÃO IMPLICITA

            int inteiro = 100;
            long longo = inteiro;
            //Seguro

            long longMax = long.MaxValue;
            float flutuante = longMax;
            //Conversão pode ser imprecisa, long(64 Bits) float(32 Bits)

            double numeroDecimal = flutuante;
            //Seguro

            char letra = 'A';
            int codigoAscii = letra;
            Console.WriteLine(codigoAscii);
            //Output: 65 => Char pode ser convertido para int pois representam um valor na tabela ASCII

            
            //CONVERSÃO EXPLICITA

            double double1 = 3.14159;
            int doubleParaInt = (int)double1;
            //Output: 3 

            float numeroFloat = 12345.67f;
            long numeroLong = Convert.ToInt64(numeroFloat);
            //Output: 12345

            string textoValido = "123";
            int numero = int.Parse(textoValido);
            //Parse : Se o formato for correto retorna valor, se não, lança FormatException

            bool sucesso = int.TryParse(textoValido, out int n);
            //TryParse : Retorna true se a conversão der certo e coloca o valor convertido na variável out, e se for false, out recebe valor padrão do tipo


        }
    }
}
