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
using Tarea8CrearRegistroConLogin.Entidades;

namespace Tarea8CrearRegistroConLogin.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuarios>();

            if (!string.IsNullOrEmpty(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = UsuariosBLL.GetList(e => e.UsuarioID == int.Parse(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = UsuariosBLL.GetList(e => e.NombreUsuario.Contains(CriterioTextBox.Text));
                        break;
                    case 2:
                        listado = UsuariosBLL.GetList(e => e.Email.Contains(CriterioTextBox.Text));
                        break;
                    case 3:
                        listado = UsuariosBLL.GetList(e => e.Rol.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = UsuariosBLL.GetList(c => true);
            }

            if (UsarFechaCheckBox.Checked == true)
            {
                listado = UsuariosBLL.GetList(e => e.FechaUsuario.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaUsuario.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            DatosDataGrid.DataSource = null;
            DatosDataGrid.DataSource = listado;
        }
    }
}
