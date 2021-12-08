using System;
using System.Windows.Forms;

namespace PDV_CLUSTERS
{
    public partial class InicioPDV : Form
    {
        public InicioPDV()
        {
            InitializeComponent();
            customizarDesing();
        }

        private void InicioPDV_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.AbrirCaixas();

            telaLogin login = new telaLogin();
            login.ShowDialog();

            if (Sessao.Login != "" && Sessao.Login != null)
            {
                btLogin.Visible = false;
                txtLogin.Text = Sessao.Login;
                btCaixa.Enabled = true;
                btCadastro.Enabled = true;
            }
            else
            {
                txtLogin.Text = "";
                btCaixa.Enabled = false;
                btCadastro.Enabled = false;
                btLogoff.Enabled = false;
            }
        }

        private void customizarDesing()
        {
            panelSubmenuCadastro.Visible = false;
            panelSubmenuCaixa.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubmenuCadastro.Visible == true)
                panelSubmenuCadastro.Visible = false;
            if (panelSubmenuCaixa.Visible == true)
                panelSubmenuCaixa.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btCaixa_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuCaixa);
        }

        private void btVenda_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCaixaVenda());
            hideSubmenu();
        }

        private void btSangria_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCaixaSangria());
            hideSubmenu();
        }

        private void btFechamento_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCaixaFechamento());
            hideSubmenu();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubmenuCadastro);
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCadastroProduto());
            hideSubmenu();
        }

        private void btFuncionario_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCadastroFuncionario());
            hideSubmenu();
        }

        private void btFornecedor_Click(object sender, EventArgs e)
        {
            openChildForm(new telaCadastroFornecedor());
            hideSubmenu();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.ShowDialog();

            txtLogin.Text = Sessao.Login;

            if (txtLogin.Text != "")
            {
                btLogin.Visible = false;
                btCaixa.Enabled = true;
                btCadastro.Enabled = true;
                btLogoff.Enabled = true;
            }
            else
            {
                btLogin.Visible = true;
                btCaixa.Enabled = false;
                btCadastro.Enabled = false;
                btLogoff.Enabled = false;
            }
        }

        private void btLogoff_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            btLogin.Visible = true;
            btCaixa.Enabled = false;
            btCadastro.Enabled = false;
            btLogoff.Enabled = false;

            hideSubmenu();

            if (activeForm != null)
                activeForm.Hide();
        }
    }
}