
namespace Gerenciador
{
    partial class Alterar_cadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtAnos = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblCodUsuario = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.mkdTxtCpfCadastrado = new System.Windows.Forms.MaskedTextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dTPNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblLinkSair = new System.Windows.Forms.LinkLabel();
            this.gpbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Controls.Add(this.lblIdade);
            this.gpbConsulta.Controls.Add(this.txtAnos);
            this.gpbConsulta.Controls.Add(this.lblStatus);
            this.gpbConsulta.Controls.Add(this.btnEditar);
            this.gpbConsulta.Controls.Add(this.lblCodUsuario);
            this.gpbConsulta.Controls.Add(this.txtCodUsuario);
            this.gpbConsulta.Controls.Add(this.btnCancelar);
            this.gpbConsulta.Controls.Add(this.btnAlterarUsuario);
            this.gpbConsulta.Controls.Add(this.mkdTxtCpfCadastrado);
            this.gpbConsulta.Controls.Add(this.txtSobrenome);
            this.gpbConsulta.Controls.Add(this.lblSobrenome);
            this.gpbConsulta.Controls.Add(this.lblNome);
            this.gpbConsulta.Controls.Add(this.txtNome);
            this.gpbConsulta.Controls.Add(this.lblSexo);
            this.gpbConsulta.Controls.Add(this.dTPNascimento);
            this.gpbConsulta.Controls.Add(this.lblDataNasc);
            this.gpbConsulta.Controls.Add(this.lblCpf);
            this.gpbConsulta.Controls.Add(this.rdbFeminino);
            this.gpbConsulta.Controls.Add(this.rdbMasculino);
            this.gpbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsulta.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gpbConsulta.Location = new System.Drawing.Point(122, 25);
            this.gpbConsulta.Margin = new System.Windows.Forms.Padding(428, 3, 3, 3);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(556, 383);
            this.gpbConsulta.TabIndex = 11;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Alterar dados";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdade.Location = new System.Drawing.Point(328, 203);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(60, 20);
            this.lblIdade.TabIndex = 21;
            this.lblIdade.Text = "Idade:";
            // 
            // txtAnos
            // 
            this.txtAnos.Enabled = false;
            this.txtAnos.Location = new System.Drawing.Point(394, 201);
            this.txtAnos.Name = "txtAnos";
            this.txtAnos.Size = new System.Drawing.Size(119, 24);
            this.txtAnos.TabIndex = 20;
            this.txtAnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 18);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "label1";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditar.Location = new System.Drawing.Point(225, 308);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 37);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblCodUsuario
            // 
            this.lblCodUsuario.AutoSize = true;
            this.lblCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodUsuario.Location = new System.Drawing.Point(382, 25);
            this.lblCodUsuario.Name = "lblCodUsuario";
            this.lblCodUsuario.Size = new System.Drawing.Size(70, 20);
            this.lblCodUsuario.TabIndex = 17;
            this.lblCodUsuario.Text = "Código:";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(458, 23);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(55, 24);
            this.txtCodUsuario.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoEllipsis = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancelar.Location = new System.Drawing.Point(367, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAlterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlterarUsuario.Location = new System.Drawing.Point(53, 308);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(168, 37);
            this.btnAlterarUsuario.TabIndex = 9;
            this.btnAlterarUsuario.Text = "Alterar";
            this.btnAlterarUsuario.UseVisualStyleBackColor = true;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // mkdTxtCpfCadastrado
            // 
            this.mkdTxtCpfCadastrado.Enabled = false;
            this.mkdTxtCpfCadastrado.Location = new System.Drawing.Point(103, 156);
            this.mkdTxtCpfCadastrado.Mask = "000.000.000-00";
            this.mkdTxtCpfCadastrado.Name = "mkdTxtCpfCadastrado";
            this.mkdTxtCpfCadastrado.Size = new System.Drawing.Size(410, 24);
            this.mkdTxtCpfCadastrado.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(161, 109);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(352, 24);
            this.txtSobrenome.TabIndex = 2;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSobrenome.Location = new System.Drawing.Point(49, 109);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(106, 20);
            this.lblSobrenome.TabIndex = 15;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(49, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(115, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(398, 24);
            this.txtNome.TabIndex = 1;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSexo.Location = new System.Drawing.Point(49, 251);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 20);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";
            // 
            // dTPNascimento
            // 
            this.dTPNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNascimento.Location = new System.Drawing.Point(207, 201);
            this.dTPNascimento.Name = "dTPNascimento";
            this.dTPNascimento.Size = new System.Drawing.Size(110, 24);
            this.dTPNascimento.TabIndex = 4;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataNasc.Location = new System.Drawing.Point(49, 205);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data Nascimento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCpf.Location = new System.Drawing.Point(49, 157);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(48, 20);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbFeminino.Location = new System.Drawing.Point(225, 250);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(95, 22);
            this.rdbFeminino.TabIndex = 6;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbMasculino.Location = new System.Drawing.Point(118, 249);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(103, 22);
            this.rdbMasculino.TabIndex = 5;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblLinkSair
            // 
            this.lblLinkSair.AutoSize = true;
            this.lblLinkSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkSair.LinkColor = System.Drawing.Color.Blue;
            this.lblLinkSair.Location = new System.Drawing.Point(723, 25);
            this.lblLinkSair.Name = "lblLinkSair";
            this.lblLinkSair.Size = new System.Drawing.Size(45, 17);
            this.lblLinkSair.TabIndex = 28;
            this.lblLinkSair.TabStop = true;
            this.lblLinkSair.Text = "SAIR";
            this.lblLinkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSair_LinkClicked);
            // 
            // Alterar_cadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLinkSair);
            this.Controls.Add(this.gpbConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alterar_cadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar_cadastroUsuario";
            this.Load += new System.EventHandler(this.Alterar_cadastroUsuario_Load);
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.MaskedTextBox mkdTxtCpfCadastrado;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.DateTimePicker dTPNascimento;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Button btnAlterarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodUsuario;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.LinkLabel lblLinkSair;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAnos;
        private System.Windows.Forms.Label lblIdade;
    }
}