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
    public partial class FormularioParaLoginDeAdministrador : Form
    {
        public FormularioParaLoginDeAdministrador()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult elResultado = MessageBox.Show("¿Desea cancelar?", "Cancelar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (elResultado == DialogResult.OK)
            {
                Dispose();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show("Ingrese los datos que se le solicitan", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                    if (elGestorDeOperaciones.EncontrarUsuario(txtUsuario.Text, txtClave.Text) == true)
                    {
                        GestorDePermisosDeEstudio.UI.FormularioDeMuestraDePermisos elFormularioDeMuestraDePermisos = new FormularioDeMuestraDePermisos(txtUsuario.Text);
                        this.Dispose();
                        elFormularioDeMuestraDePermisos.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Se ha presentado un error de autenticación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
