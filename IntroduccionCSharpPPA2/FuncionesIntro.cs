using System;
using System.Collections.Generic;
using System.Text;

namespace IntroduccionCSharpPPA2
{
    public class FuncionesIntro
    {
        enum DiasSemana { Domingo=1, Lunes=2, Martes=3, Miércoles=4, Jueves=5, Viernes=6, Sábado=7 };

        public enum Colores { Blanco, Azul, Negro };
        public Int64 SumaDosNumeros(int valor1,int valor2)
        {
            Console.WriteLine("la suma de los numeros valor1:{0} y valor2:{1} es {2}",valor1 ,valor2,(valor1 + valor2));
            return valor1 + valor2;
        }

        public string CadenaOcho(string valor1)
        {
            return valor1!=null?valor1.Length==8?valor1.Substring(0, 4): valor1:null;
        }
        public DateTime FechaHoraActual()
        {
            return DateTime.Now;
        }
        public void LeeDiasSemana()
        {
            Console.WriteLine(DiasSemana.Domingo); //Domingo
            Console.WriteLine(DiasSemana.Lunes); // Lunes
            Console.WriteLine(DiasSemana.Martes); // Martes
            Console.WriteLine(DiasSemana.Miércoles); // Miercoles
            Console.WriteLine(DiasSemana.Jueves); // Jueves
            Console.WriteLine(DiasSemana.Viernes); // Viernes
            Console.WriteLine(DiasSemana.Sábado); // Sabado
        }
        public void ConversionBoolean()
        {
            Console.WriteLine("Método Convert");
            Console.WriteLine(Convert.ToBoolean(true));
            Console.WriteLine(Convert.ToBoolean(false));
            Console.WriteLine(Convert.ToBoolean(1));
            Console.WriteLine(Convert.ToBoolean(0));
            Console.WriteLine("Método BoolParse");
            Console.WriteLine(Boolean.Parse("true"));
            Console.WriteLine(Boolean.Parse("false"));
            /* no se aceptan 0 o 1 solo true or false
            Console.WriteLine(Boolean.Parse("1"));
            Console.WriteLine(Boolean.Parse('0'));
             */
            Console.WriteLine("Método BoolTryParse");
            bool result;
            Console.WriteLine(Boolean.TryParse("true", out result));
            Console.WriteLine(Boolean.TryParse("false", out result));
            Console.WriteLine(Boolean.TryParse("1", out result));
            Console.WriteLine(Boolean.TryParse("0",out result));
        }
        public void ConversionesEnteras()
        {
            int a = (int)344.4;
            Console.WriteLine("Se convierte{0} a entero y resulta{1} ",344.4,a);
            decimal b = 10;
            Console.WriteLine("Se convierte{0} a decimal y resulta{1} ", 10, b);
            int c = 443444;
            short d = (short)c;
            Console.WriteLine("Se convierte{0} a short y resulta{1} ", c, d);
        }

        public void InformaColores(Colores misColores)
        {
            //Colores misColores = Colores.Azul;
            switch (misColores)
            {
                case Colores.Blanco:
                    Console.WriteLine("Soy el color Blanco");
                    break;
                case Colores.Azul:
                    Console.WriteLine("Soy el color Azul");
                    break;
                case Colores.Negro:
                    Console.WriteLine("Soy el color Negro");
                    break;
                default:
                    Console.WriteLine("Yo no soy un color");
                    break;
            }
        }
        public void MayorADiez(int valor)
        {
            if (valor>10)
            {
                Console.WriteLine("El valor ingresado {0} es Mayor a 10",valor);
            }
            else
            {
                Console.WriteLine("El valor ingresado {0} no es Mayor a 10", valor);
            }
        }
        public void ExcedeCincuenta()
        {
            int valorAIncrementar = 0;
            while (valorAIncrementar<=50)
            {
                valorAIncrementar += 5;
                Console.WriteLine("Valor Actual: {0}",valorAIncrementar);
            }
            Console.WriteLine("El valor superó el número 50");
        }
    }

}
