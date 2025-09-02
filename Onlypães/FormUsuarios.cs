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
                    MessageBox.Show("Usuário caadastrado com sucesso!.",
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
    }
}
