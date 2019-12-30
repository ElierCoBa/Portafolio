using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDePermisosDeEstudio.UI
{
    public partial class FormularioParaMostrarReportes : Form
    {
        public FormularioParaMostrarReportes()
        {
            InitializeComponent();
            CargarReportes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void CargarReportes()
        {
            try
            {
                GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                dgvReportes.DataSource = elGestorDeOperaciones.MostrarReportes();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
