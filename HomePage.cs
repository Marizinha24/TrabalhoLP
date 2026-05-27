using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoLP
{
    public partial class HomePage : Form
    {

        private Form formAtivo = null;
        public HomePage()
        {
            InitializeComponent();

            pbGif.Image = Properties.Resources.processed;

            pbGif.SizeMode = PictureBoxSizeMode.Zoom;
        }


        public void AbrirTela(Form formTela)
        {
            if (formAtivo != null)
            {
                formPanel.Controls.Remove(formAtivo);

                formAtivo.Close();
            }
            formAtivo = formTela;

            formTela.TopLevel = false;
            formTela.Dock = DockStyle.Fill;
            formTela.FormBorderStyle = FormBorderStyle.None;

        
            formPanel.Controls.Add(formTela);
            formPanel.Tag = formTela;

            formTela.BringToFront();
            formTela.Show();
            pbGif.Visible = false;
        }
        public void LimparPanel()
        {
            if (formAtivo != null)
            {
                formPanel.Controls.Remove(formAtivo);

                formAtivo.Close();

                formAtivo = null;
            }

            
            pbGif.Visible = true;
            pbGif.BringToFront();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {

            AbrirTela(new CadastroUsuario(this));

        }



        private void btnListaUsuarios_Click(object sender, EventArgs e)
        {
            AbrirTela(new UsuarioPet(this));

        }
    }
}
