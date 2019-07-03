using System;
using System.IO;
using Medic;
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
        [TestMethod]
        public void TestError()
        {
            Medic.Form1.Kashel = true;
            Medic.Form1.Nasmork = true;
            Medic.Form1.Slezotochenie = true;
            Medic.Form1.Temperatura = 40.0;
            Medic.Form1.Lomkost = true;
            string diagnosis = Medic.Form1.Diagnosis();
            Assert.AreEqual("Такой болезни не существует. Присутствие одновремнно всех симптомов невозможно. Пройдите тест еще раз.", diagnosis);

        }
        [TestMethod]
        public void CreateFileToSave()
        {
       
            Form1.patient.Set_Fio("Валентин");
            Form1.patient.Data_to_file();
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\" + Form1.patient.fio + ".txt";
            Assert.IsTrue(File.Exists(path));
        }
        [TestMethod]
        public void WriteDataToFile()
        {
            Form1.Slezotochenie = true;
            Form1.Lomkost = true;
            string diagnosis = Form1.Diagnosis();
            Form1.patient.Set_Fio("Валентин");
            Form1.patient.Set_Diagnosis(diagnosis);
            Form1.patient.Data_to_file();
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\" + Form1.patient.fio + ".txt";
            string Content = File.ReadAllText(path);
            string text = "ФИО: Валентин" + "\n" + "Диагноз: Авитаминоз";
            Assert.AreEqual(Content, text);
        }
        [TestMethod]
        public void WriteDateExamination()
        {
            Form1.Slezotochenie = true;
            Form1.Lomkost = true;
            string diagnosis = Form1.Diagnosis();
            Form1.patient.Set_Fio("Валентин");
            Form1.patient.Set_Diagnosis(diagnosis);
            string date = DateTime.Now.ToString("dd.MM.yyyy");
            Form1.patient.Data_to_file();
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\" + Form1.patient.fio + ".txt";
            string Content = File.ReadAllText(path);
            string text = "ФИО: Валентин" + "\n" + "Диагноз: Авитаминоз" + "\n" + date;
            Assert.AreEqual(Content, text);
        }
        [TestMethod]
        public void TestGepatitA()
        {
            Medic.Form1.YellowSkin = true;
            Medic.Form1.Temperatura = 38.8;
            Medic.Form1.Rvota = true;
            string diagnosis = Medic.Form1.Diagnosis();
            Assert.AreEqual("Гепатит А. Срочно запишитесь на прием к врачу!", diagnosis);
        }
        [TestMethod]
        public void TestSitovidnaya()
        {
            Form1.TremorRuk = true;
            Form1.RezkoePohudenie = true;
            string diagnosis = Form1.Diagnosis();
            Assert.AreEqual("У вас проблемы с щитовидной железой. Рекомендуется пройти обследование в больнице!", diagnosis);
        }
        [TestMethod]
        public void TestRotaVirus()
        {
            Form1.Rvota = true;
            Form1.Temperatura = 38.8;
            Form1.Nasmork = true;
            string diagnosis = Form1.Diagnosis();
            Assert.AreEqual("Ротавирусная инфекция. Соблюдайте санитарные нормы, чтобы не заразить окружающих!", diagnosis);
        }
    }
}
