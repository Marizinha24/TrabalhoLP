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
    public partial class PetCare : Form
    {
        public PetCare()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string sexo = cmbSexo.Text;
            string castrado = cmbCastrado.Text;

            string[] dados = { txtNomeTutor.Text, txtNomePet.Text, sexo, castrado };

            int camposValidos = 0;

            for (int i = 0; i < dados.Length; i++)
            {
                if (dados[i] != "")
                {
                    camposValidos++;
                }
            }

            if (camposValidos == dados.Length)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");

                Agendamento_de_Serviços hp = new Agendamento_de_Serviços();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ops! Não foi possível realizar o cadastro. Todos os campos devem ser preenchidos antes de continuar!");
            }
        }

        public async void cbespecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbRacas.Items.Clear();

            if (cbEspecie.Text == "Cachorro")
            {
                Cachorro api = new Cachorro();

                List<string> racas = await api.GetRacas();

                cbRacas.Items.AddRange(racas.ToArray());
            }
            else if (cbEspecie.Text == "Gato")
            {
                Gato api = new Gato();

                List<string> racas = await api.GetRacas();

                cbRacas.Items.AddRange(racas.ToArray());
            
        }

    }
    }
}

