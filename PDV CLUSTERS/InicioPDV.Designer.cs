namespace PDV_CLUSTERS
{
    partial class InicioPDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btLogoff = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.panelSubmenuCadastro = new System.Windows.Forms.Panel();
            this.btFornecedor = new System.Windows.Forms.Button();
            this.btFuncionario = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.panelSubmenuCaixa = new System.Windows.Forms.Panel();
            this.btFechamento = new System.Windows.Forms.Button();
            this.btSangria = new System.Windows.Forms.Button();
            this.btVenda = new System.Windows.Forms.Button();
            this.btCaixa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubmenuCadastro.SuspendLayout();
            this.panelSubmenuCaixa.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(975, 32);
            this.BarraTitulo.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.panelMenu.Controls.Add(this.txtLogin);
            this.panelMenu.Controls.Add(this.btLogin);
            this.panelMenu.Controls.Add(this.btLogoff);
            this.panelMenu.Controls.Add(this.btSair);
            this.panelMenu.Controls.Add(this.panelSubmenuCadastro);
            this.panelMenu.Controls.Add(this.btCadastro);
            this.panelMenu.Controls.Add(this.panelSubmenuCaixa);
            this.panelMenu.Controls.Add(this.btCaixa);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(179, 703);
            this.panelMenu.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLogin.Enabled = false;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.HideSelection = false;
            this.txtLogin.Location = new System.Drawing.Point(3, 460);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(173, 23);
            this.txtLogin.TabIndex = 20;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btLogin.Image = global::PDV_CLUSTERS.Properties.Resources.settings;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(2, 412);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(179, 43);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "Login";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btLogoff
            // 
            this.btLogoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btLogoff.FlatAppearance.BorderSize = 0;
            this.btLogoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btLogoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogoff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogoff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btLogoff.Image = global::PDV_CLUSTERS.Properties.Resources.settings;
            this.btLogoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogoff.Location = new System.Drawing.Point(3, 488);
            this.btLogoff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogoff.Name = "btLogoff";
            this.btLogoff.Size = new System.Drawing.Size(179, 51);
            this.btLogoff.TabIndex = 7;
            this.btLogoff.Text = "Logoff";
            this.btLogoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLogoff.UseVisualStyleBackColor = true;
            this.btLogoff.Click += new System.EventHandler(this.btLogoff_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSair.Image = global::PDV_CLUSTERS.Properties.Resources.settings;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(2, 651);
            this.btSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(179, 51);
            this.btSair.TabIndex = 7;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panelSubmenuCadastro
            // 
            this.panelSubmenuCadastro.Controls.Add(this.btFornecedor);
            this.panelSubmenuCadastro.Controls.Add(this.btFuncionario);
            this.panelSubmenuCadastro.Controls.Add(this.btProduto);
            this.panelSubmenuCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuCadastro.Location = new System.Drawing.Point(0, 289);
            this.panelSubmenuCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubmenuCadastro.Name = "panelSubmenuCadastro";
            this.panelSubmenuCadastro.Size = new System.Drawing.Size(179, 119);
            this.panelSubmenuCadastro.TabIndex = 4;
            // 
            // btFornecedor
            // 
            this.btFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFornecedor.FlatAppearance.BorderSize = 0;
            this.btFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFornecedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFornecedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFornecedor.Location = new System.Drawing.Point(0, 64);
            this.btFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFornecedor.Name = "btFornecedor";
            this.btFornecedor.Size = new System.Drawing.Size(179, 32);
            this.btFornecedor.TabIndex = 3;
            this.btFornecedor.Text = "Fabricante";
            this.btFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFornecedor.UseCompatibleTextRendering = true;
            this.btFornecedor.UseVisualStyleBackColor = true;
            this.btFornecedor.Click += new System.EventHandler(this.btFornecedor_Click);
            // 
            // btFuncionario
            // 
            this.btFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFuncionario.FlatAppearance.BorderSize = 0;
            this.btFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFuncionario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFuncionario.Location = new System.Drawing.Point(0, 32);
            this.btFuncionario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFuncionario.Name = "btFuncionario";
            this.btFuncionario.Size = new System.Drawing.Size(179, 32);
            this.btFuncionario.TabIndex = 2;
            this.btFuncionario.Text = "Funcionário";
            this.btFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFuncionario.UseCompatibleTextRendering = true;
            this.btFuncionario.UseVisualStyleBackColor = true;
            this.btFuncionario.Click += new System.EventHandler(this.btFuncionario_Click);
            // 
            // btProduto
            // 
            this.btProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btProduto.FlatAppearance.BorderSize = 0;
            this.btProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.btProduto.Location = new System.Drawing.Point(0, 0);
            this.btProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(179, 32);
            this.btProduto.TabIndex = 1;
            this.btProduto.Text = "Produto";
            this.btProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btProduto.UseVisualStyleBackColor = true;
            this.btProduto.Click += new System.EventHandler(this.btProduto_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastro.FlatAppearance.BorderSize = 0;
            this.btCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCadastro.Image = global::PDV_CLUSTERS.Properties.Resources.shopping_list;
            this.btCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastro.Location = new System.Drawing.Point(0, 239);
            this.btCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(179, 50);
            this.btCadastro.TabIndex = 3;
            this.btCadastro.Text = "Cadastro";
            this.btCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // panelSubmenuCaixa
            // 
            this.panelSubmenuCaixa.Controls.Add(this.btFechamento);
            this.panelSubmenuCaixa.Controls.Add(this.btSangria);
            this.panelSubmenuCaixa.Controls.Add(this.btVenda);
            this.panelSubmenuCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuCaixa.Location = new System.Drawing.Point(0, 144);
            this.panelSubmenuCaixa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSubmenuCaixa.Name = "panelSubmenuCaixa";
            this.panelSubmenuCaixa.Size = new System.Drawing.Size(179, 95);
            this.panelSubmenuCaixa.TabIndex = 2;
            // 
            // btFechamento
            // 
            this.btFechamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btFechamento.FlatAppearance.BorderSize = 0;
            this.btFechamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btFechamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btFechamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechamento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechamento.ForeColor = System.Drawing.Color.Gainsboro;
            this.btFechamento.Location = new System.Drawing.Point(0, 64);
            this.btFechamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btFechamento.Name = "btFechamento";
            this.btFechamento.Size = new System.Drawing.Size(179, 32);
            this.btFechamento.TabIndex = 2;
            this.btFechamento.Text = "Fechamento";
            this.btFechamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFechamento.UseVisualStyleBackColor = true;
            this.btFechamento.Click += new System.EventHandler(this.btFechamento_Click);
            // 
            // btSangria
            // 
            this.btSangria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSangria.FlatAppearance.BorderSize = 0;
            this.btSangria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btSangria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btSangria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSangria.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSangria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btSangria.Location = new System.Drawing.Point(0, 32);
            this.btSangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btSangria.Name = "btSangria";
            this.btSangria.Size = new System.Drawing.Size(179, 32);
            this.btSangria.TabIndex = 1;
            this.btSangria.Text = "Sangria";
            this.btSangria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSangria.UseVisualStyleBackColor = true;
            this.btSangria.Click += new System.EventHandler(this.btSangria_Click);
            // 
            // btVenda
            // 
            this.btVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVenda.FlatAppearance.BorderSize = 0;
            this.btVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVenda.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btVenda.Location = new System.Drawing.Point(0, 0);
            this.btVenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btVenda.Name = "btVenda";
            this.btVenda.Size = new System.Drawing.Size(179, 32);
            this.btVenda.TabIndex = 0;
            this.btVenda.Text = "Venda";
            this.btVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVenda.UseVisualStyleBackColor = true;
            this.btVenda.Click += new System.EventHandler(this.btVenda_Click);
            // 
            // btCaixa
            // 
            this.btCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCaixa.FlatAppearance.BorderSize = 0;
            this.btCaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCaixa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCaixa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCaixa.Image = global::PDV_CLUSTERS.Properties.Resources.shopping_cart__1_;
            this.btCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCaixa.Location = new System.Drawing.Point(0, 99);
            this.btCaixa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCaixa.Name = "btCaixa";
            this.btCaixa.Size = new System.Drawing.Size(179, 45);
            this.btCaixa.TabIndex = 1;
            this.btCaixa.Text = "Caixa";
            this.btCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCaixa.UseVisualStyleBackColor = true;
            this.btCaixa.Click += new System.EventHandler(this.btCaixa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 99);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PDV_CLUSTERS.Properties.Resources.LogoCerto2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(179, 32);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(796, 703);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::PDV_CLUSTERS.Properties.Resources.logo_grande;
            this.pictureBox2.Location = new System.Drawing.Point(34, 44);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(726, 589);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // InicioPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 735);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InicioPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InicioPDV_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelSubmenuCadastro.ResumeLayout(false);
            this.panelSubmenuCaixa.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Panel panelSubmenuCaixa;
       
        private System.Windows.Forms.Button btVenda;
        private System.Windows.Forms.Button btCaixa;
        private System.Windows.Forms.Panel panelSubmenuCadastro;
        private System.Windows.Forms.Button btFornecedor;
        private System.Windows.Forms.Button btFuncionario;
        private System.Windows.Forms.Button btProduto;
        
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btFechamento;
        private System.Windows.Forms.Button btSangria;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btLogoff;
    }
}

