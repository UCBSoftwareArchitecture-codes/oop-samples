using NUnit.Framework;

namespace OOP.Sample1.Test
{
    public class PerroTests
    {
        private Perro perro;
        [SetUp]
        public void Setup()
        {
            perro = new Perro();
        }

        [Test]
        public void Test_EstadoDeAnimoTriste()
        {
            Assert.AreEqual("wow estoy...triste",perro.Ladrar());
        }
         [Test]
        public void Test_EstadoDeAnimoFelizDespuesDeComer()
        {
            perro.Comer();
            Assert.AreEqual("wow estoy...feliz",perro.Ladrar());
        }
    }
}