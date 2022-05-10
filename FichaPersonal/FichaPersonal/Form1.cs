using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text == "") || (txtDireccion.Text == "") || (cbCiudad.Text == ""))
            {
                MessageBox.Show("Ha de rellenar el formulario.");
            }
            else
            {
                MessageBox.Show("Los datos se han rellenado correctamente.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = null;
            txtDireccion.Text = null;
            cbCiudad.Text = null;
            pbFoto.Image = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (opfFoto.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(opfFoto.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = System.Drawing.Color.Red;
            }
            else {
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
                if (e.KeyChar == (char)13)
                {
                    txtDireccion.Focus();
                }
               
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
