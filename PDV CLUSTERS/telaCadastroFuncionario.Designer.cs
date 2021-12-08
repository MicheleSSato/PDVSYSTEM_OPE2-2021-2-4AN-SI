
namespace PDV_CLUSTERS
{
    partial class telaCadastroFuncionario
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNomeTela = new System.Windows.Forms.Label();
            this.textBoxBuscaFuncionario = new System.Windows.Forms.TextBox();
            this.dgvListaFuncionario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBCADASTROFUNCIONARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDVClusterDataSet6 = new PDV_CLUSTERS.PDVClusterDataSet6();
            this.btPesquisarFuncionario = new System.Windows.Forms.Button();
            this.btAdicionarFuncionario = new System.Windows.Forms.Button();
            this.btExcluirFuncionario = new System.Windows.Forms.Button();
            this.btAlterarFuncionario = new System.Windows.Forms.Button();
            this.tB_CADASTRO_FUNCIONARIOTableAdapter = new PDV_CLUSTERS.PDVClusterDataSet6TableAdapters.TB_CADASTRO_FUNCIONARIOTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCADASTROFUNCIONARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btVoltar.Location = new System.Drawing.Point(10, 634);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(108, 57);
            this.btVoltar.TabIndex = 2;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbNomeTela);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 34);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDV_CLUSTERS.Properties.Resources.value;
            this.pictureBox1.Location = new System.Drawing.Point(405, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbNomeTela
            // 
            this.lbNomeTela.AutoSize = true;
            this.lbNomeTela.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeTela.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNomeTela.Location = new System.Drawing.Point(3, -1);
            this.lbNomeTela.Name = "lbNomeTela";
            this.lbNomeTela.Size = new System.Drawing.Size(382, 36);
            this.lbNomeTela.TabIndex = 1;
            this.lbNomeTela.Text = "Cadastro de Funcionários";
            // 
            // textBoxBuscaFuncionario
            // 
            this.textBoxBuscaFuncionario.Location = new System.Drawing.Point(12, 57);
            this.textBoxBuscaFuncionario.Multiline = true;
            this.textBoxBuscaFuncionario.Name = "textBoxBuscaFuncionario";
            this.textBoxBuscaFuncionario.Size = new System.Drawing.Size(658, 57);
            this.textBoxBuscaFuncionario.TabIndex = 6;
            // 
            // dgvListaFuncionario
            // 
            this.dgvListaFuncionario.AllowUserToAddRows = false;
            this.dgvListaFuncionario.AllowUserToDeleteRows = false;
            this.dgvListaFuncionario.AutoGenerateColumns = false;
            this.dgvListaFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaFuncionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvListaFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvListaFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaFuncionario.ColumnHeadersHeight = 30;
            this.dgvListaFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn0,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvListaFuncionario.DataSource = this.tBCADASTROFUNCIONARIOBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaFuncionario.EnableHeadersVisualStyles = false;
            this.dgvListaFuncionario.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvListaFuncionario.Location = new System.Drawing.Point(10, 132);
            this.dgvListaFuncionario.Name = "dgvListaFuncionario";
            this.dgvListaFuncionario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaFuncionario.RowHeadersVisible = false;
            this.dgvListaFuncionario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lavender;
            this.dgvListaFuncionario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaFuncionario.Size = new System.Drawing.Size(772, 491);
            this.dgvListaFuncionario.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn0
            // 
            this.dataGridViewTextBoxColumn0.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn0.FillWeight = 66.33072F;
            this.dataGridViewTextBoxColumn0.HeaderText = "ID";
            this.dataGridViewTextBoxColumn0.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn0.Name = "dataGridViewTextBoxColumn0";
            this.dataGridViewTextBoxColumn0.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LOGIN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.FillWeight = 108.1994F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn3.FillWeight = 108.1994F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn4.FillWeight = 108.1994F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Tel";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn5.FillWeight = 90.81177F;
            this.dataGridViewTextBoxColumn5.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RG";
            this.dataGridViewTextBoxColumn6.FillWeight = 64.80467F;
            this.dataGridViewTextBoxColumn6.HeaderText = "RG";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "COD_INTERNO";
            this.dataGridViewTextBoxColumn7.FillWeight = 137.0558F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Cód. Interno";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SALARIO";
            this.dataGridViewTextBoxColumn8.HeaderText = "SALARIO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tBCADASTROFUNCIONARIOBindingSource
            // 
            this.tBCADASTROFUNCIONARIOBindingSource.DataMember = "TB_CADASTRO_FUNCIONARIO";
            this.tBCADASTROFUNCIONARIOBindingSource.DataSource = this.pDVClusterDataSet6;
            // 
            // pDVClusterDataSet6
            // 
            this.pDVClusterDataSet6.DataSetName = "PDVClusterDataSet6";
            this.pDVClusterDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btPesquisarFuncionario
            // 
            this.btPesquisarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btPesquisarFuncionario.FlatAppearance.BorderSize = 0;
            this.btPesquisarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisarFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btPesquisarFuncionario.Location = new System.Drawing.Point(676, 57);
            this.btPesquisarFuncionario.Name = "btPesquisarFuncionario";
            this.btPesquisarFuncionario.Size = new System.Drawing.Size(108, 57);
            this.btPesquisarFuncionario.TabIndex = 14;
            this.btPesquisarFuncionario.Text = "Pesquisar";
            this.btPesquisarFuncionario.UseVisualStyleBackColor = false;
            this.btPesquisarFuncionario.Click += new System.EventHandler(this.BtPesquisarFuncionario_Click);
            // 
            // btAdicionarFuncionario
            // 
            this.btAdicionarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btAdicionarFuncionario.FlatAppearance.BorderSize = 0;
            this.btAdicionarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAdicionarFuncionario.Location = new System.Drawing.Point(446, 635);
            this.btAdicionarFuncionario.Name = "btAdicionarFuncionario";
            this.btAdicionarFuncionario.Size = new System.Drawing.Size(108, 57);
            this.btAdicionarFuncionario.TabIndex = 15;
            this.btAdicionarFuncionario.Text = "Adicionar";
            this.btAdicionarFuncionario.UseVisualStyleBackColor = false;
            this.btAdicionarFuncionario.Click += new System.EventHandler(this.btAdicionarFuncionario_Click);
            // 
            // btExcluirFuncionario
            // 
            this.btExcluirFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btExcluirFuncionario.FlatAppearance.BorderSize = 0;
            this.btExcluirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btExcluirFuncionario.Location = new System.Drawing.Point(674, 635);
            this.btExcluirFuncionario.Name = "btExcluirFuncionario";
            this.btExcluirFuncionario.Size = new System.Drawing.Size(108, 57);
            this.btExcluirFuncionario.TabIndex = 17;
            this.btExcluirFuncionario.Text = "Excluir";
            this.btExcluirFuncionario.UseVisualStyleBackColor = false;
            this.btExcluirFuncionario.Click += new System.EventHandler(this.btExcluirFuncionario_Click);
            // 
            // btAlterarFuncionario
            // 
            this.btAlterarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(130)))));
            this.btAlterarFuncionario.FlatAppearance.BorderSize = 0;
            this.btAlterarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAlterarFuncionario.Location = new System.Drawing.Point(560, 635);
            this.btAlterarFuncionario.Name = "btAlterarFuncionario";
            this.btAlterarFuncionario.Size = new System.Drawing.Size(108, 57);
            this.btAlterarFuncionario.TabIndex = 18;
            this.btAlterarFuncionario.Text = "Alterar";
            this.btAlterarFuncionario.UseVisualStyleBackColor = false;
            this.btAlterarFuncionario.Click += new System.EventHandler(this.btAlterarFuncionario_Click);
            // 
            // tB_CADASTRO_FUNCIONARIOTableAdapter
            // 
            this.tB_CADASTRO_FUNCIONARIOTableAdapter.ClearBeforeFill = true;
            // 
            // telaCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 703);
            this.Controls.Add(this.btAlterarFuncionario);
            this.Controls.Add(this.btExcluirFuncionario);
            this.Controls.Add(this.btAdicionarFuncionario);
            this.Controls.Add(this.btPesquisarFuncionario);
            this.Controls.Add(this.dgvListaFuncionario);
            this.Controls.Add(this.textBoxBuscaFuncionario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaCadastroFuncionario";
            this.Text = "telaCadastroFuncionario";
            this.Load += new System.EventHandler(this.telaCadastroFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCADASTROFUNCIONARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNomeTela;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxBuscaFuncionario;
        private System.Windows.Forms.DataGridView dgvListaFuncionario;
        private System.Windows.Forms.Button btPesquisarFuncionario;
        private System.Windows.Forms.Button btAdicionarFuncionario;
        private System.Windows.Forms.Button btExcluirFuncionario;
        private System.Windows.Forms.Button btAlterarFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODINTERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIVELACESSODataGridViewTextBoxColumn;
        private PDVClusterDataSet6 pDVClusterDataSet6;
        private System.Windows.Forms.BindingSource tBCADASTROFUNCIONARIOBindingSource;
        private PDVClusterDataSet6TableAdapters.TB_CADASTRO_FUNCIONARIOTableAdapter tB_CADASTRO_FUNCIONARIOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}