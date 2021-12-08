using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PDV_CLUSTERS
{
    public partial class telaCadastroProduto : Form
    {
        public static int? idProduto = null;

        public telaCadastroProduto()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TODO dividir os metodos grandes em pequenas funcionalidades
        private void btExcluir_Click(object sender, EventArgs e)
        {
            var produto = dgvListaProduto.CurrentRow.Cells[0].Value;

            if (produto != null)
            {
                var idProduto = Convert.ToInt32(produto);

                Conexao conexao = new Conexao();
                SqlCommand produtoVenda = conexao.SelecionarItemVendaPorProduto(idProduto);
                SqlDataAdapter adaptadorProdutoVenda = new SqlDataAdapter();
                adaptadorProdutoVenda.SelectCommand = produtoVenda;
                DataTable tabelaProdutoVenda = new DataTable();
                adaptadorProdutoVenda.Fill(tabelaProdutoVenda);

                if (tabelaProdutoVenda.Rows.Count > 0)
                {
                    var mensagem = "Produto está vinculado aos itens vendidos! Não é permitido excluir!";
                    MessageBox.Show(mensagem, "Excluir Produto", MessageBoxButtons.OK);
                    return;
                }

                var mensagemExclusao = $"Deseja excluir Produto? {idProduto} - {dgvListaProduto.CurrentRow.Cells[1].Value}?";
                var returnMsgBox = MessageBox.Show(mensagemExclusao, "Excluir Produto", MessageBoxButtons.YesNo);

                if (returnMsgBox == DialogResult.Yes)
                {
                    try
                    {                        
                        SqlCommand excluir = conexao.ExcluirProduto(idProduto);
                        Visualizar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (returnMsgBox == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Excluir Produto");
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void btAdicionarNovo_Click(object sender, EventArgs e)
        {
            idProduto = null;
            TelaManterCadastroProduto manterCadastro = new TelaManterCadastroProduto();
            manterCadastro.ShowDialog();
            Visualizar();
        }

        public void Visualizar(string nome = "")
        {
            Conexao conexao = new Conexao();
            SqlCommand produto = conexao.SelecionarProduto(nome);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = produto;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dgvListaProduto.DataSource = tabela;
        }

        private void telaCadastroProduto_Load(object sender, EventArgs e)
        {
           Visualizar();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            var id = dgvListaProduto.CurrentRow.Cells[0].Value;

            if (id != null)
            {
                idProduto = Convert.ToInt32(id);
                TelaManterCadastroProduto manterCadastro = new TelaManterCadastroProduto();
                manterCadastro.ShowDialog();
                Visualizar();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Visualizar(textBoxBuscaProduto.Text);
        }
    }
}