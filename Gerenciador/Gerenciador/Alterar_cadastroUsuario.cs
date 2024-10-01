using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Gerenciador.DTO;
using Gerenciador.BLL;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Diagnostics;

namespace Gerenciador
{
    public partial class Alterar_cadastroUsuario : Form
    {
        public Alterar_cadastroUsuario()
        {
            InitializeComponent();
            lblStatus.Text = "";
            FormUtils.DesativaCampos(this);
        }
        private void PreencherCamposDoFormulario()
        {
            try
            {
                IList<usuario_DTO> usuarioConsultado = new GerenciadorBLL().ConsultarUsuarios();

                foreach (usuario_DTO usuario in usuarioConsultado)
                {
                    txtCodUsuario.Text = usuario.cod_usuario.ToString();
                    txtNome.Text = usuario.nome.ToString();
                    txtSobrenome.Text = usuario.sobrenome.ToString();
                    mkdTxtCpfCadastrado.Text = usuario.cpf.ToString();
                    dTPNascimento.Text = usuario.data_nasc.ToString();
                    txtAnos.Text = usuario.anos.ToString();

                    if (usuario.sexo == 'M')
                    {
                        rdbMasculino.Checked = true;
                    }
                    else if (usuario.sexo == 'F')
                    {
                        rdbFeminino.Checked = true;
                    }

                }
            }
            catch
            {
                MessageBox.Show($"Erro ao consultar os dados ou nenhum valor foi encontrado. tente novamente", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja alterar ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    usuario_DTO USU = new usuario_DTO
                    {
                        cod_usuario = Convert.ToInt32(txtCodUsuario.Text),
                        nome = txtNome.Text,
                        sobrenome = txtSobrenome.Text,
                        cpf = mkdTxtCpfCadastrado.Text,
                        data_nasc = DateTime.ParseExact(dTPNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    };

                    //Debug.WriteLine($"Usuario criado com sucesso: {USU.cod_usuario}, {USU.nome}, {USU.sobrenome}, {USU.cpf}, {USU.data_nasc}, {USU.sexo}");

                    if (rdbMasculino.Checked)
                        {
                            USU.sexo = 'M';
                        }

                        if (rdbFeminino.Checked)
                        {
                            USU.sexo = 'F';
                        }

                    int x = new GerenciadorBLL().alteraUsuario(USU);

                    if (x > 0)
                    {
                        lblStatus.Text = "Alterado com sucesso";
                        lblStatus.ForeColor = Color.Green;
                    }
                    FormUtils.DesativaCampos(this);
                }
                else
                {
                    FormUtils.DesativaCampos(this);
                }

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Erro inesperado" + ex.Message;
            }
        }
        private void Alterar_cadastroUsuario_Load(object sender, EventArgs e)
        {
            // Chamada para preencher os campos do formulário
            PreencherCamposDoFormulario();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormUtils.AtivaCampos(this);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormUtils.DesativaCampos(this);
        }
        private void lblLinkSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
