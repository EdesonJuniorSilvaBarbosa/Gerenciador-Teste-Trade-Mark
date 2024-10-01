using Gerenciador.BLL;
using Gerenciador.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class Pesquisa_Avancada : Form
    {
        public Pesquisa_Avancada()
        {
            InitializeComponent();

            dTPDataInicial.Value = DateTime.Today;
            dTPDataFinal.Value = DateTime.Today;

            lblValorPendenteRecebimento.Text = "";
            lblValorPendentePagamento.Text = "";
            lblValorPrevistoTotalEntradas.Text = "";

            dTPDataInicial.ValueChanged += new EventHandler(DateTimePickers_ValueChanged);
            dTPDataFinal.ValueChanged += new EventHandler(DateTimePickers_ValueChanged);

        }
        private void btnPesqPendentes_Click(object sender, EventArgs e)
        {
            try
            {
                // Pesquisa intervalo de datas
                DateTime dataInicial;
                DateTime dataFinal;

                Regex dateFormatadaRegex = new Regex(@"^\d{2}/\d{2}/\d{4}$");
                if (!dateFormatadaRegex.IsMatch(dTPDataInicial.Text) || !dateFormatadaRegex.IsMatch(dTPDataFinal.Text))
                {
                    MessageBox.Show("Formato de data inválido. Certifique-se de inserir a data no formato dd/MM/yyyy.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tenta avaliar a data inicial
                if (!DateTime.TryParseExact(dTPDataInicial.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataInicial))
                {
                    MessageBox.Show("Formato de data inicial é inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Tenta avaliar a data final
                if (!DateTime.TryParseExact(dTPDataFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataFinal))
                {
                    MessageBox.Show("Formato de data final é inválido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dataFormatadaInicial = dataInicial.ToString("dd/MM/yyyy");
                string dataFormatadaFinal = dataFinal.ToString("dd/MM/yyyy");

                // Obter a conta selecionada no comboBox
                //string nomeConta = comboBox1.SelectedItem.ToString() == "Todas as Contas" ? null : comboBox1.SelectedItem.ToString();
                string nomeConta = null;
                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() != "Todas as Contas")
                {
                    nomeConta = comboBox1.SelectedItem.ToString();
                }

                // Obter as contas e os valores pendentes
                decimal pendenteEntradas = 0;
                decimal pendenteSaidas = 0;
                decimal recebidos = 0;
                decimal pagos = 0;
                decimal previstoEntradas = 0;
                decimal previstoSaidas = 0;

                IList<contas_DTO> contasConsultadas = new GerenciadorBLL().ContasPendentes(dataInicial, dataFinal, nomeConta, out pendenteEntradas, out pendenteSaidas, out recebidos, out pagos, out previstoEntradas, out previstoSaidas);
                
                decimal saldoPrevisto = (pendenteEntradas + recebidos) - (pendenteSaidas + pagos);

                if (contasConsultadas.Count == 0)
                {
                    MessageBox.Show("Nenhuma conta encontrada para o nome especificado", "Conta não encontrada.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = "";
                    lblValorPagos.Text = "";
                    lblValorRecebidos.Text = "";
                    lblValorPendentePagamento.Text = "";
                    lblValorPendenteRecebimento.Text = "";
                    lblValorPrevistoTotalEntradas.Text = "";
                    lblValorPrevistoTotalSaidas.Text = "";
                    lblValorSaldoPrevisto.Text = "";
                    dTPDataInicial.Value = DateTime.Today;
                    dTPDataFinal.Value = DateTime.Today;
                    return;
                }
                else
                {
                    lblValorPendenteRecebimento.Text = pendenteEntradas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                    lblValorPendentePagamento.Text = pendenteSaidas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                    lblValorRecebidos.Text = recebidos.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                    lblValorPagos.Text = pagos.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                    lblValorPrevistoTotalEntradas.Text = previstoEntradas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                    lblValorPrevistoTotalSaidas.Text = previstoSaidas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                    lblValorSaldoPrevisto.Text = saldoPrevisto.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                    // Preencher o DataGridView com os resultados
                    dataGridView1.DataSource = contasConsultadas.Select(c => new
                    {
                        Tipo = c.tipo,
                        Data = c.data_cont.ToString("dd/MM/yyyy"),
                        Valor = c.valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR")),
                        Descricao = c.descricao,
                        Status = c.status_cont
                    }).ToList();

                    // Ajusta automaticamente o tamanho das colunas do DataGridView
                    dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch
            {
                MessageBox.Show($"Erro ao consultar os dados ou nenhum valor foi encontrado. tente novamente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarDescricoesComboBox(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                string contaSelecionada = comboBox1.SelectedItem?.ToString();
                
                GerenciadorBLL gerenciadorBLL = new GerenciadorBLL();
                int codUsuario = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;
                IList<string> descricoes = gerenciadorBLL.ObterContasEPreencherComboBox(codUsuario, dataInicial, dataFinal);

                // Adiciona a opção de "Todas as contas"
                descricoes.Insert(0, "Todas as contas");

                comboBox1.DataSource = descricoes;

                if (contaSelecionada != null && descricoes.Contains(contaSelecionada))
                {
                    comboBox1.SelectedItem = contaSelecionada;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as descrições das contas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DateTimePickers_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataInicial = dTPDataInicial.Value;
            DateTime dataFinal = dTPDataFinal.Value;

            // Certifique-se de que a data inicial é menor ou igual à data final
            if (dataInicial <= dataFinal)
            {
                CarregarDescricoesComboBox(dataInicial, dataFinal);
            }
            else
            {
                MessageBox.Show("A data inicial deve ser menor ou igual à data final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dTPDataInicial_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                // Tenta converter a entrada de data para DateTime usando o formato especifico
                DateTime dataInicio = DateTime.ParseExact(dTPDataInicial.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dataFim = DateTime.ParseExact(dTPDataFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Verifica se a data Inicio é maior que a data Fim
                if (dataInicio > dataFim)
                {
                    MessageBox.Show("A data Inicial não pode ser maior que a data final!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; // Cancela a mudança do foco
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A data Inicial é inválida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Cancela a mudança de foco
            }
        }
        private void dTPDataFinal_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                // Tenta converter a entrada de data para DateTime usando o formato especifico
                DateTime dataInicio = DateTime.ParseExact(dTPDataInicial.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dataFim = DateTime.ParseExact(dTPDataFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Verifica se a data Inicio é maior que a data Fim
                if (dataFim < dataInicio)
                {
                    MessageBox.Show("A data Final não pode ser menor que a data Inicial!", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true; // Cancela a mudança do foco
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A data Final é inválida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Cancela a mudança de foco
            }
        }
    }
}
