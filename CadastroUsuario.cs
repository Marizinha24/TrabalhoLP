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
    public partial class CadastroUsuario : Form
    {
        Endereco endereco = new Endereco();
        public bool isUpdate = false;

        private HomePage home;

        public CadastroUsuario(HomePage homePage)
        {
            InitializeComponent();
            this.home = home;

            tbxNumero.TextChanged += TbNumero_TextChanged;
            tbxComplemento.TextChanged += TbComplemento_TextChanged;
        }




        private void btnEntrar_Click(object sender, EventArgs e)
        {


            string[] dados = { txtNomeTutor.Text, txtCPF.Text, txtEndereco.Text, txtTelefone.Text, txtEmail.Text };

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
                Usuario usuario = new Usuario();

                usuario.Nome = txtNomeTutor.Text;

                usuario.CPF = txtCPF.Text;

                usuario.Telefone = txtTelefone.Text;

                usuario.Email = txtEmail.Text;

                usuario.Endereco = txtEndereco.Text;


                // salva no banco
                int idGerado =
                    usuario.InsertUsuario(usuario);


                // guarda ID no objeto
                usuario.Usuario_ID = idGerado;

                MessageBox.Show("Cadastro realizado com sucesso!");

                home.AbrirTela(new CadastroPet(usuario, home));



            }
            else
            {
                MessageBox.Show("Ops! Não foi possível realizar o cadastro. Todos os campos devem ser preenchidos antes de continuar!");
            }
        }



        private void TbNumero_TextChanged(object sender, EventArgs e)
        {
            MontarEndereco();
        }

        private void TbComplemento_TextChanged(object sender, EventArgs e)
        {
            MontarEndereco();
        }


        private async void btnEndereco_Click(object sender, EventArgs e)
        {

            endereco = await endereco.getEndereco(tbxCEP.Text);

            MontarEndereco();

        }

        private void MontarEndereco()
        {
            txtEndereco.Text =
            endereco.Logradouro + " ," +
            tbxNumero.Text + " " +
            tbxComplemento.Text + " - " +
            endereco.Bairro + " - " +
            endereco.Cidade + " - " +
            endereco.UF;
        }

       

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {

            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }

    }
    
}
