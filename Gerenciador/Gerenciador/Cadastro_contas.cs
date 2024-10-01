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
using System.Globalization;
using System.Threading;
using System.Diagnostics;

namespace Gerenciador
{
    public partial class Cadastro_contas : Form
    {
        public Cadastro_contas()
        {
            InitializeComponent();
        }
        private void Cadastro_contas_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "";

            //Pegando a data atual automatico e colocando no dateTimePicker
            dTPData.Text = Convert.ToString(System.DateTime.Now);
        }
        private void limpa_campos()
        {
            txtValor.Text = "";
            txtDescricao.Text = "";
            dTPData.Text = "";
            cboTipo.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpa_campos();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValor.Text) ||
                    string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                    string.IsNullOrWhiteSpace(dTPData.Text) ||
                    string.IsNullOrWhiteSpace(cboTipo.Text))
                {
                    // Pelo menos um campo está vazio, identifique qual campo e mostre uma mensagem de aviso.
                    string campoVazio = "";

                    if (string.IsNullOrWhiteSpace(txtValor.Text))
                        campoVazio = "Valor";
                    else if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                        campoVazio = "Descrição";
                    else if (string.IsNullOrWhiteSpace(dTPData.Text))
                        campoVazio = "Data";
                    else if (string.IsNullOrWhiteSpace(cboTipo.Text))
                        campoVazio = "Tipo";

                    MessageBox.Show($"O campo '{campoVazio}' está vazio.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    contas_DTO CONT = new contas_DTO
                    {
                        cod_usuario = Gerenciador.DTO.sessao_DTO.UsuarioAutenticadoID,
                        valor = decimal.Parse(txtValor.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR")),
                        descricao = txtDescricao.Text,
                        data_cont = DateTime.ParseExact(dTPData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        tipo = cboTipo.Text
                    };

                    int x = new GerenciadorBLL().insereConta(CONT);

                    if (x > 0)
                    {
                        lblMensagem.Text = "Gravado com sucesso!";
                        lblMensagem.ForeColor = Color.White;
                    }
                    limpa_campos();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro inesperado: " + ex.Message;
            }
        }
        private void lblLinkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação do campo valor, aceita somente numeros e virgula
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
                lblMensagem.Text = "Este campo só aceita número e virgula";
                lblMensagem.ForeColor = Color.Red;
            }
            if ((e.KeyChar == ',') &&
                ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                lblMensagem.Text = "Este campo aceita somente virgula";
                lblMensagem.ForeColor = Color.Red;
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
                lblMensagem.Text = "Algo inesperado aconteceu" + ex.Message;
            }
        }
        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1º feito a validação do campo descrição aceitando somente letras
            if (!(Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;

            /* O sistema muda a cor da fonte de acordo o usuario digitar
              Numero - > fonte vermelha
              Letras -> fonte laranja indicando atenção ao digitar*/
            if ((!(Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar))))
            {
                lblMensagem.Text = "Atenção: você está digitando número! digite apenas letras";
                lblMensagem.ForeColor = Color.Red;
            }
            else
            {
                lblMensagem.ForeColor = Color.Orange;
                lblMensagem.Text = "Digite com atenção este campo só aceita letras";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Cadastro_contas_Resize(object sender, EventArgs e)
        {
        }
        private void cboTipo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTipo.Text))
            {
                // Campo está vazio, não precisa de validação adicional
                return;
            }

            if (cboTipo.Text != "Entrada" && cboTipo.Text != "Saida")
            {
                MessageBox.Show("Esta campo aceita somente os valores da lista.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipo.Focus(); // Foca no TextBox novamente
                cboTipo.SelectAll(); // Seleciona todo o texto para facilitar a correção
            }
        }
    }
}
