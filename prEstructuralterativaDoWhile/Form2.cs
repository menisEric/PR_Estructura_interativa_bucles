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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresaar_Click(object sender, EventArgs e)
        {
            int stock;
            int cantPersonas, cantEntrega;

            stock = Convert.ToInt32(txtStockInicial.Text);
            cantPersonas = 0;

            while (stock >= 10)
            {
                cantEntrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cantidad entregada" + (cantPersonas+1), "Reparto de vacunas "));

                if (stock >= cantEntrega)
                {
                    cantPersonas += 1;
                    stock = stock - cantEntrega;
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock", "Reparto de vacunas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("El stock es inferior a 10", "Reparto de vacuna", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtStock.Text = Convert.ToString(stock);
            txtCantidadPersonas.Text = Convert.ToString(cantPersonas);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantidadPersonas.Clear();
            txtStock.Clear();
            txtStockInicial.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
