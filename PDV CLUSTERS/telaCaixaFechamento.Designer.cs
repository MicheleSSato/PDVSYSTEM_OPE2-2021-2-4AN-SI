
namespace PDV_CLUSTERS
{
    partial class telaCaixaFechamento
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbNomeTela = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtPix = new System.Windows.Forms.TextBox();
            this.txtQrcode = new System.Windows.Forms.TextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCaixa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btVoltar.Location = new System.Drawing.Point(109, 550);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(115, 50);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lbNomeTela);
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 42);
            this.panel3.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 6);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(390, 30);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PDV_CLUSTERS.Properties.Resources.vetorCaixa1;
            this.pictureBox2.Location = new System.Drawing.Point(336, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbNomeTela
            // 
            this.lbNomeTela.AutoSize = true;
            this.lbNomeTela.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeTela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNomeTela.Location = new System.Drawing.Point(3, 2);
            this.lbNomeTela.Name = "lbNomeTela";
            this.lbNomeTela.Size = new System.Drawing.Size(339, 36);
            this.lbNomeTela.TabIndex = 0;
            this.lbNomeTela.Text = "Fechamento de Caixa";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDinheiro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDinheiro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDinheiro.Enabled = false;
            this.txtDinheiro.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.HideSelection = false;
            this.txtDinheiro.Location = new System.Drawing.Point(303, 110);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(199, 37);
            this.txtDinheiro.TabIndex = 22;
            this.txtDinheiro.Text = "0,00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pagamento em Dinheiro";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pagamento em Débito";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pagamento em Crédito";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pagamento em PIX";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pagamento em QRCode";
            // 
            // txtDebito
            // 
            this.txtDebito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDebito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDebito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDebito.Enabled = false;
            this.txtDebito.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebito.HideSelection = false;
            this.txtDebito.Location = new System.Drawing.Point(303, 166);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(199, 37);
            this.txtDebito.TabIndex = 28;
            this.txtDebito.Text = "0,00";
            // 
            // txtCredito
            // 
            this.txtCredito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCredito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCredito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCredito.Enabled = false;
            this.txtCredito.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredito.HideSelection = false;
            this.txtCredito.Location = new System.Drawing.Point(303, 223);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(199, 37);
            this.txtCredito.TabIndex = 29;
            this.txtCredito.Text = "0,00";
            // 
            // txtPix
            // 
            this.txtPix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPix.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPix.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPix.Enabled = false;
            this.txtPix.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPix.HideSelection = false;
            this.txtPix.Location = new System.Drawing.Point(303, 278);
            this.txtPix.Name = "txtPix";
            this.txtPix.Size = new System.Drawing.Size(199, 37);
            this.txtPix.TabIndex = 30;
            this.txtPix.Text = "0,00";
            // 
            // txtQrcode
            // 
            this.txtQrcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQrcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtQrcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtQrcode.Enabled = false;
            this.txtQrcode.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQrcode.HideSelection = false;
            this.txtQrcode.Location = new System.Drawing.Point(303, 331);
            this.txtQrcode.Name = "txtQrcode";
            this.txtQrcode.Size = new System.Drawing.Size(199, 37);
            this.txtQrcode.TabIndex = 31;
            this.txtQrcode.Text = "0,00";
            // 
            // btFechar
            // 
            this.btFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btFechar.FlatAppearance.BorderSize = 0;
            this.btFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btFechar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btFechar.Location = new System.Drawing.Point(525, 550);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(123, 50);
            this.btFechar.TabIndex = 33;
            this.btFechar.Text = "Fechar Caixa";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCaixa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQrcode);
            this.groupBox1.Controls.Add(this.txtPix);
            this.groupBox1.Controls.Add(this.txtCredito);
            this.groupBox1.Controls.Add(this.txtDebito);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDinheiro);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(109, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(539, 413);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caixa";
            // 
            // cbxCaixa
            // 
            this.cbxCaixa.FormattingEnabled = true;
            this.cbxCaixa.Location = new System.Drawing.Point(12, 38);
            this.cbxCaixa.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCaixa.Name = "cbxCaixa";
            this.cbxCaixa.Size = new System.Drawing.Size(92, 40);
            this.cbxCaixa.TabIndex = 34;
            this.cbxCaixa.SelectionChangeCommitted += new System.EventHandler(this.cbxCaixa_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total do Dia";
            // 
            // telaCaixaFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaCaixaFechamento";
            this.Text = "796; 703";
            this.Load += new System.EventHandler(this.telaCaixaFechamento_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbNomeTela;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtPix;
        private System.Windows.Forms.TextBox txtQrcode;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCaixa;
    }
}