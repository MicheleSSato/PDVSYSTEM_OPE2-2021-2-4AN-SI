using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class cupomVenda : Form
    {
        public static int? idVenda = null;

        public cupomVenda()
        {
            InitializeComponent();
            idVenda = telaCaixaVenda.id_Venda;
        }

        private void cupomVenda_Load(object sender, EventArgs e)
        {
            if (idVenda != null)
            {
                Conexao conexao = new Conexao();
                SqlCommand cupomVenda = conexao.SelecionarVenda(idVenda.GetValueOrDefault());
                SqlDataAdapter adaptadorCupomVenda = new SqlDataAdapter();
                adaptadorCupomVenda.SelectCommand = cupomVenda;
                DataSet tabelaCupomVenda = new DataSet();
                adaptadorCupomVenda.Fill(tabelaCupomVenda);

                lblIdVenda.Text = tabelaCupomVenda.Tables[0].Rows[0]["ID"].ToString();
                lblData.Text = tabelaCupomVenda.Tables[0].Rows[0]["DATA"].ToString();
                lblFuncionario.Text = BuscarFuncionario(Convert.ToInt32(tabelaCupomVenda.Tables[0].Rows[0]["ID_FUNCIONARIO"].ToString()));
                lblCaixa.Text = BuscarCaixa(Convert.ToInt32(tabelaCupomVenda.Tables[0].Rows[0]["ID_CAIXA"].ToString()));
                lblTipoPagamento.Text = BuscarTipoPagamento(Convert.ToInt32(tabelaCupomVenda.Tables[0].Rows[0]["ID_TIPO_PAGAMENTO"].ToString()));
                lblCPF.Text = tabelaCupomVenda.Tables[0].Rows[0]["CPF"].ToString();
                lblValor.Text = tabelaCupomVenda.Tables[0].Rows[0]["VALOR"].ToString();
                lblValorTotal.Text = tabelaCupomVenda.Tables[0].Rows[0]["VALOR_TOTAL"].ToString();
                lblDesconto.Text = tabelaCupomVenda.Tables[0].Rows[0]["DESCONTO"].ToString();
                lbValorRecebido.Text = tabelaCupomVenda.Tables[0].Rows[0]["VALOR_RECEBIDO"].ToString();
                lbTroco.Text = tabelaCupomVenda.Tables[0].Rows[0]["TROCO"].ToString();

               
                SqlCommand cupomItemVenda = conexao.SelecionarItemVenda(idVenda.GetValueOrDefault());
                SqlDataAdapter adaptadorCupomItemVenda = new SqlDataAdapter();
                adaptadorCupomItemVenda.SelectCommand = cupomItemVenda;
                DataTable tabelaCupomItemVenda = new DataTable();
                adaptadorCupomItemVenda.Fill(tabelaCupomItemVenda);
                dgvItemVenda.DataSource = tabelaCupomItemVenda;             
            }
            else
            {
                var mensagem = $"Falha ao gerar cupom fiscal!";
                var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);

                this.Close();
            }
        }

        private void lblfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string BuscarFuncionario(int idFuncionario)
        {
            Conexao conexao = new Conexao();
            SqlCommand fornecedor = conexao.BuscarFuncionario(idFuncionario);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = fornecedor;
            DataSet tabela = new DataSet();
            adaptador.Fill(tabela);

            return tabela.Tables[0].Rows[0]["Nome"].ToString();
        }

        public string BuscarCaixa(int idCaixa)
        {
            Conexao conexao = new Conexao();
            SqlCommand caixa = conexao.SelecionarCaixa(idCaixa);

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = caixa;
            DataSet tabela = new DataSet();
            adaptador.Fill(tabela);

            return tabela.Tables[0].Rows[0]["DESCRICAO"].ToString();
        }

        public string BuscarTipoPagamento(int idTipoPagamento)
        {
            Conexao conexao = new Conexao();
            SqlCommand fornecedor = conexao.SelecionarTipoPagamento(idTipoPagamento.ToString());

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = fornecedor;
            DataSet tabela = new DataSet();
            adaptador.Fill(tabela);

            return tabela.Tables[0].Rows[0]["DESCRICAO"].ToString();
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }
    }
}