using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeReciclaje
{
    public partial class FormularioDeReciclaje : Form
    {
        private int ContadorPlastico;
        private int ContadorOrganicos;
        private int ContadorVidrio;
        private int ContadorPapel;
        private int ContadorOrdinarios;
        private int ContadorEspeciales;
        private int ContadorBioinfecciosos;
        private int ContadorAluminio;
        private bool Presionar;
        private Point PuntoInicial;

        public FormularioDeReciclaje()
        {
            InitializeComponent();

            this.ContadorOrganicos = 0;
            this.ContadorPapel = 0;
            this.ContadorVidrio = 0;
            this.ContadorAluminio = 0;
            this.ContadorBioinfecciosos = 0;
            this.ContadorEspeciales = 0;
            this.ContadorOrdinarios = 0;
            this.ContadorPlastico = 0;
            this.Presionar = false;

            //primero le quita el tipo control, se determina que solo se van a mover si son botones y se convierte en una lista para aplicar el ForEach
            this.Controls.OfType<Control>().Where(elControl => elControl is Button).ToList().ForEach(elControl =>
            {
                elControl.MouseDown += PresionarElBoton;
                elControl.MouseUp += SoltarElBoton;
                elControl.MouseMove += MoverElBoton;

            });

        }


        private void MoverElBoton(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;
            if (Presionar)
            {
                //se asigna la posición actual del cursos, más la separación del botón con el formulario y menos el punto inicial
                elControlDeMovimiento.Left = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
                elControlDeMovimiento.Top = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;

            }
        }

        private void SoltarElBoton(object sender, MouseEventArgs e) => Presionar = false;


        //se pregunta si es el botón izquierdo el que si clickeo, y se obtine la localización del mouse
        private void PresionarElBoton(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Presionar = true;
                PuntoInicial = e.Location;
            }
        }



        /*
         Papel
             */

        private void btnHojas_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPapel(laCoordenadaX, laCoordenadaY, btnHojas);
        }
        private void btnBolsaDePapel_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPapel(laCoordenadaX, laCoordenadaY, btnBolsaDePapel);
        }
        private void btnCuaderno_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPapel(laCoordenadaX, laCoordenadaY, btnCuaderno);
        }
        private void btnCartonDeLeche_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPapel(laCoordenadaX, laCoordenadaY, btnCartonDeLeche);
        }

        private void btnCaja_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPapel(laCoordenadaX, laCoordenadaY, btnCaja);
        }


        /*Envases*/

        private void btnBotella_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPlastico(laCoordenadaX, laCoordenadaY, btnBotella);
        }
        private void btnBolsaDePlastico_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPlastico(laCoordenadaX, laCoordenadaY, btnBolsaDePlastico);
        }
        private void btnMermelada_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPlastico(laCoordenadaX, laCoordenadaY, btnMermelada);
        }
        private void btnBalde_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPlastico(laCoordenadaX, laCoordenadaY, btnBalde);
        }
        private void btnVasoPlastico_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarPlastico(laCoordenadaX, laCoordenadaY, btnVasoPlastico);
        }


        /*Ordinarios*/

        private void btnTuallitas_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrdinarios(laCoordenadaX, laCoordenadaY, btnTuallitas);
        }
        private void btnPapelHigienico_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrdinarios(laCoordenadaX, laCoordenadaY, btnPapelHigienico);
        }

        private void btnBarrer_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrdinarios(laCoordenadaX, laCoordenadaY, btnBarrer);
        }
        private void btnCigarro_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrdinarios(laCoordenadaX, laCoordenadaY, btnCigarro);
        }

        private void btnTela_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrdinarios(laCoordenadaX, laCoordenadaY, btnTela);
        }

        /*Organicos*/

        private void btnBanano_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrganico(laCoordenadaX, laCoordenadaY, btnBanano);
        }
        private void btnZanahoria_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrganico(laCoordenadaX, laCoordenadaY, btnZanahoria);
        }

        private void btnSandia_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrganico(laCoordenadaX, laCoordenadaY, btnSandia);
        }
        private void btnManzana_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrganico(laCoordenadaX, laCoordenadaY, btnManzana);

        }

        private void btnPera_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarOrganico(laCoordenadaX, laCoordenadaY, btnPera);

        }


        /*Vidrio*/

        private void btnVaso_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarVidrio(laCoordenadaX, laCoordenadaY, btnVaso);
        }
        private void btnLupa_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarVidrio(laCoordenadaX, laCoordenadaY, btnLupa);
        }
        private void btnEspejo_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarVidrio(laCoordenadaX, laCoordenadaY, btnEspejo);
        }

        private void btnPlatos_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarVidrio(laCoordenadaX, laCoordenadaY, btnPlatos);
        }

        private void btnJarron_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarVidrio(laCoordenadaX, laCoordenadaY, btnJarron);
        }

        /*Bioinfecciosos*/

        private void btnCuritas_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarBioinfecciosos(laCoordenadaX, laCoordenadaY, btnCuritas);
        }

        private void btnSangre_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarBioinfecciosos(laCoordenadaX, laCoordenadaY, btnSangre);
        }

        private void btnJeringa_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarBioinfecciosos(laCoordenadaX, laCoordenadaY, btnJeringa);
        }
        private void btnTermometro_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarBioinfecciosos(laCoordenadaX, laCoordenadaY, btnTermometro);
        }

        private void btnPañuelo_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarBioinfecciosos(laCoordenadaX, laCoordenadaY, btnPañuelo);
        }

        /*Especiales*/
        private void btnColchon_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarEspecial(laCoordenadaX, laCoordenadaY, btnColchon);
        }

        private void btnBateria_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarEspecial(laCoordenadaX, laCoordenadaY, btnBateria);
        }

        private void btnMicroondas_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarEspecial(laCoordenadaX, laCoordenadaY, btnMicroondas);
        }
        private void btnLlanta_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarEspecial(laCoordenadaX, laCoordenadaY, btnLlanta);

        }

        private void btnBombillo_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarEspecial(laCoordenadaX, laCoordenadaY, btnBombillo);
        }

        /*Aluminio*/

        private void btnPapelAluminio_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarAluminio(laCoordenadaX, laCoordenadaY, btnPapelAluminio);
        }

        private void btnLata_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarAluminio(laCoordenadaX, laCoordenadaY, btnLata);
        }

        private void btnRefresco_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarAluminio(laCoordenadaX, laCoordenadaY, btnRefresco);
        }
        private void btnSardinas_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarAluminio(laCoordenadaX, laCoordenadaY, btnSardinas);
        }

        private void btnAtun_MouseDown(object sender, MouseEventArgs e)
        {
            Control elControlDeMovimiento = (Control)sender;

            int laCoordenadaX = e.X + elControlDeMovimiento.Left - PuntoInicial.X;
            int laCoordenadaY = e.Y + elControlDeMovimiento.Top - PuntoInicial.Y;
            VerificarAluminio(laCoordenadaX, laCoordenadaY, btnAtun);

        }




        /*
         Métodos para validar las coordanadas de cada residuo en relación al basurero al que pertenece
             */

        public void VerificarOrganico(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 168 && laCoordenadaX >= 130) && (laCoordenadaY <= 154 && laCoordenadaY >= 110))
            {
                btnElBoton.Visible = false;
                ContadorOrganicos++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }
        public void VerificarPlastico(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 338 && laCoordenadaX >= 305) && (laCoordenadaY <= 165 && laCoordenadaY >= 102))
            {
                btnElBoton.Visible = false;
                ContadorPlastico++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }
        public void VerificarAluminio(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 500 && laCoordenadaX >= 430) && (laCoordenadaY <= 171 && laCoordenadaY >= 96))
            {
                btnElBoton.Visible = false;
                ContadorAluminio++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }
        public void VerificarPapel(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 665 && laCoordenadaX >= 590) && (laCoordenadaY <= 178 && laCoordenadaY >= 80))
            {
                btnElBoton.Visible = false;
                ContadorPapel++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }
        public void VerificarOrdinarios(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 825 && laCoordenadaX >= 700) && (laCoordenadaY <= 180 && laCoordenadaY >= 100))
            {
                btnElBoton.Visible = false;
                ContadorOrdinarios++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }
        public void VerificarBioinfecciosos(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 345 && laCoordenadaX >= 265) && (laCoordenadaY <= 330 && laCoordenadaY >= 245))
            {
                btnElBoton.Visible = false;
                ContadorBioinfecciosos++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }
        public void VerificarVidrio(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 508 && laCoordenadaX >= 434) && (laCoordenadaY <= 330 && laCoordenadaY >= 250))
            {
                btnElBoton.Visible = false;
                ContadorVidrio++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }
        public void VerificarEspecial(int laCoordenadaX, int laCoordenadaY, Button btnElBoton)
        {
            if ((laCoordenadaX <= 674 && laCoordenadaX >= 580) && (laCoordenadaY <= 332 && laCoordenadaY >= 250))
            {
                btnElBoton.Visible = false;
                ContadorEspeciales++;
                MessageBox.Show("¡Excelente!", "Respuesta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PartidaCompleta();
            }
        }


        /*
         Métodos de validación para ver si la todos los residuos están en sus lugares
             */
        public void PartidaCompleta()
        {
            if (TerminarPartida())
            {
                lblFelicitacion.Text = "¡Felicidades has clasificado\n bien tus residuos!";
            }
        }

        public Boolean TerminarPartida()
        {
            if (ContadorPlastico == 5 && ContadorPapel == 5 && ContadorVidrio == 5 && ContadorOrganicos == 5
                && ContadorAluminio == 5 && ContadorBioinfecciosos == 5 && ContadorEspeciales == 5 && ContadorOrdinarios == 5)
            {
                return true;
            }
            return false;
        }

       
    }
}
