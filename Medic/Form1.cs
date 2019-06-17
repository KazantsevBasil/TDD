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
        public static string Diagnosis(bool kashel, bool nasmork)
        {
            string diagnosis="Здоров";
            if (kashel==true || nasmork == true)
            {
                diagnosis ="ОРВ";
            }
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
