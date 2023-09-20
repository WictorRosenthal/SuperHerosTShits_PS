namespace SuperHerosTShits_PS
{
    partial class FormVenda
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
            this.albel = new System.Windows.Forms.Panel();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtTotalVenda = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCriarVenda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnInserirItemVenda = new System.Windows.Forms.Button();
            this.dgvItensVenda = new System.Windows.Forms.DataGridView();
            this.superHeroShirtsDBDataSet = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSet();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter();
            this.vendaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensVendaTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new SuperHerosTShits_PS.SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter();
            this.produtoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // albel
            // 
            this.albel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.albel.Controls.Add(this.dgvItensVenda);
            this.albel.Controls.Add(this.btnInserirItemVenda);
            this.albel.Controls.Add(this.nudQuantidade);
            this.albel.Controls.Add(this.cmbProduto);
            this.albel.Controls.Add(this.label8);
            this.albel.Controls.Add(this.label7);
            this.albel.Controls.Add(this.label6);
            this.albel.Location = new System.Drawing.Point(10, 260);
            this.albel.Name = "albel";
            this.albel.Size = new System.Drawing.Size(540, 297);
            this.albel.TabIndex = 0;
            this.albel.Visible = false;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vendaBindingSource, "DataVenda", true));
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource1, "VendaID", true));
            this.dtpDataVenda.Location = new System.Drawing.Point(37, 77);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(228, 20);
            this.dtpDataVenda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data da venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor total da venda";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "FuncionarioID", true));
            this.cmbVendedor.DataSource = this.funcionariosBindingSource;
            this.cmbVendedor.DisplayMember = "Nome";
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(37, 149);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(200, 21);
            this.cmbVendedor.TabIndex = 7;
            this.cmbVendedor.ValueMember = "FuncionarioID";
            // 
            // cmbCliente
            // 
            this.cmbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "ClienteID", true));
            this.cmbCliente.DataSource = this.clienteBindingSource;
            this.cmbCliente.DisplayMember = "Nome";
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(37, 211);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 21);
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.ValueMember = "ClienteID";
            // 
            // txtTotalVenda
            // 
            this.txtTotalVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "TotalVenda", true));
            this.txtTotalVenda.Location = new System.Drawing.Point(407, 166);
            this.txtTotalVenda.Name = "txtTotalVenda";
            this.txtTotalVenda.Size = new System.Drawing.Size(100, 20);
            this.txtTotalVenda.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(406, 80);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(236, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Venda";
            // 
            // btnCriarVenda
            // 
            this.btnCriarVenda.Location = new System.Drawing.Point(432, 195);
            this.btnCriarVenda.Name = "btnCriarVenda";
            this.btnCriarVenda.Size = new System.Drawing.Size(75, 23);
            this.btnCriarVenda.TabIndex = 12;
            this.btnCriarVenda.Text = "Criar Venda";
            this.btnCriarVenda.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(182, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Itens da Venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quantidade";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "ProdutoId", true));
            this.cmbProduto.DataSource = this.produtoBindingSource;
            this.cmbProduto.DisplayMember = "NomeProduto";
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(27, 64);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(252, 21);
            this.cmbProduto.TabIndex = 3;
            this.cmbProduto.ValueMember = "ProdutoID";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itensVendaBindingSource, "Quantidade", true));
            this.nudQuantidade.Location = new System.Drawing.Point(396, 64);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(120, 20);
            this.nudQuantidade.TabIndex = 4;
            // 
            // btnInserirItemVenda
            // 
            this.btnInserirItemVenda.Location = new System.Drawing.Point(441, 90);
            this.btnInserirItemVenda.Name = "btnInserirItemVenda";
            this.btnInserirItemVenda.Size = new System.Drawing.Size(75, 23);
            this.btnInserirItemVenda.TabIndex = 5;
            this.btnInserirItemVenda.Text = "Inserir";
            this.btnInserirItemVenda.UseVisualStyleBackColor = true;
            // 
            // dgvItensVenda
            // 
            this.dgvItensVenda.AutoGenerateColumns = false;
            this.dgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produtoIdDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.dgvItensVenda.DataSource = this.itensVendaBindingSource;
            this.dgvItensVenda.Location = new System.Drawing.Point(18, 119);
            this.dgvItensVenda.Name = "dgvItensVenda";
            this.dgvItensVenda.ReadOnly = true;
            this.dgvItensVenda.Size = new System.Drawing.Size(498, 150);
            this.dgvItensVenda.TabIndex = 6;
            // 
            // superHeroShirtsDBDataSet
            // 
            this.superHeroShirtsDBDataSet.DataSetName = "SuperHeroShirtsDBDataSet";
            this.superHeroShirtsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            this.funcionariosBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // vendaBindingSource1
            // 
            this.vendaBindingSource1.DataMember = "Venda";
            this.vendaBindingSource1.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataMember = "ItensVenda";
            this.itensVendaBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // itensVendaTableAdapter
            // 
            this.itensVendaTableAdapter.ClearBeforeFill = true;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.superHeroShirtsDBDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // produtoIdDataGridViewTextBoxColumn
            // 
            this.produtoIdDataGridViewTextBoxColumn.DataPropertyName = "ProdutoId";
            this.produtoIdDataGridViewTextBoxColumn.DataSource = this.produtoBindingSource;
            this.produtoIdDataGridViewTextBoxColumn.DisplayMember = "NomeProduto";
            this.produtoIdDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoIdDataGridViewTextBoxColumn.Name = "produtoIdDataGridViewTextBoxColumn";
            this.produtoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtoIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.produtoIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.produtoIdDataGridViewTextBoxColumn.ValueMember = "ProdutoID";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 569);
            this.Controls.Add(this.btnCriarVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTotalVenda);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDataVenda);
            this.Controls.Add(this.albel);
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.albel.ResumeLayout(false);
            this.albel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superHeroShirtsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel albel;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtTotalVenda;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriarVenda;
        private System.Windows.Forms.DataGridView dgvItensVenda;
        private System.Windows.Forms.Button btnInserirItemVenda;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private SuperHeroShirtsDBDataSet superHeroShirtsDBDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.FuncionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.BindingSource vendaBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ItensVendaTableAdapter itensVendaTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private SuperHeroShirtsDBDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn produtoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
    }
}