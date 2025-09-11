namespace Onlypães
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagarDescricao = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbprecoEditar = new System.Windows.Forms.TextBox();
            this.txbProdutoEditar = new System.Windows.Forms.TextBox();
            this.lblCategoriaEditar = new System.Windows.Forms.Label();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.lblProdutoEditar = new System.Windows.Forms.Label();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaCadastro = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbPrecoCadastro = new System.Windows.Forms.TextBox();
            this.txbProdutoCadastro = new System.Windows.Forms.TextBox();
            this.lblCategoriaCadastro = new System.Windows.Forms.Label();
            this.lblPrecoCadastrar = new System.Windows.Forms.Label();
            this.lblProdutoCadastro = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbApagar.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(103, -83);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(364, 40);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Gerenciador de Usuários";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagarDescricao);
            this.grbApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbApagar.Location = new System.Drawing.Point(18, 580);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(709, 88);
            this.grbApagar.TabIndex = 9;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Brown;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Location = new System.Drawing.Point(500, 11);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(203, 71);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagarDescricao
            // 
            this.lblApagarDescricao.AutoSize = true;
            this.lblApagarDescricao.Location = new System.Drawing.Point(13, 46);
            this.lblApagarDescricao.Name = "lblApagarDescricao";
            this.lblApagarDescricao.Size = new System.Drawing.Size(174, 13);
            this.lblApagarDescricao.TabIndex = 0;
            this.lblApagarDescricao.Text = "Selecione um Produto para apagar:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.cmbCategoriaEditar);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbprecoEditar);
            this.grbEditar.Controls.Add(this.txbProdutoEditar);
            this.grbEditar.Controls.Add(this.lblCategoriaEditar);
            this.grbEditar.Controls.Add(this.lblPrecoEditar);
            this.grbEditar.Controls.Add(this.lblProdutoEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbEditar.Location = new System.Drawing.Point(382, 355);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(345, 219);
            this.grbEditar.TabIndex = 8;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // cmbCategoriaEditar
            // 
            this.cmbCategoriaEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.cmbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoriaEditar.FormattingEnabled = true;
            this.cmbCategoriaEditar.Location = new System.Drawing.Point(136, 112);
            this.cmbCategoriaEditar.Name = "cmbCategoriaEditar";
            this.cmbCategoriaEditar.Size = new System.Drawing.Size(139, 21);
            this.cmbCategoriaEditar.TabIndex = 14;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(6, 155);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(333, 58);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbprecoEditar
            // 
            this.txbprecoEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbprecoEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbprecoEditar.Location = new System.Drawing.Point(136, 72);
            this.txbprecoEditar.Name = "txbprecoEditar";
            this.txbprecoEditar.Size = new System.Drawing.Size(141, 20);
            this.txbprecoEditar.TabIndex = 11;
            // 
            // txbProdutoEditar
            // 
            this.txbProdutoEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbProdutoEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdutoEditar.Location = new System.Drawing.Point(136, 31);
            this.txbProdutoEditar.Name = "txbProdutoEditar";
            this.txbProdutoEditar.Size = new System.Drawing.Size(141, 20);
            this.txbProdutoEditar.TabIndex = 10;
            // 
            // lblCategoriaEditar
            // 
            this.lblCategoriaEditar.AutoSize = true;
            this.lblCategoriaEditar.Location = new System.Drawing.Point(78, 115);
            this.lblCategoriaEditar.Name = "lblCategoriaEditar";
            this.lblCategoriaEditar.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaEditar.TabIndex = 9;
            this.lblCategoriaEditar.Text = "Categoria:";
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(88, 77);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(37, 13);
            this.lblPrecoEditar.TabIndex = 8;
            this.lblPrecoEditar.Text = "preço:";
            // 
            // lblProdutoEditar
            // 
            this.lblProdutoEditar.AutoSize = true;
            this.lblProdutoEditar.Location = new System.Drawing.Point(78, 38);
            this.lblProdutoEditar.Name = "lblProdutoEditar";
            this.lblProdutoEditar.Size = new System.Drawing.Size(47, 13);
            this.lblProdutoEditar.TabIndex = 7;
            this.lblProdutoEditar.Text = "Produto:";
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.cmbCategoriaCadastro);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbPrecoCadastro);
            this.grbCadastro.Controls.Add(this.txbProdutoCadastro);
            this.grbCadastro.Controls.Add(this.lblCategoriaCadastro);
            this.grbCadastro.Controls.Add(this.lblPrecoCadastrar);
            this.grbCadastro.Controls.Add(this.lblProdutoCadastro);
            this.grbCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbCadastro.Location = new System.Drawing.Point(18, 355);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(345, 219);
            this.grbCadastro.TabIndex = 7;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // cmbCategoriaCadastro
            // 
            this.cmbCategoriaCadastro.BackColor = System.Drawing.Color.SaddleBrown;
            this.cmbCategoriaCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoriaCadastro.FormattingEnabled = true;
            this.cmbCategoriaCadastro.Location = new System.Drawing.Point(118, 117);
            this.cmbCategoriaCadastro.Name = "cmbCategoriaCadastro";
            this.cmbCategoriaCadastro.Size = new System.Drawing.Size(139, 21);
            this.cmbCategoriaCadastro.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(6, 155);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(333, 58);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbPrecoCadastro
            // 
            this.txbPrecoCadastro.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbPrecoCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrecoCadastro.Location = new System.Drawing.Point(118, 73);
            this.txbPrecoCadastro.Name = "txbPrecoCadastro";
            this.txbPrecoCadastro.Size = new System.Drawing.Size(141, 20);
            this.txbPrecoCadastro.TabIndex = 4;
            // 
            // txbProdutoCadastro
            // 
            this.txbProdutoCadastro.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbProdutoCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProdutoCadastro.Location = new System.Drawing.Point(118, 36);
            this.txbProdutoCadastro.Name = "txbProdutoCadastro";
            this.txbProdutoCadastro.Size = new System.Drawing.Size(141, 20);
            this.txbProdutoCadastro.TabIndex = 3;
            // 
            // lblCategoriaCadastro
            // 
            this.lblCategoriaCadastro.AutoSize = true;
            this.lblCategoriaCadastro.Location = new System.Drawing.Point(59, 120);
            this.lblCategoriaCadastro.Name = "lblCategoriaCadastro";
            this.lblCategoriaCadastro.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaCadastro.TabIndex = 2;
            this.lblCategoriaCadastro.Text = "Categoria:";
            // 
            // lblPrecoCadastrar
            // 
            this.lblPrecoCadastrar.AutoSize = true;
            this.lblPrecoCadastrar.Location = new System.Drawing.Point(77, 77);
            this.lblPrecoCadastrar.Name = "lblPrecoCadastrar";
            this.lblPrecoCadastrar.Size = new System.Drawing.Size(37, 13);
            this.lblPrecoCadastrar.TabIndex = 1;
            this.lblPrecoCadastrar.Text = "preço:";
            // 
            // lblProdutoCadastro
            // 
            this.lblProdutoCadastro.AutoSize = true;
            this.lblProdutoCadastro.Location = new System.Drawing.Point(71, 38);
            this.lblProdutoCadastro.Name = "lblProdutoCadastro";
            this.lblProdutoCadastro.Size = new System.Drawing.Size(44, 13);
            this.lblProdutoCadastro.TabIndex = 0;
            this.lblProdutoCadastro.Text = "Produto";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(18, 120);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(709, 229);
            this.dgvProdutos.TabIndex = 6;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 31);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(368, 36);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Gerenciamento de Produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox1.Image = global::Onlypães.Properties.Resources.grocery;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(518, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(730, 674);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagarDescricao;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbprecoEditar;
        private System.Windows.Forms.TextBox txbProdutoEditar;
        private System.Windows.Forms.Label lblCategoriaEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.Label lblProdutoEditar;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbPrecoCadastro;
        private System.Windows.Forms.TextBox txbProdutoCadastro;
        private System.Windows.Forms.Label lblCategoriaCadastro;
        private System.Windows.Forms.Label lblPrecoCadastrar;
        private System.Windows.Forms.Label lblProdutoCadastro;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastro;
        private System.Windows.Forms.ComboBox cmbCategoriaEditar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}