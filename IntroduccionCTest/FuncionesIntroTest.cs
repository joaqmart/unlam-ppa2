using IntroduccionCSharpPPA2;
using NUnit.Framework;

namespace IntroduccionCTest
{
    public class FuncionesIntroTest
    {
        private FuncionesIntro claseTest = null;
        
        [SetUp]
        public void Setup()
        {
            claseTest = new FuncionesIntro();
        }

        [Test]
        public void TestSumaDosNumerosHappyPath()
        {
            string a = "3";
            string b = "4";
            long resultadoEsperado = 7;
            
            long resultadoObtenido=claseTest.SumaDosNumeros(a,b);

            Assert.AreEqual(resultadoObtenido,resultadoEsperado);
        }
        [Test]
        public void TestSumaDosNumerosError()
        {
            string a = "a";
            string b = "4";
            long resultadoEsperado = 4;
            
            long resultadoObtenido = claseTest.SumaDosNumeros(a, b);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
        [Test]
        public void TestSumaDosNumerosErrorAmbosNumeros()
        {
            string a = "a";
            string b = "b";
            long resultadoEsperado = 0;
            
            long resultadoObtenido = claseTest.SumaDosNumeros(a, b);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }

        public void TestCadenaOchoHappyPath()
        {
            string a = "puntapie";
            string resultadoEsperado = "punt";
            
            string resultadoObtenido = claseTest.CadenaOcho(a);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
        [Test]
        public void TestCadenaOchoCadenaInferior()
        {
            string a = "punta";
            string resultadoEsperado = "punta";

            string resultadoObtenido = claseTest.CadenaOcho(a);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
        [Test]
        public void TestCadenaOchoCadenaSuperior()
        {
            string a = "puntapies";
            string resultadoEsperado = "puntapies";

            string resultadoObtenido = claseTest.CadenaOcho(a);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
        [Test]
        public void TestCadenaOchoCadenaVacia()
        {
            string a = "";
            string resultadoEsperado = "";

            string resultadoObtenido = claseTest.CadenaOcho(a);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
        [Test]
        public void TestCadenaOchoCadenaNula()
        {
            string a = null;
            string resultadoEsperado = null;

            string resultadoObtenido = claseTest.CadenaOcho(a);

            Assert.AreEqual(resultadoObtenido, resultadoEsperado);
        }
        
    }
}