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
    public partial class UsuarioPet : Form
    {
        private List<Usuario> usuarios = new List<Usuario>();


        public UsuarioPet()
        {
            InitializeComponent();

            lvUsuariosPets.View = View.Details;

            lvUsuariosPets.FullRowSelect = true;

            lvUsuariosPets.GridLines = true;

            lvUsuariosPets.MultiSelect = false;

            lvUsuariosPets.Columns.Add("Usuário", 150);

            lvUsuariosPets.Columns.Add("Pet", 120);

            lvUsuariosPets.Columns.Add("Espécie", 100);

            lvUsuariosPets.Columns.Add("Raça", 150);


            CarregarPetsBanco();

        }


        private void CarregarPetsBanco()
        {
            lvUsuariosPets.Items.Clear();

            Pet p = new Pet();

            List<Pet> lista = p.GetPets();

            foreach (Pet pet in lista)
            {
                ListViewItem item = new ListViewItem(pet.Usuario.Nome);

                item.SubItems.Add(pet.Nome);

                item.SubItems.Add(pet.Especie);

                item.SubItems.Add(pet.Raca);

                item.Tag = pet;

                lvUsuariosPets.Items.Add(item);
            }
        }





        private void lvUsuariosPets_DoubleClick(object sender, EventArgs e)
        {
            if (lvUsuariosPets.SelectedItems.Count == 0)
            {
                return;
            }


            Pet pet = (Pet)lvUsuariosPets.SelectedItems[0].Tag;


            CustomizadoBox tela = new CustomizadoBox(pet);

            tela.ShowDialog();
            this.Close();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {


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

        }


    }
}