using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaCaixaFechamento : Form
    {
        public telaCaixaFechamento()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telaCaixaFechamento_Load(object sender, EventArgs e)
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
                var mensagem = $"O caixa {cbxCaixa.SelectedValue} está fechado! Selecione outro caixa.";
                var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                cbxCaixa.SelectedValue = -1;
            }

            txtDinheiro.Text = "0,00";
            txtDebito.Text = "0,00";
            txtCredito.Text = "0,00";
            txtPix.Text = "0,00";
            txtQrcode.Text = "0,00";

            SqlCommand totalCaixa = conexao.SelecionarTotalCaixa(Convert.ToInt32(cbxCaixa.SelectedValue), DateTime.Now);
            SqlDataAdapter adaptadorTotalCaixa = new SqlDataAdapter(totalCaixa);
            DataSet dsTotalCaixa = new DataSet();
            adaptadorTotalCaixa.Fill(dsTotalCaixa);

            if (dsTotalCaixa.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsTotalCaixa.Tables[0].Rows.Count; i++)
                {
                    if (dsTotalCaixa.Tables[0].Rows[i][0].ToString() == "1")
                    {
                        txtCredito.Text = dsTotalCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsTotalCaixa.Tables[0].Rows[i][0].ToString() == "2")
                    {
                        txtDebito.Text = dsTotalCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsTotalCaixa.Tables[0].Rows[i][0].ToString() == "3")
                    {
                        txtDinheiro.Text = dsTotalCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsTotalCaixa.Tables[0].Rows[i][0].ToString() == "4")
                    {
                        txtPix.Text = dsTotalCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsTotalCaixa.Tables[0].Rows[i][0].ToString() == "5")
                    {
                        txtQrcode.Text = dsTotalCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }
                }
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            if (cbxCaixa.SelectedIndex == -1)
            {
                var mensagem = $"Nenhum caixa adicionado!";
                var returnMsgBox = MessageBox.Show(mensagem, "Caixa", MessageBoxButtons.OK);
                return;
            }

            var mensagemFechamento = $"Deseja fechar o caixa {cbxCaixa.SelectedValue}? O caixa não poderá ser utilizado até a próxima data.";
            var returnMsgBoxFechamento = MessageBox.Show(mensagemFechamento, "Caixa", MessageBoxButtons.YesNo);

            if (returnMsgBoxFechamento == DialogResult.No)
            {
                var mensagemCancelada = $"Operação cancelada!";
                var returnMsgBoxCancelada = MessageBox.Show(mensagemCancelada, "Caixa", MessageBoxButtons.OK);
                return;
            }

            conexao.FecharCaixa(Convert.ToInt32(cbxCaixa.SelectedValue), DateTime.Now);

            //SqlCommand caixa = conexao.SelecionarFechamentoCaixa(Convert.ToInt32(cbxCaixa.SelectedValue), DateTime.Now);
            //SqlDataAdapter adaptadorCaixa = new SqlDataAdapter(caixa);
            //DataSet dsCaixa = new DataSet();
            //adaptadorCaixa.Fill(dsCaixa);

            //if (dsCaixa.Tables[0].Rows.Count > 0)
            //{
            //    for (int i = 0; i < dsCaixa.Tables[0].Rows.Count; i++)
            //    {
            //        if (dsCaixa.Tables[0].Rows[i][0].ToString() == "1")
            //        {
            //            txtCredito.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
            //            continue;
            //        }

            //        if (dsCaixa.Tables[0].Rows[i][0].ToString() == "2")
            //        {
            //            txtDebito.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
            //            continue;
            //        }

            //        if (dsCaixa.Tables[0].Rows[i][0].ToString() == "3")
            //        {
            //            txtDinheiro.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
            //            continue;
            //        }

            //        if (dsCaixa.Tables[0].Rows[i][0].ToString() == "4")
            //        {
            //            txtPix.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
            //            continue;
            //        }

            //        if (dsCaixa.Tables[0].Rows[i][0].ToString() == "5")
            //        {
            //            txtQrcode.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
            //            continue;
            //        }
            //    }
            //}
            //else
            //{
            //    txtDinheiro.Text = "0,00";
            //    txtDebito.Text = "0,00";
            //    txtCredito.Text = "0,00";
            //    txtPix.Text = "0,00";
            //    txtQrcode.Text = "0,00";
            //}

            var mensagemSucesso = $"Caixa {cbxCaixa.SelectedValue} fechado com sucesso!";
            var returnMsgBoxSucesso = MessageBox.Show(mensagemSucesso, "Caixa", MessageBoxButtons.OK);
        }
    }
}