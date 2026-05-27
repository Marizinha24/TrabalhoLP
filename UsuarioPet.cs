using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrabalhoLP.Properties.DAO;
using TrabalhoLP.Properties.Model;
using static TrabalhoLP.Properties.Model.Agendamento;

namespace TrabalhoLP
{
    public partial class UsuarioPet : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private HomePage home;


        public UsuarioPet(HomePage home)
        {
            InitializeComponent();
            this.home = home;


            lvUsuariosPets.Clear();

            lvUsuariosPets.View = View.Details;

            lvUsuariosPets.FullRowSelect = true;

            lvUsuariosPets.GridLines = true;

            lvUsuariosPets.MultiSelect = false;

            // COLUNAS
            lvUsuariosPets.Columns.Add("Usuário", 150);
            lvUsuariosPets.Columns.Add("CPF", 120);
            lvUsuariosPets.Columns.Add("Telefone", 100);
            lvUsuariosPets.Columns.Add("Email", 100);
            lvUsuariosPets.Columns.Add("Endereco", 100);
            lvUsuariosPets.Columns.Add("Pet", 120);
            lvUsuariosPets.Columns.Add("Espécie", 100);
            lvUsuariosPets.Columns.Add("Raça", 150);
            lvUsuariosPets.Columns.Add("Serviço", 120);
            lvUsuariosPets.Columns.Add("Status", 100);
            lvUsuariosPets.Columns.Add("Data", 120);

            CarregarPetsBanco();

        }


        private void CarregarPetsBanco()
        {
            lvUsuariosPets.Items.Clear();

            // USUÁRIOS
            List<Usuario> usuarios = new Usuario().GetUsuarios();

            // PETS
            List<Pet> pets = new Pet().GetPets();

            // AGENDAMENTOS
            List<Agendamento> agendamentos = new Agendamento().GetAgendamentos();


            // RELACIONA PETS AOS USUÁRIOS
            foreach (Usuario usuario in usuarios)
            {
                usuario.Pets = pets.Where(p => p.Usuario_ID == usuario.Usuario_ID).ToList();
            }


            // RELACIONA AGENDAMENTOS AOS PETS
            foreach (Pet pet in pets)
            {
                pet.Agendamentos = agendamentos.Where(a => a.Pet_ID == pet.Pet_ID).ToList();
            }


            // LISTVIEW
            foreach (Usuario usuario in usuarios)
            {
                foreach (Pet pet in usuario.Pets)
                {
                    // PET SEM AGENDAMENTO
                    if (pet.Agendamentos.Count == 0)
                    {
                        ListViewItem item = new ListViewItem(usuario.Nome);

                        // USUÁRIO
                        item.SubItems.Add(usuario.CPF);
                        item.SubItems.Add(usuario.Telefone);
                        item.SubItems.Add(usuario.Email);
                        item.SubItems.Add(usuario.Endereco);

                        // PET
                        item.SubItems.Add(pet.Nome);
                        item.SubItems.Add(pet.Especie);
                        item.SubItems.Add(pet.Raca);

                        // AGENDAMENTO VAZIO
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        item.SubItems.Add("");

                        item.Tag = new Tuple<Usuario, Pet>(usuario, pet);
                        lvUsuariosPets.Items.Add(item);

                    }

                    // PET COM AGENDAMENTO
                    else
                    {
                        foreach (Agendamento ag in pet.Agendamentos)
                        {
                            ListViewItem item = new ListViewItem(usuario.Nome);

                            // USUÁRIO
                            item.SubItems.Add(usuario.CPF);
                            item.SubItems.Add(usuario.Telefone);
                            item.SubItems.Add(usuario.Email);
                            item.SubItems.Add(usuario.Endereco);

                            // PET
                            item.SubItems.Add(pet.Nome);
                            item.SubItems.Add(pet.Especie);
                            item.SubItems.Add(pet.Raca);

                            // AGENDAMENTO
                            item.SubItems.Add(ag.Servicos);
                            item.SubItems.Add(ag.Status.ToString());
                            item.SubItems.Add(
                                ag.Data?.ToShortDateString() ?? ""
                            );

                            item.Tag = new Tuple<Usuario, Pet>(usuario, pet);

                            lvUsuariosPets.Items.Add(item);



                        }
                    }
                }
            }
        }


        private void lvUsuariosPets_DoubleClick(object sender, EventArgs e)
        {
            if (lvUsuariosPets.SelectedItems.Count == 0)
            {
                return;
            }

            var dados = (Tuple<Usuario, Pet>)lvUsuariosPets.SelectedItems[0].Tag;

            Pet pet = dados.Item2;

            CustomizadoBox tela = new CustomizadoBox(pet, home);

            tela.ShowDialog();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivo CSV|*.csv";

            ofd.Title = "Importar arquivo csv";


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] linhasArquivo = File.ReadAllLines(ofd.FileName);


                foreach (string linha in linhasArquivo)
                {
                    // pula cabeçalho
                    if (!linha.Contains("Usuário"))
                    {
                        string[] colunas = linha.Split(';');


                        // USUARIO
                        Usuario usuario = new Usuario();

                        usuario.Nome = colunas[0];

                        usuario.CPF = colunas[1];

                        usuario.Telefone = colunas[2];

                        usuario.Email = colunas[3];

                        usuario.Endereco = colunas[4];


                        int idUsuario = usuario.InsertUsuario(usuario);

                        usuario.Usuario_ID = idUsuario;



                        // PET
                        if (colunas[5] != "")
                        {
                            Pet pet = new Pet();

                            pet.Nome = colunas[5];

                            pet.Especie = colunas[6];

                            pet.Raca = colunas[7];

                            pet.Usuario_ID =
                            usuario.Usuario_ID;

                            pet.InsertPet(pet);
                        }
                    }
                }


                CarregarPetsBanco();

                MessageBox.Show("Arquivo importado com sucesso!");
            }
        }



        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo CSV| *.csv";
            sfd.Title = "Salvar como csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {


                    for (int i = 0; i < lvUsuariosPets.Columns.Count; i++)
                    {
                        sw.Write(lvUsuariosPets.Columns[i].Text);

                        if (i < lvUsuariosPets.Columns.Count - 1)
                            sw.Write(';');
                    }
                    sw.WriteLine();

                    foreach (ListViewItem item in lvUsuariosPets.Items)
                    {
                        for (int i = 0; i < lvUsuariosPets.Columns.Count; i++)
                        {
                            string valor = (i == 0)
                                ? item.Text
                                : item.SubItems[i].Text;

                            sw.Write(valor);

                            if (i < lvUsuariosPets.Columns.Count - 1)
                                sw.Write(';');
                        }

                        sw.WriteLine();
                    }

                    MessageBox.Show("Arquivo salvo em" + sfd.FileName);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lvUsuariosPets.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um usuário.");
                return;
            }

            var dados = (Tuple<Usuario, Pet>)lvUsuariosPets.SelectedItems[0].Tag;

            Usuario usuario = dados.Item1;

            DialogResult resposta =
                MessageBox.Show($"Deseja deletar {usuario.Nome}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            usuario.DeleteUsuario(usuario.Usuario_ID);

            MessageBox.Show("Usuário removido!");

            CarregarPetsBanco();

        }

        private void btnHomePage_Click_1(object sender, EventArgs e)
        {
            home.LimparPanel();
        }
    }
}

