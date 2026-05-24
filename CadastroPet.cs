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
    public partial class CadastroPet : Form
    {
        private Usuario usuarioAtual;

        public CadastroPet(Usuario usuario)
        {
            InitializeComponent();

            usuarioAtual = usuario;

            if (usuarioAtual != null)
            {
                txtNomeTutor.Text = usuarioAtual.Nome;
            }

        }





        private async void btnEntrar_Click(object sender, EventArgs e)
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
                Pet pet = new Pet();

                pet.Nome = txtNomePet.Text;

                pet.Especie = cbEspecie.Text;

                pet.Raca = cbRacas.Text;


                // FK
                pet.Usuario_ID = usuarioAtual.Usuario_ID;

                pet.Usuario = usuarioAtual;


                // IMAGEM
                if (pet.Especie == "Cachorro")
                {
                    Cachorro dog = new Cachorro();

                    pet.ImagemURL = await dog.GetImagemPorRaca(pet.Raca);
                }

                else
                {
                    Gato gato = new Gato();

                    pet.ImagemURL = await gato.GetImagemPorRaca(pet.Raca);
                }



                pet.InsertPet(pet);


                // MESSAGE BOX
                DialogResult resposta =
                MessageBox.Show(
                    "Cadastro realizado com sucesso!\nDeseja cadastrar um novo pet?",
                    "Cadastro",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );


                // NOVO PET
                if (resposta == DialogResult.Yes)
                {
                    CadastroPet tela =
                        new CadastroPet(usuarioAtual);

                    tela.ShowDialog();

                    this.Close();
                }


                // HOME
                else if (resposta == DialogResult.No)
                {
                    HomePage tela =
                        new HomePage();

                    tela.ShowDialog();

                    this.Close();
                }
            }

            else
            {
                MessageBox.Show(
                    "Ops! Não foi possível realizar o cadastro. Todos os campos devem ser preenchidos antes de continuar!");
            }
        }



        private async void cbRacas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRacas.SelectedItem == null)
                    return;

                string raca = cbRacas.SelectedItem.ToString();

                string imagem = "";


                // CACHORRO
                if (cbEspecie.Text == "Cachorro")
                {
                    Cachorro api =
                        new Cachorro();

                    imagem = await api.GetImagemPorRaca(raca);
                }


                // GATO
                else if (cbEspecie.Text == "Gato")
                {
                    Gato api = new Gato();

                    imagem = await api.GetImagemPorRaca(raca);
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

        private async void cbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRacas.DataSource = null;

            // CACHORRO
            if (cbEspecie.Text == "Cachorro")
            {
                Cachorro api = new Cachorro();

                List<string> racas = await api.GetRacas();

                cbRacas.DataSource = racas;
                cbRacas.SelectedIndex = -1;
            }

            // GATO
            else if (cbEspecie.Text == "Gato")
            {
                Gato api = new Gato();

                List<string> racas = await api.GetRacas();

                cbRacas.DataSource = racas;
                cbRacas.SelectedIndex = -1;
            }
        }
    }
}
