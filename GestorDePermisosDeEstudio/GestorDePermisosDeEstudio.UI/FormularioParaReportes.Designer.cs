namespace GestorDePermisosDeEstudio.UI
{
    partial class FormularioParaReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioParaReportes));
            this.lblReporte = new System.Windows.Forms.Label();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.msElMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.msElMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.Location = new System.Drawing.Point(43, 35);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(313, 25);
            this.lblReporte.TabIndex = 0;
            this.lblReporte.Text = "Reportes o recomentaciones";
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(32, 91);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReporte.Size = new System.Drawing.Size(324, 201);
            this.txtReporte.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(63, 304);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 36);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // msElMenu
            // 
            this.msElMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInformacion});
            this.msElMenu.Location = new System.Drawing.Point(0, 0);
            this.msElMenu.Name = "msElMenu";
            this.msElMenu.Size = new System.Drawing.Size(396, 24);
            this.msElMenu.TabIndex = 3;
            this.msElMenu.Text = "menuStrip1";
            // 
            // tsmiInformacion
            // 
            this.tsmiInformacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAyuda});
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
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(205, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormularioParaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 352);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.msElMenu);
            this.MainMenuStrip = this.msElMenu;
            this.Name = "FormularioParaReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.msElMenu.ResumeLayout(false);
            this.msElMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MenuStrip msElMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.Button btnCancelar;
    }
}