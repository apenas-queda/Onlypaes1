namespace Onlypães
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.txbNomeCompletoEditar = new System.Windows.Forms.TextBox();
            this.lblSenhaEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeCompletoEditar = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagarDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pibIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 141);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(709, 229);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.txbSenha);
            this.grbCadastro.Controls.Add(this.txbEmail);
            this.grbCadastro.Controls.Add(this.txbNomeCompleto);
            this.grbCadastro.Controls.Add(this.lblSenha);
            this.grbCadastro.Controls.Add(this.lblEmail);
            this.grbCadastro.Controls.Add(this.lblNomeCompleto);
            this.grbCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbCadastro.Location = new System.Drawing.Point(12, 376);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(345, 219);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
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
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Location = new System.Drawing.Point(102, 108);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(141, 20);
            this.txbSenha.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Location = new System.Drawing.Point(102, 68);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(141, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // txbNomeCompleto
            // 
            this.txbNomeCompleto.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeCompleto.Location = new System.Drawing.Point(102, 31);
            this.txbNomeCompleto.Name = "txbNomeCompleto";
            this.txbNomeCompleto.Size = new System.Drawing.Size(141, 20);
            this.txbNomeCompleto.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(55, 115);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(61, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(12, 38);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome completo:";
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.txbSenhaEditar);
            this.grbEditar.Controls.Add(this.txbEmailEditar);
            this.grbEditar.Controls.Add(this.txbNomeCompletoEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEditar);
            this.grbEditar.Controls.Add(this.lblEmailEditar);
            this.grbEditar.Controls.Add(this.lblNomeCompletoEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbEditar.Location = new System.Drawing.Point(376, 376);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(345, 219);
            this.grbEditar.TabIndex = 2;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
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
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbSenhaEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenhaEditar.Location = new System.Drawing.Point(102, 104);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(141, 20);
            this.txbSenhaEditar.TabIndex = 12;
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbEmailEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmailEditar.Location = new System.Drawing.Point(102, 69);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(141, 20);
            this.txbEmailEditar.TabIndex = 11;
            // 
            // txbNomeCompletoEditar
            // 
            this.txbNomeCompletoEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.txbNomeCompletoEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeCompletoEditar.Location = new System.Drawing.Point(102, 31);
            this.txbNomeCompletoEditar.Name = "txbNomeCompletoEditar";
            this.txbNomeCompletoEditar.Size = new System.Drawing.Size(141, 20);
            this.txbNomeCompletoEditar.TabIndex = 10;
            // 
            // lblSenhaEditar
            // 
            this.lblSenhaEditar.AutoSize = true;
            this.lblSenhaEditar.Location = new System.Drawing.Point(55, 111);
            this.lblSenhaEditar.Name = "lblSenhaEditar";
            this.lblSenhaEditar.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaEditar.TabIndex = 9;
            this.lblSenhaEditar.Text = "Senha:";
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(58, 72);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEditar.TabIndex = 8;
            this.lblEmailEditar.Text = "Email:";
            // 
            // lblNomeCompletoEditar
            // 
            this.lblNomeCompletoEditar.AutoSize = true;
            this.lblNomeCompletoEditar.Location = new System.Drawing.Point(9, 38);
            this.lblNomeCompletoEditar.Name = "lblNomeCompletoEditar";
            this.lblNomeCompletoEditar.Size = new System.Drawing.Size(84, 13);
            this.lblNomeCompletoEditar.TabIndex = 7;
            this.lblNomeCompletoEditar.Text = "Nome completo:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagarDescricao);
            this.grbApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbApagar.Location = new System.Drawing.Point(12, 601);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(709, 88);
            this.grbApagar.TabIndex = 3;
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
            this.lblApagarDescricao.Size = new System.Drawing.Size(177, 13);
            this.lblApagarDescricao.TabIndex = 0;
            this.lblApagarDescricao.Text = "Selecione uma pessoa para apagar:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Goudy Old Style", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(69, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(364, 40);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Gerenciador de Usuários";
            // 
            // pibIcon
            // 
            this.pibIcon.Image = global::Onlypães.Properties.Resources.baker__1_;
            this.pibIcon.InitialImage = global::Onlypães.Properties.Resources.baker__1_;
            this.pibIcon.Location = new System.Drawing.Point(478, 12);
            this.pibIcon.Name = "pibIcon";
            this.pibIcon.Size = new System.Drawing.Size(120, 120);
            this.pibIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibIcon.TabIndex = 5;
            this.pibIcon.TabStop = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(731, 695);
            this.Controls.Add(this.pibIcon);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNomeCompleto;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.TextBox txbNomeCompletoEditar;
        private System.Windows.Forms.Label lblSenhaEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeCompletoEditar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagarDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pibIcon;
    }
}