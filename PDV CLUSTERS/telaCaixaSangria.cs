using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class telaCaixaSangria : Form
    {
        public telaCaixaSangria()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telaCaixaSangria_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                Sangria(i);
            }
        }

        private void Sangria(int numeroCaixa)
        {
            TextBox txtDinheiro = this.Controls.Find($"txtDinheiro{numeroCaixa}", true).FirstOrDefault() as TextBox;
            TextBox txtDebito = this.Controls.Find($"txtDebito{numeroCaixa}", true).FirstOrDefault() as TextBox;
            TextBox txtCredito = this.Controls.Find($"txtCredito{numeroCaixa}", true).FirstOrDefault() as TextBox;
            TextBox txtPix = this.Controls.Find($"txtPix{numeroCaixa}", true).FirstOrDefault() as TextBox;
            TextBox txtQrcode = this.Controls.Find($"txtQrcode{numeroCaixa}", true).FirstOrDefault() as TextBox;

            Conexao conexao = new Conexao();
            SqlCommand caixa = conexao.SelecionarTotalCaixa(numeroCaixa, DateTime.Now);
            SqlDataAdapter adaptadorCaixa = new SqlDataAdapter(caixa);
            DataSet dsCaixa = new DataSet();
            adaptadorCaixa.Fill(dsCaixa);

            if (dsCaixa.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsCaixa.Tables[0].Rows.Count; i++)
                {
                    if (dsCaixa.Tables[0].Rows[i][0].ToString() == "1")
                    {
                        txtCredito.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsCaixa.Tables[0].Rows[i][0].ToString() == "2")
                    {
                        txtDebito.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsCaixa.Tables[0].Rows[i][0].ToString() == "3")
                    {
                        txtDinheiro.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsCaixa.Tables[0].Rows[i][0].ToString() == "4")
                    {
                        txtPix.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }

                    if (dsCaixa.Tables[0].Rows[i][0].ToString() == "5")
                    {
                        txtQrcode.Text = dsCaixa.Tables[0].Rows[i][1].ToString();
                        continue;
                    }
                }
            }
        }
    }
}
