namespace GestorDeSimon
{
    partial class FormularioDeSimon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDeSimon));
            this.pb_0 = new System.Windows.Forms.PictureBox();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.lblAnuncio = new System.Windows.Forms.Label();
            this.panelImagenes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.TemporizadorDeJuego = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            this.panelImagenes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_0
            // 
            this.pb_0.Image = ((System.Drawing.Image)(resources.GetObject("pb_0.Image")));
            this.pb_0.Location = new System.Drawing.Point(22, 173);
            this.pb_0.Name = "pb_0";
            this.pb_0.Size = new System.Drawing.Size(128, 128);
            this.pb_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_0.TabIndex = 0;
            this.pb_0.TabStop = false;
            this.pb_0.Click += new System.EventHandler(this.pb_0_Click);
            this.pb_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_0_MouseDown);
            this.pb_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_0_MouseUp);
            // 
            // pb_1
            // 
            this.pb_1.Image = ((System.Drawing.Image)(resources.GetObject("pb_1.Image")));
            this.pb_1.Location = new System.Drawing.Point(177, 173);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(128, 128);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_1.TabIndex = 1;
            this.pb_1.TabStop = false;
            this.pb_1.Click += new System.EventHandler(this.pb_0_Click);
            this.pb_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_1_MouseDown);
            this.pb_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_1_MouseUp);
            // 
            // pb_2
            // 
            this.pb_2.Image = ((System.Drawing.Image)(resources.GetObject("pb_2.Image")));
            this.pb_2.Location = new System.Drawing.Point(22, 13);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(128, 128);
            this.pb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_2.TabIndex = 2;
            this.pb_2.TabStop = false;
            this.pb_2.Click += new System.EventHandler(this.pb_0_Click);
            this.pb_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_2_MouseDown);
            this.pb_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_2_MouseUp);
            // 
            // pb_3
            // 
            this.pb_3.Image = ((System.Drawing.Image)(resources.GetObject("pb_3.Image")));
            this.pb_3.Location = new System.Drawing.Point(177, 13);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(128, 128);
            this.pb_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_3.TabIndex = 3;
            this.pb_3.TabStop = false;
            this.pb_3.Click += new System.EventHandler(this.pb_0_Click);
            this.pb_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_3_MouseDown);
            this.pb_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_3_MouseUp);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(192, 412);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(321, 42);
            this.btnEmpezar.TabIndex = 5;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // lblAnuncio
            // 
            this.lblAnuncio.AutoSize = true;
            this.lblAnuncio.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnuncio.Location = new System.Drawing.Point(217, 21);
            this.lblAnuncio.Name = "lblAnuncio";
            this.lblAnuncio.Size = new System.Drawing.Size(296, 36);
            this.lblAnuncio.TabIndex = 6;
            this.lblAnuncio.Text = "¡Sigamos el patrón!";
            // 
            // panelImagenes
            // 
            this.panelImagenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImagenes.Controls.Add(this.pb_0);
            this.panelImagenes.Controls.Add(this.pb_1);
            this.panelImagenes.Controls.Add(this.pb_2);
            this.panelImagenes.Controls.Add(this.pb_3);
            this.panelImagenes.Location = new System.Drawing.Point(25, 69);
            this.panelImagenes.Name = "panelImagenes";
            this.panelImagenes.Size = new System.Drawing.Size(322, 314);
            this.panelImagenes.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblPuntos);
            this.panel1.Controls.Add(this.lblCronometro);
            this.panel1.Controls.Add(this.lblTiempo);
            this.panel1.Location = new System.Drawing.Point(370, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 314);
            this.panel1.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(104, 185);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 52);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPuntos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.Black;
            this.lblPuntos.Location = new System.Drawing.Point(3, 132);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(252, 32);
            this.lblPuntos.TabIndex = 4;
            this.lblPuntos.Text = "Puntos obtenidos: ";
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.Location = new System.Drawing.Point(54, 61);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(212, 56);
            this.lblCronometro.TabIndex = 1;
            this.lblCronometro.Text = "00:00:00";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(97, 11);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(141, 41);
            this.lblTiempo.TabIndex = 0;
            this.lblTiempo.Text = "Tiempo";
            // 
            // TemporizadorDeJuego
            // 
            this.TemporizadorDeJuego.Enabled = true;
            this.TemporizadorDeJuego.Interval = 900;
            this.TemporizadorDeJuego.Tick += new System.EventHandler(this.ActualizarTiempoTranscurrido);
            // 
            // FormularioDeSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelImagenes);
            this.Controls.Add(this.lblAnuncio);
            this.Controls.Add(this.btnEmpezar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 519);
            this.MinimumSize = new System.Drawing.Size(744, 519);
            this.Name = "FormularioDeSimon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.FormularioDeSimon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            this.panelImagenes.ResumeLayout(false);
            this.panelImagenes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_0;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.PictureBox pb_2;
        private System.Windows.Forms.PictureBox pb_3;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Label lblAnuncio;
        private System.Windows.Forms.Panel panelImagenes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Timer TemporizadorDeJuego;
    }
}