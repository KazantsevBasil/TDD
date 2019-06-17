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
            bool kashel = true;
            bool nasmork = true;
            string diagnosis = Medic.Form1.Diagnosis(kashel, nasmork);
            Assert.AreEqual("ОРВ", diagnosis);
        }
    }
}
