namespace Onlypães
{
    partial class FormComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComandas));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbProdutoinformacoes = new System.Windows.Forms.TextBox();
            this.txbComandaInformacoes = new System.Windows.Forms.TextBox();
            this.lblProdutoInformacoes = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbLancamentos = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidadeLancamento = new System.Windows.Forms.TextBox();
            this.txbProdutoLancamento = new System.Windows.Forms.TextBox();
            this.lblQuantidadeLancamento = new System.Windows.Forms.Label();
            this.lblProdutoLancamento = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(402, 95);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(553, 705);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbProdutoinformacoes);
            this.grbInformacoes.Controls.Add(this.txbComandaInformacoes);
            this.grbInformacoes.Controls.Add(this.lblProdutoInformacoes);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 95);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(384, 303);
            this.grbInformacoes.TabIndex = 1;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnContinuar.Location = new System.Drawing.Point(6, 215);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(372, 72);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbProdutoinformacoes
            // 
            this.txbProdutoinformacoes.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbProdutoinformacoes.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutoinformacoes.Location = new System.Drawing.Point(197, 149);
            this.txbProdutoinformacoes.Name = "txbProdutoinformacoes";
            this.txbProdutoinformacoes.Size = new System.Drawing.Size(181, 42);
            this.txbProdutoinformacoes.TabIndex = 3;
            // 
            // txbComandaInformacoes
            // 
            this.txbComandaInformacoes.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbComandaInformacoes.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComandaInformacoes.Location = new System.Drawing.Point(197, 43);
            this.txbComandaInformacoes.Name = "txbComandaInformacoes";
            this.txbComandaInformacoes.Size = new System.Drawing.Size(181, 42);
            this.txbComandaInformacoes.TabIndex = 2;
            // 
            // lblProdutoInformacoes
            // 
            this.lblProdutoInformacoes.AutoSize = true;
            this.lblProdutoInformacoes.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoInformacoes.Location = new System.Drawing.Point(48, 157);
            this.lblProdutoInformacoes.Name = "lblProdutoInformacoes";
            this.lblProdutoInformacoes.Size = new System.Drawing.Size(123, 34);
            this.lblProdutoInformacoes.TabIndex = 1;
            this.lblProdutoInformacoes.Text = "Produto :";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(28, 51);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(143, 34);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda :";
            // 
            // grbLancamentos
            // 
            this.grbLancamentos.Controls.Add(this.btnLancar);
            this.grbLancamentos.Controls.Add(this.txbQuantidadeLancamento);
            this.grbLancamentos.Controls.Add(this.txbProdutoLancamento);
            this.grbLancamentos.Controls.Add(this.lblQuantidadeLancamento);
            this.grbLancamentos.Controls.Add(this.lblProdutoLancamento);
            this.grbLancamentos.Enabled = false;
            this.grbLancamentos.Location = new System.Drawing.Point(12, 404);
            this.grbLancamentos.Name = "grbLancamentos";
            this.grbLancamentos.Size = new System.Drawing.Size(384, 280);
            this.grbLancamentos.TabIndex = 2;
            this.grbLancamentos.TabStop = false;
            this.grbLancamentos.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLancar.Location = new System.Drawing.Point(6, 199);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(372, 72);
            this.btnLancar.TabIndex = 6;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidadeLancamento
            // 
            this.txbQuantidadeLancamento.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbQuantidadeLancamento.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidadeLancamento.Location = new System.Drawing.Point(197, 127);
            this.txbQuantidadeLancamento.Name = "txbQuantidadeLancamento";
            this.txbQuantidadeLancamento.Size = new System.Drawing.Size(181, 42);
            this.txbQuantidadeLancamento.TabIndex = 5;
            // 
            // txbProdutoLancamento
            // 
            this.txbProdutoLancamento.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbProdutoLancamento.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutoLancamento.Location = new System.Drawing.Point(197, 29);
            this.txbProdutoLancamento.Name = "txbProdutoLancamento";
            this.txbProdutoLancamento.ReadOnly = true;
            this.txbProdutoLancamento.Size = new System.Drawing.Size(181, 42);
            this.txbProdutoLancamento.TabIndex = 4;
            // 
            // lblQuantidadeLancamento
            // 
            this.lblQuantidadeLancamento.AutoSize = true;
            this.lblQuantidadeLancamento.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeLancamento.Location = new System.Drawing.Point(6, 135);
            this.lblQuantidadeLancamento.Name = "lblQuantidadeLancamento";
            this.lblQuantidadeLancamento.Size = new System.Drawing.Size(165, 34);
            this.lblQuantidadeLancamento.TabIndex = 1;
            this.lblQuantidadeLancamento.Text = "Quantidade :";
            // 
            // lblProdutoLancamento
            // 
            this.lblProdutoLancamento.AutoSize = true;
            this.lblProdutoLancamento.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutoLancamento.Location = new System.Drawing.Point(48, 37);
            this.lblProdutoLancamento.Name = "lblProdutoLancamento";
            this.lblProdutoLancamento.Size = new System.Drawing.Size(123, 34);
            this.lblProdutoLancamento.TabIndex = 0;
            this.lblProdutoLancamento.Text = "Produto :";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(277, 28);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(389, 40);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Lançamento de Comandas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Onlypães.Properties.Resources.Hopstarter_Soft_Scraps_Document_Text_256;
            this.pictureBox1.Location = new System.Drawing.Point(739, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnVoltar.Location = new System.Drawing.Point(12, 701);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(384, 99);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(967, 812);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.grbLancamentos);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComandas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamentos.ResumeLayout(false);
            this.grbLancamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.GroupBox grbLancamentos;
        private System.Windows.Forms.Label lblProdutoInformacoes;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Label lblQuantidadeLancamento;
        private System.Windows.Forms.Label lblProdutoLancamento;
        private System.Windows.Forms.TextBox txbProdutoinformacoes;
        private System.Windows.Forms.TextBox txbComandaInformacoes;
        private System.Windows.Forms.TextBox txbQuantidadeLancamento;
        private System.Windows.Forms.TextBox txbProdutoLancamento;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}