using Gerenciador.BLL;
using Gerenciador.DTO;
using Gerenciador.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Drawing.Printing;
using Margins = System.Drawing.Printing.Margins;
using System.Diagnostics;

namespace Gerenciador
{
    public partial class Resumo_Historicos : Form
    {
        private readonly GerenciadorBLL gerenciadorBLL;
        private string ultimoMesSelecionado = null; // Variável para armazenar o último mês usado para gerar o gráfico
        private int ultimoAnoSelecionado; // Variável para armazenar o último ano usado para gerar o gráfico
        //private int codUsuario;

        public Resumo_Historicos()
        {
            InitializeComponent();
            PreencherComboBoxAno();

            // Pega o valor do Textbox do Campo Saldo Total do Formulario Bancos
            Bancos form = new Bancos();
            form.Show();
            lblSaldoBancario.Text = form.txtTotalSaldo.Text;
            lblSaldoBancario.Visible = false;
            // Fecha o formulario automatico
            form.Close();
            form = null;

            // Definindo o tamanho fixo da tela Resumo Mensal
            int width = 1150; // largura da tela
            int height = 626; // altura da tela
            this.Size = new Size(width, height);

            // Definindo o tarmanho da tela do gráfico
            int widthGrafico = 971;
            int heightGrafico = 598;
            chart1.Size = new Size(widthGrafico, heightGrafico);

            gerenciadorBLL = new GerenciadorBLL();

            cboMesSelecionado.SelectedIndexChanged += cboMesSelecionado_SelectedIndexChanged;
        }
        private string tituloDoGrafico = "Demonstrativo"; // Variável de membro para armazenar o título do gráfico
        private void CriarGrafico(string titulo, IList<contas_DTO> dados, string mesSelecionado, int anoSelecionado)
        {
            chart1.Titles.Clear();
            chart1.Series.Clear();

            // Define o título do gráfico
            var tituloGrafico = new Title
            {
                Font = new Font("Arial", 22, FontStyle.Bold),
                ForeColor = Color.Teal,
                Text = $"{titulo} - {mesSelecionado} / {anoSelecionado}"
            };
            chart1.Titles.Add(tituloGrafico);

            // Adiciona uma série de dados do tipo Doughnut
            Series series = new Series
            {
                ChartType = SeriesChartType.Doughnut,
                BorderWidth = 2, // Largura da linha
                //Color = Color.DarkBlue // Define a cor azul escuro
            };

            // Inclinação do gráfico
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.ChartAreas[0].Area3DStyle.Inclination = 30;
            chart1.ChartAreas[0].Area3DStyle.Rotation = 60;

            // Adiciona os dados retornados pela procedure diretamente à série de pizza
            foreach (var dto in dados)
            {
                DataPoint point = new DataPoint
                {
                    AxisLabel = dto.descricao,
                    YValues = new double[] { (double)dto.valor },
                    Label = dto.descricao,
                    LegendText = dto.tipo,
                    ToolTip = $"{dto.descricao} - {dto.tipo}",
                    IsValueShownAsLabel = true
                };

                series.Points.Add(point);
            }

            // Adiciona a série ao gráfico
            chart1.Series.Add(series);

            // Define a cor da fonte e a fonte para cada ponto de dados
            foreach (DataPoint point in series.Points)
            {
                point.LabelForeColor = Color.Black;
                point.Font = new Font("Arial", 10, FontStyle.Bold);
                point.Label = string.Format("{0}\n{1:N2}", point.AxisLabel, point.YValues[0].ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
            }

            // Define a posição dos rótulos fora da fatia, mas próximos ao gráfico
            chart1.Series[0]["PieLabelStyle"] = "Outside";
        }
        private void ExibirGrafico(IList<contas_DTO> dados, string mesSelecionado, int anoSelecionado)
        {
            int numeroMes;

            switch (mesSelecionado)
            {
                case "Janeiro":
                    numeroMes = 1;
                    break;
                case "Fevereiro":
                    numeroMes = 2;
                    break;
                case "Março":
                    numeroMes = 3;
                    break;
                case "Abril":
                    numeroMes = 4;
                    break;
                case "Maio":
                    numeroMes = 5;
                    break;
                case "Junho":
                    numeroMes = 6;
                    break;
                case "Julho":
                    numeroMes = 7;
                    break;
                case "Agosto":
                    numeroMes = 8;
                    break;
                case "Setembro":
                    numeroMes = 9;
                    break;
                case "Outubro":
                    numeroMes = 10;
                    break;
                case "Novembro":
                    numeroMes = 11;
                    break;
                case "Dezembro":
                    numeroMes = 12;
                    break;
                default:
                    MessageBox.Show("Selecione um mês válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Retorna sem continuar a execução do método
            }

            // Chama o método na camada BLL passando o número do mês
            IList<contas_DTO> dadosBrutos = new GerenciadorBLL().ObterDadosParaGraficoAnual(numeroMes, anoSelecionado);

            // Cria o gráfico com os dados obtidos
            CriarGrafico(tituloDoGrafico, dadosBrutos, mesSelecionado, anoSelecionado);
          
            // Calcula os totais de entradas e saídas
            decimal totalEntradas = 0;
            decimal totalSaidas = 0;

            foreach (var dto in dadosBrutos)
            {
                if (dto.valor > 0 && dto.tipo == "Entrada")
                {
                    totalEntradas += dto.valor;
                }
                else if(dto.valor > 0 && dto.tipo == "Saida")
                {
                    totalSaidas += dto.valor;
                }
            }

            //Calcula o subtotal
            decimal subtotal = totalEntradas - totalSaidas;

            // Atualiza os textboxes com os totais calculados
            txtReceitas.Text = totalEntradas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            txtDespesas.Text = totalSaidas.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            txtTotal.Text = subtotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }
        private void lblLinkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;
            usuario_DTO usuarioAutenticado = new GerenciadorDAL().ObterUsuarioNome(codUsuarioAutenticado);

            this.Cursor = Cursors.Hand;
            string nomeUsuario = Gerenciador.DTO.sessao_DTO.NomeUsuarioAutenticado = usuarioAutenticado.nome + " " + usuarioAutenticado.sobrenome;
            string totalEntrada = txtReceitas.Text;
            string totalSaida = txtDespesas.Text;
            string subtotal = txtTotal.Text;

            // Verifica se o botão Imprimir foi clicado e mostra o valor Label
            if (sender == btnImprimir)
            {
                lblSaldoBancario.Visible = true;
            }
            string saldoBancario = lblSaldoBancario.Text;
            ImprimirGrafico(nomeUsuario, totalEntrada, totalSaida, subtotal, saldoBancario);
        }
        public void ImprimirGrafico(string nomeUsuario, string totalEntrada, string totalSaida, string subtotal, string saldoBancario)
        {
            // Cria um novo documento de impressão
            PrintDocument pd = new PrintDocument();

            // Define a orientação da página para paisagem
            pd.DefaultPageSettings.Landscape = true;

            // Manipula o evento PrintPage para desenhar o gráfico na página
            pd.PrintPage += (sender, e) =>
            {
                // Define a cor da página
                e.Graphics.Clear(Color.White);

                // Desenha o gráfico na página
                chart1.Printing.PrintPaint(e.Graphics, e.MarginBounds);

                // Dados da data
                string mesPorExtenso = DateTime.Now.ToString("MMMM", CultureInfo.GetCultureInfo("pt-BR"));
                int dia = DateTime.Now.Day;
                int ano = DateTime.Now.Year;
                string horaAtual = DateTime.Now.ToString("HH:mm"); // hora atual

                // Define a fonte para o texto
                using (Font font = new Font("Calibri", 12))
                {
                    // Medir o tamanho do texto do Author
                    string textoAuthor = $"Author: \n{nomeUsuario}, Impresso em: {dia} de {mesPorExtenso} de {ano} às {horaAtual}".Trim();
                    SizeF textoAuthorTamanho = e.Graphics.MeasureString(textoAuthor, font);

                    // Margens da página
                    float margemInferior = e.PageBounds.Bottom - e.MarginBounds.Bottom + 10;
                    float margemEsquerda = e.MarginBounds.Left;

                    // Define a posição para o desenho do texto Author
                    float xAuthor = margemEsquerda; // Posição horizontal na margem esquerda
                    float yAuthor = e.PageBounds.Bottom - margemInferior - textoAuthorTamanho.Height; // Posição vertical na margem inferior

                    // Calcula a largura necessária para o texto
                    float larguraTexto = e.Graphics.MeasureString(textoAuthor, font).Width;

                    // Define a configuração de alinhamento do texto para o Author
                    StringFormat stringFormatAuthor = new StringFormat
                    {
                        Alignment = StringAlignment.Near, // Alinhamento à esquerda
                        FormatFlags = StringFormatFlags.NoWrap // Impede a quebra de linha
                    };

                    // Desenha o texto do Author
                    //e.Graphics.DrawString(textoAuthor, font, Brushes.Teal, new RectangleF(xAuthor, yAuthor, e.PageBounds.Width - margemEsquerda, textoAuthorTamanho.Height), stringFormatAuthor);
                    e.Graphics.DrawString(textoAuthor, font, Brushes.Teal, new RectangleF(xAuthor, yAuthor, larguraTexto, textoAuthorTamanho.Height), stringFormatAuthor);

                    // Define a posição inicial para o desenho das outras linhas
                    float y = yAuthor - 20; // Move a posição vertical para cima

                    // Define a configuração de alinhamento do texto para as outras linhas
                    StringFormat stringFormatOther = new StringFormat
                    {
                        Alignment = StringAlignment.Far // Alinhamento à direita
                    };

                    // Desenha o texto do subtotal
                    e.Graphics.DrawString($"Subtotal: {subtotal}", font, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width - 20, font.Height), stringFormatOther);

                    // Desenha o texto do total de saída
                    y -= 20; // Move a posição vertical para cima
                    e.Graphics.DrawString($"Total de saída: {totalSaida}", font, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width - 20, font.Height), stringFormatOther);

                    // Desenha o texto do total de entrada
                    y -= 20; // Move a posição vertical para cima
                    e.Graphics.DrawString($"Total de entrada: {totalEntrada}", font, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width - 20, font.Height), stringFormatOther);

                    // Desenha o texto do saldo bancário
                    y -= 20; // Move a posição vertical para cima
                    e.Graphics.DrawString($"Saldo bancário: {saldoBancario}", font, Brushes.Black, new RectangleF(e.MarginBounds.Left, y, e.MarginBounds.Width - 20, font.Height), stringFormatOther);
                }
            };

            // Define o nome do documento de impressão
            string nomeDocumento = $"RESUMO_MENSAL_DT{DateTime.Now.ToString("dd.MM.yyyy")}_HR{DateTime.Now.ToString("HHmmss")}.pdf";
            pd.DocumentName = nomeDocumento;

            // Define as margens do documento de impressão
            pd.DefaultPageSettings.Margins = new Margins(5, 5, 5, 5);

            // Cria um diálogo de impressão e define o documento a ser impresso
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            // Exibe o diálogo de impressão e verifica se o usuário confirmou a impressão
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Inicia o processo de impressão
                pd.Print();
            }

            // Deixa o Label invisível após terminar a impressão
            lblSaldoBancario.Visible = false;
        }
        private void cboMesSelecionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGrafico();
            AtualizarTamanhoFonteTextBox();
        }
        private void cboAnoSelecionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGrafico();
            AtualizarTamanhoFonteTextBox();
        }
        private void AjustarTamanhoFonteTextBox(TextBox textBox)
        {
            // Defina o tamanho máximo permitido para a fonte do TextBox
            float tamanhoMaximoFonte = 18f;

            // Defina a margem mínima em pixels para garantir que o texto não seja cortado
            int margemMinima = 2;

            // Obtenha o tamanho atual da fonte
            float tamanhoFonteAtual = textBox.Font.Size;

            // Obtenha o tamanho do texto atual
            SizeF tamanhoTexto = TextRenderer.MeasureText(textBox.Text, textBox.Font);

            // Calcule a proporção de ajuste necessário para caber no TextBox
            float proporcaoAjuste = Math.Min((textBox.Width - margemMinima) / tamanhoTexto.Width,
                                              (textBox.Height - margemMinima) / tamanhoTexto.Height);

            // Calcule o novo tamanho da fonte
            float novoTamanhoFonte = tamanhoFonteAtual * proporcaoAjuste;

            // Garanta que o tamanho da fonte não ultrapasse o tamanho máximo
            novoTamanhoFonte = Math.Min(novoTamanhoFonte, tamanhoMaximoFonte);

            // Aplique o novo tamanho da fonte ao TextBox
            textBox.Font = new Font(textBox.Font.FontFamily, novoTamanhoFonte, FontStyle.Bold);
        }
        private void AtualizarTamanhoFonteTextBox()
        {
            AjustarTamanhoFonteTextBox(txtTotal);
            AjustarTamanhoFonteTextBox(txtReceitas);
            AjustarTamanhoFonteTextBox(txtDespesas);
        }
        private void PreencherComboBoxAno()
        {
            int anoInicial = 2000; // Ano inicial do intervalo
            int anoFinal = DateTime.Now.Year; // Ano final do intervalo (Ano Atual)

            for (int ano = anoInicial; ano <= anoFinal; ano++)
            {
                cboAnoSelecionado.Items.Add(ano);
            }

            // Opcional: seleciona o ano atual por padrão
            cboAnoSelecionado.SelectedItem = anoFinal;
        }

        // Função para converter o nome do mês para o número do mês
        private int ObterNumeroMes(string mesNome)
        {
            Dictionary<string, int> meses = new Dictionary<string, int>()
            {
                { "Janeiro", 1 },
                { "Fevereiro", 2 },
                { "Março", 3 },
                { "Abril", 4 },
                { "Maio", 5 },
                { "Junho", 6 },
                { "Julho", 7 },
                { "Agosto", 8 },
                { "Setembro", 9 },
                { "Outubro", 10 },
                { "Novembro", 11 },
                { "Dezembro", 12 }
            };

            if (meses.ContainsKey(mesNome))
            {
                return meses[mesNome];
            }
            else
            {
                throw new Exception("Mês inválido selecionado.");
            }
        }
        private void AtualizarGrafico()
        {
            if (cboMesSelecionado.SelectedItem != null && cboAnoSelecionado.SelectedItem != null)
            {
                string mesSelecionado = cboMesSelecionado.SelectedItem.ToString();
                int anoSelecionado = (int)cboAnoSelecionado.SelectedItem;
                int codUsuarioAutenticado = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                // Mapeia o nome do mês para seu número correspondente
                int numeroMesSelecionado = ObterNumeroMes(mesSelecionado);

                // Obtém os dados atualizados para o gráfico
                GerenciadorDAL gerenciadorDAL = new GerenciadorDAL();
                var dados = gerenciadorDAL.ObterDadosParaGraficoAnual(codUsuarioAutenticado, numeroMesSelecionado, anoSelecionado);

                // Atualiza o gráfico com os novos dados
                ExibirGrafico(dados, mesSelecionado, anoSelecionado);

                ultimoMesSelecionado = mesSelecionado;
                ultimoAnoSelecionado = anoSelecionado;
            }
            AtualizarTamanhoFonteTextBox();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AtualizarGrafico();
        }
    }
}
