
namespace Gerenciador
{
    partial class Altera_login
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
            this.PainelLoginAltera = new System.Windows.Forms.Panel();
            this.cklRequisitosNecessarios = new System.Windows.Forms.CheckedListBox();
            this.txtLoginAltera = new System.Windows.Forms.TextBox();
            this.txtSenhaAltera = new System.Windows.Forms.TextBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAlteraLogin = new System.Windows.Forms.Button();
            this.lblLinkSair = new System.Windows.Forms.LinkLabel();
            this.lblCadastroContas = new System.Windows.Forms.Label();
            this.PainelLoginAltera.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelLoginAltera
            // 
            this.PainelLoginAltera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelLoginAltera.Controls.Add(this.cklRequisitosNecessarios);
            this.PainelLoginAltera.Controls.Add(this.txtLoginAltera);
            this.PainelLoginAltera.Controls.Add(this.txtSenhaAltera);
            this.PainelLoginAltera.Controls.Add(this.lblInformacao);
            this.PainelLoginAltera.Controls.Add(this.lblSenha);
            this.PainelLoginAltera.Controls.Add(this.lblLogin);
            this.PainelLoginAltera.Controls.Add(this.btnAlteraLogin);
            this.PainelLoginAltera.Location = new System.Drawing.Point(57, 67);
            this.PainelLoginAltera.Name = "PainelLoginAltera";
            this.PainelLoginAltera.Size = new System.Drawing.Size(598, 345);
            this.PainelLoginAltera.TabIndex = 10;
            // 
            // cklRequisitosNecessarios
            // 
            this.cklRequisitosNecessarios.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cklRequisitosNecessarios.ForeColor = System.Drawing.Color.Red;
            this.cklRequisitosNecessarios.FormattingEnabled = true;
            this.cklRequisitosNecessarios.Location = new System.Drawing.Point(53, 232);
            this.cklRequisitosNecessarios.Name = "cklRequisitosNecessarios";
            this.cklRequisitosNecessarios.Size = new System.Drawing.Size(188, 72);
            this.cklRequisitosNecessarios.TabIndex = 18;
            // 
            // txtLoginAltera
            // 
            this.txtLoginAltera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginAltera.Location = new System.Drawing.Point(51, 109);
            this.txtLoginAltera.Name = "txtLoginAltera";
            this.txtLoginAltera.Size = new System.Drawing.Size(472, 31);
            this.txtLoginAltera.TabIndex = 3;
            this.txtLoginAltera.Leave += new System.EventHandler(this.txtLoginAltera_Leave);
            // 
            // txtSenhaAltera
            // 
            this.txtSenhaAltera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAltera.Location = new System.Drawing.Point(51, 181);
            this.txtSenhaAltera.Name = "txtSenhaAltera";
            this.txtSenhaAltera.Size = new System.Drawing.Size(472, 31);
            this.txtSenhaAltera.TabIndex = 4;
            this.txtSenhaAltera.UseSystemPasswordChar = true;
            this.txtSenhaAltera.TextChanged += new System.EventHandler(this.txtSenhaAltera_TextChanged);
            this.txtSenhaAltera.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenhaAltera_KeyDown);
            this.txtSenhaAltera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenhaAltera_KeyPress);
            // 
            // lblInformacao
            // 
            this.lblInformacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.ForeColor = System.Drawing.Color.Black;
            this.lblInformacao.Location = new System.Drawing.Point(50, 25);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(154, 18);
            this.lblInformacao.TabIndex = 0;
            this.lblInformacao.Text = "Mensagem de retorno";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(47, 149);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(157, 29);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Nova senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(47, 78);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(237, 29);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Informe seu e-mail:";
            // 
            // btnAlteraLogin
            // 
            this.btnAlteraLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlteraLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlteraLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlteraLogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAlteraLogin.FlatAppearance.BorderSize = 2;
            this.btnAlteraLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAlteraLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlteraLogin.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraLogin.ForeColor = System.Drawing.Color.Black;
            this.btnAlteraLogin.Location = new System.Drawing.Point(361, 271);
            this.btnAlteraLogin.Name = "btnAlteraLogin";
            this.btnAlteraLogin.Size = new System.Drawing.Size(162, 33);
            this.btnAlteraLogin.TabIndex = 5;
            this.btnAlteraLogin.Text = "Alterar";
            this.btnAlteraLogin.UseVisualStyleBackColor = false;
            this.btnAlteraLogin.Click += new System.EventHandler(this.btnAlteraLogin_Click_1);
            // 
            // lblLinkSair
            // 
            this.lblLinkSair.AutoSize = true;
            this.lblLinkSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkSair.LinkColor = System.Drawing.Color.Blue;
            this.lblLinkSair.Location = new System.Drawing.Point(535, 33);
            this.lblLinkSair.Name = "lblLinkSair";
            this.lblLinkSair.Size = new System.Drawing.Size(45, 17);
            this.lblLinkSair.TabIndex = 28;
            this.lblLinkSair.TabStop = true;
            this.lblLinkSair.Text = "SAIR";
            this.lblLinkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSair_LinkClicked);
            // 
            // lblCadastroContas
            // 
            this.lblCadastroContas.AutoSize = true;
            this.lblCadastroContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroContas.Location = new System.Drawing.Point(105, 27);
            this.lblCadastroContas.Name = "lblCadastroContas";
            this.lblCadastroContas.Size = new System.Drawing.Size(316, 25);
            this.lblCadastroContas.TabIndex = 29;
            this.lblCadastroContas.Text = "ALTERAR DADOS DE LOGIN";
            // 
            // Altera_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 426);
            this.Controls.Add(this.lblCadastroContas);
            this.Controls.Add(this.lblLinkSair);
            this.Controls.Add(this.PainelLoginAltera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Altera_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de alteração";
            this.PainelLoginAltera.ResumeLayout(false);
            this.PainelLoginAltera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelLoginAltera;
        private System.Windows.Forms.TextBox txtLoginAltera;
        private System.Windows.Forms.TextBox txtSenhaAltera;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAlteraLogin;
        private System.Windows.Forms.CheckedListBox cklRequisitosNecessarios;
        private System.Windows.Forms.LinkLabel lblLinkSair;
        private System.Windows.Forms.Label lblCadastroContas;
    }
}