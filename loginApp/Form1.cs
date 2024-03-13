namespace loginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            string senha, login;

            senha = senhaInserir.Text;
            login = loginInserir.Text;

            if (login == "admin" && senha == "ra2357040")
            {
                resultadoText.Visible = true;
                resultadoText.Text = "Acesso liberado";
                bemvindoText.Visible = true;
            }
            else
            {
                resultadoText.Visible = true;
                resultadoText.Text = "Credenciais incorretas";
            }

        }

        private void verSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (verSenha.Checked == true)
            {
                senhaInserir.UseSystemPasswordChar = false;
            }
            else
            {
                senhaInserir.UseSystemPasswordChar = true;

            }
        }
    }
}
