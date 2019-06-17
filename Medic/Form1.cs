﻿using System;
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
            if (Slezotochenie == true && Lomkost == true)
            {
                diagnosis = "Авитаминоз";
            }

            //Сброс показателей для Юнит тестов
            Kashel = false;
            Nasmork = false;
            Slezotochenie = false;
            Temperatura = 36.0;
            Lomkost = false;
            return diagnosis;
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
        }
    }
}
