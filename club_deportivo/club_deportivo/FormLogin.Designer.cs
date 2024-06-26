namespace club_deportivo
{
    partial class FormLogin
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
            lblNombreUsuario = new Label();
            lblPass = new Label();
            txtNombreUsuario = new TextBox();
            txtPass = new TextBox();
            btnAceptarIngresar = new Button();
            btnMostrarPass = new Button();
            SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(258, 62);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(110, 15);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(258, 156);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Contraseña";
            lblPass.Click += label2_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(258, 90);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(233, 23);
            txtNombreUsuario.TabIndex = 1;
            txtNombreUsuario.Text = "usuario";
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            txtNombreUsuario.Enter += txtNombreUsuario_Enter;
            txtNombreUsuario.Leave += txtNombreUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(258, 185);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(233, 23);
            txtPass.TabIndex = 2;
            txtPass.Text = "contraseña";
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnAceptarIngresar
            // 
            btnAceptarIngresar.Location = new Point(339, 288);
            btnAceptarIngresar.Name = "btnAceptarIngresar";
            btnAceptarIngresar.Size = new Size(75, 23);
            btnAceptarIngresar.TabIndex = 4;
            btnAceptarIngresar.Text = "Ingresar";
            btnAceptarIngresar.UseVisualStyleBackColor = true;
            btnAceptarIngresar.Click += btnAceptarIngresar_Click;
            // 
            // btnMostrarPass
            // 
            btnMostrarPass.Location = new Point(509, 185);
            btnMostrarPass.Name = "btnMostrarPass";
            btnMostrarPass.Size = new Size(75, 23);
            btnMostrarPass.TabIndex = 3;
            btnMostrarPass.Text = "Mostrar";
            btnMostrarPass.UseVisualStyleBackColor = true;
            btnMostrarPass.Click += btnMostrarPass_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarPass);
            Controls.Add(btnAceptarIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblPass);
            Controls.Add(lblNombreUsuario);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreUsuario;
        private Label lblPass;
        private TextBox txtNombreUsuario;
        private TextBox txtPass;
        private Button btnAceptarIngresar;
        private Button btnMostrarPass;
    }
}