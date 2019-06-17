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


        public static string Diagnosis()
        {
            string diagnosis="Здоров";
            if (Kashel==true || Nasmork == true)
            {
                diagnosis ="ОРВ";
            }
            if (Nasmork == true && Slezotochenie)
            {
                diagnosis = "Аллергия";
            }
            if (Nasmork == true && Slezotochenie)
            {
                diagnosis = "Аллергия";
            }
            if (Kashel == true && Nasmork == true && Temperatura>37.4)
            {
                diagnosis = "Грипп";
            }
            //Сброс показателей для Юнит тестов
            Kashel = false;
            Nasmork = false;
            Slezotochenie = false;
            Temperatura = 36.0;
            return diagnosis;
        }

        List<string> questions = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
