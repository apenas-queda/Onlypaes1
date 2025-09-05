using Onlypães.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onlypães
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        int idSelecionado = 0;
        Model.Produto produto = new Produto();
       
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
            ListarCategoriaCmb();
        }
        public void AtualizarDgv()
        { dgvProdutos.DataSource = produto.Listar(); }
        public void ListarCategoriaCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            //Tabela para receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();
            foreach (DataRow dr in tabela.Rows)
            {
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }
        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbProdutoCadastro.Text.Length < 2)
            {
                MessageBox.Show("O produto deve ter no mínimo 2 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoCadastro.Text.Length < 0)
            {

                MessageBox.Show("O preço deve ter no mínimo 1 caractere.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaCadastro.Items.Count < 1)
            {

                MessageBox.Show("selecione uma categoria.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Produto produtoCadastro = new Model.Produto();

                produtoCadastro.Nome = txbProdutoCadastro.Text;
                produtoCadastro.Preco = int.Parse(txbPrecoCadastro.Text);
                produtoCadastro.IdCategoria = cmbCategoriaCadastro.TabIndex;
                produtoCadastro.IdRespCadastro = usuario.Id;

                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!.",
                    "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    AtualizarDgv();
                    //Apagar os campos de cadastro
                    txbPrecoCadastro.Clear();
                    txbPrecoCadastro.Clear();
                    cmbCategoriaCadastro.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar novo Produto.",
                          "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ResetarCampos()
        {

            // Atualizar o dgv:
            AtualizarDgv();

            // Limpar campos de edição:
            txbProdutoEditar.Clear();
            txbprecoEditar.Clear();
            cmbCategoriaEditar.SelectedIndex = -1;

            // Retornar o idSelecionado para 0
            idSelecionado = 0;
            //Retornar o texto padrão de "Apagar":
            lblApagarDescricao.Text = "Selecione o produto que deseja apagar,";

            // Desabilitar os grabs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbProdutoEditar.Text.Length < 2)
            {
                MessageBox.Show("O produto deve ter no mínimo 2 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbprecoEditar.Text.Length < 0)
            {

                MessageBox.Show("O preço deve ter no mínimo 1 caractere.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaEditar.Items.Count < 1)
            {

                MessageBox.Show("selecione uma categoria.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Model.Produto produtoEditar = new Model.Produto();

            produtoEditar.Nome = txbProdutoCadastro.Text;
            produtoEditar.Preco = int.Parse(txbPrecoCadastro.Text);
            produtoEditar.IdCategoria = cmbCategoriaCadastro.TabIndex;
            produtoEditar.IdRespCadastro = usuario.Id;

            if (produtoEditar.modificar())
            {
                MessageBox.Show("Produto modificado com sucesso!.",
                "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Atualizar o dgv:
                AtualizarDgv();
                //Apagar os campos de cadastro
                ResetarCampos();

            }
            else
            {
                MessageBox.Show("Falha ao modificar Produto.",
                      "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este produto?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
              Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = idSelecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!.",
                    "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao Apagar o produto.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
    }
   
}
