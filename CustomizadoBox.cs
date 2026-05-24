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

        public CustomizadoBox(Pet petAtual)
        {
            InitializeComponent();
            this.petAtual = petAtual;

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            CadastroPet tela = new CadastroPet(petAtual.Usuario);

            tela.ShowDialog();

            this.Close();
        }


        private void btnNovoAgendamento_Click(object sender, EventArgs e)
        {
            Agendamento_de_Serviços ads =new Agendamento_de_Serviços(petAtual);

            ads.Show();

            this.Close();
        }


        private void btnVerAgendamentos_Click(object sender, EventArgs e)
        {
            AgendamentosPet tela = new AgendamentosPet(petAtual);

            tela.Show();

            this.Close();
        }
    }
}
