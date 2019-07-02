using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medic
{

    public partial class Form1 : Form
    {
        //Симптомы:
        public static bool Kashel=false;
        public static bool Nasmork=false;
        public static bool Slezotochenie = false;
        public static double Temperatura = 36.0;
        public static bool Lomkost = false;
        public static bool YellowSkin = false;
        public static bool Rvota = false;
        public static Patient patient = new Patient();


        public static string Diagnosis()
        {
            string diagnosis="Здоров";
            if (Kashel == true && Nasmork == true && Slezotochenie == true && Lomkost == true && Temperatura > 37.4)
            {
                diagnosis = "Такой болезни не существует. Присутствие одновремнно всех симптомов невозможно. Пройдите тест еще раз.";
                ToNull();
                return diagnosis;
            }
            if (Kashel == true && Nasmork == true && Temperatura > 37.4)
            {
                diagnosis = "Грипп";
                ToNull();
                return diagnosis;
            }
            if (Kashel==true && Nasmork == true)
            {
                diagnosis ="ОРВ";
                ToNull();
                return diagnosis;
            }
            if (Nasmork == true && Slezotochenie==true)
            {
                diagnosis = "Аллергия";
                ToNull();
                return diagnosis;
            }
            if (Nasmork == true && Slezotochenie)
            {
                diagnosis = "Аллергия";
                ToNull();
                return diagnosis;
            }
            if (Slezotochenie == true && Lomkost == true)
            {
                
                diagnosis = "Авитаминоз";
                ToNull();
                return diagnosis;
            }
            if (YellowSkin == true && Rvota == true && Temperatura > 37.4)
            {

                diagnosis = "Гепатит А. Срочно запишитесь на прием к врачу!";
                ToNull();
                return diagnosis;
            }

            //Сброс показателей для Юнит тестов
            ToNull();
            return diagnosis;
        }
        public static void ToNull()
        {
            Kashel = false;
            Nasmork = false;
            Slezotochenie = false;
            Temperatura = 36.0;
            Lomkost = false;
        }

        List<string> questions = new List<string>();
       

        public Form1()
        {
            InitializeComponent();
            questions.Add("У вас присутсвует сухой или мокрый кашель?");
            questions.Add("Наличие Насморка?");
            questions.Add("Слезотечение из глаз?");
            questions.Add("Температура тела выше нормы(37.4)?");
            questions.Add("Ломкость ноктей?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2(this);
            Hide();
            int i = 1;
            foreach (string line in questions)
            {
                string messageBoxText = line;
                string caption = "Вопрос №" + " " + i;
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(messageBoxText, caption, button);
                if (result == DialogResult.Yes && i==1)
                {
                    Kashel = true;
                }
                if (result == DialogResult.Yes && i == 2)
                {
                    Nasmork = true;
                }
                if (result == DialogResult.Yes && i == 3)
                {
                    Slezotochenie = true;
                }
                if (result == DialogResult.Yes && i == 4)
                {
                    Temperatura = 40.0;
                }
                if (result == DialogResult.Yes && i == 5)
                {
                    Lomkost = true;
                }
                i++;
            }
            MessageBox.Show("Диагноз: "+ Diagnosis());
            form2.Show();
            patient.Data_to_file();
        }
    }
}
