
namespace PDV_CLUSTERS
{
    partial class telaManterFuncionario
    {
        
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbEnderecoFuncionario = new System.Windows.Forms.Label();
            this.lbTelefoneFuncionario = new System.Windows.Forms.Label();
            this.lbCpfFuncionario = new System.Windows.Forms.Label();
            this.lbRgFuncionario = new System.Windows.Forms.Label();
            this.lbCodInternoFuncionario = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lbSalarioFuncionario = new System.Windows.Forms.Label();
            this.lbNivelAcessoFuncionario = new System.Windows.Forms.Label();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
            this.btSalvarFuncionario = new System.Windows.Forms.Button();
            this.cbxNivelAcesso = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbNomeTela = new System.Windows.Forms.Label();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(100, 72);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(369, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVoltar.Location = new System.Drawing.Point(10, 284);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(66, 35);
            this.btVoltar.TabIndex = 10;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(7, 72);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(45, 19);
            this.lbLogin.TabIndex = 17;
            this.lbLogin.Text = "Login";
            // 
            // lbEnderecoFuncionario
            // 
            this.lbEnderecoFuncionario.AutoSize = true;
            this.lbEnderecoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnderecoFuncionario.Location = new System.Drawing.Point(8, 98);
            this.lbEnderecoFuncionario.Name = "lbEnderecoFuncionario";
            this.lbEnderecoFuncionario.Size = new System.Drawing.Size(76, 19);
            this.lbEnderecoFuncionario.TabIndex = 18;
            this.lbEnderecoFuncionario.Text = "Endereço";
            // 
            // lbTelefoneFuncionario
            // 
            this.lbTelefoneFuncionario.AutoSize = true;
            this.lbTelefoneFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefoneFuncionario.Location = new System.Drawing.Point(8, 120);
            this.lbTelefoneFuncionario.Name = "lbTelefoneFuncionario";
            this.lbTelefoneFuncionario.Size = new System.Drawing.Size(66, 19);
            this.lbTelefoneFuncionario.TabIndex = 19;
            this.lbTelefoneFuncionario.Text = "Telefone";
            // 
            // lbCpfFuncionario
            // 
            this.lbCpfFuncionario.AutoSize = true;
            this.lbCpfFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfFuncionario.Location = new System.Drawing.Point(8, 169);
            this.lbCpfFuncionario.Name = "lbCpfFuncionario";
            this.lbCpfFuncionario.Size = new System.Drawing.Size(35, 19);
            this.lbCpfFuncionario.TabIndex = 20;
            this.lbCpfFuncionario.Text = "CPF";
            // 
            // lbRgFuncionario
            // 
            this.lbRgFuncionario.AutoSize = true;
            this.lbRgFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRgFuncionario.Location = new System.Drawing.Point(8, 146);
            this.lbRgFuncionario.Name = "lbRgFuncionario";
            this.lbRgFuncionario.Size = new System.Drawing.Size(30, 19);
            this.lbRgFuncionario.TabIndex = 21;
            this.lbRgFuncionario.Text = "RG";
            // 
            // lbCodInternoFuncionario
            // 
            this.lbCodInternoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodInternoFuncionario.Location = new System.Drawing.Point(7, 244);
            this.lbCodInternoFuncionario.Name = "lbCodInternoFuncionario";
            this.lbCodInternoFuncionario.Size = new System.Drawing.Size(88, 22);
            this.lbCodInternoFuncionario.TabIndex = 22;
            this.lbCodInternoFuncionario.Text = "Cód. Interno";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(100, 97);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(369, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(100, 121);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(369, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(100, 170);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(369, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(100, 145);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(369, 20);
            this.txtRg.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(100, 194);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(369, 20);
            this.txtSalario.TabIndex = 6;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // lbSalarioFuncionario
            // 
            this.lbSalarioFuncionario.AutoSize = true;
            this.lbSalarioFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioFuncionario.Location = new System.Drawing.Point(8, 195);
            this.lbSalarioFuncionario.Name = "lbSalarioFuncionario";
            this.lbSalarioFuncionario.Size = new System.Drawing.Size(55, 19);
            this.lbSalarioFuncionario.TabIndex = 28;
            this.lbSalarioFuncionario.Text = "Salário";
            // 
            // lbNivelAcessoFuncionario
            // 
            this.lbNivelAcessoFuncionario.AutoSize = true;
            this.lbNivelAcessoFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivelAcessoFuncionario.Location = new System.Drawing.Point(8, 220);
            this.lbNivelAcessoFuncionario.Name = "lbNivelAcessoFuncionario";
            this.lbNivelAcessoFuncionario.Size = new System.Drawing.Size(92, 19);
            this.lbNivelAcessoFuncionario.TabIndex = 29;
            this.lbNivelAcessoFuncionario.Text = "Nível Acesso";
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.Location = new System.Drawing.Point(100, 245);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.Size = new System.Drawing.Size(369, 20);
            this.txtCodigoInterno.TabIndex = 8;
            // 
            // btSalvarFuncionario
            // 
            this.btSalvarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btSalvarFuncionario.FlatAppearance.BorderSize = 0;
            this.btSalvarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarFuncionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalvarFuncionario.Location = new System.Drawing.Point(388, 284);
            this.btSalvarFuncionario.Name = "btSalvarFuncionario";
            this.btSalvarFuncionario.Size = new System.Drawing.Size(80, 35);
            this.btSalvarFuncionario.TabIndex = 9;
            this.btSalvarFuncionario.Text = "Salvar";
            this.btSalvarFuncionario.UseVisualStyleBackColor = false;
            this.btSalvarFuncionario.Click += new System.EventHandler(this.btSalvarFuncionario_Click);
            // 
            // cbxNivelAcesso
            // 
            this.cbxNivelAcesso.FormattingEnabled = true;
            this.cbxNivelAcesso.Location = new System.Drawing.Point(100, 219);
            this.cbxNivelAcesso.Name = "cbxNivelAcesso";
            this.cbxNivelAcesso.Size = new System.Drawing.Size(369, 21);
            this.cbxNivelAcesso.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbNomeTela);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 34);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PDV_CLUSTERS.Properties.Resources.value;
            this.pictureBox2.Location = new System.Drawing.Point(386, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbNomeTela
            // 
            this.lbNomeTela.AutoSize = true;
            this.lbNomeTela.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeTela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNomeTela.Location = new System.Drawing.Point(3, -1);
            this.lbNomeTela.Name = "lbNomeTela";
            this.lbNomeTela.Size = new System.Drawing.Size(371, 36);
            this.lbNomeTela.TabIndex = 1;
            this.lbNomeTela.Text = "Cadastro de Funcionário";
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.Location = new System.Drawing.Point(8, 47);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(50, 19);
            this.lbNomeFuncionario.TabIndex = 37;
            this.lbNomeFuncionario.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(101, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(369, 20);
            this.txtNome.TabIndex = 0;
            // 
            // telaManterFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 330);
            this.Controls.Add(this.lbNomeFuncionario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxNivelAcesso);
            this.Controls.Add(this.btSalvarFuncionario);
            this.Controls.Add(this.txtCodigoInterno);
            this.Controls.Add(this.lbNivelAcessoFuncionario);
            this.Controls.Add(this.lbSalarioFuncionario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbCodInternoFuncionario);
            this.Controls.Add(this.lbRgFuncionario);
            this.Controls.Add(this.lbCpfFuncionario);
            this.Controls.Add(this.lbTelefoneFuncionario);
            this.Controls.Add(this.lbEnderecoFuncionario);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaManterFuncionario";
            this.Text = "telaManterFuncionario";
            this.Load += new System.EventHandler(this.TelaManterFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbEnderecoFuncionario;
        private System.Windows.Forms.Label lbTelefoneFuncionario;
        private System.Windows.Forms.Label lbCpfFuncionario;
        private System.Windows.Forms.Label lbRgFuncionario;
        private System.Windows.Forms.Label lbCodInternoFuncionario;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lbSalarioFuncionario;
        private System.Windows.Forms.Label lbNivelAcessoFuncionario;
        private System.Windows.Forms.TextBox txtCodigoInterno;
        private System.Windows.Forms.Button btSalvarFuncionario;
        private System.Windows.Forms.ComboBox cbxNivelAcesso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbNomeTela;
        private System.Windows.Forms.Label lbNomeFuncionario;
        private System.Windows.Forms.TextBox txtNome;
    }
}