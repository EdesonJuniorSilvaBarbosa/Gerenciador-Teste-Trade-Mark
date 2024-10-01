using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gerenciador
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();

            // Carrega a imagem desejada como plano de fundo
            this.BackgroundImage = Gerenciador.Properties.Resources.fundo01;

            // Outras formas 
            //this.BackgroundImage = Image.FromFile("E:\\DOCUMENTOS\\Backup Sistema Financeiro\\SistemaGerenciadorFinanceiro\\Gerenciador\\Gerenciador\\Resources\\fundo.png");

            // Define o layout da imagem de fundo
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Define o estado inicial do formulario como maximizado
            this.WindowState = FormWindowState.Maximized;

            // Define o tamanho do formulario para tamanho do dispositivo
            this.Size = SystemInformation.PrimaryMonitorSize;
        }
        private void MDIParent1_Load(object sender, EventArgs e)
        {
            ExibirMensagemBoasVindas();
        }
        private void ExibirMensagemBoasVindas()
        {
            string nomeUsuario = Gerenciador.DTO.sessao_DTO.NomeUsuarioAutenticado;
            lblBoasVindas.Text = $"Olá, \n{nomeUsuario}!";
            lblBoasVindas.ForeColor = Color.White;
            lblBoasVindas.Font = new Font(lblBoasVindas.Font.FontFamily, 10, FontStyle.Bold);
        }

        // Método para otimizar e evitar duplicidade de telas abertas
        private void AbrirOuAtivarTela<T>() where T : Form, new()
        {
            // Verifica se a uma instância da tela já está aberta
            T telaAberta = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (telaAberta != null)
            {
                // Se a tela já estiver aberta, traz ela para frente
                telaAberta.Activate();
            }
            else
            {
                Form childForm = new T();
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        // Chamadas das Telas
        private void tsmRegistrarContas_Click(object sender, EventArgs e)
        {
            AbrirOuAtivarTela<Cadastro_contas>();
        }
        private void tsmGerenciarContasCadastradas_Click(object sender, EventArgs e)
        {
            AbrirOuAtivarTela<Consulta_contas>();
        }
        private void tsmGerenciarCadastroUsuarios_Click(object sender, EventArgs e)
        {
            AbrirOuAtivarTela<Alterar_cadastroUsuario>();
        }
        private void tsmGerenciarBancos_Click(object sender, EventArgs e)
        {
            AbrirOuAtivarTela<Bancos>();
        }
        private void tsmResumosHistoricos_Click(object sender, EventArgs e)
        {
            AbrirOuAtivarTela<Resumo_Historicos>();
        }
        private void lblLinkSairSistema_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
            string nomeProcesso = Process.GetCurrentProcess().ProcessName;

            Process[] processos = Process.GetProcessesByName(nomeProcesso);

            foreach (Process processo in processos)
            {
                processo.Kill();
            }
            this.Close();
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
