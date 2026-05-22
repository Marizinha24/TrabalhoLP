namespace TrabalhoLP
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Nome = "Mari";
            string Senha = "123";
            if (txbNome.Text == Nome && txbSenha.Text == Senha)
            {
                HomePage hp = new HomePage();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalido");
            }
        }
    }
}
