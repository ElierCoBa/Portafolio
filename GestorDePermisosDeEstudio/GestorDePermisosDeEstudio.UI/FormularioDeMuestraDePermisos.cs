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
    public partial class FormularioDeMuestraDePermisos : Form
    {
        public static string elUsuarioLogueado = "";
        public FormularioDeMuestraDePermisos(string elUsuario)
        {
            InitializeComponent();
            CargarPermisos();
            elUsuarioLogueado = elUsuario;
        }


        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.UI.FormularioParaInsertarResidente elFormularioParaInsertarResidente = new FormularioParaInsertarResidente();
                elFormularioParaInsertarResidente.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.UI.FormularioParaMostrarReportes elFormularioParaMostrarReportes = new FormularioParaMostrarReportes();
                elFormularioParaMostrarReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPermisosDelDia_Click(object sender, EventArgs e)
        {
            try
            {
                CargarPermisosDelDia();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                CargarPermisos();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarPermisos()
        {
            try
            {
                GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                dgvListaDePermisos.DataSource = elGestorDeOperaciones.MostrarPermisos();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarPermisosDelDia()
        {
        
                GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                dgvListaDePermisos.DataSource = elGestorDeOperaciones.MostrarPermisosDelDia();
         
        }

        private void tsmiAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se le presenta la lista de permisos con su respectivo\n" +
                "estudiante de residencias y sus acompañantes, para\n" +
                "ver los permisos del día, favor seleccione el " +
                "respectivo botón, mismo caso para mostrar todos los permisos\n\n" +
                "En cuanto a reportes se mostrarán reportes acerca del " +
                "funcionamiento de la aplicación, no son reportes para estudiantes\n\n" +
                "Finalmente el botón estudiantes lleva al módulo donde " +
                "se muestran todos los estudiantes pertenecientes al " +
                "programa de residencias de la sede ", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void reportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.UI.FormularioParaReportes elFormularioDeReportes = new FormularioParaReportes(elUsuarioLogueado);
                elFormularioDeReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
