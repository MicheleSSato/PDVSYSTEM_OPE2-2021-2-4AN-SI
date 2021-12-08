
namespace PDV_CLUSTERS
{
    partial class cupomVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTituloNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdVenda = new System.Windows.Forms.Label();
            this.lblfechar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.dgvItemVenda = new System.Windows.Forms.DataGridView();
            this.iDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORSUBTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBITEMVENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDVClusterDataSet7 = new PDV_CLUSTERS.PDVClusterDataSet7();
            this.tB_ITEM_VENDATableAdapter = new PDV_CLUSTERS.PDVClusterDataSet7TableAdapters.TB_ITEM_VENDATableAdapter();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lbTroco = new System.Windows.Forms.Label();
            this.lbValorRecebido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBITEMVENDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloNome
            // 
            this.lbTituloNome.AutoSize = true;
            this.lbTituloNome.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloNome.ForeColor = System.Drawing.Color.Black;
            this.lbTituloNome.Location = new System.Drawing.Point(37, 65);
            this.lbTituloNome.Name = "lbTituloNome";
            this.lbTituloNome.Size = new System.Drawing.Size(216, 28);
            this.lbTituloNome.TabIndex = 0;
            this.lbTituloNome.Text = "Cupom de Venda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PDV_CLUSTERS.Properties.Resources.LogoCerto2;
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº Venda";
            // 
            // lblIdVenda
            // 
            this.lblIdVenda.AutoSize = true;
            this.lblIdVenda.Location = new System.Drawing.Point(144, 125);
            this.lblIdVenda.Name = "lblIdVenda";
            this.lblIdVenda.Size = new System.Drawing.Size(48, 13);
            this.lblIdVenda.TabIndex = 3;
            this.lblIdVenda.Text = "id venda";
            // 
            // lblfechar
            // 
            this.lblfechar.AutoSize = true;
            this.lblfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechar.Location = new System.Drawing.Point(285, 0);
            this.lblfechar.Name = "lblfechar";
            this.lblfechar.Size = new System.Drawing.Size(15, 13);
            this.lblfechar.TabIndex = 4;
            this.lblfechar.Text = "X";
            this.lblfechar.Click += new System.EventHandler(this.lblfechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(144, 148);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(28, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Funcionário";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(143, 174);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(59, 13);
            this.lblFuncionario.TabIndex = 3;
            this.lblFuncionario.Text = "funcionario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tipo de Pagamento";
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Location = new System.Drawing.Point(143, 198);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(80, 13);
            this.lblTipoPagamento.TabIndex = 3;
            this.lblTipoPagamento.Text = "tipo pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CPF";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(143, 222);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(22, 13);
            this.lblCPF.TabIndex = 3;
            this.lblCPF.Text = "cpf";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Subtotal";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(143, 246);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(30, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "valor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(144, 290);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(53, 13);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "valor total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Desconto";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(144, 267);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(51, 13);
            this.lblDesconto.TabIndex = 3;
            this.lblDesconto.Text = "desconto";
            // 
            // dgvItemVenda
            // 
            this.dgvItemVenda.AllowUserToAddRows = false;
            this.dgvItemVenda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Moccasin;
            this.dgvItemVenda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemVenda.AutoGenerateColumns = false;
            this.dgvItemVenda.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvItemVenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVenda.ColumnHeadersVisible = false;
            this.dgvItemVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUTODataGridViewTextBoxColumn,
            this.nOMEPRODUTODataGridViewTextBoxColumn,
            this.vALORUNITARIODataGridViewTextBoxColumn,
            this.qTDDataGridViewTextBoxColumn,
            this.vALORSUBTOTALDataGridViewTextBoxColumn});
            this.dgvItemVenda.DataSource = this.tBITEMVENDABindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemVenda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItemVenda.GridColor = System.Drawing.Color.Moccasin;
            this.dgvItemVenda.Location = new System.Drawing.Point(11, 375);
            this.dgvItemVenda.Margin = new System.Windows.Forms.Padding(2);
            this.dgvItemVenda.Name = "dgvItemVenda";
            this.dgvItemVenda.ReadOnly = true;
            this.dgvItemVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemVenda.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItemVenda.RowHeadersVisible = false;
            this.dgvItemVenda.RowHeadersWidth = 10;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvItemVenda.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItemVenda.RowTemplate.Height = 24;
            this.dgvItemVenda.Size = new System.Drawing.Size(279, 250);
            this.dgvItemVenda.TabIndex = 5;
            // 
            // iDPRODUTODataGridViewTextBoxColumn
            // 
            this.iDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.HeaderText = "Código Produto";
            this.iDPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPRODUTODataGridViewTextBoxColumn.Name = "iDPRODUTODataGridViewTextBoxColumn";
            this.iDPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUTODataGridViewTextBoxColumn.Visible = false;
            this.iDPRODUTODataGridViewTextBoxColumn.Width = 50;
            // 
            // nOMEPRODUTODataGridViewTextBoxColumn
            // 
            this.nOMEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "NOME_PRODUTO";
            this.nOMEPRODUTODataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nOMEPRODUTODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nOMEPRODUTODataGridViewTextBoxColumn.Name = "nOMEPRODUTODataGridViewTextBoxColumn";
            this.nOMEPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEPRODUTODataGridViewTextBoxColumn.Width = 80;
            // 
            // vALORUNITARIODataGridViewTextBoxColumn
            // 
            this.vALORUNITARIODataGridViewTextBoxColumn.DataPropertyName = "VALOR_UNITARIO";
            this.vALORUNITARIODataGridViewTextBoxColumn.HeaderText = "Valor ";
            this.vALORUNITARIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORUNITARIODataGridViewTextBoxColumn.Name = "vALORUNITARIODataGridViewTextBoxColumn";
            this.vALORUNITARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORUNITARIODataGridViewTextBoxColumn.Width = 60;
            // 
            // qTDDataGridViewTextBoxColumn
            // 
            this.qTDDataGridViewTextBoxColumn.DataPropertyName = "QTD";
            this.qTDDataGridViewTextBoxColumn.HeaderText = "Qtd";
            this.qTDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qTDDataGridViewTextBoxColumn.Name = "qTDDataGridViewTextBoxColumn";
            this.qTDDataGridViewTextBoxColumn.ReadOnly = true;
            this.qTDDataGridViewTextBoxColumn.Width = 40;
            // 
            // vALORSUBTOTALDataGridViewTextBoxColumn
            // 
            this.vALORSUBTOTALDataGridViewTextBoxColumn.DataPropertyName = "VALOR_SUBTOTAL";
            this.vALORSUBTOTALDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.vALORSUBTOTALDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vALORSUBTOTALDataGridViewTextBoxColumn.Name = "vALORSUBTOTALDataGridViewTextBoxColumn";
            this.vALORSUBTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.vALORSUBTOTALDataGridViewTextBoxColumn.Width = 60;
            // 
            // tBITEMVENDABindingSource
            // 
            this.tBITEMVENDABindingSource.DataMember = "TB_ITEM_VENDA";
            this.tBITEMVENDABindingSource.DataSource = this.pDVClusterDataSet7;
            // 
            // pDVClusterDataSet7
            // 
            this.pDVClusterDataSet7.DataSetName = "PDVClusterDataSet7";
            this.pDVClusterDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tB_ITEM_VENDATableAdapter
            // 
            this.tB_ITEM_VENDATableAdapter.ClearBeforeFill = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(9, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Caixa";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Location = new System.Drawing.Point(143, 102);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(32, 13);
            this.lblCaixa.TabIndex = 3;
            this.lblCaixa.Text = "caixa";
            // 
            // lbTroco
            // 
            this.lbTroco.AutoSize = true;
            this.lbTroco.Location = new System.Drawing.Point(144, 343);
            this.lbTroco.Name = "lbTroco";
            this.lbTroco.Size = new System.Drawing.Size(31, 13);
            this.lbTroco.TabIndex = 8;
            this.lbTroco.Text = "troco";
            // 
            // lbValorRecebido
            // 
            this.lbValorRecebido.AutoSize = true;
            this.lbValorRecebido.Location = new System.Drawing.Point(144, 317);
            this.lbValorRecebido.Name = "lbValorRecebido";
            this.lbValorRecebido.Size = new System.Drawing.Size(74, 13);
            this.lbValorRecebido.TabIndex = 9;
            this.lbValorRecebido.Text = "valor recebido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Troco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Recebido";
            // 
            // cupomVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(299, 665);
            this.Controls.Add(this.lbValorRecebido);
            this.Controls.Add(this.lbTroco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvItemVenda);
            this.Controls.Add(this.lblfechar);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTipoPagamento);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.lblIdVenda);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTituloNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cupomVenda";
            this.Text = "cupomVenda";
            this.Load += new System.EventHandler(this.cupomVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBITEMVENDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVClusterDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdVenda;
        private System.Windows.Forms.Label lblfechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.DataGridView dgvItemVenda;
        private PDVClusterDataSet7 pDVClusterDataSet7;
        private System.Windows.Forms.BindingSource tBITEMVENDABindingSource;
        private PDVClusterDataSet7TableAdapters.TB_ITEM_VENDATableAdapter tB_ITEM_VENDATableAdapter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORUNITARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORSUBTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbTroco;
        private System.Windows.Forms.Label lbValorRecebido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}