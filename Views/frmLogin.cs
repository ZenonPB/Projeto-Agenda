namespace ProjetoAgenda
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            // checa se o tamanho do usuario e senha � maior que o estipulado e habilita o bot�o caso verdadeiro
            if (tbxUsuario.TextLength > 0 && tbxSenha.TextLength >= 8)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();

        }

        private void tbxUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }
    }
}
