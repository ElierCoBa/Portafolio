namespace GestorDePermisosDeEstudio.UI
{
    partial class FormularioParaInsertarResidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioParaInsertarResidente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCarne = new System.Windows.Forms.Label();
            this.lblDatosCuarto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbPabellon = new System.Windows.Forms.ComboBox();
            this.txtCuarto = new System.Windows.Forms.TextBox();
            this.lblPabellon = new System.Windows.Forms.Label();
            this.lblCuarto = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblDatosEstudiante = new System.Windows.Forms.Label();
            this.dgvLaListaDeResidentes = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaListaDeResidentes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnActivar);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.lblCarne);
            this.panel1.Controls.Add(this.lblDatosCuarto);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.cbPabellon);
            this.panel1.Controls.Add(this.txtCuarto);
            this.panel1.Controls.Add(this.lblPabellon);
            this.panel1.Controls.Add(this.lblCuarto);
            this.panel1.Controls.Add(this.lblPrimerApellido);
            this.panel1.Controls.Add(this.lblSegundoApellido);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 408);
            this.panel1.TabIndex = 0;
            // 
            // btnActivar
            // 
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.Location = new System.Drawing.Point(160, 358);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(109, 37);
            this.btnActivar.TabIndex = 23;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(32, 358);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 37);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCarne
            // 
            this.lblCarne.AutoSize = true;
            this.lblCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarne.Location = new System.Drawing.Point(9, 52);
            this.lblCarne.Name = "lblCarne";
            this.lblCarne.Size = new System.Drawing.Size(47, 16);
            this.lblCarne.TabIndex = 1;
            this.lblCarne.Text = "Carné:";
            // 
            // lblDatosCuarto
            // 
            this.lblDatosCuarto.AutoSize = true;
            this.lblDatosCuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCuarto.Location = new System.Drawing.Point(86, 205);
            this.lblDatosCuarto.Name = "lblDatosCuarto";
            this.lblDatosCuarto.Size = new System.Drawing.Size(122, 16);
            this.lblDatosCuarto.TabIndex = 14;
            this.lblDatosCuarto.Text = "Datos del cuarto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(99, 315);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 37);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbPabellon
            // 
            this.cbPabellon.Enabled = false;
            this.cbPabellon.FormattingEnabled = true;
            this.cbPabellon.Items.AddRange(new object[] {
            "A1",
            "A2",
            "B1",
            "B2",
            "Santa Rosa"});
            this.cbPabellon.Location = new System.Drawing.Point(160, 243);
            this.cbPabellon.Name = "cbPabellon";
            this.cbPabellon.Size = new System.Drawing.Size(125, 21);
            this.cbPabellon.TabIndex = 16;
            // 
            // txtCuarto
            // 
            this.txtCuarto.Enabled = false;
            this.txtCuarto.Location = new System.Drawing.Point(160, 278);
            this.txtCuarto.Name = "txtCuarto";
            this.txtCuarto.Size = new System.Drawing.Size(125, 20);
            this.txtCuarto.TabIndex = 18;
            // 
            // lblPabellon
            // 
            this.lblPabellon.AutoSize = true;
            this.lblPabellon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPabellon.Location = new System.Drawing.Point(12, 244);
            this.lblPabellon.Name = "lblPabellon";
            this.lblPabellon.Size = new System.Drawing.Size(65, 16);
            this.lblPabellon.TabIndex = 15;
            this.lblPabellon.Text = "Pabellón:";
            // 
            // lblCuarto
            // 
            this.lblCuarto.AutoSize = true;
            this.lblCuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuarto.Location = new System.Drawing.Point(12, 278);
            this.lblCuarto.Name = "lblCuarto";
            this.lblCuarto.Size = new System.Drawing.Size(50, 16);
            this.lblCuarto.TabIndex = 17;
            this.lblCuarto.Text = "Cuarto:";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(9, 82);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(102, 16);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer apellido:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(9, 108);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(118, 16);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo apellido:";
            // 
            // txtCarne
            // 
            this.txtCarne.Enabled = false;
            this.txtCarne.Location = new System.Drawing.Point(174, 56);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(125, 20);
            this.txtCarne.TabIndex = 2;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(23, 143);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(99, 16);
            this.lblPrimerNombre.TabIndex = 5;
            this.lblPrimerNombre.Text = "Primer nombre:";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(23, 171);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(115, 16);
            this.lblSegundoNombre.TabIndex = 6;
            this.lblSegundoNombre.Text = "Segundo nombre:";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(174, 86);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(125, 20);
            this.txtPrimerApellido.TabIndex = 7;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Location = new System.Drawing.Point(174, 116);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(125, 20);
            this.txtSegundoApellido.TabIndex = 8;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(174, 143);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(125, 20);
            this.txtPrimerNombre.TabIndex = 9;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Enabled = false;
            this.txtSegundoNombre.Location = new System.Drawing.Point(174, 171);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(125, 20);
            this.txtSegundoNombre.TabIndex = 10;
            // 
            // lblDatosEstudiante
            // 
            this.lblDatosEstudiante.AutoSize = true;
            this.lblDatosEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEstudiante.Location = new System.Drawing.Point(79, 26);
            this.lblDatosEstudiante.Name = "lblDatosEstudiante";
            this.lblDatosEstudiante.Size = new System.Drawing.Size(151, 16);
            this.lblDatosEstudiante.TabIndex = 13;
            this.lblDatosEstudiante.Text = "Datos del estudiante";
            // 
            // dgvLaListaDeResidentes
            // 
            this.dgvLaListaDeResidentes.AllowUserToAddRows = false;
            this.dgvLaListaDeResidentes.AllowUserToDeleteRows = false;
            this.dgvLaListaDeResidentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaListaDeResidentes.Location = new System.Drawing.Point(337, 15);
            this.dgvLaListaDeResidentes.Name = "dgvLaListaDeResidentes";
            this.dgvLaListaDeResidentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLaListaDeResidentes.Size = new System.Drawing.Size(698, 345);
            this.dgvLaListaDeResidentes.TabIndex = 20;
            this.dgvLaListaDeResidentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaListaDeResidentes_CellClick);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(925, 378);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(110, 36);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(694, 378);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 37);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(809, 378);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 36);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormularioParaInsertarResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 426);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dgvLaListaDeResidentes);
            this.Controls.Add(this.lblDatosEstudiante);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1076, 465);
            this.MinimumSize = new System.Drawing.Size(1076, 465);
            this.Name = "FormularioParaInsertarResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar residente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaListaDeResidentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCarne;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblDatosEstudiante;
        private System.Windows.Forms.Label lblDatosCuarto;
        private System.Windows.Forms.Label lblPabellon;
        private System.Windows.Forms.ComboBox cbPabellon;
        private System.Windows.Forms.Label lblCuarto;
        private System.Windows.Forms.TextBox txtCuarto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvLaListaDeResidentes;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActivar;
    }
}