using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class TelaManterFornecedor : Form
    {
        public static int? idFornecedor = null;

        public TelaManterFornecedor()
        {
            InitializeComponent();
            idFornecedor = telaCadastroFornecedor.idFornecedor;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                if (idFornecedor == null)
                {
                    SqlCommand incluir = conexao.IncluirFornecedor(txtNome.Text,
                                                                   txtEndereco.Text,
                                                                   txtTelefone.Text,
                                                                   txtCnpj.Text);
                }
                else
                {
                    SqlCommand alterar = conexao.AlterarFornecedor(idFornecedor.GetValueOrDefault(),
                                                                   txtNome.Text,
                                                                   txtEndereco.Text,
                                                                   txtTelefone.Text,
                                                                   txtCnpj.Text);
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void TelaManterFornecedor_Load(object sender, EventArgs e)
        {
            if (idFornecedor != null)
            {
                try
                {
                    Conexao conexao = new Conexao();
                    SqlCommand fornecedor = conexao.BuscarFornecedor(idFornecedor.GetValueOrDefault());

                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = fornecedor;
                    DataSet tabela = new DataSet();
                    adaptador.Fill(tabela);

                    txtNome.Text = tabela.Tables[0].Rows[0]["Nome"].ToString();
                    txtEndereco.Text = tabela.Tables[0].Rows[0]["Endereco"].ToString();
                    txtTelefone.Text = tabela.Tables[0].Rows[0]["Telefone"].ToString();
                    txtCnpj.Text = tabela.Tables[0].Rows[0]["CNPJ"].ToString();                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}