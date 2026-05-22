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


            }
            else
            {
                MessageBox.Show("Ops! Não foi possível realizar o cadastro. Todos os campos devem ser preenchidos antes de continuar!");
            }
        }

        public async void cbespecie_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbRacas.DataSource = null;

            // CACHORRO
            if (cbEspecie.Text == "Cachorro")
            {
                Cachorro api =
                    new Cachorro();

                List<string> racas =
                    await api.GetRacas();

                cbRacas.DataSource = racas;
            }

            // GATO
            else if (cbEspecie.Text == "Gato")
            {
                Gato api =
                    new Gato();

                List<string> racas =
                    await api.GetRacas();

                cbRacas.DataSource = racas;
            }

        }

        private async void UsuarioPet_Load(object sender, EventArgs e)
        {
            Cachorro apic = new Cachorro();

            List<string> racas = await apic.GetRacas();

            cbRacas.DataSource = racas;


            Gato apig = new Gato();

            string imagem =
                await apig.GetImagemPorRaca(cbRacas.Text);

            pbPet.Load(imagem);
        }

        private async void cbRacas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRacas.SelectedItem == null)
                    return;

                string raca =
                    cbRacas.SelectedItem.ToString();

                string imagem = "";


                // CACHORRO
                if (cbEspecie.Text == "Cachorro")
                {
                    Cachorro api =
                        new Cachorro();

                    imagem =
                        await api.GetImagemPorRaca(raca);
                }


                // GATO
                else if (cbEspecie.Text == "Gato")
                {
                    Gato api =
                        new Gato();

                    imagem =
                        await api.GetImagemPorRaca(raca);
                }


                if (!string.IsNullOrEmpty(imagem))
                {
                    pbPet.SizeMode =
                        PictureBoxSizeMode.Zoom;

                    pbPet.Load(imagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao carregar imagem: "
                    + ex.Message);
            }
        }
    }
}

