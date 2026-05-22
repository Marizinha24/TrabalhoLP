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
        private List<Usuario> usuarios =
            new List<Usuario>();


        public UsuarioPet()
        {
            InitializeComponent();

            //teste depois que colocar o sql tira ******************************

            lvUsuariosPets.View = View.Details;

            lvUsuariosPets.FullRowSelect = true;

            lvUsuariosPets.GridLines = true;

            lvUsuariosPets.MultiSelect = false;

            lvUsuariosPets.Columns.Add("Usuário", 150);

            lvUsuariosPets.Columns.Add("Pet", 120);

            lvUsuariosPets.Columns.Add("Espécie", 100);

            lvUsuariosPets.Columns.Add("Raça", 150);


            CriarDadosTeste();

            CarregarPets(usuarios);
        }


        private void CriarDadosTeste()
        {

            Usuario usuario1 =
                new Usuario();

            usuario1.Nome = "Laura";


            Pet pet1 =
                new Pet();

            pet1.Nome = "Thor";

            pet1.Especie = "Cachorro";

            pet1.Raca = "Labrador";

            pet1.Usuario = usuario1;


            Agendamento ag1 =
                new Agendamento();

            ag1.Pet = pet1;

            ag1.Data = DateTime.Now;

            ag1.Horario = "14:00";

            ag1.Servicos = "Banho";

            ag1.Total = 30;

            ag1.Status =
                StatusAgendamento.Pendente;


            pet1.Agendamentos.Add(ag1);

            usuario1.Pets.Add(pet1);


            Pet pet2 =
                new Pet();

            pet2.Nome = "Mimi";

            pet2.Especie = "Gato";

            pet2.Raca = "Siamese";

            pet2.Usuario = usuario1;


            Agendamento ag2 =
                new Agendamento();

            ag2.Pet = pet2;

            ag2.Data =
                DateTime.Now.AddDays(1);

            ag2.Horario = "10:30";

            ag2.Servicos = "Tosa";

            ag2.Total = 60;

            ag2.Status =
                StatusAgendamento.Concluido;


            pet2.Agendamentos.Add(ag2);

            usuario1.Pets.Add(pet2);


            usuarios.Add(usuario1);

            // termina aqui o teste *************************
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
            if (lvUsuariosPets.SelectedItems.Count == 0)
            {
                return;
            }

            Pet pet =
                (Pet)lvUsuariosPets
                .SelectedItems[0]
                .Tag;


            DialogResult resposta =
                MessageBox.Show(
                    "Sim = Novo Agendamento\n" +
                    "Não = Ver Agendamentos",
                    "Escolha uma opção",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );


            // NOVO AGENDAMENTO
            if (resposta == DialogResult.Yes)
            {
                Agendamento_de_Serviços tela =
                    new Agendamento_de_Serviços(pet);

                tela.ShowDialog();
            }


            // VER AGENDAMENTOS
            else if (resposta == DialogResult.No)
            {
                AgendamentosPet tela = new AgendamentosPet(pet);

                tela.ShowDialog();
            }
        }
    }
}
