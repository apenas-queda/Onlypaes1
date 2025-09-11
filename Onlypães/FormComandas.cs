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
    public partial class FormComandas : Form
    {
        Model.Usuario usuario;
        public FormComandas(Model.Usuario usuario)
        
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.Listar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a Linha selecionada
            int ls = dgvProdutos.SelectedCells[0].RowIndex;
            //Colocar o ID do produto selecionado
            txbProdutoinformacoes.Text = dgvProdutos.Rows[ls].Cells[0].Value.ToString();
            // Colocar o nome do produto selecionado
            txbProdutoLancamento.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se ps campos estão vazios:
            if(txbComandaInformacoes.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbProdutoinformacoes.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do produto!",
                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Desativar o grbinfos:
                grbInformacoes.Enabled = false;
                // Ativar o grblancamento:
                grbLancamentos.Enabled = true;
            }
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            // Verificar se a quantidade foi preenchida:
            if (txbQuantidadeLancamento.Text.Length == 0)
            {
                MessageBox.Show("Informe a código quantidade!",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComandaInformacoes.Text);
                ordemComanda.IdProduto = int.Parse(txbProdutoinformacoes.Text);
                ordemComanda.Quantidade = int.Parse(txbQuantidadeLancamento.Text);
                ordemComanda.IdResp = usuario.Id;
                if (ordemComanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado!",
                "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao efetuar lançamento!",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetarCampos()
        {
            txbComandaInformacoes.Clear();
            txbProdutoinformacoes.Clear();
            txbProdutoLancamento.Clear();
            txbQuantidadeLancamento.Clear();
            // Resetar os groupBoxes
            grbInformacoes.Enabled = true;
            grbLancamentos.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
