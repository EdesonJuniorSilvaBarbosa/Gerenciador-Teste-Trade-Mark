using Gerenciador.BLL;
using Gerenciador.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Gerenciador
{
    public partial class Bancos : Form
    {
        private bool saldoOculto = true;
        private string textoOriginalBotaoEditar = "Editar";
        private string valorOriginalTextBox; // armazena o valor original do campo TextBox

        public Bancos()
        {
            InitializeComponent();
            btnCadBanco.Text = "Enviar dados";
            btnMostrarSaldo.Text = "Exibir";
        }
        private void btnCadBanco_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeBanco = txtNomeBanco.Text;

                if (BancoJaCadastrado(nomeBanco))
                {
                    MessageBox.Show("Este nome de banco já está cadastrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtém o codigo do usuário autenticado
                int idUsuario = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID;

                GerenciadorBLL gerenciadorBLL = new GerenciadorBLL();

                // Obtém a lista de bancos cadastrados pelo usuário autenticado
                IList<bancos_DTO> bancosCadastrados = gerenciadorBLL.cargaBanco();

                // Verifica se o número de bancos cadastrados é menor que 4
                if (bancosCadastrados.Count < 4)
                {
                    if (string.IsNullOrWhiteSpace(txtNomeBanco.Text) || string.IsNullOrWhiteSpace(txtSaldoBanco.Text))
                    {
                        // Pelo menos um campo está vazio, identifique qual campo e mostre uma mensagem de aviso.
                        string campoVazio = "";

                        if (string.IsNullOrWhiteSpace(txtNomeBanco.Text))
                            campoVazio = "Nome banco";
                        else if (string.IsNullOrWhiteSpace(txtSaldoBanco.Text))
                            campoVazio = "Saldo";

                        MessageBox.Show($"O campo '{campoVazio}' está vazio.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bancos_DTO BAN = new bancos_DTO
                        {
                            cod_usuario = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID,
                            nome_banco = txtNomeBanco.Text,
                            saldo = decimal.Parse(txtSaldoBanco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR")),
                        };

                        int x = new GerenciadorBLL().insereBanco(BAN);

                        if (x > 0)
                        {
                            btnCadBanco.Text = "Gravado com sucesso!";
                            CarregaDadosBancoDeDados();
                            btnCadBanco.ForeColor = Color.Green;
                            btnCadBanco.TextAlign = ContentAlignment.MiddleCenter;

                            // Amazena um referencia ao botao que disparou o evento
                            Button botaoClicado = btnCadBanco;

                            // Inicializa um temporizador
                            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                            timer.Interval = 2000; // aguardar 5 segundos

                            timer.Tick += (s, _) =>
                            {
                                botaoClicado.Text = "Enviar novos dados";
                                botaoClicado.ForeColor = Color.MidnightBlue;
                                timer.Stop();
                            };
                            timer.Start();
                        }
                        txtNomeBanco.Text = "";
                        txtSaldoBanco.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Você já cadastrou o número máximo de bancos permitidos (4).", "Limite de Bancos Atingido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeBanco.Text = "";
                    txtSaldoBanco.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }
        private bool BancoJaCadastrado(string nomeBanco)
        {
            GerenciadorBLL gerenciadorBLL = new GerenciadorBLL();

            IList<bancos_DTO> bancosCadastrados = gerenciadorBLL.cargaBanco();

            foreach (var banco in bancosCadastrados)
            {
                if (banco.nome_banco.Equals(nomeBanco, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        private void Bancos_Load(object sender, EventArgs e)
        {
            CarregaDadosBancoDeDados();
        }
        private void CarregaDadosBancoDeDados()
        {
            try
            {
                IList<bancos_DTO> bancosConsultados = new GerenciadorBLL().cargaBanco();

                // Matriz para organizar os textboxes de cada registro bancario
                TextBox[,] textboxs = new TextBox[4, 2]
                {
                    { txtBanco1, txtNomeBanco1},
                    { txtBanco2, txtNomeBanco2},
                    { txtBanco3, txtNomeBanco3},
                    { txtBanco4, txtNomeBanco4}
                };

                // inicia os Textboxes como invisíveis
                for (int i = 0; i < 4; i++)
                {
                    textboxs[i, 0].Visible = false;
                    textboxs[i, 1].Visible = false;
                }

                // Matriz para organizar os botoes de cada registro bancario
                Button[,] botoes = new Button[4, 3]
                {
                    { btnEditarBanco1, btnAlterarBanco1, btnExcluirBanco1 },
                    { btnEditarBanco2, btnAlterarBanco2, btnExcluirBanco2 },
                    { btnEditarBanco3, btnAlterarBanco3, btnExcluirBanco3 },
                    { btnEditarBanco4, btnAlterarBanco4, btnExcluirBanco4 }
                };

                // Inicia os botões como invisíveis
                foreach (var btn in botoes)
                {
                    btn.Visible = false;
                }

                // Exibe os resultados nos campos do formulário se houver dados
                int contador = 0;
                foreach (var banco in bancosConsultados.Take(4)) // Take limita a no máximo 4 registros
                {
                    if (contador < botoes.GetLength(0) && contador < textboxs.GetLength(0))
                    {
                        TextBox textBox = null;
                        TextBox txtBoxNome = null;

                        switch (contador)
                        {
                            case 0:
                                textBox = textboxs[0, 0];
                                txtBoxNome = textboxs[0, 1];
                                break;
                            case 1:
                                textBox = textboxs[1, 0];
                                txtBoxNome = textboxs[1, 1];
                                break;
                            case 2:
                                textBox = textboxs[2, 0];
                                txtBoxNome = textboxs[2, 1];
                                break;
                            case 3:
                                textBox = textboxs[3, 0];
                                txtBoxNome = textboxs[3, 1];
                                break;
                            default:
                                continue; // Não executa o restante do código neste loop
                        }

                        Button btnEditar = botoes[contador, 0];
                        Button btnAlterar = botoes[contador, 1];
                        Button btnExcluir = botoes[contador, 2];

                        textBox.Text = banco.saldo.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                        txtBoxNome.Text = banco.nome_banco;
                        txtTotalSaldo.Text = banco.total_saldo.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                        txtTotalSaldoPrevisto.Text = banco.saldo_previsto.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                        textBox.Visible = true;
                        txtBoxNome.Visible = true;
                        btnEditar.Visible = true;
                        btnAlterar.Visible = true;
                        btnExcluir.Visible = true;
                    }
                    else
                    {
                        // Se não houver botões suficientes na matriz, sai do loop
                        break;
                    }
                    contador++;
                }

                // Esconde o campo de texto do saldo total se não houver bancos consultados
                txtTotalSaldo.Visible = bancosConsultados.Any();
                txtTotalSaldoPrevisto.Visible = bancosConsultados.Any();
                lblSaldoTotal.Visible = bancosConsultados.Any();
                PainelDireito.Visible = bancosConsultados.Any();


                // Define o tamanho padrão da tela Bancos
                int widthPadrao = 944;
                int heightPadrao = 449;

                // Definindo o tamanho alternativo da tela quando usuário não tenha nenhum banco cadastrado
                int widthAlternativo = 425;
                int heightAlternativo = 449;

                if (contador > 0)
                {
                    this.Size = new Size(widthPadrao, heightPadrao);
                    lblLinkSairTelaGrande.Visible = true;
                    lblLinkSairTelaPequena.Visible = false;
                }
                else
                {
                    this.Size = new Size(widthAlternativo, heightAlternativo);
                    lblLinkSairTelaGrande.Visible = false;
                    lblLinkSairTelaPequena.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditarBanco1_Click(object sender, EventArgs e)
        {
            Button btnEditar = (Button)sender;
            if (btnEditar.Text == "Cancelar")
            {
                HabilitarControles(txtBanco1, false, btnEditar);
            }
            else
            {
                HabilitarControles(txtBanco1, true, btnEditar);
            }
        }
        private void btnAlterarBanco1_Click(object sender, EventArgs e)
        {
            AlterarBanco(txtBanco1, txtNomeBanco1, btnEditarBanco1);
        }
        private void btnEditarBanco2_Click(object sender, EventArgs e)
        {
            Button btnEditar = (Button)sender;
            if (btnEditar.Text == "Cancelar")
            {
                HabilitarControles(txtBanco2, false, btnEditar);
            }
            else
            {
                HabilitarControles(txtBanco2, true, btnEditar);
            }
        }
        private void btnAlterarBanco2_Click(object sender, EventArgs e)
        {
            AlterarBanco(txtBanco2, txtNomeBanco2, btnEditarBanco2);
        }
        private void btnEditarBanco3_Click(object sender, EventArgs e)
        {
            Button btnEditar = (Button)sender;
            if (btnEditar.Text == "Cancelar")
            {
                HabilitarControles(txtBanco3, false, btnEditar);
            }
            else
            {
                HabilitarControles(txtBanco3, true, btnEditar);
            }
        }
        private void btnAlterarBanco3_Click(object sender, EventArgs e)
        {
            AlterarBanco(txtBanco3, txtNomeBanco3, btnEditarBanco3);
        }
        private void btnEditarBanco4_Click(object sender, EventArgs e)
        {
            Button btnEditar = (Button)sender;
            if (btnEditar.Text == "Cancelar")
            {
                HabilitarControles(txtBanco4, false, btnEditar);
            }
            else
            {
                HabilitarControles(txtBanco4, true, btnEditar);
            }
        }
        private void btnAlterarBanco4_Click(object sender, EventArgs e)
        {
            AlterarBanco(txtBanco4, txtNomeBanco4, btnEditarBanco4);
        }
        
        // Método para habilitar os controles
        private void HabilitarControles(TextBox txtBanco, bool habilitar, Button btnEditar)
        {
            if (habilitar)
            {
                // Botão está no modo editar
                btnEditar.Text = "Cancelar";
                //editando = true;
                txtBanco.Enabled = true;
                valorOriginalTextBox = txtBanco.Text;
            }
            else
            {
                // Botão está modo cancelar
                btnEditar.Text = textoOriginalBotaoEditar;
                //editando = false;
                txtBanco.Enabled = false;
                txtBanco.Text = valorOriginalTextBox;
            }
        }
        
        // Método para tratar e alterar os campos
        private void AlterarBanco(TextBox txtBanco, TextBox txtNomeBanco, Button btnEditar)
        {
            try
            {
                if (txtBanco.Enabled == false)
                {
                    MessageBox.Show("Para alterar você precisa informar um novo valor, clique em editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    decimal novoSaldo;

                    // Tenta converter o texto do campo para um valor decimal
                    if (!decimal.TryParse(txtBanco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out novoSaldo))
                    {
                        MessageBox.Show("Por favor, digite um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // sai do método sem tentar alterar o saldo do banco
                    }

                    // Se chegou até aqui, o novo saldo é válido e pode prosseguir para a alteração
                    bancos_DTO BAN = new bancos_DTO
                    {
                        cod_usuario = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID,
                        nome_banco = txtNomeBanco.Text,
                        saldo = novoSaldo // Atribui o valor do novo saldo, sem formatação
                    };

                    int x = new GerenciadorBLL().alteraBanco(BAN);

                    if (x > 0)
                    {
                        MessageBox.Show("Alterado com sucesso", "Sucesso", MessageBoxButtons.OK);
                        HabilitarControles(txtBanco, false, btnEditar); // Desabilita o campo após a alteração bem-sucedida
                        CarregaDadosBancoDeDados(); //Atualiza os campos Textbox com o novo valor
                    }
                }
                else
                {
                    btnEditar.Text = textoOriginalBotaoEditar;
                    txtBanco.Enabled = false;
                    txtBanco.Text = valorOriginalTextBox;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }
        
        // Método para excluir banco
        private void ExcluirBanco(TextBox txtNomeBanco)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    // Se chegou até aqui, o novo saldo é válido e pode prosseguir para a alteração
                    bancos_DTO BAN = new bancos_DTO
                    {
                        cod_usuario = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID,
                        nome_banco = txtNomeBanco.Text
                    };

                    int x = new GerenciadorBLL().excluiBanco(BAN);

                    if (x > 0)
                    {
                        MessageBox.Show("Excluído com sucesso", "Sucesso", MessageBoxButtons.OK);
                        CarregaDadosBancoDeDados(); 
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado" + ex.Message);
            }
        }
        private void btnExcluirBanco1_Click(object sender, EventArgs e)
        {
            ExcluirBanco(txtNomeBanco1);
        }
        private void btnExcluirBanco2_Click(object sender, EventArgs e)
        {
            ExcluirBanco(txtNomeBanco2);
        }
        private void btnExcluirBanco3_Click(object sender, EventArgs e)
        {
            ExcluirBanco(txtNomeBanco3);
        }
        private void btnExcluirBanco4_Click(object sender, EventArgs e)
        {
            ExcluirBanco(txtNomeBanco4);
        }
        private void lblLinkSairTelaGrande_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        private void lblLinkSairTelaPequena_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        private void txtSaldoBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação do campo valor, aceita somente numeros e virgula
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo só aceita número e virgula", "Error Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldoBanco.Focus();
                return;
            }
            if ((e.KeyChar == ',') &&
                ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente virgula", "Error Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldoBanco.Focus();
                return;
            }
        }
        private void MostrarOcultarSaldo()
        {
            // Lista dos TextBox com os valores a exibir ou ocultar
            TextBox[] textBoxes = { txtBanco1, txtBanco2, txtBanco3, txtBanco4, txtTotalSaldo, txtTotalSaldoPrevisto };

            // Verifica se o saldo está oculto
            if (saldoOculto)
            {
                // Exibe os valores do TextBox
                foreach (TextBox textBox in textBoxes)
                {
                    bool wasDisabled = !textBox.Enabled;
                    
                    if (wasDisabled)
                    {
                        textBox.Enabled = true; // habilita o TextBox temporariamente
                    }

                    textBox.UseSystemPasswordChar = false; // Exibe o valor

                    if (wasDisabled)
                    {
                        textBox.Enabled = false; // Desabilita novamente se estava inabilitado
                    }
                }
                saldoOculto = false;
                btnMostrarSaldo.Text = "Ocultar";
            }
            else
            {
                // Oculta os valores dos TextBox
                foreach (TextBox textBox in textBoxes)
                {
                    bool wasDisabled = !textBox.Enabled;
                    if (wasDisabled)
                    {
                        textBox.Enabled = true;
                    }

                    textBox.UseSystemPasswordChar = true; // Oculta o valor

                    if (wasDisabled)
                    {
                        textBox.Enabled = false;
                    }
                }
                saldoOculto = true;
                btnMostrarSaldo.Text = "Exibir";
            }
        }
        private void btnMostrarSaldo_Click(object sender, EventArgs e)
        {
            MostrarOcultarSaldo();
        }
    }
}