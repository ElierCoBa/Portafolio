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
    public partial class FormularioParaLoginDeEstudiante : Form
    {
        public FormularioParaLoginDeEstudiante()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                if (elGestorDeOperaciones.EncontrarEstudiante(txtCarne.Text) == true)
                {
                    if (rbUnaPersona.Checked)
                    {
                        GestorDePermisosDeEstudio.UI.FormularioParaSolicitarPermisoDeUno elFormularioDePermisos = new FormularioParaSolicitarPermisoDeUno(txtCarne.Text);
                        this.Dispose();
                        elFormularioDePermisos.ShowDialog();
                      
                    }
                    else if (rbDosPersonas.Checked)
                    {
                        GestorDePermisosDeEstudio.UI.FormularioParaSolicitarPermisosDeDos elFormularioDePermisos = new FormularioParaSolicitarPermisosDeDos(txtCarne.Text);
                        this.Dispose();
                        elFormularioDePermisos.ShowDialog();
                    }
                    else if (rbTresPersonas.Checked)
                    {
                        GestorDePermisosDeEstudio.UI.FormularioParaSolicitarPermisosDeTres elFormularioDePermisos = new FormularioParaSolicitarPermisosDeTres(txtCarne.Text);
                        this.Dispose();
                        elFormularioDePermisos.ShowDialog();
                    }
                    else if (rbCuatroPersonas.Checked)
                    {
                        GestorDePermisosDeEstudio.UI.FormularioParaSolicitarPermisoDeCuatro elFormularioDePermisos = new FormularioParaSolicitarPermisoDeCuatro(txtCarne.Text);
                        this.Dispose();
                        elFormularioDePermisos.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione la cantidad de personas", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
                else
                {
                    MessageBox.Show("Se ha presentado un error de autenticación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
