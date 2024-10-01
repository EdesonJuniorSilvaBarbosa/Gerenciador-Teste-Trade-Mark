using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Gerenciador.DTO;
using Gerenciador.BLL;
using Gerenciador.DAL;
using System.Diagnostics;
using System.IO;
using static Gerenciador.BLL.Cls_Uteis;

namespace Gerenciador
{
    public partial class Cadastro_usuarios : Form
    {
        private ChecaForcaSenha checaForcaSenha = new ChecaForcaSenha();
        public string sexo;

        // Button Senha
        private bool senhaOculta = true;

        public Cadastro_usuarios()
        {
            InitializeComponent();
            lblInformacao.Text = "";
            lblCorSenha.Text = "";

            btnCadastroUsuario.Enabled = false;
            btnMostrarSenha.Text = "Mostrar";
            btnMostrarSenha.ForeColor = Color.Gray;
            btnMostrarSenha.BackColor = Color.White;

            // Máscara para formatar o CPF
            mkdTxtCpf.Mask = "000.000.000-00";

        }
        private void Cadastro_usuarios_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            AlterarCorFontGrupoBox(gpbLogin, Color.LightSeaGreen);
        }
        private void limpa_campos()
        {
            txtNome.Clear();
            mkdTxtCpf.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            dTPNascimento.Text = "";
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
            txtSobrenome.Clear();
        }

        // Valida campos
        private bool CamposValidos()
        {
            string vConteudo = mkdTxtCpf.Text;

            vConteudo = vConteudo.Replace(".", "").Replace("-", ""); // Remove os pontos e os traços do texto do CPF
            vConteudo = vConteudo.Trim(); // remove quaisquer espaços em branco

            // verifica se todos os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Nome", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;

            }else if (string.IsNullOrWhiteSpace(txtSobrenome.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Sobrenome", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSobrenome.Focus();
                return false;
            }else if (string.IsNullOrWhiteSpace(vConteudo))
            {
                MessageBox.Show("Por favor, preencha o campo CPF", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkdTxtCpf.Focus();
                return false;
            }else if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, preencha o campo E-mail", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }else if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Senha", "Campo Obrigatório!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            else
            {
                return true; // todos os campos foram preenchidos
            }
        }
        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CamposValidos())
                {
                    return; // Não prossegue com o registro se houver campos em branco
                }
                usuario_DTO USU = new usuario_DTO();
                login_DTO LOG = new login_DTO();
                USU.nome = Convert.ToString(txtNome.Text);
                USU.sobrenome = Convert.ToString(txtSobrenome.Text);
                USU.cpf = mkdTxtCpf.Text;
                USU.data_nasc = DateTime.ParseExact(dTPNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (rdbMasculino.Checked)
                {
                    USU.sexo = 'M';
                }

                if (rdbFeminino.Checked)
                {
                    USU.sexo = 'F';
                }

                LOG.nome_login = txtUsuario.Text;
                LOG.senha_login = txtSenha.Text;

                if ((string.IsNullOrWhiteSpace(txtNome.Text) == false) &&
                    (string.IsNullOrWhiteSpace(mkdTxtCpf.Text) == false))
                {

                }

                //Método inserir conta na classe GerenciadorBLL
                int x = new GerenciadorBLL().insereUsuario(USU);

                //Verificar se houve alguma gravação
                if (x > 0)
                {
                    gpbCadastro.Text = "Gravado com sucesso! volte para o login";
                    gpbCadastro.ForeColor = Color.Green;
                }

                int y = new GerenciadorBLL().insereLogin(LOG);

                if (y > 0)
                {
                    gpbCadastro.Text = "Gravado com sucesso! volte para o login";
                    gpbCadastro.ForeColor = Color.Green;
                    limpa_campos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro de Gravação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            Form childForm = new Cadastro_login();
            childForm.Show();
        }
        private void AlterarCorFontGrupoBox(GroupBox grupoBox, Color cor)
        {
            foreach (Control control in grupoBox.Controls)
            {
                if (control is Label)
                {
                    control.ForeColor = cor; //LightSeaGreen
                }
                else if(control is Button)
                {
                    control.ForeColor = cor;
                }
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            string email = txtUsuario.Text.Trim();
            if (ValidaEmail(email))
            {
                lblCorSenha.Text = "E-mail válido";
                lblCorSenha.ForeColor = Color.Green;
            }
            else
            {
                lblCorSenha.Text = "E-mail inválido";
                lblCorSenha.ForeColor = Color.Red;
            }
        }
        private bool ValidaEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        
        // Método verifica a força da senha
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            Cls_Uteis.ChecaForcaSenha verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca = verifica.GetForcaDaSenha(txtSenha.Text);
            string mensagem = verifica.GetMensagemForcaSenha(forca);
            lblCorSenha.Text = mensagem;

            if (mensagem == "Senha inaceitável" | mensagem == "Senha fraca")
            {
                lblCorSenha.ForeColor = Color.Red;
            }
            if (mensagem == "Senha aceitavel")
            {
                lblCorSenha.ForeColor = Color.Blue;
            }
            if (mensagem == "Senha forte" | mensagem == "Senha segura")
            {
                lblCorSenha.ForeColor = Color.Green;
            }
        }

        // Método para limitar a quantidade de caracteres digitado pelo usuário
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é uma tecla de controle como por exemplo, Backspace
            if (!char.IsControl(e.KeyChar))
            {
                // Verifica se a quantidade de caracteres no campo é igual ao tamanho da senha na base de dados
                if (txtSenha.Text.Length >= 12)
                {
                    // Interrompe a digitação
                    e.Handled = true;
                }
            }
        }
        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            MostrarOcultarSenha();
        }

        // Botão para mostrar e ocultar a senha
        private void MostrarOcultarSenha()
        {
            if (senhaOculta)
            {
                txtSenha.UseSystemPasswordChar = false; // Exibe a senha
                senhaOculta = false;

                btnMostrarSenha.Text = "Ocultar";
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true; // Oculta a senha
                senhaOculta = true;

                btnMostrarSenha.Text = "Mostrar";
            }
        }

        // Método para informar ao usuário os requisitos da senha
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;

            // Verificar quais requisitos o usuario já cumpriu
            bool possuiMinusculas = senha.Any(char.IsLower);
            bool possuiMaiusculas = senha.Any(char.IsUpper);
            bool possuiDigitos = senha.Any(char.IsDigit);
            bool possuiSimbolos = ContemCaracterEspecial(senha);
            bool possuiTamanhoMinimo = senha.Length >= 8;

            // Atualiza a lsita de requisitos conforme o que o usuario já digitou
            lstRequisitosNecessarios.Items.Clear();
            if (!possuiMinusculas)
            {
                lstRequisitosNecessarios.Items.Add("Digite uma letra minúscula.");
                btnCadastroUsuario.Enabled = false;
            }
            else if (!possuiMaiusculas)
            {
                lstRequisitosNecessarios.Items.Add("Digite uma letra maiúscula.");
                btnCadastroUsuario.Enabled = false;
            }
            else if (!possuiDigitos)
            {
                lstRequisitosNecessarios.Items.Add("Digite um número.");
                btnCadastroUsuario.Enabled = false;
            }
            else if (!possuiSimbolos)
            {
                lstRequisitosNecessarios.Items.Add("Digite um símbolo. (@,#,$,%,&,*)");
                btnCadastroUsuario.Enabled = false;
            }
            else if (!possuiTamanhoMinimo)
            {
                lstRequisitosNecessarios.Items.Add("Digite no mínimo 8 caracteres.");
                btnCadastroUsuario.Enabled = false;
            }
            else
            {
                lstRequisitosNecessarios.Items.Add("Você cumpriu os requisitos.");
                btnCadastroUsuario.Enabled = true;
            }
        }

        // Método para caracteres especiais
        private bool ContemCaracterEspecial(string senha)
        {
            string caracteresEspeciais = "@,#,$,%,&,*";
            return senha.IndexOfAny(caracteresEspeciais.ToCharArray()) != -1;
        }

        // Impede o usuário de prosseguir caso o CPF seja Inválido ou incompleto ( < 11 digitos )
        private void mkdTxtCpf_Validating(object sender, CancelEventArgs e)
        {
            string vConteudo = mkdTxtCpf.Text;

            bool cpfExiste = new GerenciadorDAL().CpfExiste(vConteudo);

            if (cpfExiste)
            {
                lblInformacao.Text = "CPF informado já está cadastro";
                lblInformacao.LinkColor = Color.Red;
                mkdTxtCpf.Focus();
                e.Cancel = true;
            }
            else
            {
                lblInformacao.Text = "";
                e.Cancel = false;
            }

            vConteudo = vConteudo.Replace(".", "").Replace("-", ""); // Remove os pontos e os traços do texto do CPF
            vConteudo = vConteudo.Trim(); // remove quaisquer espaços em branco

            if (string.IsNullOrEmpty(vConteudo))
            {
                lblInformacao.Text = "CPF não pode estar vazio!";
                lblInformacao.LinkColor = Color.Red;
                e.Cancel = true;
                return; // Interrompe a execução caso o CPF esteja vazio ou nulo

            }else if (vConteudo.Length == 11)
            {
                if (!Cls_Uteis.Valida(mkdTxtCpf.Text))
                {
                    lblInformacao.Text = "CPF inválido! por favor revise-o.";
                    lblInformacao.LinkColor = Color.Red;
                    e.Cancel = true; // Cancela a mudança de foco
                }
            }
            else if (vConteudo.Length > 0)
            {
                lblInformacao.Text = "CPF deve ter 11 dígitos, preencha o campo corretamente!";
                lblInformacao.LinkColor = Color.Red;
                e.Cancel = true;
            }
        }

        // Valida a data de nascimento
        private void dTPNascimento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                // Tenta converter a entrada de data para DateTime usando o formato especifico
                DateTime dataNascimento = DateTime.ParseExact(dTPNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Verifica se a data de nascimento é maior que a data atual
                if (dataNascimento > DateTime.Today)
                {
                    lblInformacao.Text = "A data de nascimento não pode ser maior que a data atual!";
                    lblInformacao.LinkColor = Color.Red;
                    e.Cancel = true; // Cancela a mudança do foco
                }
                else
                {
                    lblInformacao.Text = "";
                }
            }
            catch (FormatException)
            {
                lblInformacao.Text = "Data de nascimento é inválida.";
                lblInformacao.LinkColor = Color.Red;
                e.Cancel = true; // Cancela a mudança de foco
            }
        }
    }
}
