using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeSimon
{
    public partial class FormularioDeSimon : Form
    {
        private int ControlDeSecuencia;
        private int Tiempo;
        private int PuntosPorExitos;
        public int PuntoObtenidos;
        private int Indice;
        public List<int> ListaDePuntuaciones;
        private List<int> ListaDeSimon;
        private bool Hablando;
        private Random NumeroAleatoreo;
        private System.Diagnostics.Stopwatch Temporizador = new System.Diagnostics.Stopwatch();
        
        public FormularioDeSimon(List<int> laListaDePuntuaciones, int elIndice)
        {
            InitializeComponent();
            this.ControlDeSecuencia = 0;
            this.Tiempo = 700;
            this.PuntosPorExitos = 20;
            this.PuntoObtenidos = 0;
            this.Indice = elIndice;
            this.ListaDeSimon = new List<int>();
            this.NumeroAleatoreo = new Random();
            this.Hablando = false;
            this.ListaDePuntuaciones = laListaDePuntuaciones;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (lblCronometro.Text == "00:00:00") Temporizador.Start();
            ListaDeSimon.Add(NumeroAleatoreo.Next(0, 4));
            new Thread(IniciarJuego).Start();
        }

        public void IniciarJuego()
        {
            Thread.Sleep(Tiempo);
            Hablando = true;
            foreach (var ParteActiva in ListaDeSimon)
            {
                switch (ParteActiva)
                {
                    case 0:
                        pb_0.Image = Properties.Resources.a_on;
                        Thread.Sleep(300);
                        pb_0.Image = Properties.Resources.a;
                        break;
                    case 1:
                        pb_1.Image = Properties.Resources.b_on;
                        Thread.Sleep(300);
                        pb_1.Image = Properties.Resources.b;
                        break;
                    case 2:
                        pb_2.Image = Properties.Resources.c_on;
                        Thread.Sleep(300);
                        pb_2.Image = Properties.Resources.c;
                        break;
                    case 3:
                        pb_3.Image = Properties.Resources.d_on;
                        Thread.Sleep(300);
                        pb_3.Image = Properties.Resources.d;
                        break;
                }
            }
            Thread.Sleep(Tiempo);
            Hablando = false;
        }

        public void VerificarBotonPresionado(int elValor)
        {
            PuntoObtenidos = ListaDeSimon.Count * PuntosPorExitos;
            if (Hablando || ListaDeSimon.Count == 0) return;
            if (ListaDeSimon[ControlDeSecuencia] == elValor) ControlDeSecuencia++;
            else
            {
                Temporizador.Stop();
                ListaDePuntuaciones.Add(PuntoObtenidos);
                lblPuntos.Text = "Puntos obtenidos: " + PuntoObtenidos;
                DialogResult elResultado = MessageBox.Show("Tu record final es: " + PuntoObtenidos, "Has fallado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (elResultado == DialogResult.OK) Dispose();
                //if (elResultado == DialogResult.OK) this.DialogResult = DialogResult.OK;

            }
            if (ControlDeSecuencia >= ListaDeSimon.Count)
            {
                ControlDeSecuencia = 0;
                ListaDeSimon.Add(NumeroAleatoreo.Next(0, 4));
                Thread.Sleep(1000);
                new Thread(IniciarJuego).Start();
            }
            lblPuntos.Text = "Puntos obtenidos: " + PuntoObtenidos;
        }

        private void FormularioDeSimon_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void pb_0_Click(object sender, EventArgs e)
        {
            String Presionado = ((PictureBox)sender).Name;
            string[] NumeroBoton = Presionado.Split('_');
            VerificarBotonPresionado(Convert.ToInt32(NumeroBoton[1]));
        }

        public int ObtenerListaDePuntuaciones(int elIndice)
        {
            int elPuntaje = 0;
            return elPuntaje = ListaDePuntuaciones.ElementAt(elIndice);
        }

        private void ActualizarTiempoTranscurrido(object sender, EventArgs e)
        {
            if (Temporizador.Elapsed.ToString() != "00:00:00")
            {
                lblCronometro.Text = Temporizador.Elapsed.ToString().Remove(8);
            }
            if (Temporizador.Elapsed.Minutes.ToString() == "3")
            {
                Temporizador.Reset();
                lblCronometro.Text = "00:00:00";
                ListaDePuntuaciones.Add(PuntoObtenidos);
                DialogResult elResultado = MessageBox.Show("El tiempo ha concluido", "Has pérdido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (elResultado == DialogResult.OK) this.DialogResult = DialogResult.OK;
            }
        }
        private void pb_0_MouseDown(object sender, MouseEventArgs e)
        {
            pb_0.Image = Properties.Resources.a_on;
        }

        private void pb_0_MouseUp(object sender, MouseEventArgs e)
        {
            pb_0.Image = Properties.Resources.a;
        }

        private void pb_1_MouseDown(object sender, MouseEventArgs e)
        {
            pb_1.Image = Properties.Resources.b_on;
        }

        private void pb_1_MouseUp(object sender, MouseEventArgs e)
        {
            pb_1.Image = Properties.Resources.b;
        }

        private void pb_2_MouseDown(object sender, MouseEventArgs e)
        {
            pb_2.Image = Properties.Resources.c_on;
        }

        private void pb_2_MouseUp(object sender, MouseEventArgs e)
        {
            pb_2.Image = Properties.Resources.c;
        }

        private void pb_3_MouseDown(object sender, MouseEventArgs e)
        {
            pb_3.Image = Properties.Resources.d_on;
        }

        private void pb_3_MouseUp(object sender, MouseEventArgs e)
        {
            pb_3.Image = Properties.Resources.d;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
