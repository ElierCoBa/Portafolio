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
    public partial class FormularioParaInsertarResidente : Form
    {
        public FormularioParaInsertarResidente()
        {
            InitializeComponent();
            CargarResidentes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtCarne.Text) || string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtSegundoApellido.Text) ||
                 string.IsNullOrEmpty(txtPrimerNombre.Text) || string.IsNullOrEmpty(txtCuarto.Text) || string.IsNullOrEmpty(cbPabellon.Text))
                {
                    MessageBox.Show("Ingrese los datos que se le solicitan", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                    elGestorDeOperaciones.InsertarResidente(txtCarne.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtPrimerNombre.Text, txtSegundoNombre.Text);
                    elGestorDeOperaciones.InsertarCuarto(cbPabellon.Text, txtCuarto.Text, txtCarne.Text);
                    CargarResidentes();
                    LimpiarCamposDeTexto();
                }
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

        private void dgvLaListaDeResidentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCarne.Text = dgvLaListaDeResidentes.CurrentRow.Cells[0].Value.ToString();
                txtPrimerApellido.Text = dgvLaListaDeResidentes.CurrentRow.Cells[1].Value.ToString();
                txtSegundoApellido.Text = dgvLaListaDeResidentes.CurrentRow.Cells[2].Value.ToString();
                txtPrimerNombre.Text = dgvLaListaDeResidentes.CurrentRow.Cells[3].Value.ToString();
                txtSegundoNombre.Text = dgvLaListaDeResidentes.CurrentRow.Cells[4].Value.ToString();
                cbPabellon.Text = dgvLaListaDeResidentes.CurrentRow.Cells[5].Value.ToString();
                txtCuarto.Text = dgvLaListaDeResidentes.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposDeTexto();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (txtCuarto.Enabled.Equals(false))
            {
                txtCarne.Enabled = true;
                txtPrimerApellido.Enabled = true;
                txtSegundoApellido.Enabled = true;
                txtPrimerNombre.Enabled = true;
                txtSegundoNombre.Enabled = true;
                txtCuarto.Enabled = true;
                cbPabellon.Enabled = true;
            }
            else
            {
                txtCarne.Enabled = false;
                txtPrimerApellido.Enabled = false;
                txtSegundoApellido.Enabled = false;
                txtPrimerNombre.Enabled = false;
                txtSegundoNombre.Enabled = false;
                txtCuarto.Enabled = false;
                cbPabellon.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCarne.Text) || string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtSegundoApellido.Text) ||
                 string.IsNullOrEmpty(txtPrimerNombre.Text) || string.IsNullOrEmpty(txtSegundoNombre.Text) || string.IsNullOrEmpty(txtCuarto.Text) || string.IsNullOrEmpty(cbPabellon.Text))
                {
                    MessageBox.Show("Ingrese los datos que se le solicitan", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                    elGestorDeOperaciones.ActualizarResidente(txtCarne.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtPrimerNombre.Text, txtSegundoNombre.Text);
                    elGestorDeOperaciones.ActualizarCuarto(cbPabellon.Text, txtCuarto.Text, txtCarne.Text);
                    CargarResidentes();
                    LimpiarCamposDeTexto();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
   
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int elIdPermiso = 0;
                int laCantidadDePermisos = 0;
                DialogResult elResultado = MessageBox.Show("¿Desea eliminar al residente?", "Eliminar residente", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (elResultado == DialogResult.OK)
                {
                    GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();

                    laCantidadDePermisos = elGestorDeOperaciones.EncontrarPermisos(txtCarne.Text);

                    for (int i = 0; i < laCantidadDePermisos; i++)
                    {
                        elIdPermiso = elGestorDeOperaciones.EncontrarIdAEliminar(txtCarne.Text);
                        elGestorDeOperaciones.EliminarEstados(elIdPermiso);
                        elGestorDeOperaciones.EliminarPermisos(elIdPermiso);
                    }
                    elGestorDeOperaciones.EliminarCuarto(txtCarne.Text);
                    elGestorDeOperaciones.EliminarResidente(txtCarne.Text);
                    CargarResidentes();
                    LimpiarCamposDeTexto();
                }
            
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void CargarResidentes()
        {
            GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
            dgvLaListaDeResidentes.DataSource = elGestorDeOperaciones.MostrarResidentes();
        }
        public void LimpiarCamposDeTexto()
        {
            txtCarne.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtCuarto.Text = "";
            cbPabellon.Text = "";
        }
    }
}
