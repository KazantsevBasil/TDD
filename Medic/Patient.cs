using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medic
{
    public class Patient
    {
        public string fio;
        public string diagnosis;


        public Patient()
        {
            fio = null;
            diagnosis = null;
        }

        public void Set_Fio(string Fio)
        {
            fio = Fio;
        }

        public void Set_Diagnosis(string Diagnosis)
        {
            diagnosis = Diagnosis;
        }

        public string Get_Name()
        {
            return fio;
        }

        public string Get_Diagnosis()
        {
            return diagnosis;
        }
        public void Data_to_file()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory +"\\"+ fio + ".txt";
            string text = "ФИО: " + fio + "\n" + "Диагноз: " + diagnosis;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, text);
        }
    }
    
}
