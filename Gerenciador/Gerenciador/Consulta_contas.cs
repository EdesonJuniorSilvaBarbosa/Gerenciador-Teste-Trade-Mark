using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Gerenciador.DTO;
using Gerenciador.BLL;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;
using System.Threading.Tasks;

namespace Gerenciador
{
    public partial class Consulta_contas : Form
    {
        private Label alertLabel;
        private readonly Timer timer = new Timer();
        public Consulta_contas()
        {
            InitializeComponent();

            // método para criar um rotulo ou lembre sobre o campo da data pesquisada
            CriarRotuloDataPesquisada();

            lbl_information.Text = "";
            FormUtils.DesativaCampos(this);

            dTPDataPesquisa.Value = DateTime.Today;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataPesquisada;

                Regex dateFormatadaRegex = new Regex(@"^\d{2}/\d{2}/\d{4}$");
                if (!dateFormatadaRegex.IsMatch(dTPDataPesquisa.Text))
                {
                    MessageBox.Show("Formato de data inválido. Certifique-se de inserir a data no formato dd/MM/yyyy.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tenta avaliar a data
                if (!DateTime.TryParseExact(dTPDataPesquisa.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataPesquisada))
                {
                    MessageBox.Show("Formato de data inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dataFormatada = dataPesquisada.ToString("dd/MM/yyyy");

                string nomeConta = txtPesquisa.Text;

                IList<contas_DTO> contasConsultadas = new GerenciadorBLL().ConsultarContasPorNome(nomeConta, dataPesquisada);

                if (string.IsNullOrEmpty(nomeConta))
                {
                    MessageBox.Show("O campo Nome é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormUtils.DesativaCampos(this);
                    return;

                }else if (contasConsultadas.Count == 0)
                {
                    MessageBox.Show("Nenhuma conta encontrada para o nome especificado", "Conta não encontrada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesquisa.Text = string.Empty;
                    return;
                }
                else
                {
                    // Ajuste na lógica para preencher os campos do formulário com a primeira conta encontrada
                    var primeiraConta = contasConsultadas.First();

                    txtCodConta.Text = primeiraConta.cod_conta.ToString();
                    txtPesquisa.Text = primeiraConta.descricao;
                    dTPDataPesquisa.Text = primeiraConta.dataFormatada; // Use o formato da data já formatado na consulta
                    txtTipo.Text = primeiraConta.tipo;
                    txtValor.Text = primeiraConta.valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR")); // Use o formato do valor já formatado na consulta
                    dTPData.Text = primeiraConta.data_cont.ToString();
                    txtDescricao.Text = primeiraConta.descricao;
                    txtStatus.Text = primeiraConta.status_cont.ToString();

                    // Limpa o campo após a pesquisa
                    txtPesquisa.Text = string.Empty;
                    dTPDataPesquisa.Text = "";
                }
            }
            catch
            {
                MessageBox.Show($"Erro ao consultar os dados ou nenhum valor foi encontrado. tente novamente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            FormUtils.DesativaCampos(this);
            FormUtils.LimpaCampos(this);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                if (txtCodConta.Text == "")
                {
                    MessageBox.Show("Nenhuma conta foi selecionada !", "Erro ao Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtDescricao.Enabled == false)
                {
                    MessageBox.Show("Você não pode alterar sem antes informar novos valores, clique em editar!", "Erro ao Alterar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    contas_DTO CONT = new contas_DTO
                    {
                        cod_conta = Convert.ToInt32(txtCodConta.Text),
                        valor = decimal.Parse(txtValor.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR")),
                        descricao = txtDescricao.Text,
                        data_cont = DateTime.ParseExact(dTPData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        tipo = txtTipo.Text
                    };

                    int x = new GerenciadorBLL().alteraConta(CONT, codUsuarioAutenticado);

                    if (x > 0)
                    {
                        lbl_information.Text = "Alterado com sucesso";
                        lbl_information.ForeColor = Color.Green;
                    }
                    FormUtils.LimpaCampos(this);
                    FormUtils.DesativaCampos(this);
                }
                else
                {
                    FormUtils.LimpaCampos(this);
                    FormUtils.DesativaCampos(this);
                }
            } catch (Exception ex)
            {
                lbl_information.Text = "Erro inesperado" + ex.Message;
            }
        }
        private void btnEdita_Click(object sender, EventArgs e)
        {
            if (txtCodConta.Text != "")
            {
                FormUtils.AtivaCampos(this);
            }
            else
            {
                MessageBox.Show("Nenhuma conta foi selecionada !", "Erro ao Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                if (txtCodConta.Text == "")
                {
                    MessageBox.Show("Nenhuma conta foi selecionada !", "Erro ao Deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Tem certeza que desjea deletar ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(resultado == DialogResult.Yes)
                    {
                        contas_DTO CONT = new contas_DTO()
                        {
                            cod_conta = Convert.ToInt32(txtCodConta.Text)
                        };

                        int x = new GerenciadorBLL().excluiConta(CONT, codUsuarioAutenticado);
                        if (x > 0)
                        {
                            lbl_information.Text = "Excluído com sucesso!";
                            lbl_information.ForeColor = Color.Green;
                        }
                        FormUtils.LimpaCampos(this);
                    }
                    else
                    {
                        FormUtils.LimpaCampos(this);
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_information.Text = "Erro inesperado" + ex.Message;
            }
        }
        private void txtTipo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                // Campo está vazio, não precisa de validação adicional
                return;
            }

            if (txtTipo.Text != "Entrada" && txtTipo.Text != "Saida")
            {
                MessageBox.Show("Esta campo aceita somente os valores: Entrada ou Saida", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipo.Focus(); // Foca no TextBox novamente
                txtTipo.SelectAll(); // Seleciona todo o texto para facilitar a correção
            }
        }
        private void txtValor_Leave(object sender, EventArgs e)
        {
            //formatar o campo automatico 
            try
            {
                double valor;

                if (double.TryParse(txtValor.Text.Trim(), NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valor))
                {
                    txtValor.Text = valor.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"));
                }
            }
            catch (Exception ex)
            {
                lbl_information.Text = "Algo inesperado aconteceu" + ex.Message;
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um novo objeto SaveFileDialog
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Define o titulo da janela do dialogo
                saveFileDialog.Title = "Salvar Backup das Contas";

                // Define o filtro para exibir apenas arquivos CSV
                saveFileDialog.Filter = "Arquivos CSV (*.csv) |*.csv";

                // Define o diretorio inicial como Meus Documentos
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtém o caminho completo do arquivo selecionado pelo usuario
                    string filePath = saveFileDialog.FileName;

                    // Obtém o codigo do usuario autenticado
                    int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                    GerenciadorBLL gerenciadorBLL = new GerenciadorBLL();
                    gerenciadorBLL.GerarBackupContas(codUsuarioAutenticado, filePath);

                    MessageBox.Show("Backup das contas gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar o backup das contas: {ex.Message}");
            }
        }
        private void Consulta_contas_Load(object sender, EventArgs e)
        {
            GerenciadorBLL gerenciadorBLL = new GerenciadorBLL();

            IList<contas_DTO> contasProximas = gerenciadorBLL.ConsultarContasProximasDoVencimento();

            // Verifica se há resultados
            if (contasProximas != null && contasProximas.Count > 0)
            {
                // Intera sobre os resultados e adicione-os ao ListBox
                foreach (contas_DTO conta in contasProximas)
                {
                    // Construa uma string com os detalhes da conta para exibição no ListBox
                    string detalhesConta = $"Dia:  {conta.dataFormatada},       Valor:  {conta.valorFormatado},       Conta:  {conta.descricao},       {conta.status_cont}";
                    ListContasProximasVencimento.Items.Add(detalhesConta);
                }
            }
        }
        private void CriarRotuloDataPesquisada()
        {
            // Cria um rótulo temporário para a mensagem de alerta
            alertLabel = new Label();
            alertLabel.Text = "Selecione a data da conta.";
            alertLabel.AutoSize = true;
            alertLabel.ForeColor = Color.DimGray; // Cor da fonte
            alertLabel.BackColor = Color.White; // Cor de fundo
            alertLabel.Visible = false;

            // Define a posição do rótulo
            alertLabel.Location = new Point(dTPDataPesquisa.Left, dTPDataPesquisa.Bottom + 10);//55

            // Adiciona o rótulo ao formulário
            Controls.Add(alertLabel);

            // Garante que o rótulo seja exibido sobre outros controles
            alertLabel.BringToFront();

            // Configura o temporizador
            timer.Interval = 2000; // Tempo em milissegundos (3 segundos)
            timer.Tick += Timer_Tick;

            // Subscreve-se no evento MouseHover do DateTimePicker
            dTPDataPesquisa.MouseHover += dTPDataPesquisa_MouseHover;
            dTPDataPesquisa.MouseLeave += dTPDataPesquisa_MouseLeave;
        }
        private void dTPDataPesquisa_MouseHover(object sender, EventArgs e)
        {
            // Exibe o rótulo quando o mouse entra no DateTimePicker
            alertLabel.Visible = true;
            // Inicia o temporizador quando o mouse entra
            timer.Start();
        }
        private void dTPDataPesquisa_MouseLeave(object sender, EventArgs e)
        {
            // Oculta o rótulo quando o mouse sai do DateTimePicker
            alertLabel.Visible = false;
            // Para o temporizador quando o mouse sai
            timer.Stop();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Aguarda por um curto período de tempo
            System.Threading.Thread.Sleep(1000); // Espera por 1000 milissegundos (1 segundo)

            // Oculta o rótulo após o tempo decorrido
            alertLabel.Visible = false;

            // Para o temporizador
            timer.Stop();
        }
        private void linkLabelPendentes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirOuAtivarTela<Pesquisa_Avancada>();
        }
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
                childForm.Show();
            }
        }
    }
}
