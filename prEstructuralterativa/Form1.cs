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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;
            double suma, resta, division, multiplicacion;

            numero = Convert.ToInt32(txtnumero.Text);

            cboDivision.Items.Clear();
            cboMultiplicacion.Items.Clear();
            cboResta.Items.Clear();
            cboSuma.Items.Clear();

            for(int i=1; i<=12; i++)
            {
                suma = numero + i;
                resta = numero - i;
                multiplicacion = numero * i;
                division = numero / i;

                cboSuma.Items.Add(numero + " + " + i + " = " + suma);
                cboResta.Items.Add(numero + " - " + i + " = " + resta);
                cboMultiplicacion.Items.Add(numero + " * " + i + " = " + multiplicacion);
                cboDivision.Items.Add(numero + " / " + i + " = " + division);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cboDivision.Items.Clear();
            cboMultiplicacion.Items.Clear();
            cboResta.Items.Clear();
            cboSuma.Items.Clear();
            txtnumero.Clear();
        }
    }
}
