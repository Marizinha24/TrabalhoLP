using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrabalhoLP.Properties.Model;

namespace TrabalhoLP
{
    public partial class CustomizadoBox : Form
    {

        private Pet petAtual;
        private HomePage home;

        public CustomizadoBox(Pet petAtual, HomePage home)
        {
            InitializeComponent();
            this.petAtual = petAtual;

            this.home = home;
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {

            home.AbrirTela(new CadastroPet(petAtual.Usuario, home));
            this.Close();

        }


        private void btnNovoAgendamento_Click(object sender, EventArgs e)
        {
            home.AbrirTela(new Agendamento_de_Serviços(petAtual, home));
            this.Close();
        }


        private void btnVerAgendamentos_Click(object sender, EventArgs e)
        {
            home.AbrirTela(new AgendamentosPet(petAtual, home));
            this.Close();
        }
    }
}
