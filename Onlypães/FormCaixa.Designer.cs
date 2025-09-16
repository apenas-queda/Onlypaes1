namespace Onlypães
{
    partial class FormCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixa));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbNumeroComanda = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.btnEncerrarComanda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(131, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "N° Comanda:";
            // 
            // txbNumeroComanda
            // 
            this.txbNumeroComanda.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbNumeroComanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumeroComanda.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumeroComanda.Location = new System.Drawing.Point(316, 36);
            this.txbNumeroComanda.Name = "txbNumeroComanda";
            this.txbNumeroComanda.Size = new System.Drawing.Size(173, 46);
            this.txbNumeroComanda.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(495, 36);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(126, 47);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Onlypães.Properties.Resources.Ebiene_E_Commerce_Cash_register_256;
            this.pictureBox1.InitialImage = global::Onlypães.Properties.Resources.Ebiene_E_Commerce_Cash_register_256;
            this.pictureBox1.Location = new System.Drawing.Point(187, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Location = new System.Drawing.Point(12, 117);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.Size = new System.Drawing.Size(765, 304);
            this.dgvPagamentos.TabIndex = 5;
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaixa.Location = new System.Drawing.Point(93, 511);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(88, 36);
            this.lblCaixa.TabIndex = 6;
            this.lblCaixa.Text = "Caixa";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(548, 462);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 37);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "R$     -";
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbPagamento.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPagamento.Location = new System.Drawing.Point(556, 511);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(185, 27);
            this.chbPagamento.TabIndex = 8;
            this.chbPagamento.Text = "Pagamento Recebido";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // btnEncerrarComanda
            // 
            this.btnEncerrarComanda.BackColor = System.Drawing.Color.IndianRed;
            this.btnEncerrarComanda.Enabled = false;
            this.btnEncerrarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarComanda.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEncerrarComanda.Location = new System.Drawing.Point(556, 557);
            this.btnEncerrarComanda.Name = "btnEncerrarComanda";
            this.btnEncerrarComanda.Size = new System.Drawing.Size(188, 43);
            this.btnEncerrarComanda.TabIndex = 9;
            this.btnEncerrarComanda.Text = "Encerrar Comanda";
            this.btnEncerrarComanda.UseVisualStyleBackColor = false;
            this.btnEncerrarComanda.Click += new System.EventHandler(this.btnEncerrarComanda_Click);
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(789, 648);
            this.Controls.Add(this.btnEncerrarComanda);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.dgvPagamentos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txbNumeroComanda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaixa";
            this.Text = "FormCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbNumeroComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.Button btnEncerrarComanda;
    }
}