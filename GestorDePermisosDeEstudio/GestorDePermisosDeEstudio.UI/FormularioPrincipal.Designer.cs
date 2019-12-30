namespace GestorDePermisosDeEstudio.UI
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.msElMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.msElMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(95, 29);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(220, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Seleccione un usuario";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AccessibleDescription = "Seleccione para solicutar un permiso";
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("lblEstudiante.Image")));
            this.lblEstudiante.Location = new System.Drawing.Point(33, 79);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(150, 155);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Tag = "";
            this.lblEstudiante.Text = "Estudiante";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblEstudiante.UseVisualStyleBackColor = true;
            this.lblEstudiante.Click += new System.EventHandler(this.lblEstudiante_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrador.Image")));
            this.btnAdministrador.Location = new System.Drawing.Point(227, 79);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(150, 155);
            this.btnAdministrador.TabIndex = 2;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(259, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // msElMenu
            // 
            this.msElMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInformacion});
            this.msElMenu.Location = new System.Drawing.Point(0, 0);
            this.msElMenu.Name = "msElMenu";
            this.msElMenu.Size = new System.Drawing.Size(423, 24);
            this.msElMenu.TabIndex = 4;
            this.msElMenu.Text = "menuStrip1";
            // 
            // tsmiInformacion
            // 
            this.tsmiInformacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyuda,
            this.tmsiAcercaDe});
            this.tsmiInformacion.Name = "tsmiInformacion";
            this.tsmiInformacion.Size = new System.Drawing.Size(84, 20);
            this.tsmiInformacion.Text = "Información";
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(180, 22);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // tmsiAcercaDe
            // 
            this.tmsiAcercaDe.Name = "tmsiAcercaDe";
            this.tmsiAcercaDe.Size = new System.Drawing.Size(180, 22);
            this.tmsiAcercaDe.Text = "Acerca de";
            this.tmsiAcercaDe.Click += new System.EventHandler(this.tmsiAcercaDe_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 300);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.msElMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 339);
            this.MinimumSize = new System.Drawing.Size(439, 304);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.msElMenu.ResumeLayout(false);
            this.msElMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button lblEstudiante;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MenuStrip msElMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tmsiAcercaDe;
    }
}