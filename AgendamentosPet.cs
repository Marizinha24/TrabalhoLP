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

        private HomePage home;

        public AgendamentosPet(Pet pet, HomePage home)
        {
            InitializeComponent();

            petAtual = pet;

            this.home = home;

            CarregarTela();
        }


        // =========================
        // CARREGA TELA
        // =========================

        private async void CarregarTela()
        {
            // LABELS

            lblNomePet.Text = petAtual.Nome;

            lblUsuario.Text = petAtual.Usuario.Nome;

            lblRaca.Text = petAtual.Raca;

            lblEspecie.Text = petAtual.Especie;


            // IMAGEM

            pbPet.SizeMode = PictureBoxSizeMode.Zoom;

            // SE NÃO TEM IMAGEM
            if (string.IsNullOrEmpty(petAtual.ImagemURL))
            {
                if (petAtual.Especie == "Cachorro")
                {
                    Cachorro dog = new Cachorro();

                    petAtual.ImagemURL =
                        await dog.GetImagemPorRaca( petAtual.Raca);
                }
                else
                {
                    Gato gato = new Gato();

                    petAtual.ImagemURL = await gato.GetImagemPorRaca(  petAtual.Raca);
                }
            }

            // CARREGA IMAGEM
            if (!string.IsNullOrEmpty(petAtual.ImagemURL))
            {
                pbPet.Load(petAtual.ImagemURL);
            }


            // LISTVIEW

            ConfigurarListView();

            CarregarLista();
        }


        // =========================
        // CONFIGURA LISTVIEW
        // =========================

        private void ConfigurarListView()
        {
            lvHistorico.View = View.Details;

            lvHistorico.FullRowSelect = true;

            lvHistorico.GridLines = true;

            lvHistorico.MultiSelect = false;

            // LIMPA COLUNAS
            lvHistorico.Columns.Clear();

            // COLUNAS
            lvHistorico.Columns.Add("Data", 100);

            lvHistorico.Columns.Add("Horário", 100);

            lvHistorico.Columns.Add("Serviço", 180);

            lvHistorico.Columns.Add("Valor", 100);

            lvHistorico.Columns.Add("Status", 120);
        }


        // =========================
        // CARREGA ITENS
        // =========================

        private void CarregarLista()
        {
            // LIMPA ITENS
            lvHistorico.Items.Clear();

            foreach (Agendamento agendamento in petAtual.Agendamentos)
            {
                ListViewItem item = new ListViewItem( agendamento.Data?.ToString("dd/MM/yyyy"));

                // GUARDA OBJETO
                item.Tag = agendamento;

                // SUBITENS
                item.SubItems.Add(agendamento.Horario);

                item.SubItems.Add(agendamento.Servicos);

                item.SubItems.Add($"R$ {agendamento.Total:F2}");

                item.SubItems.Add(agendamento.Status.ToString());


                // CORES

                if (agendamento.Status== Agendamento.StatusAgendamento.Cancelado)
                {
                    item.BackColor =Color.LightCoral;
                }

                else if (agendamento.Status == Agendamento.StatusAgendamento.Concluido)
                {
                    item.BackColor = Color.LightGreen;
                }

                else
                {
                    item.BackColor = Color.LightYellow;
                }

                // ADICIONA ITEM
                lvHistorico.Items.Add(item);
            }
        }


        // =========================
        // BOTÃO CANCELAR
        // =========================

        private void btnCancelar_Click(object sender, EventArgs e)
        {


            // VERIFICA SE TEM ITEM
            {
                // VERIFICA SE TEM ITEM
                if (lvHistorico.SelectedItems.Count == 0)
                {
                    MessageBox.Show(
                        "Selecione um agendamento.");

                    return;
                }

                // PEGA ITEM
                ListViewItem item =
                    lvHistorico.SelectedItems[0];

                // PEGA AGENDAMENTO
                Agendamento agendamento =
                    (Agendamento)item.Tag;


                // CONFIRMAÇÃO
                DialogResult resposta =
                    MessageBox.Show( "Deseja cancelar este agendamento?\n\n"+ agendamento.GerarResumo(), "Confirmar Cancelamento", MessageBoxButtons.YesNo,MessageBoxIcon.Question);


                // SE CLICAR NÃO
                if (resposta != DialogResult.Yes)
                {
                    return;
                }


                // ALTERA STATUS
                agendamento.Status =
                    Agendamento.StatusAgendamento.Cancelado;

                // ATUALIZA BANCO
                agendamento.UpdateAgendamento( agendamento);

                // RECARREGA LISTA
                CarregarLista();

                MessageBox.Show(  "Agendamento cancelado!");
            }
        }


        // =========================
        // BOTÃO CONCLUÍDO
        // =========================

        private void btnConcluido_Click( object sender, EventArgs e)
        {
            // VERIFICA SE TEM ITEM
            // VERIFICA SE TEM ITEM
            if (lvHistorico.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Selecione um agendamento.");

                return;
            }

            // PEGA ITEM
            ListViewItem item =
                lvHistorico.SelectedItems[0];

            // PEGA AGENDAMENTO
            Agendamento agendamento =
                (Agendamento)item.Tag;


            // CONFIRMAÇÃO
            DialogResult resposta =
                MessageBox.Show( "Deseja concluir este agendamento?\n\n" + agendamento.GerarResumo(),"Confirmar Conclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            // SE CLICAR NÃO
            if (resposta != DialogResult.Yes)
            {
                return;
            }


            // ALTERA STATUS
            agendamento.Status = Agendamento.StatusAgendamento.Concluido;

            // ATUALIZA BANCO
            agendamento.UpdateAgendamento(agendamento);

            // RECARREGA LISTA
            CarregarLista();

            MessageBox.Show("Agendamento concluído!");
        }





        // =========================
        // EVENTO LISTVIEW
        // =========================

        private void lvHistorico_SelectedIndexChanged( object sender,  EventArgs e)
        {

        }
    }

}
