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
    public partial class UsuarioPet : Form
    {
        public UsuarioPet()
        {
            InitializeComponent();
        }
        private List<Usuario> usuarios =
        new List<Usuario>();


        private void FormUsuariosPets_Load( object sender, EventArgs e)
        {
            lvUsuariosPets.View = View.Details;

            lvUsuariosPets.FullRowSelect = true;

            lvUsuariosPets.GridLines = true;

            lvUsuariosPets.MultiSelect = false;

            lvUsuariosPets.Columns.Add("Usuário", 150);

            lvUsuariosPets.Columns.Add("Pet", 120);

            lvUsuariosPets.Columns.Add("Espécie", 100);

            lvUsuariosPets.Columns.Add("Raça", 150);
        }


        private void CarregarPets(
           List<Usuario> usuariosLista)
        {
            lvUsuariosPets.Items.Clear();

            foreach (Usuario usuario in usuariosLista)
            {
                foreach (Pet pet in usuario.Pets)
                {
                    ListViewItem item =
                        new ListViewItem(usuario.Nome);

                    item.SubItems.Add(pet.Nome);

                    item.SubItems.Add(pet.Especie);

                    item.SubItems.Add(pet.Raca);

                    item.Tag = pet;

                    lvUsuariosPets.Items.Add(item);
                }
            }
        }

        private void lvUsuariosPets_DoubleClick(object sender, EventArgs e)
        {
            if (lvUsuariosPets.SelectedItems.Count > 0)
            {
                Pet pet =
                    (Pet)lvUsuariosPets
                    .SelectedItems[0]
                    .Tag;

                Agendamento_de_Serviços tela =
                    new Agendamento_de_Serviços(pet);

                tela.ShowDialog();
            }

        }
    } 
}
