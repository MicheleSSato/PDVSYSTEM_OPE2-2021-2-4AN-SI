
namespace PDV_CLUSTERS
{
    partial class telaCadastroProduto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaProduto = new System.Windows.Forms.DataGridView();
            this.tBCADASTROPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDVClusterDataSet3 = new PDV_CLUSTERS.PDVClusterDataSet3();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.textBoxBuscaProduto = new System.Windows.Forms.TextBox();
            this.btAdicionarNovo = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.pDVClusterDataSet = new PDV_CLUSTERS.PDVClusterDataSet();
            this.tBCADASTROFORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tB_CADASTRO_FORNECEDORTableAdapter = new PDV_CLUSTERS.PDVClusterDataSetTableAdapters.TB_CADASTRO_FORNECEDORTableAdapter();
            this.pDVClusterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNomeTela = new System.Windows.Forms.Label();
            this.tB_CADASTRO_PRODUTOTableAdapter = new PDV_CLUSTERS.PDVClusterDataSet3TableAdapters.TB_CADASTRO_PRODUTOTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODBARRASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_INTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOCOMPRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARGEMLUCRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCADASTROPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCADASTROFORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProduto
            // 
            this.dgvListaProduto.AllowUserToAddRows = false;
            this.dgvListaProduto.AllowUserToDeleteRows = false;
            this.dgvListaProduto.AutoGenerateColumns = false;
            this.dgvListaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvListaProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProduto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvListaProduto.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvListaProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.cODBARRASDataGridViewTextBoxColumn,
            this.COD_INTERNO,
            this.pRECOCOMPRADataGridViewTextBoxColumn,
            this.pRECOVENDADataGridViewTextBoxColumn,
            this.mARGEMLUCRODataGridViewTextBoxColumn});
            this.dgvListaProduto.DataSource = this.tBCADASTROPRODUTOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProduto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProduto.EnableHeadersVisualStyles = false;
            this.dgvListaProduto.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListaProduto.Location = new System.Drawing.Point(12, 104);
            this.dgvListaProduto.Name = "dgvListaProduto";
            this.dgvListaProduto.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProduto.RowHeadersVisible = false;
            this.dgvListaProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgvListaProduto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaProduto.Size = new System.Drawing.Size(775, 441);
            this.dgvListaProduto.TabIndex = 8;
            // 
            // tBCADASTROPRODUTOBindingSource
            // 
            this.tBCADASTROPRODUTOBindingSource.DataMember = "TB_CADASTRO_PRODUTO";
            this.tBCADASTROPRODUTOBindingSource.DataSource = this.pDVClusterDataSet3;
            // 
            // pDVClusterDataSet3
            // 
            this.pDVClusterDataSet3.DataSetName = "PDVClusterDataSet3";
            this.pDVClusterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btPesquisar.Location = new System.Drawing.Point(679, 44);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(108, 54);
            this.btPesquisar.TabIndex = 17;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // textBoxBuscaProduto
            // 
            this.textBoxBuscaProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxBuscaProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxBuscaProduto.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscaProduto.HideSelection = false;
            this.textBoxBuscaProduto.Location = new System.Drawing.Point(12, 41);
            this.textBoxBuscaProduto.Name = "textBoxBuscaProduto";
            this.textBoxBuscaProduto.Size = new System.Drawing.Size(661, 57);
            this.textBoxBuscaProduto.TabIndex = 18;
            // 
            // btAdicionarNovo
            // 
            this.btAdicionarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btAdicionarNovo.FlatAppearance.BorderSize = 0;
            this.btAdicionarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAdicionarNovo.Location = new System.Drawing.Point(451, 551);
            this.btAdicionarNovo.Name = "btAdicionarNovo";
            this.btAdicionarNovo.Size = new System.Drawing.Size(108, 54);
            this.btAdicionarNovo.TabIndex = 19;
            this.btAdicionarNovo.Text = "Adicionar";
            this.btAdicionarNovo.UseCompatibleTextRendering = true;
            this.btAdicionarNovo.UseVisualStyleBackColor = false;
            this.btAdicionarNovo.Click += new System.EventHandler(this.btAdicionarNovo_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btAlterar.FlatAppearance.BorderSize = 0;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAlterar.Location = new System.Drawing.Point(565, 551);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(108, 54);
            this.btAlterar.TabIndex = 20;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btExcluir.Location = new System.Drawing.Point(679, 551);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(108, 54);
            this.btExcluir.TabIndex = 21;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btVoltar.Location = new System.Drawing.Point(10, 551);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(108, 54);
            this.btVoltar.TabIndex = 22;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // pDVClusterDataSet
            // 
            this.pDVClusterDataSet.DataSetName = "PDVClusterDataSet";
            this.pDVClusterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBCADASTROFORNECEDORBindingSource
            // 
            this.tBCADASTROFORNECEDORBindingSource.DataMember = "TB_CADASTRO_FORNECEDOR";
            this.tBCADASTROFORNECEDORBindingSource.DataSource = this.pDVClusterDataSet;
            // 
            // tB_CADASTRO_FORNECEDORTableAdapter
            // 
            this.tB_CADASTRO_FORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // pDVClusterDataSetBindingSource
            // 
            this.pDVClusterDataSetBindingSource.DataSource = this.pDVClusterDataSet;
            this.pDVClusterDataSetBindingSource.Position = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbNomeTela);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 34);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDV_CLUSTERS.Properties.Resources.value;
            this.pictureBox1.Location = new System.Drawing.Point(277, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbNomeTela
            // 
            this.lbNomeTela.AutoSize = true;
            this.lbNomeTela.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeTela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNomeTela.Location = new System.Drawing.Point(3, -2);
            this.lbNomeTela.Name = "lbNomeTela";
            this.lbNomeTela.Size = new System.Drawing.Size(278, 36);
            this.lbNomeTela.TabIndex = 0;
            this.lbNomeTela.Text = "Cadastrar Produto";
            // 
            // tB_CADASTRO_PRODUTOTableAdapter
            // 
            this.tB_CADASTRO_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 33;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nOMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEDataGridViewTextBoxColumn.Width = 97;
            // 
            // cODBARRASDataGridViewTextBoxColumn
            // 
            this.cODBARRASDataGridViewTextBoxColumn.DataPropertyName = "COD_BARRAS";
            this.cODBARRASDataGridViewTextBoxColumn.HeaderText = "Cód.Barras";
            this.cODBARRASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cODBARRASDataGridViewTextBoxColumn.Name = "cODBARRASDataGridViewTextBoxColumn";
            this.cODBARRASDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODBARRASDataGridViewTextBoxColumn.Width = 120;
            // 
            // COD_INTERNO
            // 
            this.COD_INTERNO.DataPropertyName = "COD_INTERNO";
            this.COD_INTERNO.HeaderText = "Cód.Interno";
            this.COD_INTERNO.MinimumWidth = 6;
            this.COD_INTERNO.Name = "COD_INTERNO";
            this.COD_INTERNO.ReadOnly = true;
            this.COD_INTERNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COD_INTERNO.Width = 130;
            // 
            // pRECOCOMPRADataGridViewTextBoxColumn
            // 
            this.pRECOCOMPRADataGridViewTextBoxColumn.DataPropertyName = "PRECO_COMPRA";
            this.pRECOCOMPRADataGridViewTextBoxColumn.HeaderText = "Preço Compra";
            this.pRECOCOMPRADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECOCOMPRADataGridViewTextBoxColumn.Name = "pRECOCOMPRADataGridViewTextBoxColumn";
            this.pRECOCOMPRADataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECOCOMPRADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRECOCOMPRADataGridViewTextBoxColumn.Width = 148;
            // 
            // pRECOVENDADataGridViewTextBoxColumn
            // 
            this.pRECOVENDADataGridViewTextBoxColumn.DataPropertyName = "PRECO_VENDA";
            this.pRECOVENDADataGridViewTextBoxColumn.HeaderText = "Preço Venda";
            this.pRECOVENDADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRECOVENDADataGridViewTextBoxColumn.Name = "pRECOVENDADataGridViewTextBoxColumn";
            this.pRECOVENDADataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECOVENDADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRECOVENDADataGridViewTextBoxColumn.Width = 136;
            // 
            // mARGEMLUCRODataGridViewTextBoxColumn
            // 
            this.mARGEMLUCRODataGridViewTextBoxColumn.DataPropertyName = "MARGEM_LUCRO";
            this.mARGEMLUCRODataGridViewTextBoxColumn.HeaderText = "Margem";
            this.mARGEMLUCRODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mARGEMLUCRODataGridViewTextBoxColumn.Name = "mARGEMLUCRODataGridViewTextBoxColumn";
            this.mARGEMLUCRODataGridViewTextBoxColumn.ReadOnly = true;
            this.mARGEMLUCRODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mARGEMLUCRODataGridViewTextBoxColumn.Width = 102;
            // 
            // telaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btAdicionarNovo);
            this.Controls.Add(this.textBoxBuscaProduto);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.dgvListaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaCadastroProduto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telaCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCADASTROPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCADASTROFORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaProduto;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox textBoxBuscaProduto;
        private System.Windows.Forms.Button btAdicionarNovo;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btVoltar;
        private PDVClusterDataSet pDVClusterDataSet;
        private System.Windows.Forms.BindingSource tBCADASTROFORNECEDORBindingSource;
        private PDVClusterDataSetTableAdapters.TB_CADASTRO_FORNECEDORTableAdapter tB_CADASTRO_FORNECEDORTableAdapter;
        private System.Windows.Forms.BindingSource pDVClusterDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbNomeTela;
        private PDVClusterDataSet3 pDVClusterDataSet3;
        private System.Windows.Forms.BindingSource tBCADASTROPRODUTOBindingSource;
        private PDVClusterDataSet3TableAdapters.TB_CADASTRO_PRODUTOTableAdapter tB_CADASTRO_PRODUTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODBARRASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_INTERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCOMPRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARGEMLUCRODataGridViewTextBoxColumn;
    }
}