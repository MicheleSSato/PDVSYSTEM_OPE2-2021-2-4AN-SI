using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaCadastroFuncionario : Form
    {
        public static int? idFuncionario = null;

        public void VisualizarFuncionario(string nome = "")
        {
            Conexao conexao = new Conexao();
            SqlCommand funcionario = conexao.SelecionarFuncionario(nome);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = funcionario;
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            dgvListaFuncionario.DataSource = tabela;
        }

        public telaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            VisualizarFuncionario(textBoxBuscaFuncionario.Text);
        }

        private void btAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            idFuncionario = null;
            telaManterFuncionario manterFuncionario = new telaManterFuncionario();
            manterFuncionario.ShowDialog();
            VisualizarFuncionario();
        }

        private void btExcluirFuncionario_Click(object sender, EventArgs e)
        {
            //TODO Michele: colocar um verificação se o fornecedor esta sendo atrelado a algum produto
            var id = dgvListaFuncionario.CurrentRow.Cells[0].Value;

            if (id != null)
            {
                var idFuncionario = Convert.ToInt32(id);
                var mensagemExclusao = $"Deseja excluir Funcionário? {idFuncionario} - { dgvListaFuncionario.CurrentRow.Cells[1].Value}?";
                var returnMsgBox = MessageBox.Show(mensagemExclusao, "Excluir Funcionario", MessageBoxButtons.YesNo);

                if (returnMsgBox == DialogResult.Yes)
                {
                    try
                    {
                        Conexao conexao = new Conexao();

                        SqlCommand excluir = conexao.ExcluirFuncionario(idFuncionario);

                        VisualizarFuncionario();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (returnMsgBox == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!", "Excluir Funcionário");
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void btAlterarFuncionario_Click(object sender, EventArgs e)
        {
            var id = dgvListaFuncionario.CurrentRow.Cells[0].Value;

            if (id != null)
            {
                idFuncionario = Convert.ToInt32(id);
                telaManterFuncionario manterFuncionario = new telaManterFuncionario();
                manterFuncionario.ShowDialog();
                VisualizarFuncionario();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void btVisualizarFuncionario_Click(object sender, EventArgs e)
        {
            VisualizarFuncionario();
        }

        private void telaCadastroFuncionario_Load(object sender, EventArgs e)
        {
            VisualizarFuncionario();
        }
    }
}