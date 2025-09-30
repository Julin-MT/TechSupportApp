using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Entidades;
using TechSupport.Model;

namespace TechSupportApp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Pega os dados da tela
                UsuarioEntidade entidade = new UsuarioEntidade();
                entidade.Email = txtEmail.Text;
                entidade.Senha = txtSenha.Text;

                // Chama a camada de modelo para verificar a lógica
                UsuarioModel model = new UsuarioModel();
                bool loginOk = model.VerificarLogin(entidade);

                if (loginOk)
                {
                    // SE O LOGIN ESTIVER CORRETO, FAÇA ISSO:

                    // 1. Cria uma instância da nossa nova tela principal
                    TelaPrincipal telaPrincipal = new TelaPrincipal();

                    // 2. Mostra a tela principal para o usuário
                    telaPrincipal.Show();

                    // 3. Esconde a tela de login atual
                    this.Hide();
                }
                else
                {
                    // SE O LOGIN ESTIVER INCORRETO, MOSTRA FALHA
                    MessageBox.Show("Email ou senha incorretos. Tente novamente.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // SE OCORRER UM ERRO DE CONEXÃO OU OUTRO PROBLEMA
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
