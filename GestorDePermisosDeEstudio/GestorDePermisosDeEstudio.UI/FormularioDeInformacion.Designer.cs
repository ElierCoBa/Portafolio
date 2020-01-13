namespace GestorDePermisosDeEstudio.UI
{
    partial class FormularioDeInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDeInformacion));
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblInformacionDelDesarrollador = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(20, 21);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(336, 130);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = resources.GetString("lblInformacion.Text");
            // 
            // lblInformacionDelDesarrollador
            // 
            this.lblInformacionDelDesarrollador.AutoSize = true;
            this.lblInformacionDelDesarrollador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionDelDesarrollador.Location = new System.Drawing.Point(72, 163);
            this.lblInformacionDelDesarrollador.MaximumSize = new System.Drawing.Size(221, 39);
            this.lblInformacionDelDesarrollador.MinimumSize = new System.Drawing.Size(221, 39);
            this.lblInformacionDelDesarrollador.Name = "lblInformacionDelDesarrollador";
            this.lblInformacionDelDesarrollador.Size = new System.Drawing.Size(221, 39);
            this.lblInformacionDelDesarrollador.TabIndex = 1;
            this.lblInformacionDelDesarrollador.Text = "Realizada por: Elier Cortés Baltodano\r\nEstudiante de Informática Empresarial\r\n   " +
    "                   Año 2019";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(237, 217);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 33);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FormularioDeInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(368, 258);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblInformacionDelDesarrollador);
            this.Controls.Add(this.lblInformacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 297);
            this.MinimumSize = new System.Drawing.Size(384, 297);
            this.Name = "FormularioDeInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de la aplicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblInformacionDelDesarrollador;
        private System.Windows.Forms.Button btnRegresar;
    }
}