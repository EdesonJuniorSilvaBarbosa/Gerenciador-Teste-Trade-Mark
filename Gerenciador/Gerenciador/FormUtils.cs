using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerenciador
{
    public static class FormUtils
    {
        public static void LimpaCampos(Form form)
        {
            LimpaControles(form.Controls);
        }
        private static void LimpaControles(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Today;
                }
                else if (control.Controls.Count > 0)
                {
                    LimpaControles(control.Controls);
                }
            }
        }
        public static void DesativaCampos(Form form)
        {
            DesativaControls(form.Controls);
        }
        private static void DesativaControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                // Se o controle estiver desativado, pule para o próximo controle
                if (!control.Enabled)
                    continue;

                // Verifica se o controle é o TextBox de pesquisa e pula para o próximo controle se for
                if (control.Name == "txtPesquisa")
                    continue;

                if (control.Name == "dTPDataPesquisa")
                    continue;

                // Destaiva o controle de acordo com o tipo
                switch (control)
                {
                    case TextBox textBox:
                    case ComboBox comboBox:
                    case RadioButton radioButton:
                    case MaskedTextBox maskedTextBox:
                    case DateTimePicker dateTimePicker:
                        control.Enabled = false;
                        break;
                }

                // Se o controle tiver controles filhos desative-os também
                if (control.HasChildren)
                {
                    DesativaControls(control.Controls);
                }
            }
        }
        public static void AtivaCampos(Form form)
        {
            AtivaControls(form.Controls);
        }
        private static void AtivaControls(Control.ControlCollection controls)
        {
            // campos que nunca serão ativados
            List<string> controlesNaoAtivar = new List<string> {"txtCodUsuario", "txtCodConta", "txt_Total_Entrada", "txt_Total_Saida", "txtSaldo", "txtStatus", "txtAnos", "ListContasProximasVencimento", "mkdTxtCpfCadastrado" };

            foreach (Control control in controls)
            {
                if (controlesNaoAtivar.Contains(control.Name))
                {
                    control.Enabled = false;
                    continue;
                }

                // Se o controle tiver controles filhos ative-os também
                if (control.HasChildren)
                {
                    AtivaControls(control.Controls);
                }
                else
                {
                    control.Enabled = true;
                }
            }
        }
    }
}
