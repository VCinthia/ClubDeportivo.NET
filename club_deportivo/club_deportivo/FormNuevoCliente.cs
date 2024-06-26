using MySql.Data.MySqlClient;
using System.Data;

namespace club_deportivo
{
    public partial class FormNuevoCliente : Form
    {
        private MySqlConnection connection;

        public FormNuevoCliente()
        {
            InitializeComponent();
            string cadenaConexion = "Server=localhost;Database=club_deportivo;Uid=root;Pwd='';";
            connection = new MySqlConnection(cadenaConexion);
        }

        public void CrearCliente(Cliente cliente, Persona persona) //TODO: Ver insert en la tabla Cliente heredado
        {

            string? salida;

            try
            {
                connection.Open();

                // Insertar la persona
                //string insertPersonaQuery = "INSERT INTO Personas (nombre, apellido, dni) VALUES (@Nombre, @Apellido, @DNI)";

                //MySqlCommand comando = new MySqlCommand("NuevaPersona",connection);

                using (MySqlCommand comando = new MySqlCommand("NuevaPersona", connection))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@Nom", persona.Nombre);
                    comando.Parameters.AddWithValue("@Ape", persona.Apellido);
                    comando.Parameters.AddWithValue("@Dni", persona.DNI);
                    
                    MySqlParameter ParCodigo = new MySqlParameter();
                    ParCodigo.ParameterName = "rta";
                    ParCodigo.MySqlDbType = MySqlDbType.Int32;
                    ParCodigo.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(ParCodigo);
                    comando.ExecuteNonQuery();
                    salida = Convert.ToString(ParCodigo.Value);

                }

                // Obtener el último IDPersona insertado
                //string selectLastIdQuery = "SELECT LAST_INSERT_ID()";
                //using (MySqlCommand cmdLastId = new MySqlCommand(selectLastIdQuery, connection))
                //{
                //    int idPersona = Convert.ToInt32(cmdLastId.ExecuteScalar());

                //    // Insertar el cliente vinculado a la persona
                //    string insertClienteQuery = "INSERT INTO Clientes (id_persona, es_socio, apto_fisico) VALUES (@IdPersona, @EsSocio, @AptoFisico)";
                //    using (MySqlCommand cmdCliente = new MySqlCommand(insertClienteQuery, connection))
                //    {
                //        cmdCliente.Parameters.AddWithValue("@IdPersona", idPersona);
                //        cmdCliente.Parameters.AddWithValue("@EsSocio", cliente.EsSocio);
                //        cmdCliente.Parameters.AddWithValue("@AptoFisico", cliente.AptoFisico);

                //        cmdCliente.ExecuteNonQuery();
                //    }
                //}

                MessageBox.Show("El cliente ha sido registrado correctamente");
                Form formPrincipal = new FormPrincipal();
                formPrincipal.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "nombre")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "nombre";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "apellido")
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "apellido";
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "00000000")
            {
                txtDni.Text = "";
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "00000000";
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancelar la entrada del carácter
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores desde los controles
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int dni = int.Parse(txtDni.Text);
            bool esSocio = cboTipo.SelectedIndex == 0; // Si el índice 0 está seleccionado, esSocio es verdadero
            bool aptoFisico = btnAptoMedico.Text == "Archivo Subido";

            // Crear instancias de Persona y Cliente
            Persona nuevaPersona = new Persona(nombre, apellido, dni);
            Cliente nuevoCliente = new Cliente(nombre, apellido, dni, esSocio, aptoFisico);

            // Llamar a la función para crear Cliente y Persona
            
            CrearCliente(nuevoCliente, nuevaPersona);
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAptoMedico_Click(object sender, EventArgs e)
        {
            if (btnAptoMedico.Text == "Subir Archivo")
            {
                MessageBox.Show("La carga ha sido satisfactoria");
                btnAptoMedico.Text = "Archivo Subido";
            }

        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            Form formClientes = new FormClientes();
            formClientes.Show();
            this.Close();
        }
    }
}
