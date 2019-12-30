namespace GestorDePermisosDeEstudio.UI
{
    partial class FormularioParaLoginDeEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioParaLoginDeEstudiante));
            this.lblCarne = new System.Windows.Forms.Label();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.rbUnaPersona = new System.Windows.Forms.RadioButton();
            this.rbDosPersonas = new System.Windows.Forms.RadioButton();
            this.rbTresPersonas = new System.Windows.Forms.RadioButton();
            this.rbCuatroPersonas = new System.Windows.Forms.RadioButton();
            this.PanelPersonas = new System.Windows.Forms.Panel();
            this.PanelPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarne
            // 
            this.lblCarne.AutoSize = true;
            this.lblCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarne.Location = new System.Drawing.Point(62, 125);
            this.lblCarne.Name = "lblCarne";
            this.lblCarne.Size = new System.Drawing.Size(47, 16);
            this.lblCarne.TabIndex = 0;
            this.lblCarne.Text = "Carné:";
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(115, 124);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(152, 20);
            this.txtCarne.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(52, 164);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 36);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(168, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(45, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(161, 16);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Cantidad de personas";
            // 
            // rbUnaPersona
            // 
            this.rbUnaPersona.AutoSize = true;
            this.rbUnaPersona.Location = new System.Drawing.Point(32, 41);
            this.rbUnaPersona.Name = "rbUnaPersona";
            this.rbUnaPersona.Size = new System.Drawing.Size(31, 17);
            this.rbUnaPersona.TabIndex = 5;
            this.rbUnaPersona.TabStop = true;
            this.rbUnaPersona.Text = "1";
            this.rbUnaPersona.UseVisualStyleBackColor = true;
            // 
            // rbDosPersonas
            // 
            this.rbDosPersonas.AutoSize = true;
            this.rbDosPersonas.Location = new System.Drawing.Point(82, 41);
            this.rbDosPersonas.Name = "rbDosPersonas";
            this.rbDosPersonas.Size = new System.Drawing.Size(31, 17);
            this.rbDosPersonas.TabIndex = 6;
            this.rbDosPersonas.TabStop = true;
            this.rbDosPersonas.Text = "2";
            this.rbDosPersonas.UseVisualStyleBackColor = true;
            // 
            // rbTresPersonas
            // 
            this.rbTresPersonas.AutoSize = true;
            this.rbTresPersonas.Location = new System.Drawing.Point(135, 41);
            this.rbTresPersonas.Name = "rbTresPersonas";
            this.rbTresPersonas.Size = new System.Drawing.Size(31, 17);
            this.rbTresPersonas.TabIndex = 7;
            this.rbTresPersonas.TabStop = true;
            this.rbTresPersonas.Text = "3";
            this.rbTresPersonas.UseVisualStyleBackColor = true;
            // 
            // rbCuatroPersonas
            // 
            this.rbCuatroPersonas.AutoSize = true;
            this.rbCuatroPersonas.Location = new System.Drawing.Point(184, 41);
            this.rbCuatroPersonas.Name = "rbCuatroPersonas";
            this.rbCuatroPersonas.Size = new System.Drawing.Size(31, 17);
            this.rbCuatroPersonas.TabIndex = 8;
            this.rbCuatroPersonas.TabStop = true;
            this.rbCuatroPersonas.Text = "4";
            this.rbCuatroPersonas.UseVisualStyleBackColor = true;
            // 
            // PanelPersonas
            // 
            this.PanelPersonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPersonas.Controls.Add(this.rbCuatroPersonas);
            this.PanelPersonas.Controls.Add(this.rbTresPersonas);
            this.PanelPersonas.Controls.Add(this.rbDosPersonas);
            this.PanelPersonas.Controls.Add(this.rbUnaPersona);
            this.PanelPersonas.Controls.Add(this.lblNumero);
            this.PanelPersonas.Location = new System.Drawing.Point(31, 13);
            this.PanelPersonas.Name = "PanelPersonas";
            this.PanelPersonas.Size = new System.Drawing.Size(254, 87);
            this.PanelPersonas.TabIndex = 9;
            // 
            // FormularioParaLoginDeEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 216);
            this.Controls.Add(this.PanelPersonas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.lblCarne);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 160);
            this.Name = "FormularioParaLoginDeEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.PanelPersonas.ResumeLayout(false);
            this.PanelPersonas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarne;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.RadioButton rbUnaPersona;
        private System.Windows.Forms.RadioButton rbDosPersonas;
        private System.Windows.Forms.RadioButton rbTresPersonas;
        private System.Windows.Forms.RadioButton rbCuatroPersonas;
        private System.Windows.Forms.Panel PanelPersonas;
    }
}