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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form formClientes = new FormClientes();
            formClientes.Show();
            this.Close();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente", "Próximamente");

        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente", "Próximamente");

        }

        private void btnCuotaSocios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente", "Próximamente");

        }

        private void btnAbonoActividad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente", "Próximamente");

        }

        private void btnReporteDiario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Próximamente", "Próximamente");

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
