using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaCaixaVenda : Form
    {
        public static int? id_Venda = null;

        public telaCaixaVenda()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telaCaixaVenda_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            SqlCommand caixa = conexao.SelecionarCaixa();
            SqlDataAdapter adapterCaixa = new SqlDataAdapter(caixa);
            DataTable tabelaCaixa = new DataTable();
            adapterCaixa.Fill(tabelaCaixa);
            cbxCaixa.DataSource = tabelaCaixa;
            cbxCaixa.ValueMember = "Id";
            cbxCaixa.DisplayMember = "Descricao";
            cbxCaixa.SelectedItem = "";
            cbxCaixa.SelectedIndex = -1;
            cbxCaixa.Refresh();

            SqlCommand funcionario = conexao.SelecionarFuncionario();
            SqlDataAdapter adapterFuncionario = new SqlDataAdapter(funcionario);
            DataTable tabelaFuncionario = new DataTable();
            adapterFuncionario.Fill(tabelaFuncionario);
            cbxFuncionario.DataSource = tabelaFuncionario;
            cbxFuncionario.ValueMember = "Id";
            cbxFuncionario.DisplayMember = "Nome";
            cbxFuncionario.SelectedItem = "";
            cbxFuncionario.SelectedIndex = -1;
            cbxFuncionario.Refresh();

            SqlCommand tipoPagamento = conexao.SelecionarTipoPagamento();
            SqlDataAdapter adapterTipoPagamento = new SqlDataAdapter(tipoPagamento);
            DataTable tabelaTipoPagamento = new DataTable();
            adapterTipoPagamento.Fill(tabelaTipoPagamento);
            cbxTipoPagamento.DataSource = tabelaTipoPagamento;
            cbxTipoPagamento.ValueMember = "Id";
            cbxTipoPagamento.DisplayMember = "Descricao";
            cbxTipoPagamento.SelectedItem = "";
            cbxTipoPagamento.SelectedIndex = -1;
            cbxTipoPagamento.Refresh();

            txtCodProduto.Enabled = false;
        }

        private void btPesquisarCaixa_Click(object sender, EventArgs e)
        {
            if (txtCodProduto.Text == "")
            {
                MessageBox.Show("Digite o código do produto para pesquisar!");
                return;
            }

            Conexao conexao = new Conexao();
            SqlCommand produto = conexao.SelecionarProdutoPorId(txtCodProduto.Text);
            SqlDataAdapter adapterProduto = new SqlDataAdapter(produto);
            DataSet dsProduto = new DataSet();
            adapterProduto.Fill(dsProduto);

            if (dsProduto.Tables[0].Rows.Count > 0)
            {
                txtIdProduto.Text = dsProduto.Tables[0].Rows[0][0].ToString();
                txtNomeProduto.Text = dsProduto.Tables[0].Rows[0][1].ToString();
                txtPrecoUnit.Text = dsProduto.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                MessageBox.Show("Nenhum código de produto ou código de barras foi localizado!");

                txtNomeProduto.Text = "";
                txtPrecoUnit.Text = "";
            }
        }

        private void btAdicionarCaixa_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            int idVenda = 0;

            if (txtIdVenda.Text != "")
                idVenda = Convert.ToInt32(txtIdVenda.Text);

            if (txtIdVenda.Text == "")
            {
                idVenda = conexao.IncluirVenda(Convert.ToInt32(cbxFuncionario.SelectedValue),
                                               Convert.ToInt32(cbxCaixa.SelectedValue),
                                               0,
                                               0,
                                               DateTime.Now);
                txtIdVenda.Text = idVenda.ToString();
            }

            if (idVenda == 0)
            {
                MessageBox.Show("Falha ao inserir venda!", "Caixa", MessageBoxButtons.OK);
                return;
            }

            if (txtCodProduto.Text == "" || txtNomeProduto.Text == ""
                || txtQuantidade.Text == "" || txtPrecoUnit.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Caixa", MessageBoxButtons.OK);
                return;
            }

            if (txtQuantidade.Text == "0")
            {
                MessageBox.Show("Preencha a quantidade do produto!", "Caixa", MessageBoxButtons.OK);
                return;
            }

            SqlCommand produtoPorCodigo = conexao.BuscarProdutoPorCodigo(Convert.ToInt32(txtCodProduto.Text));
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = produtoPorCodigo;
            DataSet tabela = new DataSet();
            adaptador.Fill(tabela);
            int idProduto = Convert.ToInt32(tabela.Tables[0].Rows[0]["ID"].ToString());

            SqlCommand produto = conexao.SelecionarItemVendaProduto(idVenda, idProduto);
            SqlDataAdapter adapterProduto = new SqlDataAdapter(produto);
            DataSet dsProduto = new DataSet();
            adapterProduto.Fill(dsProduto);

            int itemId = 0;
            int quantidade = 0;
            if (dsProduto.Tables[0].Rows.Count > 0)
            {
                itemId = Convert.ToInt32(dsProduto.Tables[0].Rows[0][0].ToString());
                quantidade = Convert.ToInt32(dsProduto.Tables[0].Rows[0][1].ToString());
                quantidade += Convert.ToInt32(txtQuantidade.Text);
                conexao.AlterarItemVenda(itemId, quantidade, Convert.ToDecimal(txtPrecoUnit.Text));
            }
            else
            {
                conexao.IncluirItemVenda(idVenda,
                                         Convert.ToInt32(txtIdProduto.Text),
                                         txtNomeProduto.Text,
                                         Convert.ToInt32(txtQuantidade.Text),
                                         Convert.ToDecimal(txtPrecoUnit.Text));
            }

            txtCodProduto.Text = "";
            txtNomeProduto.Text = "";
            txtQuantidade.Text = "";
            txtPrecoUnit.Text = "";

            VisualizarItemVenda(idVenda);

            txtSubTotal.Text = VisualizarItemVendaSubTotal(idVenda).ToString();
            txtTotal.Text = txtSubTotal.Text;
            txtDesconto.Text = "0";
        }

        public void VisualizarItemVenda(int idVenda)
        {
            Conexao conexao = new Conexao();
            SqlCommand itemVenda = conexao.SelecionarItemVenda(idVenda);
            SqlDataAdapter adaptadorItemVenda = new SqlDataAdapter();
            adaptadorItemVenda.SelectCommand = itemVenda;
            DataTable tabelaItemVenda = new DataTable();
            adaptadorItemVenda.Fill(tabelaItemVenda);
            dgvListaItemVenda.DataSource = tabelaItemVenda;
        }

        public decimal VisualizarItemVendaSubTotal(int idVenda)
        {
            Conexao conexao = new Conexao();
            SqlCommand itemVendaSubTotal = conexao.SelecionarItemVendaSubTotal(idVenda);
            SqlDataAdapter adaptadorItemVendaSubTotal = new SqlDataAdapter();
            adaptadorItemVendaSubTotal.SelectCommand = itemVendaSubTotal;
            DataTable tabelaItemVendaSubTotal = new DataTable();
            adaptadorItemVendaSubTotal.Fill(tabelaItemVendaSubTotal);

            return Convert.ToDecimal(tabelaItemVendaSubTotal.Rows[0].ItemArray[0]);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gdListaItemVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int idVenda = 0;
                int id = Convert.ToInt32(dgvListaItemVenda.CurrentRow.Cells[0].Value.ToString());

                if (txtIdVenda.Text != "")
                    idVenda = Convert.ToInt32(txtIdVenda.Text);

                if (idVenda == 0)
                {
                    MessageBox.Show("Falha ao localizar a venda!", "Caixa", MessageBoxButtons.OK);
                    return;
                }

                if (id != -1)
                {
                    var mensagemExclusao = $"Deseja excluir o Item?";
                    var returnMsgBox = MessageBox.Show(mensagemExclusao, "Excluir Item", MessageBoxButtons.YesNo);

                    if (returnMsgBox == DialogResult.Yes)
                    {
                        try
                        {
                            Conexao conexao = new Conexao();
                            SqlCommand itemVenda = conexao.ExcluirItemVenda(id);

                            VisualizarItemVenda(idVenda);

                            txtSubTotal.Text = VisualizarItemVendaSubTotal(idVenda).ToString();
                            txtTotal.Text = txtSubTotal.Text;
                            txtDesconto.Text = "0";
                            txtValorRecebido.Text = "";
                            txtTroco.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (returnMsgBox == DialogResult.No)
                    {
                        MessageBox.Show("Operação cancelada!", "Excluir Item");
                    }
                }
            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (txtDesconto.Text != "" && txtSubTotal.Text != ""
                && (txtDesconto.Text != "," && txtSubTotal.Text != ","))
            {
                var descontoVar = txtDesconto.Text;
                var commaPosition = descontoVar.IndexOf(",", StringComparison.Ordinal);
                descontoVar = commaPosition + 3 > descontoVar.Length ? descontoVar : descontoVar.Substring(0, commaPosition + 3);
                txtDesconto.Text = descontoVar;

                decimal desconto = Convert.ToDecimal(txtDesconto.Text);
                decimal subTotal = Convert.ToDecimal(txtSubTotal.Text);

                if (desconto > 5)
                {
                    var mensagem = $"O valor máximo de desconto é 5%!";
                    var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);

                    txtDesconto.Text = "0";
                }
                else
                {
                    subTotal = subTotal - ((desconto * subTotal) / 100);
                    subTotal = decimal.Round(subTotal, 2);
                    txtTotal.Text = Convert.ToString(subTotal);
                }
            }
        }

        private void cbxTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPagamento.Text == "Dinheiro")
            {
                txtValorRecebido.Enabled = true;
            }
            else
            {
                txtValorRecebido.Enabled = false;
            }

            txtValorRecebido.Text = "";
        }

        private void btFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (dgvListaItemVenda.Rows.Count == 0)
            {
                var mensagem = $"Nenhum item adicionado!";
                var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                return;
            }

            if (cbxCaixa.SelectedIndex == -1)
            {
                var mensagem = $"Nenhum caixa adicionado!";
                var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                return;
            }

            if (cbxFuncionario.SelectedIndex == -1)
            {
                var mensagem = $"Nenhum funcionário adicionado!";
                var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                return;
            }

            if (((txtValorRecebido.Text != "" && cbxTipoPagamento.Text == "Dinheiro") || cbxTipoPagamento.Text != "Dinheiro")
                && txtTotal.Text != "" && cbxTipoPagamento.SelectedIndex != -1)
            {
                decimal total = Convert.ToDecimal(txtTotal.Text);
                decimal valorRecebido = 0;
                var valorRecebidoVar = txtValorRecebido.Text;
                var commaPosition = valorRecebidoVar.IndexOf(",", StringComparison.Ordinal);

                if (commaPosition != -1)
                    txtValorRecebido.Text = commaPosition + 3 > valorRecebidoVar.Length ? valorRecebidoVar : valorRecebidoVar.Substring(0, commaPosition + 3);

                if (txtValorRecebido.Text != "")
                    valorRecebido = Convert.ToDecimal(txtValorRecebido.Text);

                if ((valorRecebido < total) && cbxTipoPagamento.Text == "Dinheiro")
                {
                    var mensagem = $"O valor recebido não pode ser menor do que o valor total!";
                    var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);

                    txtValorRecebido.Text = "";
                    txtTroco.Text = "";
                }
                else
                {
                    txtCPF.Text = txtCPF.Text.Replace(".", "").Replace("-", "");

                    if (txtCPF.Text.Length == 11)
                    {
                        if (ValidarNumeroCPF(txtCPF.Text) == false)
                        {
                            MessageBox.Show("O CPF está inválido!", "Caixa", MessageBoxButtons.OK);
                            return;
                        }

                        txtCPF.Text = Convert.ToUInt64(txtCPF.Text).ToString(@"000\.000\.000\-00");
                    }
                    else if (txtCPF.Text.Length != 0)
                    {
                        MessageBox.Show("O CPF está no formato inválido!", "Caixa", MessageBoxButtons.OK);
                        return;
                    }

                    var mensagem = $"Deseja finalizar a venda?";
                    var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.YesNo);

                    if (returnMsgBox == DialogResult.Yes)
                    {
                        if (cbxTipoPagamento.Text == "Dinheiro")
                            txtTroco.Text = Convert.ToString(valorRecebido - total);

                        int idVenda = 0;

                        if (txtIdVenda.Text != "")
                            idVenda = Convert.ToInt32(txtIdVenda.Text);

                        if (idVenda == 0)
                        {
                            MessageBox.Show("Falha ao localizar a venda!", "Caixa", MessageBoxButtons.OK);
                            return;
                        }

                        Conexao conexao = new Conexao();
                        SqlCommand venda = conexao.FinalizarVenda(idVenda,
                                                                  Convert.ToInt32(cbxFuncionario.SelectedValue),
                                                                  Convert.ToInt32(cbxCaixa.SelectedValue),
                                                                  Convert.ToInt32(cbxTipoPagamento.SelectedValue),
                                                                  txtCPF.Text,
                                                                  Convert.ToDecimal(txtSubTotal.Text),
                                                                  Convert.ToDecimal(txtTotal.Text),
                                                                  Convert.ToDecimal(txtDesconto.Text == "" ? "0" : txtDesconto.Text),
                                                                  Convert.ToDecimal(txtValorRecebido.Text == "" ? "0" : txtValorRecebido.Text),
                                                                  Convert.ToDecimal(txtTroco.Text == "" ? "0" : txtTroco.Text)
                                                                  );

                        SqlDataAdapter adapterVenda = new SqlDataAdapter(venda);
                        DataSet dsVenda = new DataSet();
                        adapterVenda.Fill(dsVenda);

                        id_Venda = idVenda;
                        cupomVenda cupomVenda = new cupomVenda();
                        cupomVenda.ShowDialog();

                        txtIdVenda.Text = "";
                        txtCodProduto.Text = "";
                        txtQuantidade.Text = "";
                        txtPrecoUnit.Text = "";
                        txtSubTotal.Text = "";
                        txtDesconto.Text = "";
                        txtTotal.Text = "";
                        cbxTipoPagamento.Text = "";
                        cbxTipoPagamento.SelectedIndex = -1;
                        txtValorRecebido.Text = "";
                        txtTroco.Text = "";
                        txtCPF.Text = "";
                        cbxCaixa.SelectedIndex = -1;
                        cbxFuncionario.SelectedIndex = -1;
                        dgvListaItemVenda.DataSource = null;
                    }
                    else
                    {
                        mensagem = $"Finalização cancelada!";
                        returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (cbxTipoPagamento.SelectedIndex == -1)
                {
                    var mensagem = $"Selecione um Tipo de Pagamento!";
                    var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                    return;
                }

                if (cbxTipoPagamento.Text == "Dinheiro")
                {
                    if (txtValorRecebido.Text == "" && txtTotal.Text == "")
                    {
                        var mensagem = $"O valor total e o valor recebido devem ser preenchidos!";
                        var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                    }

                    if (txtValorRecebido.Text == "")
                    {
                        var mensagem = $"O valor recebido deve ser preenchido!";
                        var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                    }

                    if (txtTotal.Text == "")
                    {
                        var mensagem = $"O valor total deve ser preenchido!";
                        var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumeroVirgula(sender, e);
        }

        private void txtValorRecebido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbxFuncionario_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxFuncionario.SelectedIndex != -1)
            {
                txtCodProduto.Enabled = true;
                txtQuantidade.Enabled = true;
                txtDesconto.Enabled = true;
                cbxTipoPagamento.Enabled = true;
                txtCPF.Enabled = true;
            }
            else
            {
                txtCodProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtDesconto.Enabled = false;
                cbxTipoPagamento.Enabled = false;
                txtValorRecebido.Enabled = false;
                txtCPF.Enabled = false;
            }
        }

        private void cbxFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (cbxFuncionario.Text != "")
            {
                txtCodProduto.Enabled = true;
                txtQuantidade.Enabled = true;
                txtDesconto.Enabled = true;
                cbxTipoPagamento.Enabled = true;
                txtCPF.Enabled = true;
            }
            else
            {
                txtCodProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtDesconto.Enabled = false;
                cbxTipoPagamento.Enabled = false;
                txtValorRecebido.Enabled = false;
                txtCPF.Enabled = false;
            }
        }

        private void cbxCaixa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand caixa = conexao.SelecionarCaixa(Convert.ToInt32(cbxCaixa.SelectedValue));
            SqlDataAdapter adaptadorCaixa = new SqlDataAdapter();
            adaptadorCaixa.SelectCommand = caixa;
            DataTable tabelaCaixa = new DataTable();
            adaptadorCaixa.Fill(tabelaCaixa);
            var status = Convert.ToInt32(tabelaCaixa.Rows[0].ItemArray[2].ToString());

            if (status == 0)
            {
                var mensagem = $"O caixa {cbxCaixa.SelectedValue} está fechado! Selecione outro caixa!";
                var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                cbxCaixa.SelectedValue = -1;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool ValidarNumeroCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf, digito;
            int soma, resto;

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}