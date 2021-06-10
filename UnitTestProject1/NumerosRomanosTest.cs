using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroRomanos;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class NumerosRomanosTest
    {
        ConversorRomanosArabicos numeros;
        public NumerosRomanosTest ()
        {
            numeros = new ConversorRomanosArabicos();
        }
        [TestMethod]
        public void DeveRetornar_1()
        {
            Assert.AreEqual(1, numeros.Converter("I"));
        }
        [TestMethod]
        public void DeveRetornar_5()
        {
            Assert.AreEqual(5, numeros.Converter("V"));
        }
        [TestMethod]
        public void DeveRetornar_4()
        {
            Assert.AreEqual(4, numeros.Converter("IV"));
        }
        [TestMethod]
        public void DeveRetornar_6()
        {
            Assert.AreEqual(6, numeros.Converter("VI"));
        }
        [TestMethod]
        public void DeveRetornar_10()
        {
            Assert.AreEqual(10, numeros.Converter("X"));
        }
        [TestMethod]
        public void DeveRetornar_15()
        {
            Assert.AreEqual(15, numeros.Converter("XV"));
        }
        [TestMethod]
        public void DeveRetornar_50()
        {
            Assert.AreEqual(50, numeros.Converter("L"));
        }
        [TestMethod]
        public void DeveRetornar_100()
        {
            Assert.AreEqual(100, numeros.Converter("C"));
        }
    }
}
