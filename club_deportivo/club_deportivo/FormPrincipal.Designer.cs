namespace club_deportivo
{
    partial class FormPrincipal
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
            btnClientes = new Button();
            btnProfesores = new Button();
            btnActividades = new Button();
            btnReporteDiario = new Button();
            btnAbonoActividad = new Button();
            btnCuotaSocios = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(151, 139);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(137, 41);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new Point(318, 139);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(137, 41);
            btnProfesores.TabIndex = 1;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnActividades
            // 
            btnActividades.Location = new Point(487, 139);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(137, 41);
            btnActividades.TabIndex = 2;
            btnActividades.Text = "Actividades del Club";
            btnActividades.UseVisualStyleBackColor = true;
            btnActividades.Click += btnActividades_Click;
            // 
            // btnReporteDiario
            // 
            btnReporteDiario.Location = new Point(487, 226);
            btnReporteDiario.Name = "btnReporteDiario";
            btnReporteDiario.Size = new Size(137, 41);
            btnReporteDiario.TabIndex = 5;
            btnReporteDiario.Text = "Reporte Diario";
            btnReporteDiario.UseVisualStyleBackColor = true;
            btnReporteDiario.Click += btnReporteDiario_Click;
            // 
            // btnAbonoActividad
            // 
            btnAbonoActividad.Location = new Point(318, 226);
            btnAbonoActividad.Name = "btnAbonoActividad";
            btnAbonoActividad.Size = new Size(137, 41);
            btnAbonoActividad.TabIndex = 4;
            btnAbonoActividad.Text = "Abono Actividad";
            btnAbonoActividad.UseVisualStyleBackColor = true;
            btnAbonoActividad.Click += btnAbonoActividad_Click;
            // 
            // btnCuotaSocios
            // 
            btnCuotaSocios.Location = new Point(151, 226);
            btnCuotaSocios.Name = "btnCuotaSocios";
            btnCuotaSocios.Size = new Size(137, 41);
            btnCuotaSocios.TabIndex = 3;
            btnCuotaSocios.Text = "Cuota Socios";
            btnCuotaSocios.UseVisualStyleBackColor = true;
            btnCuotaSocios.Click += btnCuotaSocios_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(582, 370);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(137, 41);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnReporteDiario);
            Controls.Add(btnAbonoActividad);
            Controls.Add(btnCuotaSocios);
            Controls.Add(btnActividades);
            Controls.Add(btnProfesores);
            Controls.Add(btnClientes);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProfesores;
        private Button btnActividades;
        private Button btnReporteDiario;
        private Button btnAbonoActividad;
        private Button btnCuotaSocios;
        private Button btnCerrarSesion;
    }
}