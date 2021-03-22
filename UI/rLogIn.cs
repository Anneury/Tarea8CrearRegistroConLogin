using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea8CrearRegistroConLogin.BLL;

namespace Tarea8CrearRegistroConLogin.UI
{
    public partial class rLogIn : Form
    {
        public rLogIn()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            bool paso = UsuariosBLL.Autenticar(NombreUsuarioTextBox.Text, ContraseñaTextBox.Text);

            if (NombreUsuarioTextBox.Text == string.Empty)
            {
                MessageBox.Show("El Campo (Nombre Usuario) está vacío.\n\nPor favor, escriba su nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NombreUsuarioTextBox.Clear();
                NombreUsuarioTextBox.Focus();
                return;
            }

            if (paso)
            {
                this.Hide();
                MainForm obj = new MainForm();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Nombre de Usuario o Contraseña incorrectos.", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContraseñaTextBox.Clear();
                NombreUsuarioTextBox.Focus();
            }
        }
    }
}
