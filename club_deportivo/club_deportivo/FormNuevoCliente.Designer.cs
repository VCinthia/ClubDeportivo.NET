namespace club_deportivo
{
    partial class FormNuevoCliente
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTipo = new Label();
            lblAptoMedico = new Label();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnAptoMedico = new Button();
            btnAgregar = new Button();
            btnDescartar = new Button();
            cboTipo = new ComboBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(350, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(350, 114);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            lblApellido.Click += label2_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(350, 193);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            lblDni.Click += label3_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(350, 263);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            lblTipo.Click += label4_Click;
            // 
            // lblAptoMedico
            // 
            lblAptoMedico.AutoSize = true;
            lblAptoMedico.Location = new Point(350, 325);
            lblAptoMedico.Name = "lblAptoMedico";
            lblAptoMedico.Size = new Size(76, 15);
            lblAptoMedico.TabIndex = 4;
            lblAptoMedico.Text = "Apto Médico";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(328, 211);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            txtDni.Text = "00000000";
            txtDni.Enter += txtDni_Enter;
            txtDni.KeyPress += txtDni_KeyPress;
            txtDni.Leave += txtDni_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(328, 141);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 2;
            txtApellido.Text = "apellido";
            txtApellido.TextChanged += txtApellido_TextChanged;
            txtApellido.Enter += txtApellido_Enter;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(328, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "nombre";
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // btnAptoMedico
            // 
            btnAptoMedico.Location = new Point(328, 357);
            btnAptoMedico.Name = "btnAptoMedico";
            btnAptoMedico.Size = new Size(135, 23);
            btnAptoMedico.TabIndex = 5;
            btnAptoMedico.Text = "Subir Archivo";
            btnAptoMedico.UseVisualStyleBackColor = true;
            btnAptoMedico.Click += btnAptoMedico_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(254, 404);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnDescartar
            // 
            btnDescartar.Location = new Point(452, 404);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(75, 23);
            btnDescartar.TabIndex = 7;
            btnDescartar.Text = "Descartar";
            btnDescartar.UseVisualStyleBackColor = true;
            btnDescartar.Click += btnDescartar_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Socio\t", "No Socio" });
            cboTipo.Location = new Point(328, 281);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 4;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // FormNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboTipo);
            Controls.Add(btnDescartar);
            Controls.Add(btnAgregar);
            Controls.Add(btnAptoMedico);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDni);
            Controls.Add(lblAptoMedico);
            Controls.Add(lblTipo);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "FormNuevoCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblTipo;
        private Label lblAptoMedico;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnAptoMedico;
        private Button btnAgregar;
        private Button btnDescartar;
        private ComboBox cboTipo;
    }
}