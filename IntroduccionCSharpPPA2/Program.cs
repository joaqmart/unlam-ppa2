using System;

namespace IntroduccionCSharpPPA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncionesIntro funcIntro = new FuncionesIntro();
            /*Console.WriteLine("Ingrese un valor numérico: ");
            String valor1 = Console.ReadLine();
            Console.WriteLine("Ingrese un valor numérico: ");
            String valor2 = Console.ReadLine();
            
            funcIntro.SumaDosNumeros(valor1,valor2);
            
            Console.WriteLine("Ingrese una palabra de 8 carácteres: ");
            String palabra = Console.ReadLine();
            funcIntro.CadenaOcho(ref palabra);
            Console.WriteLine("la palabra quedó de esta manera: {0}",palabra);
            */
            
            funcIntro.FechaHoraActual();
            //4 - este es un comentario de linea
            /*5 - Este es un comentario de bloque*/
            //funcIntro.LeeDiasSemana();
            //funcIntro.ConversionBoolean();
            /*funcIntro.ConversionesEnteras();

            funcIntro.InformaColores(FuncionesIntro.Colores.Blanco);
            funcIntro.InformaColores(FuncionesIntro.Colores.Azul);
            funcIntro.InformaColores(FuncionesIntro.Colores.Negro);
            */
            funcIntro.MayorADiez(7);
            funcIntro.MayorADiez(11);
            /*
                La principal diferencia, en la mayoría de los lenguajes, es que un for itera 
                sobre cosas que no tienen porqué existir, y nos garantiza el orden de acceso; 
                por su parte, un for-each itera sobre cosas que, obligatoriamente, han de existir. 
                Además, no nos garantiza el orden en el que se accede
                Fuente: https://es.stackoverflow.com/questions/102524/diferencia-entre-for-y-for-each#:~:text=La%20principal%20diferencia%2C%20en%20la,en%20el%20que%20se%20accede.

             */
            funcIntro.ExcedeCincuenta();
        }
    }
}
