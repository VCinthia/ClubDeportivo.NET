namespace club_deportivo
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngresar = new Button();
            btnRegistrar = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.Control;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(239, 335);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(119, 30);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(452, 335);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 30);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(298, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 64);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Ingreso al Sistema \r\nClub Deportivo\r\n";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Click += label1_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIngresar);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            Load += FormInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnRegistrar;
        private Label lblTitulo;
    }
}