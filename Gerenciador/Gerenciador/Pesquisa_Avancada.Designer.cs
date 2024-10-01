
namespace Gerenciador
{
    partial class Pesquisa_Avancada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_Avancada));
            this.dTPDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dTPDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPesqPendentes = new System.Windows.Forms.Button();
            this.lblNomePendenteRecebimento = new System.Windows.Forms.Label();
            this.lblNomePendentePagamento = new System.Windows.Forms.Label();
            this.lblNomePrevistoEntradas = new System.Windows.Forms.Label();
            this.lblValorPendenteRecebimento = new System.Windows.Forms.Label();
            this.lblValorPendentePagamento = new System.Windows.Forms.Label();
            this.lblValorPrevistoTotalEntradas = new System.Windows.Forms.Label();
            this.lblNomeRecebidos = new System.Windows.Forms.Label();
            this.lblValorRecebidos = new System.Windows.Forms.Label();
            this.lblNomePagos = new System.Windows.Forms.Label();
            this.lblValorPagos = new System.Windows.Forms.Label();
            this.lblNomePrevistoSaidas = new System.Windows.Forms.Label();
            this.lblValorPrevistoTotalSaidas = new System.Windows.Forms.Label();
            this.lblNomeSaldoPrevisto = new System.Windows.Forms.Label();
            this.lblValorSaldoPrevisto = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // dTPDataInicial
            // 
            this.dTPDataInicial.AccessibleDescription = "";
            this.dTPDataInicial.CalendarForeColor = System.Drawing.Color.Blue;
            this.dTPDataInicial.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dTPDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDataInicial.Location = new System.Drawing.Point(3, 3);
            this.dTPDataInicial.Name = "dTPDataInicial";
            this.dTPDataInicial.Size = new System.Drawing.Size(99, 23);
            this.dTPDataInicial.TabIndex = 3;
            this.dTPDataInicial.Value = new System.DateTime(2024, 5, 14, 11, 49, 0, 0);
            this.dTPDataInicial.Validating += new System.ComponentModel.CancelEventHandler(this.dTPDataInicial_Validating);
            // 
            // dTPDataFinal
            // 
            this.dTPDataFinal.AccessibleDescription = "";
            this.dTPDataFinal.CalendarForeColor = System.Drawing.Color.Blue;
            this.dTPDataFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dTPDataFinal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dTPDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDataFinal.Location = new System.Drawing.Point(3, 3);
            this.dTPDataFinal.Name = "dTPDataFinal";
            this.dTPDataFinal.Size = new System.Drawing.Size(99, 23);
            this.dTPDataFinal.TabIndex = 4;
            this.dTPDataFinal.Value = new System.DateTime(2024, 5, 14, 11, 49, 0, 0);
            this.dTPDataFinal.Validating += new System.ComponentModel.CancelEventHandler(this.dTPDataFinal_Validating);
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicial.Location = new System.Drawing.Point(3, 0);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(85, 17);
            this.lblDataInicial.TabIndex = 5;
            this.lblDataInicial.Text = "Data Inicio";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(3, 0);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(72, 17);
            this.lblDataFinal.TabIndex = 6;
            this.lblDataFinal.Text = "Data Fim";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(321, 97);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(176, 20);
            this.lblLista.TabIndex = 7;
            this.lblLista.Text = "Contas encontradas:";
            this.lblLista.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 154);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnPesqPendentes
            // 
            this.btnPesqPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqPendentes.ForeColor = System.Drawing.Color.Navy;
            this.btnPesqPendentes.Location = new System.Drawing.Point(29, 79);
            this.btnPesqPendentes.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.btnPesqPendentes.Name = "btnPesqPendentes";
            this.btnPesqPendentes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPesqPendentes.Size = new System.Drawing.Size(109, 35);
            this.btnPesqPendentes.TabIndex = 10;
            this.btnPesqPendentes.Text = "Pesquisar";
            this.btnPesqPendentes.UseVisualStyleBackColor = true;
            this.btnPesqPendentes.Click += new System.EventHandler(this.btnPesqPendentes_Click);
            // 
            // lblNomePendenteRecebimento
            // 
            this.lblNomePendenteRecebimento.AutoSize = true;
            this.lblNomePendenteRecebimento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePendenteRecebimento.Location = new System.Drawing.Point(3, 0);
            this.lblNomePendenteRecebimento.Name = "lblNomePendenteRecebimento";
            this.lblNomePendenteRecebimento.Size = new System.Drawing.Size(113, 17);
            this.lblNomePendenteRecebimento.TabIndex = 13;
            this.lblNomePendenteRecebimento.Text = "Valores a receber:";
            // 
            // lblNomePendentePagamento
            // 
            this.lblNomePendentePagamento.AutoSize = true;
            this.lblNomePendentePagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePendentePagamento.Location = new System.Drawing.Point(143, 0);
            this.lblNomePendentePagamento.Name = "lblNomePendentePagamento";
            this.lblNomePendentePagamento.Size = new System.Drawing.Size(102, 17);
            this.lblNomePendentePagamento.TabIndex = 14;
            this.lblNomePendentePagamento.Text = "Valores a pagar:";
            // 
            // lblNomePrevistoEntradas
            // 
            this.lblNomePrevistoEntradas.AutoSize = true;
            this.lblNomePrevistoEntradas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePrevistoEntradas.Location = new System.Drawing.Point(3, 0);
            this.lblNomePrevistoEntradas.Name = "lblNomePrevistoEntradas";
            this.lblNomePrevistoEntradas.Size = new System.Drawing.Size(165, 17);
            this.lblNomePrevistoEntradas.TabIndex = 15;
            this.lblNomePrevistoEntradas.Text = "Previsto total de Entradas:";
            // 
            // lblValorPendenteRecebimento
            // 
            this.lblValorPendenteRecebimento.AutoSize = true;
            this.lblValorPendenteRecebimento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPendenteRecebimento.ForeColor = System.Drawing.Color.Blue;
            this.lblValorPendenteRecebimento.Location = new System.Drawing.Point(122, 0);
            this.lblValorPendenteRecebimento.Name = "lblValorPendenteRecebimento";
            this.lblValorPendenteRecebimento.Size = new System.Drawing.Size(15, 17);
            this.lblValorPendenteRecebimento.TabIndex = 16;
            this.lblValorPendenteRecebimento.Text = "0";
            // 
            // lblValorPendentePagamento
            // 
            this.lblValorPendentePagamento.AutoSize = true;
            this.lblValorPendentePagamento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPendentePagamento.ForeColor = System.Drawing.Color.Blue;
            this.lblValorPendentePagamento.Location = new System.Drawing.Point(251, 0);
            this.lblValorPendentePagamento.Name = "lblValorPendentePagamento";
            this.lblValorPendentePagamento.Size = new System.Drawing.Size(15, 17);
            this.lblValorPendentePagamento.TabIndex = 17;
            this.lblValorPendentePagamento.Text = "0";
            // 
            // lblValorPrevistoTotalEntradas
            // 
            this.lblValorPrevistoTotalEntradas.AutoSize = true;
            this.lblValorPrevistoTotalEntradas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPrevistoTotalEntradas.ForeColor = System.Drawing.Color.Blue;
            this.lblValorPrevistoTotalEntradas.Location = new System.Drawing.Point(174, 0);
            this.lblValorPrevistoTotalEntradas.Name = "lblValorPrevistoTotalEntradas";
            this.lblValorPrevistoTotalEntradas.Size = new System.Drawing.Size(15, 17);
            this.lblValorPrevistoTotalEntradas.TabIndex = 18;
            this.lblValorPrevistoTotalEntradas.Text = "0";
            // 
            // lblNomeRecebidos
            // 
            this.lblNomeRecebidos.AutoSize = true;
            this.lblNomeRecebidos.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeRecebidos.Location = new System.Drawing.Point(3, 0);
            this.lblNomeRecebidos.Name = "lblNomeRecebidos";
            this.lblNomeRecebidos.Size = new System.Drawing.Size(209, 17);
            this.lblNomeRecebidos.TabIndex = 19;
            this.lblNomeRecebidos.Text = "Valores recebidos em andamento:";
            // 
            // lblValorRecebidos
            // 
            this.lblValorRecebidos.AutoSize = true;
            this.lblValorRecebidos.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRecebidos.ForeColor = System.Drawing.Color.Blue;
            this.lblValorRecebidos.Location = new System.Drawing.Point(218, 0);
            this.lblValorRecebidos.Name = "lblValorRecebidos";
            this.lblValorRecebidos.Size = new System.Drawing.Size(15, 17);
            this.lblValorRecebidos.TabIndex = 20;
            this.lblValorRecebidos.Text = "0";
            // 
            // lblNomePagos
            // 
            this.lblNomePagos.AutoSize = true;
            this.lblNomePagos.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePagos.Location = new System.Drawing.Point(239, 0);
            this.lblNomePagos.Name = "lblNomePagos";
            this.lblNomePagos.Size = new System.Drawing.Size(187, 17);
            this.lblNomePagos.TabIndex = 21;
            this.lblNomePagos.Text = "Valores pagos em andamento:";
            // 
            // lblValorPagos
            // 
            this.lblValorPagos.AutoSize = true;
            this.lblValorPagos.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagos.ForeColor = System.Drawing.Color.Blue;
            this.lblValorPagos.Location = new System.Drawing.Point(432, 0);
            this.lblValorPagos.Name = "lblValorPagos";
            this.lblValorPagos.Size = new System.Drawing.Size(15, 17);
            this.lblValorPagos.TabIndex = 22;
            this.lblValorPagos.Text = "0";
            // 
            // lblNomePrevistoSaidas
            // 
            this.lblNomePrevistoSaidas.AutoSize = true;
            this.lblNomePrevistoSaidas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePrevistoSaidas.Location = new System.Drawing.Point(195, 0);
            this.lblNomePrevistoSaidas.Name = "lblNomePrevistoSaidas";
            this.lblNomePrevistoSaidas.Size = new System.Drawing.Size(150, 17);
            this.lblNomePrevistoSaidas.TabIndex = 23;
            this.lblNomePrevistoSaidas.Text = "Previsto total de Saídas:";
            // 
            // lblValorPrevistoTotalSaidas
            // 
            this.lblValorPrevistoTotalSaidas.AutoSize = true;
            this.lblValorPrevistoTotalSaidas.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPrevistoTotalSaidas.ForeColor = System.Drawing.Color.Blue;
            this.lblValorPrevistoTotalSaidas.Location = new System.Drawing.Point(351, 0);
            this.lblValorPrevistoTotalSaidas.Name = "lblValorPrevistoTotalSaidas";
            this.lblValorPrevistoTotalSaidas.Size = new System.Drawing.Size(15, 17);
            this.lblValorPrevistoTotalSaidas.TabIndex = 24;
            this.lblValorPrevistoTotalSaidas.Text = "0";
            // 
            // lblNomeSaldoPrevisto
            // 
            this.lblNomeSaldoPrevisto.AutoSize = true;
            this.lblNomeSaldoPrevisto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSaldoPrevisto.Location = new System.Drawing.Point(3, 0);
            this.lblNomeSaldoPrevisto.Name = "lblNomeSaldoPrevisto";
            this.lblNomeSaldoPrevisto.Size = new System.Drawing.Size(97, 17);
            this.lblNomeSaldoPrevisto.TabIndex = 25;
            this.lblNomeSaldoPrevisto.Text = "Saldo previsto:";
            // 
            // lblValorSaldoPrevisto
            // 
            this.lblValorSaldoPrevisto.AutoSize = true;
            this.lblValorSaldoPrevisto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaldoPrevisto.ForeColor = System.Drawing.Color.Blue;
            this.lblValorSaldoPrevisto.Location = new System.Drawing.Point(106, 0);
            this.lblValorSaldoPrevisto.Name = "lblValorSaldoPrevisto";
            this.lblValorSaldoPrevisto.Size = new System.Drawing.Size(15, 17);
            this.lblValorSaldoPrevisto.TabIndex = 26;
            this.lblValorSaldoPrevisto.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblNomePendenteRecebimento);
            this.flowLayoutPanel1.Controls.Add(this.lblValorPendenteRecebimento);
            this.flowLayoutPanel1.Controls.Add(this.lblNomePendentePagamento);
            this.flowLayoutPanel1.Controls.Add(this.lblValorPendentePagamento);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 285);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(655, 29);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblNomeRecebidos);
            this.flowLayoutPanel2.Controls.Add(this.lblValorRecebidos);
            this.flowLayoutPanel2.Controls.Add(this.lblNomePagos);
            this.flowLayoutPanel2.Controls.Add(this.lblValorPagos);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(23, 320);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(655, 29);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblNomePrevistoEntradas);
            this.flowLayoutPanel3.Controls.Add(this.lblValorPrevistoTotalEntradas);
            this.flowLayoutPanel3.Controls.Add(this.lblNomePrevistoSaidas);
            this.flowLayoutPanel3.Controls.Add(this.lblValorPrevistoTotalSaidas);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(22, 355);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(655, 29);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lblNomeSaldoPrevisto);
            this.flowLayoutPanel4.Controls.Add(this.lblValorSaldoPrevisto);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(22, 390);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(655, 29);
            this.flowLayoutPanel4.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 23);
            this.comboBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Selecione uma conta";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(22, 9);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(656, 29);
            this.flowLayoutPanel5.TabIndex = 33;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.lblDataInicial);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(218, 23);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.lblDataFinal);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(224, 3);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(203, 23);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label1);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(433, 3);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel8.Size = new System.Drawing.Size(210, 23);
            this.flowLayoutPanel8.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel10);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel11);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel12);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(23, 41);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(655, 35);
            this.flowLayoutPanel9.TabIndex = 34;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.dTPDataInicial);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(218, 28);
            this.flowLayoutPanel10.TabIndex = 0;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.dTPDataFinal);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(224, 3);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(203, 28);
            this.flowLayoutPanel11.TabIndex = 1;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.Controls.Add(this.comboBox1);
            this.flowLayoutPanel12.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel12.Location = new System.Drawing.Point(433, 3);
            this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(210, 28);
            this.flowLayoutPanel12.TabIndex = 1;
            // 
            // Pesquisa_Avancada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(695, 429);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.btnPesqPendentes);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel9);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisa_Avancada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Avançada";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dTPDataInicial;
        private System.Windows.Forms.DateTimePicker dTPDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPesqPendentes;
        private System.Windows.Forms.Label lblNomePendenteRecebimento;
        private System.Windows.Forms.Label lblNomePendentePagamento;
        private System.Windows.Forms.Label lblNomePrevistoEntradas;
        private System.Windows.Forms.Label lblValorPendenteRecebimento;
        private System.Windows.Forms.Label lblValorPendentePagamento;
        private System.Windows.Forms.Label lblValorPrevistoTotalEntradas;
        private System.Windows.Forms.Label lblNomeRecebidos;
        private System.Windows.Forms.Label lblValorRecebidos;
        private System.Windows.Forms.Label lblNomePagos;
        private System.Windows.Forms.Label lblValorPagos;
        private System.Windows.Forms.Label lblNomePrevistoSaidas;
        private System.Windows.Forms.Label lblValorPrevistoTotalSaidas;
        private System.Windows.Forms.Label lblNomeSaldoPrevisto;
        private System.Windows.Forms.Label lblValorSaldoPrevisto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
    }
}