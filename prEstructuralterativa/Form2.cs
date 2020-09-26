using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prEstructuralterativa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numAlumno;
            double nota, suma, notaBaja, promedio;
            if (txtNdeAlumno.Text != "") 
            {
                numAlumno = Convert.ToInt32(txtNdeAlumno.Text);
                suma = 0.0;
                notaBaja = 2.0;
                for(int i=1; i <= numAlumno; i++)
                {
                    nota = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno "+i, "Promedio Notas", "", 100, 100));
                    suma += nota;
                    if (nota < notaBaja)
                    {
                        notaBaja = nota;
                    }
                }
                promedio = suma / numAlumno;

                txtPromedio.Text = Convert.ToString(promedio);
                txtNBaja.Text = Convert.ToString(notaBaja);
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido", "Promedio Notas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNBaja.Clear();
            txtNdeAlumno.Clear();
            txtPromedio.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
