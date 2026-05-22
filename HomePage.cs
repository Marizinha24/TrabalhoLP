using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoLP
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            PetCare pc = new PetCare();
            pc.Show();
            this.Hide();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            Agendamento_de_Serviços ads = new Agendamento_de_Serviços(null);
            ads.Show();
            this.Hide();

        }

        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioPet lu = new UsuarioPet();
            lu.Show();
            this.Hide();
        }
    }
}
