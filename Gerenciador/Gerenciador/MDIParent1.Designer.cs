namespace Gerenciador
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegistrarContas = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGerenciarContasCadastradas = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGerenciarCadastroUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Relatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmResumosHistoricos = new System.Windows.Forms.ToolStripMenuItem();
            this.financas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGerenciarBancos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLinkSairSistema = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastrar,
            this.Consultar,
            this.Relatorios,
            this.financas});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(200, 344);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Cadastrar
            // 
            this.Cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegistrarContas});
            this.Cadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.Cadastrar.Image = global::Gerenciador.Properties.Resources.conta;
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(-6, 120, 0, 0);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(199, 25);
            this.Cadastrar.Text = "Cadastrar";
            // 
            // tsmRegistrarContas
            // 
            this.tsmRegistrarContas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.tsmRegistrarContas.ForeColor = System.Drawing.Color.Black;
            this.tsmRegistrarContas.Image = global::Gerenciador.Properties.Resources.Cadastros;
            this.tsmRegistrarContas.Name = "tsmRegistrarContas";
            this.tsmRegistrarContas.Size = new System.Drawing.Size(202, 26);
            this.tsmRegistrarContas.Text = "Registrar contas";
            this.tsmRegistrarContas.Click += new System.EventHandler(this.tsmRegistrarContas_Click);
            // 
            // Consultar
            // 
            this.Consultar.CheckOnClick = true;
            this.Consultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGerenciarContasCadastradas,
            this.editarToolStripMenuItem});
            this.Consultar.ForeColor = System.Drawing.Color.Black;
            this.Consultar.Image = global::Gerenciador.Properties.Resources.pesquisa_de_dados;
            this.Consultar.Margin = new System.Windows.Forms.Padding(-4, 20, 0, 0);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(197, 25);
            this.Consultar.Text = "Consultar";
            // 
            // tsmGerenciarContasCadastradas
            // 
            this.tsmGerenciarContasCadastradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.tsmGerenciarContasCadastradas.ForeColor = System.Drawing.Color.Black;
            this.tsmGerenciarContasCadastradas.Image = global::Gerenciador.Properties.Resources.buscar;
            this.tsmGerenciarContasCadastradas.Name = "tsmGerenciarContasCadastradas";
            this.tsmGerenciarContasCadastradas.Size = new System.Drawing.Size(207, 26);
            this.tsmGerenciarContasCadastradas.Text = "Gerenciar contas";
            this.tsmGerenciarContasCadastradas.Click += new System.EventHandler(this.tsmGerenciarContasCadastradas_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGerenciarCadastroUsuarios});
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // tsmGerenciarCadastroUsuarios
            // 
            this.tsmGerenciarCadastroUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.tsmGerenciarCadastroUsuarios.ForeColor = System.Drawing.Color.Black;
            this.tsmGerenciarCadastroUsuarios.Image = global::Gerenciador.Properties.Resources.user;
            this.tsmGerenciarCadastroUsuarios.Name = "tsmGerenciarCadastroUsuarios";
            this.tsmGerenciarCadastroUsuarios.Size = new System.Drawing.Size(196, 26);
            this.tsmGerenciarCadastroUsuarios.Text = "Dados pessoais";
            this.tsmGerenciarCadastroUsuarios.Click += new System.EventHandler(this.tsmGerenciarCadastroUsuarios_Click);
            // 
            // Relatorios
            // 
            this.Relatorios.CheckOnClick = true;
            this.Relatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmResumosHistoricos});
            this.Relatorios.ForeColor = System.Drawing.Color.Black;
            this.Relatorios.Image = global::Gerenciador.Properties.Resources.relatorio;
            this.Relatorios.Margin = new System.Windows.Forms.Padding(-1, 20, 0, 0);
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(194, 25);
            this.Relatorios.Text = "Dashboards";
            // 
            // tsmResumosHistoricos
            // 
            this.tsmResumosHistoricos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.tsmResumosHistoricos.ForeColor = System.Drawing.Color.Black;
            this.tsmResumosHistoricos.Image = global::Gerenciador.Properties.Resources.Demonstrativos;
            this.tsmResumosHistoricos.Name = "tsmResumosHistoricos";
            this.tsmResumosHistoricos.Size = new System.Drawing.Size(241, 26);
            this.tsmResumosHistoricos.Text = "Resumos e Históricos";
            this.tsmResumosHistoricos.Click += new System.EventHandler(this.tsmResumosHistoricos_Click);
            // 
            // financas
            // 
            this.financas.CheckOnClick = true;
            this.financas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGerenciarBancos});
            this.financas.ForeColor = System.Drawing.Color.Black;
            this.financas.Image = global::Gerenciador.Properties.Resources.banco;
            this.financas.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.financas.Margin = new System.Windows.Forms.Padding(-6, 20, 0, 0);
            this.financas.Name = "financas";
            this.financas.Size = new System.Drawing.Size(199, 25);
            this.financas.Text = "Financas";
            // 
            // tsmGerenciarBancos
            // 
            this.tsmGerenciarBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.tsmGerenciarBancos.ForeColor = System.Drawing.Color.Black;
            this.tsmGerenciarBancos.Image = global::Gerenciador.Properties.Resources.money;
            this.tsmGerenciarBancos.Name = "tsmGerenciarBancos";
            this.tsmGerenciarBancos.Size = new System.Drawing.Size(211, 26);
            this.tsmGerenciarBancos.Text = "Gerenciar bancos";
            this.tsmGerenciarBancos.Click += new System.EventHandler(this.tsmGerenciarBancos_Click);
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.White;
            this.lblBoasVindas.Location = new System.Drawing.Point(3, 10);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(66, 13);
            this.lblBoasVindas.TabIndex = 6;
            this.lblBoasVindas.Text = "Boas Vindas";
            this.lblBoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblBoasVindas);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 82);
            this.panel1.TabIndex = 8;
            // 
            // lblLinkSairSistema
            // 
            this.lblLinkSairSistema.ActiveLinkColor = System.Drawing.Color.White;
            this.lblLinkSairSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.lblLinkSairSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLinkSairSistema.DisabledLinkColor = System.Drawing.Color.DarkOrange;
            this.lblLinkSairSistema.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkSairSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLinkSairSistema.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLinkSairSistema.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
            this.lblLinkSairSistema.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkSairSistema.LinkColor = System.Drawing.Color.White;
            this.lblLinkSairSistema.Location = new System.Drawing.Point(24, 302);
            this.lblLinkSairSistema.Name = "lblLinkSairSistema";
            this.lblLinkSairSistema.Size = new System.Drawing.Size(108, 42);
            this.lblLinkSairSistema.TabIndex = 29;
            this.lblLinkSairSistema.TabStop = true;
            this.lblLinkSairSistema.Text = "SAIR";
            this.lblLinkSairSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLinkSairSistema.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSairSistema_LinkClicked);
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
            this.button1.Location = new System.Drawing.Point(832, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnMinimized.Location = new System.Drawing.Point(829, 15);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(20, 20);
            this.btnMinimized.TabIndex = 32;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
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
            this.btnMaximized.Location = new System.Drawing.Point(855, 12);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(22, 22);
            this.btnMaximized.TabIndex = 33;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 344);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaximized);
            this.Controls.Add(this.lblLinkSairSistema);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "Financial Manager";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Cadastrar;
        private System.Windows.Forms.ToolStripMenuItem Consultar;
        private System.Windows.Forms.ToolStripMenuItem Relatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmRegistrarContas;
        private System.Windows.Forms.ToolStripMenuItem tsmGerenciarContasCadastradas;
        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.ToolStripMenuItem tsmResumosHistoricos;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmGerenciarCadastroUsuarios;
        private System.Windows.Forms.ToolStripMenuItem financas;
        private System.Windows.Forms.ToolStripMenuItem tsmGerenciarBancos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblLinkSairSistema;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnMaximized;
    }
}



