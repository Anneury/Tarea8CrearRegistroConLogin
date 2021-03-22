using Tarea8CrearRegistroConLogin.BLL;
using Tarea8CrearRegistroConLogin.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea8CrearRegistroConLogin.UI.Consultas
{
    public partial class cRoles : Form
    {
        public cRoles()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Roles>();

            if (!string.IsNullOrEmpty(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = RolesBLL.GetList(e => e.RolID == int.Parse(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = RolesBLL.GetList(e => e.DescripcionRol.Contains(CriterioTextBox.Text));
                        break;

                }
            }
            else
            {
                listado = RolesBLL.GetList(c => true);
            }

            if (UsarFechaCheckBox.Checked == true)
            {
                listado = RolesBLL.GetList(e => e.FechaCreacion.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaCreacion.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = RolesBLL.GetList(e => e.esActivo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = RolesBLL.GetList(e => e.esActivo == false);
            }

            DatosDataGrid.DataSource = null;
            DatosDataGrid.DataSource = listado;
        }
    }
}
