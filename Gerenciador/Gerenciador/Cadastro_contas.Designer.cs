namespace Gerenciador
{
    partial class Cadastro_contas
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
            this.lblCadastroContas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.dTPData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblLinkSair = new System.Windows.Forms.LinkLabel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCadastroContas
            // 
            this.lblCadastroContas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCadastroContas.AutoSize = true;
            this.lblCadastroContas.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroContas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.lblCadastroContas.Location = new System.Drawing.Point(8, 14);
            this.lblCadastroContas.Margin = new System.Windows.Forms.Padding(10, 12, 5, 5);
            this.lblCadastroContas.Name = "lblCadastroContas";
            this.lblCadastroContas.Size = new System.Drawing.Size(160, 24);
            this.lblCadastroContas.TabIndex = 0;
            this.lblCadastroContas.Text = "Registrar contas";
            this.lblCadastroContas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(238, 121);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(225, 11, 5, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 20);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(8, 121);
            this.lblData.Margin = new System.Windows.Forms.Padding(25, 14, 3, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 20);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(8, 180);
            this.lblValor.Margin = new System.Windows.Forms.Padding(5, 14, 3, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(56, 20);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // dTPData
            // 
            this.dTPData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dTPData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPData.Location = new System.Drawing.Point(67, 121);
            this.dTPData.Margin = new System.Windows.Forms.Padding(3, 11, 5, 3);
            this.dTPData.Name = "dTPData";
            this.dTPData.Size = new System.Drawing.Size(110, 24);
            this.dTPData.TabIndex = 1;
            this.dTPData.Value = new System.DateTime(2021, 4, 4, 0, 0, 0, 0);
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Snow;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(67, 178);
            this.txtValor.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(96, 24);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(12, 226);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(20, 7, 4, 4);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(173, 40);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar dados";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(171, 180);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 14, 3, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(94, 20);
            this.lblDescricao.TabIndex = 18;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Snow;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(271, 178);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(145, 24);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(243, 226);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(173, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblLinkSair
            // 
            this.lblLinkSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinkSair.AutoSize = true;
            this.lblLinkSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkSair.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkSair.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.lblLinkSair.Location = new System.Drawing.Point(368, 18);
            this.lblLinkSair.Margin = new System.Windows.Forms.Padding(15, 5, 3, 0);
            this.lblLinkSair.Name = "lblLinkSair";
            this.lblLinkSair.Size = new System.Drawing.Size(48, 18);
            this.lblLinkSair.TabIndex = 7;
            this.lblLinkSair.TabStop = true;
            this.lblLinkSair.Text = "SAIR";
            this.lblLinkSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLinkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSair_LinkClicked);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(9, 69);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(154, 18);
            this.lblMensagem.TabIndex = 23;
            this.lblMensagem.Text = "Mensagem de retorno";
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboTipo.BackColor = System.Drawing.Color.Snow;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cboTipo.Location = new System.Drawing.Point(294, 119);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 11, 0, 3);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(122, 26);
            this.cboTipo.Sorted = true;
            this.cboTipo.TabIndex = 2;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            this.cboTipo.Leave += new System.EventHandler(this.cboTipo_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.lblLinkSair);
            this.panel1.Controls.Add(this.lblValor);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblCadastroContas);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.dTPData);
            this.panel1.Controls.Add(this.lblMensagem);
            this.panel1.Controls.Add(this.cboTipo);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 288);
            this.panel1.TabIndex = 24;
            // 
            // Cadastro_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(449, 316);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(227)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro_contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cadastro_contas_Load);
            this.Resize += new System.EventHandler(this.Cadastro_contas_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroContas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DateTimePicker dTPData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.LinkLabel lblLinkSair;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
    }
}