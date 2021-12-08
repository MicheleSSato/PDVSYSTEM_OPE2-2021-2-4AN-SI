using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaCadastroFornecedor : Form
    {
        public static int? idFornecedor = null;

        public telaCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionarNovo_Click(object sender, EventArgs e)
        {
            idFornecedor = null;
            TelaManterFornecedor manterFornecedor = new TelaManterFornecedor();
            manterFornecedor.ShowDialog();
            Visualizar();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            Visualizar();
        }

        private void telaCadastroFornecedor_Load(object sender, EventArgs e)
        {
            Visualizar();
        }

        public void Visualizar(string nome = "")
        {
            Conexao conexao = new Conexao();

            SqlCommand fornecedor = conexao.SelecionarFornecedor(nome);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = fornecedor;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dgvListaFornecedor.DataSource = tabela;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Visualizar(textBoxBuscaFornecedor.Text);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var id = dgvListaFornecedor.CurrentRow.Cells[0].Value;

            if (id != null)
            {
                var idFornecedor = Convert.ToInt32(id);
                    
                Conexao conexao = new Conexao();
                SqlCommand produtoFornecedor = conexao.SelecionarProdutoPorFornecedor(idFornecedor);
                SqlDataAdapter adaptadorProdutoFornecedor = new SqlDataAdapter();
                adaptadorProdutoFornecedor.SelectCommand = produtoFornecedor;
                DataTable tabelaProdutoFornecedor = new DataTable();
                adaptadorProdutoFornecedor.Fill(tabelaProdutoFornecedor);

                if (tabelaProdutoFornecedor.Rows.Count > 0)
                {
                    var mensagem = "Este fabricante está vinculado aos produtos! Não é permitido excluir!";
                    MessageBox.Show(mensagem, "Excluir Fornecedor", MessageBoxButtons.OK);
                    return;
                }

                var mensagemExclusao = $"Deseja excluir Fornecedor? {idFornecedor} - { dgvListaFornecedor.CurrentRow.Cells[1].Value}?";
                var returnMsgBox = MessageBox.Show(mensagemExclusao, "Excluir Fornecedor", MessageBoxButtons.YesNo);

                if (returnMsgBox == DialogResult.Yes)
                {
                    try
                    {
                        SqlCommand excluir = conexao.ExcluirFornecedor(idFornecedor);

                        Visualizar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (returnMsgBox == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Excluir Fornecedor");
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {            
            var id = dgvListaFornecedor.CurrentRow.Cells[0].Value;

            if (id != null)
            {
                idFornecedor = Convert.ToInt32(id);

                TelaManterFornecedor manterFornecedor = new TelaManterFornecedor();
                manterFornecedor.ShowDialog();
                Visualizar();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }
    }
}