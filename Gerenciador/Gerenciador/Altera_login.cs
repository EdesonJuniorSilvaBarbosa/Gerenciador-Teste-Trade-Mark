using Gerenciador.DAL;
using Gerenciador.BLL;
using Gerenciador.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class Altera_login : Form
    {
        public Altera_login()
        {
            InitializeComponent();
            lblInformacao.Text = "";

            txtSenhaAltera.Enabled = false;
            btnAlteraLogin.Enabled = false;
        }
        private void btnAlteraLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                string email = txtLoginAltera.Text;
                string novaSenha = txtSenhaAltera.Text;

                bool emailExiste = new GerenciadorDAL().EmailExiste(email);

                if (!emailExiste)
                {
                    MessageBox.Show("O e-mail não está cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AlterarSenha(email, novaSenha);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao alterar o login e senha." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AlterarSenha(string email, string novaSenha)
        {
            try
            {
                login_DTO LOG = new login_DTO();
                LOG.nome_login = email;
                LOG.senha_login = novaSenha;

                // Validação dos campos
                if (string.IsNullOrWhiteSpace(LOG.nome_login) || string.IsNullOrWhiteSpace(LOG.senha_login))
                {
                    lblInformacao.Text = "O campo E-mail e Senha não podem ser vazios.";
                    lblInformacao.ForeColor = Color.Red;
                    return;
                }

                // inserir novo login
                bool alteracaoSucesso = new GerenciadorBLL().alteraLogin(LOG, LOG.nome_login, LOG.senha_login);

                // Verificar se houver alteração
                if (alteracaoSucesso)
                {
                    lblInformacao.Text = "Senha alterada com sucesso!";
                    lblInformacao.ForeColor = Color.Green;
                    FormUtils.LimpaCampos(this);
                }
            }
            catch (Exception ex)
            {
                lblInformacao.Text = "Erro inesperado: " + ex.Message;
                lblInformacao.ForeColor = Color.Red;
            }
        }

        // Leave - informa ao usuario em tempo real
        private void txtLoginAltera_Leave(object sender, EventArgs e)
        {
            string email = txtLoginAltera.Text;

            bool emailExiste = new GerenciadorDAL().EmailExiste(email);

            if (emailExiste)
            {
                lblInformacao.Text = "O E-mail já está cadastro, seguir para a alteração da senha.";
                lblInformacao.ForeColor = Color.Green;
                txtSenhaAltera.Enabled = true;
            }
            else
            {
                lblInformacao.Text = "O E-mail informado não está cadastrado, faça seu cadastro.";
                lblInformacao.ForeColor = Color.Red;
            }
        }

        // KeyPress - valida a quantidade de caracteres que o textbox aceita
        private void txtSenhaAltera_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é uma tecla de controle como por exemplo, Backspace
            if (!char.IsControl(e.KeyChar))
            {
                // Verifica se a quantidade de caracteres no campo é igual ao tamanho da senha na base de dados
                if (txtSenhaAltera.Text.Length >= 12)
                {
                    // Interrompe a digitação
                    e.Handled = true;
                }
            }
        }

        // Método verifica a força da senha
        private void txtSenhaAltera_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txtSenhaAltera.Text);
            lblInformacao.Text = forca.ToString();

            if (lblInformacao.Text == "Inaceitavel" | lblInformacao.Text == "Fraca")
            {
                lblInformacao.ForeColor = Color.Red;
            }
            if (lblInformacao.Text == "Aceitavel")
            {
                lblInformacao.ForeColor = Color.Blue;
            }
            if (lblInformacao.Text == "Forte" | lblInformacao.Text == "Segura")
            {
                lblInformacao.ForeColor = Color.Green;
            }
        }
       
        // requisitos para alterar a senha
        private void txtSenhaAltera_TextChanged(object sender, EventArgs e)
        {
            string senha = txtSenhaAltera.Text;

            // Verificar quais requisitos o usuario já cumpriu
            bool possuiMinusculas = senha.Any(char.IsLower);
            bool possuiMaiusculas = senha.Any(char.IsUpper);
            bool possuiDigitos = senha.Any(char.IsDigit);
            bool possuiSimbolos = ContemCaracterEspecial(senha);
            bool possuiTamanhoMinimo = senha.Length >= 8;

            // Atualiza a lsita de requisitos conforme o que o usuario já digitou
            cklRequisitosNecessarios.Items.Clear();
            if (!possuiMinusculas)
            {
                cklRequisitosNecessarios.Items.Add("Digite uma letra minúscula.");
                btnAlteraLogin.Enabled = false;
            }
            else if (!possuiMaiusculas)
            {
                cklRequisitosNecessarios.Items.Add("Digite uma letra maiúscula.");
            }
            else if (!possuiDigitos)
            {
                cklRequisitosNecessarios.Items.Add("Digite um número.");
            }
            else if (!possuiSimbolos)
            {
                cklRequisitosNecessarios.Items.Add("Digite um símbolo. (@,#,$,%,&,*)");
            }
            else if (!possuiTamanhoMinimo)
            {
                cklRequisitosNecessarios.Items.Add("Digite no mínimo 8 caracteres.");
            }
            else
            {
                cklRequisitosNecessarios.Items.Add("Você cumpriu todos os requisitos.");
                btnAlteraLogin.Enabled = true;
            }
        }
        private bool ContemCaracterEspecial(string senha)
        {
            string caracteresEspeciais = "@,#,$,%,&,*";
            return senha.IndexOfAny(caracteresEspeciais.ToCharArray()) != -1;
        }
        private void lblLinkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
