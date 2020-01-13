namespace GestorDePermisosDeEstudio.UI
{
    partial class FormularioDeMuestraDePermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDeMuestraDePermisos));
            this.dgvListaDePermisos = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPermisosDelDia = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDePermisos)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaDePermisos
            // 
            this.dgvListaDePermisos.AllowUserToAddRows = false;
            this.dgvListaDePermisos.AllowUserToDeleteRows = false;
            this.dgvListaDePermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDePermisos.Location = new System.Drawing.Point(31, 28);
            this.dgvListaDePermisos.Name = "dgvListaDePermisos";
            this.dgvListaDePermisos.RowHeadersVisible = false;
            this.dgvListaDePermisos.Size = new System.Drawing.Size(1001, 333);
            this.dgvListaDePermisos.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(913, 379);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 33);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnEstudiantes.Image")));
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstudiantes.Location = new System.Drawing.Point(30, 379);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(119, 33);
            this.btnEstudiantes.TabIndex = 3;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = true;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(155, 379);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(119, 33);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPermisosDelDia
            // 
            this.btnPermisosDelDia.Image = ((System.Drawing.Image)(resources.GetObject("btnPermisosDelDia.Image")));
            this.btnPermisosDelDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermisosDelDia.Location = new System.Drawing.Point(760, 379);
            this.btnPermisosDelDia.Name = "btnPermisosDelDia";
            this.btnPermisosDelDia.Size = new System.Drawing.Size(147, 33);
            this.btnPermisosDelDia.TabIndex = 4;
            this.btnPermisosDelDia.Text = "Permisos del día";
            this.btnPermisosDelDia.UseVisualStyleBackColor = true;
            this.btnPermisosDelDia.Click += new System.EventHandler(this.btnPermisosDelDia_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInformacion});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1060, 24);
            this.msMenu.TabIndex = 5;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiInformacion
            // 
            this.tsmiInformacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiReportar,
            this.tsmiAyuda});
            this.tsmiInformacion.Name = "tsmiInformacion";
            this.tsmiInformacion.ShowShortcutKeys = false;
            this.tsmiInformacion.Size = new System.Drawing.Size(84, 20);
            this.tsmiInformacion.Text = "Información";
            // 
            // tsmiReportar
            // 
            this.tsmiReportar.Name = "tsmiReportar";
            this.tsmiReportar.Size = new System.Drawing.Size(119, 22);
            this.tsmiReportar.Text = "Reportar";
            this.tsmiReportar.Click += new System.EventHandler(this.reportarToolStripMenuItem_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(119, 22);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarTodos.Image")));
            this.btnMostrarTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodos.Location = new System.Drawing.Point(625, 379);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(125, 33);
            this.btnMostrarTodos.TabIndex = 6;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // FormularioDeMuestraDePermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 426);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnPermisosDelDia);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnEstudiantes);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvListaDePermisos);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1076, 465);
            this.MinimumSize = new System.Drawing.Size(1076, 465);
            this.Name = "FormularioDeMuestraDePermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDePermisos)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDePermisos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnPermisosDelDia;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportar;
    }
}