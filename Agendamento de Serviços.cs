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
    public partial class Agendamento_de_Serviços : Form
    {
        private Pet petAtual;

        public Agendamento_de_Serviços(Pet pet)
        {
            InitializeComponent();

            rdbSimples.Tag = 30;
            rdbHidratacao.Tag = 55;
            rdbHigienica.Tag = 35;
            rdbUnhas.Tag = 15;
            rdbCompleto.Tag = 60;

            rdbBanhoTosa.Tag = 80;
            rdbBanhoHidratacaoUnha.Tag = 75;

            petAtual = pet;

            foreach (var rb in this.Controls.OfType<GroupBox>().SelectMany(g => g.Controls.OfType<RadioButton>()))
            {
                rb.CheckedChanged += AtualizarTotal;
            }
        }

        private void AtualizarTotal(object sender, EventArgs e)
        {
            double total = this.Controls.OfType<GroupBox>().SelectMany(g => g.Controls.OfType<RadioButton>()).Where(rb => rb.Checked).Sum(rb => Convert.ToDouble(rb.Tag));

            lblTotal.Text = $"Total: R$ {total:F2}";
        }


        private (string nomes, double total)
            ObterServicoSelecionado()
        {
            var selecionados = this.Controls.OfType<GroupBox>().SelectMany(g =>g.Controls.OfType<RadioButton>()).Where(rb => rb.Checked).ToList();

            if (!selecionados.Any())
            {
                throw new InvalidOperationException("Nenhum serviço selecionado");
            }

            string nomes =string.Join(", ",selecionados.Select(rb => rb.Text));

            double total =selecionados.Sum(rb =>Convert.ToDouble(rb.Tag));

            return (nomes, total);
        }


        private void btnConfirmar_Click_1(object sender,EventArgs e)
        {
            try
            {
                var servico =
                    ObterServicoSelecionado();

                var itemSelecionado = cbHorario.SelectedItem as string;

                if (string.IsNullOrEmpty(itemSelecionado))
                {
                    MessageBox.Show( "Selecione um horário!");

                    return;
                }


                Agendamento agendamento = new Agendamento();

                agendamento.Pet = petAtual;

                agendamento.Data =  dtDisponibilidade.Value;

                agendamento.Horario = cbHorario.Text;

                agendamento.Servicos = servico.nomes;

                agendamento.Total = servico.total;

                agendamento.Status =StatusAgendamento.Pendente;

                if (petAtual == null)
                {
                    MessageBox.Show("Pet está nulo!");
                    return;
                }


                DialogResult resposta = MessageBox.Show( agendamento.GerarResumo(),"Confirmar Agendamento",  MessageBoxButtons.YesNo,MessageBoxIcon.Question  );

                if (resposta != DialogResult.Yes)
                {
                    return;
                }


                agendamento.InsertAgendamento(agendamento);

                petAtual.Agendamentos.Add(agendamento);



                MessageBox.Show("Agendamento realizado!");
                HomePage hp = new HomePage();
                hp.Show();
                this.Hide();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dtDisponibilidade_ValueChanged_1(object sender,EventArgs e)
        {
            cbHorario.Items.Clear();

            if (dtDisponibilidade.Value.Date
                < DateTime.Now.Date)
            {
                MessageBox.Show(
                    "Escolha uma data valida!");

                return;
            }

            switch (dtDisponibilidade.Value.DayOfWeek)
            {
                case DayOfWeek.Monday:

                    cbHorario.Items.Add("08:00");
                    cbHorario.Items.Add("10:30");
                    cbHorario.Items.Add("12:00");
                    cbHorario.Items.Add("14:30");

                    break;

                case DayOfWeek.Tuesday:

                    cbHorario.Items.Add("08:30");
                    cbHorario.Items.Add("11:00");
                    cbHorario.Items.Add("16:00");
                    cbHorario.Items.Add("17:30");
                    cbHorario.Items.Add("18:00");

                    break;

                case DayOfWeek.Wednesday:

                    cbHorario.Items.Add("10:00");
                    cbHorario.Items.Add("13:30");
                    cbHorario.Items.Add("15:00");
                    cbHorario.Items.Add("17:00");

                    break;

                case DayOfWeek.Thursday:

                    cbHorario.Items.Add("09:00");
                    cbHorario.Items.Add("14:30");
                    cbHorario.Items.Add("17:00");
                    cbHorario.Items.Add("17:30");

                    break;

                case DayOfWeek.Friday:

                    cbHorario.Items.Add("11:00");
                    cbHorario.Items.Add("15:30");
                    cbHorario.Items.Add("16:30");
                    cbHorario.Items.Add("17:30");

                    break;

                case DayOfWeek.Saturday:

                    cbHorario.Items.Add("08:30");
                    cbHorario.Items.Add("10:00");
                    cbHorario.Items.Add("11:30");

                    break;

                case DayOfWeek.Sunday:

                    cbHorario.Items.Add("09:30");
                    cbHorario.Items.Add("12:30");

                    break;
            }
        }


        private void btnCancelar_Click_1(object sender,EventArgs e)
        {
            foreach (var group in this.Controls.OfType<GroupBox>())
            {
                foreach (var rb in group.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
            }

            cbHorario.SelectedIndex = -1;

            dtDisponibilidade.Value =DateTime.Now;

            lblTotal.Text = "Total: R$ 0,00";
        }
    }
}