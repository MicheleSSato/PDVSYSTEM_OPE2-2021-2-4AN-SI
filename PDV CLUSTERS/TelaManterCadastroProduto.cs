using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class TelaManterCadastroProduto : Form
    {
        public static int? idProduto = null;

        public TelaManterCadastroProduto()
        {
            InitializeComponent();
            idProduto = telaCadastroProduto.idProduto;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAlterarProduto_Click(object sender, EventArgs e)
        {
            TelaManterCadastroProduto manterCadastro = new TelaManterCadastroProduto();
            manterCadastro.ShowDialog();
        }

        private void btSalvarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();
                if (idProduto == null)
                {
                    SqlCommand incluir = conexao.IncluirProduto(textnome.Text,
                                                                textcodbarras.Text,
                                                                textcodinterno.Text,
                                                                textprecovenda.Text,
                                                                textmargemLucro.Text,
                                                                cbxFornecedor.SelectedValue.ToString(),
                                                                textprecocompra.Text);
                }
                else
                {
                    SqlCommand alterar = conexao.AlterarProduto(idProduto.GetValueOrDefault(),
                                                                 textnome.Text,
                                                                 textcodbarras.Text,
                                                                 textcodinterno.Text,
                                                                 textprecovenda.Text,
                                                                 textmargemLucro.Text,
                                                                 cbxFornecedor.SelectedValue.ToString(),
                                                                 textprecocompra.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void TelaManterCadastro_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand fornecedor = conexao.BuscarFornecedor();
            SqlDataAdapter adapterFornecedor = new SqlDataAdapter(fornecedor);
            DataTable tabelaFornecedor = new DataTable();
            adapterFornecedor.Fill(tabelaFornecedor);
            cbxFornecedor.DataSource = tabelaFornecedor;
            cbxFornecedor.ValueMember = "Id";
            cbxFornecedor.DisplayMember = "Nome";
            cbxFornecedor.SelectedItem = "";
            cbxFornecedor.SelectedIndex = -1;
            cbxFornecedor.Refresh();

            if (idProduto != null)
            {
                try
                {
                   
                    SqlCommand produto = conexao.BuscarProduto(idProduto.GetValueOrDefault());
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = produto;
                    DataSet tabela = new DataSet();
                    adaptador.Fill(tabela);

                    textnome.Text = tabela.Tables[0].Rows[0]["Nome"].ToString();
                    textcodbarras.Text = tabela.Tables[0].Rows[0]["COD_BARRAS"].ToString();
                    textcodinterno.Text = tabela.Tables[0].Rows[0]["COD_INTERNO"].ToString();
                    textprecovenda.Text = tabela.Tables[0].Rows[0]["PRECO_VENDA"].ToString();
                    textmargemLucro.Text = tabela.Tables[0].Rows[0]["MARGEM_LUCRO"].ToString();
                    cbxFornecedor.SelectedValue = Convert.ToInt32(tabela.Tables[0].Rows[0]["ID_FABRICANTE"].ToString());
                    textprecocompra.Text = tabela.Tables[0].Rows[0]["PRECO_COMPRA"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }      
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

        private void textprecocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroVirgula(sender, e);
        }

        private void textprecovenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroVirgula(sender, e);
        }

        private void textmargemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroVirgula(sender, e);
        }

        private void textquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }
    }
}