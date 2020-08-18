using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_multi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 4];
            notas[0 ,0] = 8.0;
            notas[0, 1] = 7.5;
            notas[0, 2] = 9.0;
            notas[0, 3] = 6.5;
            notas[1, 0] = 5.5;
            notas[1, 1] = 9.5;
            notas[1, 2] = 8.5;
            notas[1, 3] = 7.5;

            MessageBox.Show(notas[0, 1].ToString(), "Array");
        }
    }
}
