using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestMedic
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestORV()
        {
            Medic.Form1.Kashel = true;
            Medic.Form1.Nasmork = true;
            string diagnosis = Medic.Form1.Diagnosis();
            Assert.AreEqual("ОРВ", diagnosis);
        }
        [TestMethod]
        public void TestHealthy()
        {
            string diagnosis = Medic.Form1.Diagnosis();
            Assert.AreEqual("Здоров", diagnosis);
        }
        [TestMethod]
        public void TestAlergia()
        {
            Medic.Form1.Slezotochenie = true;
            Medic.Form1.Nasmork = true;
            string diagnosis = Medic.Form1.Diagnosis();
            Assert.AreEqual("Аллергия", diagnosis);
        }
        [TestMethod]
        public void TestGripp()
        {
            Medic.Form1.Kashel = true;
            Medic.Form1.Nasmork = true;
            Medic.Form1.Temperatura = 38.8;
            string diagnosis = Medic.Form1.Diagnosis();
            Assert.AreEqual("Грипп", diagnosis);
        }
        [TestMethod]
        public void TestAvitaminoz()
        {
            Medic.Form1.Slezotochenie = true;
            Medic.Form1.Lomkost = true;
            string diagnosis = Medic.Form1.Diagnosis();
            Assert.AreEqual("Авитаминоз", diagnosis);
        }
    }
}
