using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prEstructuralterativaDoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cantAlumnos, nota;
            Double promedio = 0;

            cantAlumnos = Convert.ToInt32(txtCAlumnos.Text);

            for(int i=1; i<=cantAlumnos; i++)
            {
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno " + i, "Registro Notas"));
                } while (nota < 0 || nota > 20);
                promedio += nota;
            }
            txtPromedio.Text = Convert.ToString(promedio / cantAlumnos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            txtCAlumnos.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
