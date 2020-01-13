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
    public partial class FormularioParaSolicitarPermisosDeDos : Form
    {
        public FormularioParaSolicitarPermisosDeDos(string elCarne)
        {
            InitializeComponent();
            txtCarne.Text = elCarne.ToUpper();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();

                if (!string.IsNullOrEmpty(txtCarnePrimerEstudiante.Text) && !string.IsNullOrEmpty(txtApellido1PrimerEstudiante.Text) && !string.IsNullOrEmpty(txtApellido2PrimerEstudiante.Text)
                    && !string.IsNullOrEmpty(txtNombre1PrimerEstudiante.Text) && !string.IsNullOrEmpty(txtCarneSegundoEstudiante.Text) && !string.IsNullOrEmpty(txtApellido1SegundoEstudiante.Text) && !string.IsNullOrEmpty(txtApellido2SegundoEstudiante.Text)
                    && !string.IsNullOrEmpty(txtNombre1SegundoEstudiante.Text))
                {

                    if (elGestorDeOperaciones.EncontrarEstudianteExterno(txtCarnePrimerEstudiante.Text) == false)
                    {
                        elGestorDeOperaciones.InsertarEstudiante(txtCarnePrimerEstudiante.Text, txtApellido1PrimerEstudiante.Text, txtApellido2PrimerEstudiante.Text, txtNombre1PrimerEstudiante.Text, txtNombre2PrimerEstudiante.Text);
                    }
                    if (elGestorDeOperaciones.EncontrarEstudianteExterno(txtCarneSegundoEstudiante.Text) == false)
                    {
                        elGestorDeOperaciones.InsertarEstudiante(txtCarneSegundoEstudiante.Text, txtApellido1SegundoEstudiante.Text, txtApellido2SegundoEstudiante.Text, txtNombre1SegundoEstudiante.Text, txtNombre2SegundoEstudiante.Text);
                    }

                    elGestorDeOperaciones.InsertarPermiso(txtCarne.Text, txtCarnePrimerEstudiante.Text, DateTime.Parse(dtpFecha.Text), DateTime.Parse(dtpHoraDeIngreso.Text), DateTime.Parse(dtpHoraDeSalida.Text));
                    elGestorDeOperaciones.InsertarPermiso(txtCarne.Text, txtCarneSegundoEstudiante.Text, DateTime.Parse(dtpFecha.Text), DateTime.Parse(dtpHoraDeIngreso.Text), DateTime.Parse(dtpHoraDeSalida.Text));
                    MessageBox.Show("Permiso solicitado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Por favor ingrese los datos que se le solicitan", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult elResultado = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (elResultado == DialogResult.OK)
            {
                Dispose();
            }
        }

        private void tsmiReportar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.UI.FormularioParaReportes elFormularioDeReportes = new FormularioParaReportes(txtCarne.Text);
                elFormularioDeReportes.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese todos los datos solicitados", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
