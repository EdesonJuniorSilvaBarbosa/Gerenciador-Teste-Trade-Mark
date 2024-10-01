namespace Gerenciador
{
    partial class Cadastro_usuarios
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dTPNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.gpb01 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInformacao = new System.Windows.Forms.LinkLabel();
            this.mkdTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.lstRequisitosNecessarios = new System.Windows.Forms.ListBox();
            this.lblCorSenha = new System.Windows.Forms.Label();
            this.btnMostrarSenha = new System.Windows.Forms.Button();
            this.gpb01.SuspendLayout();
            this.gpbCadastro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(5, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCpf.Location = new System.Drawing.Point(5, 108);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(48, 20);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF:";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataNasc.Location = new System.Drawing.Point(8, 19);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(152, 20);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data Nascimento:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSexo.Location = new System.Drawing.Point(8, 57);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 20);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsuario.Location = new System.Drawing.Point(5, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenha.Location = new System.Drawing.Point(5, 76);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 20);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(71, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(386, 24);
            this.txtNome.TabIndex = 1;
            // 
            // dTPNascimento
            // 
            this.dTPNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPNascimento.Location = new System.Drawing.Point(166, 15);
            this.dTPNascimento.Name = "dTPNascimento";
            this.dTPNascimento.Size = new System.Drawing.Size(122, 24);
            this.dTPNascimento.TabIndex = 4;
            this.dTPNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.dTPNascimento_Validating);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCadastroUsuario.Location = new System.Drawing.Point(6, 12);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(114, 37);
            this.btnCadastroUsuario.TabIndex = 9;
            this.btnCadastroUsuario.Text = "Salvar";
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            // 
            // gpb01
            // 
            this.gpb01.Controls.Add(this.btnCadastroUsuario);
            this.gpb01.Controls.Add(this.btnSair);
            this.gpb01.Location = new System.Drawing.Point(331, 13);
            this.gpb01.Name = "gpb01";
            this.gpb01.Size = new System.Drawing.Size(126, 94);
            this.gpb01.TabIndex = 14;
            this.gpb01.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.AutoEllipsis = true;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSair.Location = new System.Drawing.Point(6, 52);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 37);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Retornar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(88, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(215, 24);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(88, 76);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(215, 24);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.panel2);
            this.gpbCadastro.Controls.Add(this.panel1);
            this.gpbCadastro.Controls.Add(this.gpbLogin);
            this.gpbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastro.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gpbCadastro.Location = new System.Drawing.Point(75, 52);
            this.gpbCadastro.Margin = new System.Windows.Forms.Padding(428, 3, 3, 3);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(550, 425);
            this.gpbCadastro.TabIndex = 10;
            this.gpbCadastro.TabStop = false;
            this.gpbCadastro.Text = "Faça seu cadastro";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNome);
            this.panel2.Controls.Add(this.lblInformacao);
            this.panel2.Controls.Add(this.lblCpf);
            this.panel2.Controls.Add(this.mkdTxtCpf);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.lblSobrenome);
            this.panel2.Controls.Add(this.txtSobrenome);
            this.panel2.Location = new System.Drawing.Point(45, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 140);
            this.panel2.TabIndex = 11;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblInformacao.Location = new System.Drawing.Point(56, 88);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(85, 16);
            this.lblInformacao.TabIndex = 20;
            this.lblInformacao.TabStop = true;
            this.lblInformacao.Text = "Informacao";
            // 
            // mkdTxtCpf
            // 
            this.mkdTxtCpf.Location = new System.Drawing.Point(59, 107);
            this.mkdTxtCpf.Name = "mkdTxtCpf";
            this.mkdTxtCpf.Size = new System.Drawing.Size(398, 24);
            this.mkdTxtCpf.TabIndex = 3;
            this.mkdTxtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.mkdTxtCpf_Validating);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSobrenome.Location = new System.Drawing.Point(5, 62);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(106, 20);
            this.lblSobrenome.TabIndex = 15;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(117, 62);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(340, 24);
            this.txtSobrenome.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDataNasc);
            this.panel1.Controls.Add(this.rdbMasculino);
            this.panel1.Controls.Add(this.rdbFeminino);
            this.panel1.Controls.Add(this.dTPNascimento);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Location = new System.Drawing.Point(45, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 100);
            this.panel1.TabIndex = 11;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbMasculino.Location = new System.Drawing.Point(77, 55);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(103, 22);
            this.rdbMasculino.TabIndex = 5;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbFeminino.Location = new System.Drawing.Point(184, 56);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(95, 22);
            this.rdbFeminino.TabIndex = 6;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.lstRequisitosNecessarios);
            this.gpbLogin.Controls.Add(this.lblCorSenha);
            this.gpbLogin.Controls.Add(this.btnMostrarSenha);
            this.gpbLogin.Controls.Add(this.txtSenha);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.gpb01);
            this.gpbLogin.Controls.Add(this.txtUsuario);
            this.gpbLogin.Controls.Add(this.lblUsuario);
            this.gpbLogin.Location = new System.Drawing.Point(45, 287);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(460, 125);
            this.gpbLogin.TabIndex = 7;
            this.gpbLogin.TabStop = false;
            this.gpbLogin.Text = "Área de Login";
            // 
            // lstRequisitosNecessarios
            // 
            this.lstRequisitosNecessarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRequisitosNecessarios.Enabled = false;
            this.lstRequisitosNecessarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRequisitosNecessarios.ForeColor = System.Drawing.Color.Red;
            this.lstRequisitosNecessarios.FormattingEnabled = true;
            this.lstRequisitosNecessarios.ItemHeight = 16;
            this.lstRequisitosNecessarios.Location = new System.Drawing.Point(88, 55);
            this.lstRequisitosNecessarios.Name = "lstRequisitosNecessarios";
            this.lstRequisitosNecessarios.Size = new System.Drawing.Size(215, 16);
            this.lstRequisitosNecessarios.TabIndex = 11;
            // 
            // lblCorSenha
            // 
            this.lblCorSenha.AutoSize = true;
            this.lblCorSenha.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorSenha.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblCorSenha.Location = new System.Drawing.Point(86, 102);
            this.lblCorSenha.Name = "lblCorSenha";
            this.lblCorSenha.Size = new System.Drawing.Size(69, 20);
            this.lblCorSenha.TabIndex = 16;
            this.lblCorSenha.Text = "cor senha";
            // 
            // btnMostrarSenha
            // 
            this.btnMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarSenha.Location = new System.Drawing.Point(240, 76);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(64, 24);
            this.btnMostrarSenha.TabIndex = 9;
            this.btnMostrarSenha.UseVisualStyleBackColor = false;
            this.btnMostrarSenha.Click += new System.EventHandler(this.btnMostrarSenha_Click);
            // 
            // Cadastro_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 530);
            this.Controls.Add(this.gpbCadastro);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE USUARIOS";
            this.Load += new System.EventHandler(this.Cadastro_usuarios_Load);
            this.gpb01.ResumeLayout(false);
            this.gpbCadastro.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dTPNascimento;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.GroupBox gpb01;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbCadastro;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.LinkLabel lblInformacao;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.MaskedTextBox mkdTxtCpf;
        private System.Windows.Forms.Label lblCorSenha;
        private System.Windows.Forms.Button btnMostrarSenha;
        private System.Windows.Forms.ListBox lstRequisitosNecessarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}