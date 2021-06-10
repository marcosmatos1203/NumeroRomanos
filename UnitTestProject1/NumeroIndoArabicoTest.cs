using ConversorArabicosRomanos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class NumeroIndoArabicoTest
    {
        NumerosArabicosParaRomanos numeros;
        public NumeroIndoArabicoTest()
        {
            numeros = new NumerosArabicosParaRomanos();
        }

        [TestMethod]
        public void DeveRetornar_I()
        {
            Assert.AreEqual("I", numeros.Converter(1));
        }
        [TestMethod]
        public void DeveRetornar_V()
        {
            Assert.AreEqual("V", numeros.Converter(5));
        }
        [TestMethod]
        public void DeveRetornar_IV()
        {
            Assert.AreEqual("IV", numeros.Converter(4));
        }
        [TestMethod]
        public void DeveRetornar_VI()
        {
            Assert.AreEqual("VI", numeros.Converter(6));
        }
        [TestMethod]
        public void DeveRetornar_X()
        {
            Assert.AreEqual("X", numeros.Converter(10));
        }
        [TestMethod]
        public void DeveRetornar_XV()
        {
            Assert.AreEqual("XV", numeros.Converter(15));
        }
        [TestMethod]
        public void DeveRetornar_L()
        {
            Assert.AreEqual("L", numeros.Converter(50));
        }
        [TestMethod]
        public void DeveRetornar_C()
        {
            Assert.AreEqual("C", numeros.Converter(100));
        }
        [TestMethod]
        public void DeveRetornar_M()
        {
            Assert.AreEqual("M", numeros.Converter(1000));
        }
        [TestMethod]
        public void DeveRetornar_MM()
        {
            Assert.AreEqual("MM", numeros.Converter(2000));
        }
        [TestMethod]
        public void DeveRetornar_iv()
        {
            Assert.AreEqual("ĪV̄", numeros.Converter(4000));
        }
    }
}
