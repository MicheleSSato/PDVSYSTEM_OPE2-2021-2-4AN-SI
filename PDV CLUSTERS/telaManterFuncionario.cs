using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaManterFuncionario : Form
    {
        public static int? idFuncionario = null;

        public telaManterFuncionario()
        {
            InitializeComponent();
            idFuncionario = telaCadastroFuncionario.idFuncionario;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                var salario = txtSalario.Text;
                var commaPosition = salario.IndexOf(",", StringComparison.Ordinal);
                salario = commaPosition + 3 > salario.Length ? salario : salario.Substring(0, commaPosition + 3);

                Conexao conexao = new Conexao();
                if (idFuncionario == null)
                {
                    if (ExisteLogin(txtLogin.Text) == false && ExisteCodigoInterno(txtCodigoInterno.Text) == false)
                    {
                        SqlCommand incluir = conexao.IncluirFuncionario(txtNome.Text,
                                                                        txtLogin.Text,
                                                                        txtEndereco.Text,
                                                                        txtTelefone.Text,
                                                                        txtCpf.Text,
                                                                        txtRg.Text,
                                                                        txtCodigoInterno.Text,
                                                                        salario,
                                                                        cbxNivelAcesso.SelectedValue.ToString());
                    }
                    else
                    {
                        MessageBox.Show("O Login e/ou o Código Interno informados já foram vinculados a outro funcionário.", "Funcionário", MessageBoxButtons.OK);
                        return;

                    }
                }
                else
                {
                    SqlCommand alterar = conexao.AlterarFuncionario(idFuncionario.GetValueOrDefault(),
                                                                    txtNome.Text,
                                                                    txtLogin.Text,
                                                                    txtEndereco.Text,
                                                                    txtTelefone.Text,
                                                                    txtCpf.Text,
                                                                    txtRg.Text,
                                                                    txtCodigoInterno.Text,
                                                                    salario,
                                                                    cbxNivelAcesso.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void TelaManterFuncionario_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand nivelacesso = conexao.SelecionarNivelAcesso();
            SqlDataAdapter adapterNivelAcesso = new SqlDataAdapter(nivelacesso);
            DataTable tabelaNivelAcesso = new DataTable();
            adapterNivelAcesso.Fill(tabelaNivelAcesso);
            cbxNivelAcesso.DataSource = tabelaNivelAcesso;
            cbxNivelAcesso.ValueMember = "ID_ACESSO";
            cbxNivelAcesso.DisplayMember = "DESCRICAO";
            cbxNivelAcesso.SelectedItem = "";
            cbxNivelAcesso.SelectedIndex = -1;
            cbxNivelAcesso.Refresh();

            if (idFuncionario != null)
            {
                try
                {
                    SqlCommand funcionario = conexao.BuscarFuncionario(idFuncionario.GetValueOrDefault());
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = funcionario;
                    DataSet tabela = new DataSet();
                    adaptador.Fill(tabela);

                    txtNome.Text = tabela.Tables[0].Rows[0]["Nome"].ToString();
                    txtLogin.Text = tabela.Tables[0].Rows[0]["Login"].ToString();
                    txtEndereco.Text = tabela.Tables[0].Rows[0]["Endereco"].ToString();
                    txtTelefone.Text = tabela.Tables[0].Rows[0]["Telefone"].ToString();
                    txtCpf.Text = tabela.Tables[0].Rows[0]["CPF"].ToString();
                    txtRg.Text = tabela.Tables[0].Rows[0]["RG"].ToString();
                    txtCodigoInterno.Text = tabela.Tables[0].Rows[0]["COD_INTERNO"].ToString();
                    txtSalario.Text = tabela.Tables[0].Rows[0]["SALARIO"].ToString();
                    cbxNivelAcesso.SelectedValue = Convert.ToInt32(tabela.Tables[0].Rows[0]["NIVEL_ACESSO"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                txtLogin.Enabled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroVirgula(sender, e);
        }

        private void ValidarNumeroVirgula(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private bool ExisteLogin(string login)
        {
            var existeLogin = false;
            Conexao conexao = new Conexao();
            SqlCommand funcionario = conexao.SelecionarFuncionarioPorLogin(login);
            SqlDataAdapter adaptadorFuncionario = new SqlDataAdapter();
            adaptadorFuncionario.SelectCommand = funcionario;
            DataSet tabelaFuncionario = new DataSet();
            adaptadorFuncionario.Fill(tabelaFuncionario);

            if (tabelaFuncionario.Tables[0].Rows.Count > 0)
            {
                existeLogin = true;
            }

            return existeLogin;
        }

        private bool ExisteCodigoInterno(string codigoInterno)
        {
            var existeCodigoInterno = false;
            Conexao conexao = new Conexao();
            SqlCommand funcionario = conexao.SelecionarFuncionarioPorCodigoInterno(codigoInterno);
            SqlDataAdapter adaptadorFuncionario = new SqlDataAdapter();
            adaptadorFuncionario.SelectCommand = funcionario;
            DataSet tabelaFuncionario = new DataSet();
            adaptadorFuncionario.Fill(tabelaFuncionario);

            if (tabelaFuncionario.Tables[0].Rows.Count > 0)
            {
                existeCodigoInterno = true;
            }

            return existeCodigoInterno;
        }
    }
}