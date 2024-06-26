namespace club_deportivo
{
    partial class FormClientes
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
            components = new System.ComponentModel.Container();
            lblClientes = new Label();
            btnAgregarCliente = new Button();
            dataGridView1 = new DataGridView();
            id_cliente = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            imprimir = new DataGridViewTextBoxColumn();
            conexionBindingSource = new BindingSource(components);
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(359, 68);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(49, 15);
            lblClientes.TabIndex = 0;
            lblClientes.Text = "Clientes";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(579, 26);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(144, 23);
            btnAgregarCliente.TabIndex = 1;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_cliente, nombre, apellido, dni, tipo, imprimir });
            dataGridView1.Location = new Point(84, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(639, 170);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // id_cliente
            // 
            id_cliente.Frozen = true;
            id_cliente.HeaderText = "id";
            id_cliente.Name = "id_cliente";
            id_cliente.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.Frozen = true;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.Frozen = true;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // dni
            // 
            dni.Frozen = true;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // tipo
            // 
            tipo.Frozen = true;
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            // 
            // imprimir
            // 
            imprimir.Frozen = true;
            imprimir.HeaderText = "Imprimir";
            imprimir.Name = "imprimir";
            imprimir.ReadOnly = true;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            conexionBindingSource.CurrentChanged += conexionBindingSource_CurrentChanged;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(88, 315);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarCliente);
            Controls.Add(lblClientes);
            Name = "FormClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClientes;
        private Button btnAgregarCliente;
        private DataGridView dataGridView1;
        private BindingSource conexionBindingSource;
        private DataGridViewTextBoxColumn id_cliente;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn imprimir;
        private Button btnVolver;
    }
}