
namespace Gerenciador
{
    partial class Resumo_Historicos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLinkSair = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.txtReceitas = new System.Windows.Forms.TextBox();
            this.lblNomeTela = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cboMesSelecionado = new System.Windows.Forms.ComboBox();
            this.lblNomeMesSelecionado = new System.Windows.Forms.Label();
            this.lblSaldoBancario = new System.Windows.Forms.Label();
            this.cboAnoSelecionado = new System.Windows.Forms.ComboBox();
            this.lblNomeAnoSelecionado = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(5);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series1.LabelFormat = "R$";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.MovingDirection = ((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Right | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Left) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.TopRight) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomLeft) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.BottomRight)));
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(586, 488);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel4.Controls.Add(this.lblLinkSair);
            this.panel4.Location = new System.Drawing.Point(615, 468);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 35);
            this.panel4.TabIndex = 40;
            // 
            // lblLinkSair
            // 
            this.lblLinkSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinkSair.AutoSize = true;
            this.lblLinkSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkSair.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkSair.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLinkSair.Location = new System.Drawing.Point(36, 5);
            this.lblLinkSair.Margin = new System.Windows.Forms.Padding(5);
            this.lblLinkSair.Name = "lblLinkSair";
            this.lblLinkSair.Padding = new System.Windows.Forms.Padding(5);
            this.lblLinkSair.Size = new System.Drawing.Size(58, 28);
            this.lblLinkSair.TabIndex = 28;
            this.lblLinkSair.TabStop = true;
            this.lblLinkSair.Text = "SAIR";
            this.lblLinkSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLinkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSair_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(615, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 35);
            this.panel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(62, 4, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Subtotal";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(615, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 35);
            this.panel2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(62, 4, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Despesas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(615, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 35);
            this.panel1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receitas";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.txtTotal.Location = new System.Drawing.Point(615, 279);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(130, 35);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDespesas.Enabled = false;
            this.txtDespesas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesas.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.txtDespesas.Location = new System.Drawing.Point(615, 191);
            this.txtDespesas.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.txtDespesas.Multiline = true;
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(130, 35);
            this.txtDespesas.TabIndex = 34;
            this.txtDespesas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReceitas
            // 
            this.txtReceitas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceitas.Enabled = false;
            this.txtReceitas.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceitas.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.txtReceitas.Location = new System.Drawing.Point(615, 103);
            this.txtReceitas.Margin = new System.Windows.Forms.Padding(5, 7, 5, 5);
            this.txtReceitas.Multiline = true;
            this.txtReceitas.Name = "txtReceitas";
            this.txtReceitas.Size = new System.Drawing.Size(130, 35);
            this.txtReceitas.TabIndex = 33;
            this.txtReceitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeTela
            // 
            this.lblNomeTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNomeTela.AutoSize = true;
            this.lblNomeTela.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblNomeTela.Location = new System.Drawing.Point(617, 11);
            this.lblNomeTela.Name = "lblNomeTela";
            this.lblNomeTela.Size = new System.Drawing.Size(128, 19);
            this.lblNomeTela.TabIndex = 36;
            this.lblNomeTela.Text = "TELA DE RESUMO";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnImprimir.CausesValidation = false;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Teal;
            this.btnImprimir.Location = new System.Drawing.Point(615, 408);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(130, 35);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cboMesSelecionado
            // 
            this.cboMesSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMesSelecionado.FormattingEnabled = true;
            this.cboMesSelecionado.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cboMesSelecionado.Location = new System.Drawing.Point(24, 50);
            this.cboMesSelecionado.Name = "cboMesSelecionado";
            this.cboMesSelecionado.Size = new System.Drawing.Size(98, 24);
            this.cboMesSelecionado.TabIndex = 42;
            this.cboMesSelecionado.SelectedIndexChanged += new System.EventHandler(this.cboMesSelecionado_SelectedIndexChanged);
            // 
            // lblNomeMesSelecionado
            // 
            this.lblNomeMesSelecionado.AutoSize = true;
            this.lblNomeMesSelecionado.BackColor = System.Drawing.Color.White;
            this.lblNomeMesSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMesSelecionado.Location = new System.Drawing.Point(21, 31);
            this.lblNomeMesSelecionado.Name = "lblNomeMesSelecionado";
            this.lblNomeMesSelecionado.Size = new System.Drawing.Size(37, 16);
            this.lblNomeMesSelecionado.TabIndex = 43;
            this.lblNomeMesSelecionado.Text = "Mês";
            // 
            // lblSaldoBancario
            // 
            this.lblSaldoBancario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoBancario.AutoSize = true;
            this.lblSaldoBancario.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoBancario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoBancario.ForeColor = System.Drawing.Color.Teal;
            this.lblSaldoBancario.Location = new System.Drawing.Point(636, 336);
            this.lblSaldoBancario.Name = "lblSaldoBancario";
            this.lblSaldoBancario.Size = new System.Drawing.Size(52, 18);
            this.lblSaldoBancario.TabIndex = 44;
            this.lblSaldoBancario.Text = "label5";
            // 
            // cboAnoSelecionado
            // 
            this.cboAnoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnoSelecionado.FormattingEnabled = true;
            this.cboAnoSelecionado.Location = new System.Drawing.Point(132, 50);
            this.cboAnoSelecionado.Name = "cboAnoSelecionado";
            this.cboAnoSelecionado.Size = new System.Drawing.Size(97, 24);
            this.cboAnoSelecionado.TabIndex = 45;
            this.cboAnoSelecionado.SelectedIndexChanged += new System.EventHandler(this.cboAnoSelecionado_SelectedIndexChanged);
            // 
            // lblNomeAnoSelecionado
            // 
            this.lblNomeAnoSelecionado.AutoSize = true;
            this.lblNomeAnoSelecionado.BackColor = System.Drawing.Color.White;
            this.lblNomeAnoSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAnoSelecionado.Location = new System.Drawing.Point(132, 31);
            this.lblNomeAnoSelecionado.Name = "lblNomeAnoSelecionado";
            this.lblNomeAnoSelecionado.Size = new System.Drawing.Size(35, 16);
            this.lblNomeAnoSelecionado.TabIndex = 46;
            this.lblNomeAnoSelecionado.Text = "Ano";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.CausesValidation = false;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Teal;
            this.btnRefresh.Location = new System.Drawing.Point(615, 367);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 35);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Atualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Resumo_Historicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(759, 543);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblNomeAnoSelecionado);
            this.Controls.Add(this.cboAnoSelecionado);
            this.Controls.Add(this.lblSaldoBancario);
            this.Controls.Add(this.lblNomeMesSelecionado);
            this.Controls.Add(this.cboMesSelecionado);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtReceitas);
            this.Controls.Add(this.lblNomeTela);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Resumo_Historicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumo Anual";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel lblLinkSair;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.TextBox txtReceitas;
        private System.Windows.Forms.Label lblNomeTela;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboMesSelecionado;
        private System.Windows.Forms.Label lblNomeMesSelecionado;
        private System.Windows.Forms.Label lblSaldoBancario;
        private System.Windows.Forms.ComboBox cboAnoSelecionado;
        private System.Windows.Forms.Label lblNomeAnoSelecionado;
        private System.Windows.Forms.Button btnRefresh;
    }
}