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
            int a = 3;
            int b = 4;
            int resultadoEsperado = 7;
            
            long resultadoObtenido=claseTest.SumaDosNumeros(a,b);

            Assert.AreEqual(resultadoObtenido,resultadoEsperado);
        }
        [Test]
        public void TestSumaDosNumerosError()
        {
            int a = 3;
            int b = 4;
            int resultadoEsperado = 4;
            
            long resultadoObtenido = claseTest.SumaDosNumeros(a, b);

            Assert.AreNotEqual(resultadoObtenido, resultadoEsperado);
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