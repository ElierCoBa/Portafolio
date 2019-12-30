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
    public partial class FormularioParaReportes : Form
    {
        public static string elNumeroDeCarnet;
        public FormularioParaReportes(string elCarne)
        {
            InitializeComponent();
            elNumeroDeCarnet = elCarne;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDePermisosDeEstudio.Business.GestorDeOperaciones elGestorDeOperaciones = new Business.GestorDeOperaciones();
                elGestorDeOperaciones.InsertarReporte(txtReporte.Text, elNumeroDeCarnet);
                MessageBox.Show("Reporte realizado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
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

        private void tsmiAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese detalladamente cuál es el error o recomendación", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
