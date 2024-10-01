using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador.DTO;
using Gerenciador.BLL;
using Gerenciador.DAL;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Gerenciador
{
    public partial class Cadastro_login : Form
    {
        // Button Senha mostra ou oculta
        private bool senhaOculta = true;

        // Constante que representa a mensagem do sistema para um clique do botão esquerdo na área não cliente (não na área do cliente, como o interior do formulário)
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // Constante que identifica a barra de título do formulário
        public const int HT_CAPTION = 0x2;

        // Importa a função ReleaseCapture da User32.dll, que libera o mouse do controle atual para permitir que o sistema operacional processe a mensagem de movimentação da janela
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        // Importa a função SendMessage da User32.dll, que envia uma mensagem para o sistema operacional
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Cadastro_login()
        {
            InitializeComponent();

            btnEntrar.Enabled = false;

            // Define o estado inicial do formulario como maximizado
            this.WindowState = FormWindowState.Maximized;

            // Define o tamanho do formulario para tamanho do dispositivo
            this.Size = SystemInformation.PrimaryMonitorSize;

            btnMostrarSenha.Text = "Mostrar";
            btnMostrarSenha.ForeColor = Color.Gray;
            btnMostrarSenha.BackColor = Color.White;

            // Associa o evento de clique do mouse ao método que manipula o arraste da janela
            this.MouseDown += new MouseEventHandler(Form_MouseDown);
        }

        // Evento que é acionado quando o botão do mouse é pressionado sobre o formulário
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            // Verifica se o botão esquerdo do mouse foi pressionado
            if (e.Button == MouseButtons.Left)
            {
                // Libera o mouse do controle atual para permitir a movimentação da janela
                ReleaseCapture();

                // Envia uma mensagem ao sistema operacional para iniciar o movimento da janela como se estivesse sendo arrastada pela barra de título
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Cadastro_login_Load(object sender, EventArgs e)
        {
            lblInformacao.Text = "";
        }
        private void lblFechar_Click(object sender, EventArgs e)
        {
            // Obtém o nome do processo da aplicação
            string nomeProcesso = Process.GetCurrentProcess().ProcessName;

            // Obtém todos os processos com o mesmo nome
            Process[] processos = Process.GetProcessesByName(nomeProcesso);

            // Fecha todos os processos encontrados
            foreach (Process processo in processos)
            {
                processo.Kill();
            }
            // Fecha o formulário atual
            this.Close();
        }
        private void lblCadastre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form frminicial = new Cadastro_usuarios();
            frminicial.ShowDialog();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection CON = new SqlConnection(Properties.Settings.Default.CST))
                {
                    CON.Open();
                    using (SqlCommand CM = new SqlCommand("SELECT * FROM tb_login WHERE nome_login = @login", CON))
                    {
                        CM.Parameters.AddWithValue("@login", txtLogin.Text);
                        using (SqlDataReader ER = CM.ExecuteReader())
                        {
                            if (ER.Read())
                            {
                                string senhaDoBanco = ER["senha_login"].ToString();

                                if (txtSenha.Text == senhaDoBanco)
                                {
                                    int codUsuarioAutenticado = ER.GetInt32(0);
                                    Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID = codUsuarioAutenticado;

                                    // Chamando o método ObterUsuarioNome para obter o nome e sobrenome do usuário
                                    usuario_DTO usuarioAutenticado = new GerenciadorDAL().ObterUsuarioNome(codUsuarioAutenticado);

                                    if (usuarioAutenticado != null)
                                    {
                                        Gerenciador.DTO.sessao_DTO.NomeUsuarioAutenticado = usuarioAutenticado.nome + "\n" + usuarioAutenticado.sobrenome;
                                        Form childForm = new MDIParent1();
                                        this.Hide();
                                        CON.Close();
                                        childForm.ShowDialog();
                                    }
                                    else
                                    {
                                        // Usuário não encontrado
                                        lblInformacao.Text = "Usuário não encontrado";
                                        lblInformacao.ForeColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    // Senha incorreta
                                    lblInformacao.Text = "Senha incorreta";
                                    lblInformacao.ForeColor = Color.Red;
                                }
                            }
                            else
                            {
                                // Usuário não encontrado
                                lblInformacao.Text = "Usuário não encontrado";
                                lblInformacao.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao autenticar usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblNomeFechar_Click(object sender, EventArgs e)
        {
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            string email = txtLogin.Text.Trim();
            if (ValidaEmail(email))
            {
                lblInformacao.Text = "Agora informe sua senha";
                lblInformacao.ForeColor = Color.Green;
                btnEntrar.Enabled = true;
            }
            else
            {
                lblInformacao.Text = "E-mail inválido.";
                lblInformacao.ForeColor = Color.Red;
                btnEntrar.Enabled = false;
                btnEntrar.ForeColor = Color.FromArgb((int)(Opacity * 255), btnEntrar.ForeColor);
            }
        }
        private bool ValidaEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private void lblEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form childForm = new Altera_login();
            childForm.Show();
        }
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
        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            MostrarOcultarSenha();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMinimized.Visible = true;
        }
        private void btnMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMinimized.Visible = true;
        }
    }
}
