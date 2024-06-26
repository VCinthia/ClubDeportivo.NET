using club_deportivo.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace club_deportivo
{
    public partial class FormLogin : Form
    {
        private MySqlConnection conexion;

        public FormLogin()
        {
            InitializeComponent();
            string cadenaConexion = "Server=localhost;Database=club_deportivo;Uid=root;Pwd='';";
            conexion = new MySqlConnection(cadenaConexion);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                txtPass.UseSystemPasswordChar = false;
                btnMostrarPass.Text = "Ocultar";
            }
            else {
                txtPass.UseSystemPasswordChar = true;
                btnMostrarPass.Text = "Mostrar";
            }
        }

        private void btnAceptarIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text;
            string pass = txtPass.Text;
            if (Autenticar(usuario, pass))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                Form formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
            }

        }

        private bool Autenticar(string usuario, string pass)
        {
            try
            {
                conexion.Open();
                string consulta = "SELECT * FROM usuarios WHERE username = @usuario AND password = @pass";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@pass", pass);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    return true; // Las credenciales son correctas.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autenticar: " + ex.Message);

            }
            finally
            {
                conexion.Close();
            }

            return false; // Las credenciales son incorrectas.
        }
        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_Enter(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "usuario")
            {
                txtNombreUsuario.Text = "";
            }
        }

        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                txtNombreUsuario.Text = "usuario";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }



}
