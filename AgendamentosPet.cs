using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrabalhoLP.Properties.Model;
using static TrabalhoLP.Properties.Model.Agendamento;

namespace TrabalhoLP
{
    public partial class AgendamentosPet : Form
    {
        private Pet petAtual;
        public AgendamentosPet(Pet pet)
        {
            InitializeComponent();

            petAtual = pet;

            CarregarTela();

        }

        private async void CarregarTela()
        {
            lblNomePet.Text = petAtual.Nome;

            lblUsuario.Text = petAtual.Usuario.Nome;

            lblRaca.Text = petAtual.Raca;

            lblEspecie.Text = petAtual.Especie;

            pbPet.SizeMode = PictureBoxSizeMode.Zoom;

            // SE NÃO TEM IMAGEM
            if (string.IsNullOrEmpty(petAtual.ImagemURL))
            {
                if (petAtual.Especie == "Cachorro")
                {
                    Cachorro dog = new Cachorro();

                    petAtual.ImagemURL = await dog.GetImagemPorRaca(petAtual.Raca);
                }
                else
                {
                    Gato gato = new Gato();

                    petAtual.ImagemURL = await gato.GetImagemPorRaca(petAtual.Raca);
                }
            }


            // CARREGA IMAGEM
            if (!string.IsNullOrEmpty(petAtual.ImagemURL))
            {
                pbPet.Load(petAtual.ImagemURL);
            }

            lvHistorico.View = View.Details;

            lvHistorico.FullRowSelect = true;

            lvHistorico.GridLines = true;

            lvHistorico.Columns.Add("Data", 100);

            lvHistorico.Columns.Add("Horário", 100);

            lvHistorico.Columns.Add("Serviço", 180);

            lvHistorico.Columns.Add("Valor", 100);

            lvHistorico.Columns.Add("Status", 120);


            foreach (Agendamento agendamento
                in petAtual.Agendamentos)
            {
                ListViewItem item =
                    new ListViewItem(agendamento.Data?.ToString("dd/MM/yyyy"));

                item.SubItems.Add(agendamento.Horario);

                item.SubItems.Add(agendamento.Servicos);

                item.SubItems.Add($"R$ {agendamento.Total:F2}");

                item.SubItems.Add(agendamento.Status.ToString());


                if (agendamento.Status == StatusAgendamento.Cancelado)
                {
                    item.BackColor = Color.LightCoral;
                }

                else if (agendamento.Status == StatusAgendamento.Concluido)
                {
                    item.BackColor = Color.LightGreen;
                }

                else
                {
                    item.BackColor = Color.LightYellow;
                }

                lvHistorico.Items.Add(item);
            }
        }
        private void lvHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Agendamento agendamento
             in petAtual.Agendamentos)
            {
                ListViewItem item = new ListViewItem(
                        agendamento.Data?.ToString("dd/MM/yyyy"));

                item.SubItems.Add(agendamento.Horario);

                item.SubItems.Add(agendamento.Servicos);

                item.SubItems.Add($"R$ {agendamento.Total:F2}");

                item.SubItems.Add(agendamento.Status.ToString());


                // CORES

                if (agendamento.Status == StatusAgendamento.Cancelado)
                {
                    item.BackColor = Color.LightCoral;
                }

                else if (agendamento.Status == StatusAgendamento.Concluido)
                {
                    item.BackColor =
                        Color.LightGreen;
                }

                else if (agendamento.Status == StatusAgendamento.Pendente)
                {
                    item.BackColor = Color.LightYellow;
                }


                lvHistorico.Items.Add(item);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }
    }
}
