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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void lblEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.UI.FormularioParaLoginDeEstudiante elFormularioDeEstudiante = new FormularioParaLoginDeEstudiante();
                elFormularioDeEstudiante.Show();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.UI.FormularioParaLoginDeAdministrador elFormularioDeAdministrador = new FormularioParaLoginDeAdministrador();
                elFormularioDeAdministrador.Show();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            DialogResult elResultado = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (elResultado == DialogResult.OK)
            {
                Dispose();
            }
        }

        private void tsmiAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione uno de los dos tipos de usuarios\n" +
                "según sea el caso","Ayuda",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmsiAcercaDe_Click(object sender, EventArgs e)
        {
            GestorDePermisosDeEstudio.UI.FormularioDeInformacion elFormularioDeInformacion = new FormularioDeInformacion();
            elFormularioDeInformacion.ShowDialog();

        }
    }
}
