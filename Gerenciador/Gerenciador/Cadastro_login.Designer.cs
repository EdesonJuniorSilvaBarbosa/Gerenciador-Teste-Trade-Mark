namespace Gerenciador
{
    partial class Cadastro_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_login));
            this.lblSejaBemVindo = new System.Windows.Forms.Label();
            this.lblFechar = new System.Windows.Forms.Label();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblCadastre = new System.Windows.Forms.LinkLabel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.PainelLogin = new System.Windows.Forms.Panel();
            this.btnMostrarSenha = new System.Windows.Forms.Button();
            this.gpbLoginLegend = new System.Windows.Forms.GroupBox();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.PainelLogin.SuspendLayout();
            this.gpbLoginLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSejaBemVindo
            // 
            this.lblSejaBemVindo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSejaBemVindo.AutoSize = true;
            this.lblSejaBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblSejaBemVindo.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSejaBemVindo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSejaBemVindo.Location = new System.Drawing.Point(34, 30);
            this.lblSejaBemVindo.Name = "lblSejaBemVindo";
            this.lblSejaBemVindo.Size = new System.Drawing.Size(319, 34);
            this.lblSejaBemVindo.TabIndex = 8;
            this.lblSejaBemVindo.Text = "Seja bem-vindo (a) !!!";
            // 
            // lblFechar
            // 
            this.lblFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.ForeColor = System.Drawing.Color.White;
            this.lblFechar.Location = new System.Drawing.Point(601, 30);
            this.lblFechar.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(43, 39);
            this.lblFechar.TabIndex = 8;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.ForeColor = System.Drawing.Color.White;
            this.lblInformacao.Location = new System.Drawing.Point(20, 12);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(154, 18);
            this.lblInformacao.TabIndex = 0;
            this.lblInformacao.Text = "Mensagem de retorno";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(16, 49);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(123, 37);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(16, 122);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(124, 37);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEsqueceuSenha.LinkColor = System.Drawing.Color.White;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(20, 213);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(138, 18);
            this.lblEsqueceuSenha.TabIndex = 7;
            this.lblEsqueceuSenha.TabStop = true;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lblEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueceuSenha_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(396, 198);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(162, 33);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Conectar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblCadastre
            // 
            this.lblCadastre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastre.AutoSize = true;
            this.lblCadastre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCadastre.LinkColor = System.Drawing.Color.White;
            this.lblCadastre.Location = new System.Drawing.Point(203, 213);
            this.lblCadastre.Name = "lblCadastre";
            this.lblCadastre.Size = new System.Drawing.Size(165, 18);
            this.lblCadastre.TabIndex = 6;
            this.lblCadastre.TabStop = true;
            this.lblCadastre.Text = "Faça seu cadastro aqui!";
            this.lblCadastre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCadastre_LinkClicked);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(157, 128);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(401, 31);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(157, 55);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(401, 31);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Text = "digite seu e-mail";
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // PainelLogin
            // 
            this.PainelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PainelLogin.BackColor = System.Drawing.Color.Black;
            this.PainelLogin.Controls.Add(this.btnMostrarSenha);
            this.PainelLogin.Controls.Add(this.txtLogin);
            this.PainelLogin.Controls.Add(this.txtSenha);
            this.PainelLogin.Controls.Add(this.lblCadastre);
            this.PainelLogin.Controls.Add(this.lblInformacao);
            this.PainelLogin.Controls.Add(this.lblSenha);
            this.PainelLogin.Controls.Add(this.lblLogin);
            this.PainelLogin.Controls.Add(this.btnEntrar);
            this.PainelLogin.Controls.Add(this.lblEsqueceuSenha);
            this.PainelLogin.Location = new System.Drawing.Point(8, 57);
            this.PainelLogin.Margin = new System.Windows.Forms.Padding(5);
            this.PainelLogin.Name = "PainelLogin";
            this.PainelLogin.Size = new System.Drawing.Size(584, 271);
            this.PainelLogin.TabIndex = 9;
            // 
            // btnMostrarSenha
            // 
            this.btnMostrarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarSenha.Location = new System.Drawing.Point(493, 128);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(64, 31);
            this.btnMostrarSenha.TabIndex = 10;
            this.btnMostrarSenha.UseVisualStyleBackColor = false;
            this.btnMostrarSenha.Click += new System.EventHandler(this.btnMostrarSenha_Click);
            // 
            // gpbLoginLegend
            // 
            this.gpbLoginLegend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbLoginLegend.BackColor = System.Drawing.SystemColors.InfoText;
            this.gpbLoginLegend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gpbLoginLegend.Controls.Add(this.PainelLogin);
            this.gpbLoginLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbLoginLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbLoginLegend.ForeColor = System.Drawing.Color.White;
            this.gpbLoginLegend.Location = new System.Drawing.Point(44, 127);
            this.gpbLoginLegend.Name = "gpbLoginLegend";
            this.gpbLoginLegend.Size = new System.Drawing.Size(600, 336);
            this.gpbLoginLegend.TabIndex = 10;
            this.gpbLoginLegend.TabStop = false;
            this.gpbLoginLegend.Text = "Faça seu login aqui.";
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimized.FlatAppearance.BorderSize = 2;
            this.btnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Location = new System.Drawing.Point(537, 40);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(20, 20);
            this.btnMinimized.TabIndex = 35;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(540, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximized.FlatAppearance.BorderSize = 2;
            this.btnMaximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Location = new System.Drawing.Point(563, 37);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(22, 22);
            this.btnMaximized.TabIndex = 36;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // Cadastro_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(676, 566);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaximized);
            this.Controls.Add(this.gpbLoginLegend);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.lblSejaBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE LOGIN";
            this.Load += new System.EventHandler(this.Cadastro_login_Load);
            this.PainelLogin.ResumeLayout(false);
            this.PainelLogin.PerformLayout();
            this.gpbLoginLegend.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSejaBemVindo;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.LinkLabel lblEsqueceuSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lblCadastre;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel PainelLogin;
        private System.Windows.Forms.Button btnMostrarSenha;
        private System.Windows.Forms.GroupBox gpbLoginLegend;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaximized;
    }
}