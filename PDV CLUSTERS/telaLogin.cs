using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Os campos de Nova senha estão diferentes", "Login", MessageBoxButtons.OK);
                return;
            }
            else
            {
                var senha = CriarHash(txtNovaSenha.Text);
                Conexao conexao = new Conexao();
                SqlCommand funcionario = conexao.AlterarSenhaFuncionario(txtLogin.Text, senha);

                MessageBox.Show("Senha alterada com sucesso", "Login", MessageBoxButtons.OK);
                return;
            }
        }

        public string CriarHash(string texto)
        {
            var md5 = MD5.Create();

            byte[] bytes = Encoding.ASCII.GetBytes(texto);
            byte[] hash = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Preencha o campo Login", "Login", MessageBoxButtons.OK);
                return;
            }

            Conexao conexao = new Conexao();
            SqlCommand funcionario = conexao.SelecionarFuncionarioPorLogin(txtLogin.Text);
            SqlDataAdapter adaptadorFuncionario = new SqlDataAdapter();
            adaptadorFuncionario.SelectCommand = funcionario;
            DataSet tabelaFuncionario = new DataSet();
            adaptadorFuncionario.Fill(tabelaFuncionario);

            if (tabelaFuncionario.Tables[0].Rows.Count == 1)
            {
                var senhaHash = CriarHash(txtSenha.Text);
                var senha = tabelaFuncionario.Tables[0].Rows[0]["SENHA"].ToString();

                if (tabelaFuncionario.Tables[0].Rows[0]["SENHA"].ToString() == "")
                {
                    MessageBox.Show("Bem vindo ao seu primeiro acesso. Altere sua senha.", "Login", MessageBoxButtons.OK);

                    txtNovaSenha.Visible = true;
                    txtConfirmarSenha.Visible = true;
                    btSalvar.Visible = true;
                    groupBoxCadastrar.Visible = true;
                    lblNovaSenha.Visible = true;
                    lbConfirmarSenha.Visible = true;
                    return;
                }

                if (senhaHash != senha)
                {
                    MessageBox.Show("Senha inválida", "Login", MessageBoxButtons.OK);
                    return;
                }

                Sessao.Login = txtLogin.Text;

                Close();
            }
            else
            {
                MessageBox.Show("Login não encontrato", "Login", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
