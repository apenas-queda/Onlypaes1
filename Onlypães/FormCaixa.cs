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
    public partial class FormCaixa : Form
    {
        Model.Usuario usuario;
        public FormCaixa(Model.Usuario usuario)
        {

            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Verificar se o campo está vazio:
            if (txbNumeroComanda.Text.Length == 0)
            {
                MessageBox.Show("Iforme o número da comanda!", "Erro",
                 MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbNumeroComanda.Text);
                // Tabela para receber o resultado da consulta SELECT
                DataTable resultado = ordemComanda.BuscarPorFicha();

                // Verificar se existem linhas em "resultado":
                if (resultado.Rows.Count > 0)
                {
                    //Mostrar no dgv:
                    dgvPagamentos.DataSource = resultado;
                    // Calcular o total e mostrar o lblTotal:
                    lblTotal.Text = "R$" + resultado.Compute("Sum(Total_Item)","True").ToString();
                }
                else
                {
                    //Limpar o dgv:
                    dgvPagamentos.DataSource = null;
                    //Mostrar mensagem de erro:
                    MessageBox.Show("Não existe lançamentos nessa comanda!", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrarComanda.Enabled = chbPagamento.Checked;
        }

        private void btnEncerrarComanda_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar essa comanda?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //Encerrar acomanda:
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbNumeroComanda.Text);
                // Executar o update para encerrar a comanda:
                if (ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("Comanda encerrada!", "Show",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    //Resetar os campos:
                    txbNumeroComanda.Clear();
                   dgvPagamentos.DataSource = null ;
                    chbPagamento.Checked = false;
                    btnEncerrarComanda.Enabled = false;
                    lblTotal.Text = "R$   - ";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda!", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                
        }
    }
}
