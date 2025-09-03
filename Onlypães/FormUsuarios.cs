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
    public partial class FormUsuarios : Form
    {
        // Objetos globais:
        Model.Usuario usuario;
        int idSelecionado = 0; // armazenar o id do usuário selecionado p/ apagar ou editar:

        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            // Mostrar as informações do bd no datagridview:
            AtualizarDgv();
        }
        public void AtualizarDgv()
        { dgvUsuarios.DataSource = usuario.Listar(); }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCompleto.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmail.Text.Length < 7) //a@a.co
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer o cadastro...
                Model.Usuario usuarioCadastro = new Model.Usuario();

                // Salvar os valores dos campos nos atributos do obj:
                usuarioCadastro.NomeCompleto = txbNomeCompleto.Text;
                usuarioCadastro.Email = txbEmail.Text;
                usuarioCadastro.Senha = txbSenha.Text;

                // Executar o INSERT:
                if (usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!.",
                    "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Atualizar o dgv:
                    AtualizarDgv();
                    //Apagar os campos de cadastro
                    txbNomeCompleto.Clear();
                    txbEmail.Clear();
                    txbSenha.Clear();
                }
                else 
                {
                    MessageBox.Show("Falha ao cadastrar novo usuário.",
                          "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a linha selecionada
            int ls = dgvUsuarios.SelectedCells[0].RowIndex;

            // Colocar os valores das células no txbs de edição:
            txbNomeCompletoEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvUsuarios.Rows[ls].Cells[2].Value.ToString();

            // Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvUsuarios.Rows[ls].Cells[0].Value;


            // Ativar o grbEditar:
            grbEditar.Enabled = true;

            // Ajustes no grbApagar:
            lblApagarDescricao.Text = $"Apagar: {txbNomeCompletoEditar.Text = dgvUsuarios.Rows[ls].Cells[1].Value.ToString()}";

            // Ativar o grbApagar:
            grbApagar.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?",
                "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();
                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário Apagado com sucesso!.",
                    "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao Apagar o usuário.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ResetarCampos()
        {
            // Atualizar o dgv:
            AtualizarDgv();

            // Limpar campos de edição:
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();
            txbNomeCompletoEditar.Clear();

            // Retornar o idSelecionado para 0
            idSelecionado = 0;
            //Retornar o texto padrão de "Apagar":
            lblApagarDescricao.Text = "Selecione o usuário que deseja apagar,";

            // Desabilitar os grabs:
            grbApagar.Enabled = false;
            grbEditar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar campos:
            if (txbNomeCompletoEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7) //a@a.co
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres.",
                       "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
            // Proseguir com a edição:
            Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeCompletoEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;
                if (usuarioEditar.modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!.",
                    "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuário.",
                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
