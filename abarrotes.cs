using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaAbarrotes
{
    public partial class abarrotes : Form
    {
        public abarrotes()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //obteniendo el nombre del producto
            string name = txtname.Text;

            //obteniendo cantidad a vender del producto
            int cantidad = int.Parse(txtquantity.Text);

            //obteniendo precio unitario del producto
            double precio = double.Parse(txtprice.Text);

            //calculando precio general
            double general = precio * cantidad;

            //mostrando los resultados
            lstv.Items.Add("**Abarrotes S.A**");
            lstv.Items.Add("Nombre del producto: " + name);
            lstv.Items.Add("Cantidad: " + cantidad);
            lstv.Items.Add("Precio Unitario: " + precio.ToString("0.00"));
            lstv.Items.Add("ToTal: " + general.ToString("0.00"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtquantity.Clear();
            txtprice.Clear();
            lstv.Items.Clear();
            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Esta seguro que desea cerrar?", "Abarrotes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (q == DialogResult.Yes)
                this.Close();
        }
    }
}
