﻿namespace BmsSoftware.Modulos.Vendas
{
    partial class FrmClassFiscal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassFiscal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblObsField = new System.Windows.Forms.Label();
            this.tabControlMarca = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBaseReduzida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAliICMS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClassiFical = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTotalPesquisa = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.DataGriewDados = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALIQICMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BASEREDUZIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBGrava = new System.Windows.Forms.ToolStripButton();
            this.TSBNovo = new System.Windows.Forms.ToolStripButton();
            this.TSBDelete = new System.Windows.Forms.ToolStripButton();
            this.TSBFiltro = new System.Windows.Forms.ToolStripButton();
            this.TSBPrint = new System.Windows.Forms.ToolStripButton();
            this.TSBVolta = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gravaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnCadMensagem = new System.Windows.Forms.Button();
            this.cbMensagem = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControlMarca.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewDados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblObsField);
            this.panel1.Controls.Add(this.tabControlMarca);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 325);
            this.panel1.TabIndex = 0;
            // 
            // lblObsField
            // 
            this.lblObsField.AutoSize = true;
            this.lblObsField.ForeColor = System.Drawing.Color.Blue;
            this.lblObsField.Location = new System.Drawing.Point(12, 303);
            this.lblObsField.Name = "lblObsField";
            this.lblObsField.Size = new System.Drawing.Size(32, 13);
            this.lblObsField.TabIndex = 82;
            this.lblObsField.Text = "Obs.:";
            // 
            // tabControlMarca
            // 
            this.tabControlMarca.Controls.Add(this.tabPage1);
            this.tabControlMarca.Controls.Add(this.tabPage3);
            this.tabControlMarca.Location = new System.Drawing.Point(12, 87);
            this.tabControlMarca.Name = "tabControlMarca";
            this.tabControlMarca.SelectedIndex = 0;
            this.tabControlMarca.Size = new System.Drawing.Size(375, 213);
            this.tabControlMarca.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.btnCadMensagem);
            this.tabPage1.Controls.Add(this.cbMensagem);
            this.tabPage1.Controls.Add(this.label64);
            this.tabPage1.Controls.Add(this.txtBaseReduzida);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtAliICMS);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtClassiFical);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Cadastrais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBaseReduzida
            // 
            this.txtBaseReduzida.Location = new System.Drawing.Point(96, 71);
            this.txtBaseReduzida.MaxLength = 20;
            this.txtBaseReduzida.Name = "txtBaseReduzida";
            this.txtBaseReduzida.Size = new System.Drawing.Size(83, 20);
            this.txtBaseReduzida.TabIndex = 12;
            this.txtBaseReduzida.Text = "0,00";
            this.txtBaseReduzida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBaseReduzida.Enter += new System.EventHandler(this.txtBaseReduzida_Enter);
            this.txtBaseReduzida.Validating += new System.ComponentModel.CancelEventHandler(this.txtBaseReduzida_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Base Reduzida:";
            // 
            // txtAliICMS
            // 
            this.txtAliICMS.Location = new System.Drawing.Point(11, 71);
            this.txtAliICMS.MaxLength = 20;
            this.txtAliICMS.Name = "txtAliICMS";
            this.txtAliICMS.Size = new System.Drawing.Size(79, 20);
            this.txtAliICMS.TabIndex = 10;
            this.txtAliICMS.Text = "0,00";
            this.txtAliICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAliICMS.Enter += new System.EventHandler(this.txtAliICMS_Enter);
            this.txtAliICMS.Validating += new System.ComponentModel.CancelEventHandler(this.txtAliICMS_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Al. ICMS:";
            // 
            // txtClassiFical
            // 
            this.txtClassiFical.Location = new System.Drawing.Point(11, 32);
            this.txtClassiFical.MaxLength = 50;
            this.txtClassiFical.Name = "txtClassiFical";
            this.txtClassiFical.Size = new System.Drawing.Size(168, 20);
            this.txtClassiFical.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classificação Fiscal:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTotalPesquisa);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.DataGriewDados);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(367, 187);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pesquisa";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTotalPesquisa
            // 
            this.lblTotalPesquisa.AutoSize = true;
            this.lblTotalPesquisa.Location = new System.Drawing.Point(103, 167);
            this.lblTotalPesquisa.Name = "lblTotalPesquisa";
            this.lblTotalPesquisa.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPesquisa.TabIndex = 2;
            this.lblTotalPesquisa.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 167);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Total da pesquisa:";
            // 
            // DataGriewDados
            // 
            this.DataGriewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.ALIQICMS,
            this.BASEREDUZIDA});
            this.DataGriewDados.Location = new System.Drawing.Point(6, 17);
            this.DataGriewDados.Name = "DataGriewDados";
            this.DataGriewDados.ReadOnly = true;
            this.DataGriewDados.Size = new System.Drawing.Size(350, 147);
            this.DataGriewDados.TabIndex = 0;
            this.DataGriewDados.Enter += new System.EventHandler(this.DataGriewDados_Enter);
            this.DataGriewDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewDados_CellDoubleClick);
            this.DataGriewDados.Leave += new System.EventHandler(this.DataGriewDados_Leave);
            this.DataGriewDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGriewDados_KeyDown);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 200;
            // 
            // ALIQICMS
            // 
            this.ALIQICMS.DataPropertyName = "ALIQICMS";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.ALIQICMS.DefaultCellStyle = dataGridViewCellStyle1;
            this.ALIQICMS.HeaderText = "Al. ICMS";
            this.ALIQICMS.Name = "ALIQICMS";
            this.ALIQICMS.ReadOnly = true;
            this.ALIQICMS.Width = 50;
            // 
            // BASEREDUZIDA
            // 
            this.BASEREDUZIDA.DataPropertyName = "BASEREDUZIDA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.BASEREDUZIDA.DefaultCellStyle = dataGridViewCellStyle2;
            this.BASEREDUZIDA.HeaderText = "Red. ICMS";
            this.BASEREDUZIDA.Name = "BASEREDUZIDA";
            this.BASEREDUZIDA.ReadOnly = true;
            this.BASEREDUZIDA.Width = 50;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(44, 44);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBGrava,
            this.TSBNovo,
            this.TSBDelete,
            this.TSBFiltro,
            this.TSBPrint,
            this.TSBVolta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(394, 51);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStripCadatro";
            // 
            // TSBGrava
            // 
            this.TSBGrava.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBGrava.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGrava.Name = "TSBGrava";
            this.TSBGrava.Size = new System.Drawing.Size(23, 48);
            this.TSBGrava.Text = "toolStripButton1";
            this.TSBGrava.ToolTipText = "Grava";
            this.TSBGrava.Click += new System.EventHandler(this.TSBGrava_Click);
            // 
            // TSBNovo
            // 
            this.TSBNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBNovo.Image = ((System.Drawing.Image)(resources.GetObject("TSBNovo.Image")));
            this.TSBNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNovo.Name = "TSBNovo";
            this.TSBNovo.Size = new System.Drawing.Size(48, 48);
            this.TSBNovo.Text = "toolStripButton2";
            this.TSBNovo.Click += new System.EventHandler(this.TSBNovo_Click);
            // 
            // TSBDelete
            // 
            this.TSBDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSBDelete.Image")));
            this.TSBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDelete.Name = "TSBDelete";
            this.TSBDelete.Size = new System.Drawing.Size(48, 48);
            this.TSBDelete.Text = "toolStripButton1";
            this.TSBDelete.Click += new System.EventHandler(this.TSBDelete_Click);
            // 
            // TSBFiltro
            // 
            this.TSBFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBFiltro.Image = ((System.Drawing.Image)(resources.GetObject("TSBFiltro.Image")));
            this.TSBFiltro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBFiltro.Name = "TSBFiltro";
            this.TSBFiltro.Size = new System.Drawing.Size(48, 48);
            this.TSBFiltro.Text = "toolStripButton3";
            this.TSBFiltro.Click += new System.EventHandler(this.TSBFiltro_Click);
            // 
            // TSBPrint
            // 
            this.TSBPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBPrint.Image = ((System.Drawing.Image)(resources.GetObject("TSBPrint.Image")));
            this.TSBPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPrint.Name = "TSBPrint";
            this.TSBPrint.Size = new System.Drawing.Size(48, 48);
            this.TSBPrint.Text = "toolStripButton4";
            this.TSBPrint.Click += new System.EventHandler(this.TSBPrint_Click);
            // 
            // TSBVolta
            // 
            this.TSBVolta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBVolta.Image = ((System.Drawing.Image)(resources.GetObject("TSBVolta.Image")));
            this.TSBVolta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBVolta.Name = "TSBVolta";
            this.TSBVolta.Size = new System.Drawing.Size(48, 48);
            this.TSBVolta.Text = "toolStripButton1";
            this.TSBVolta.Click += new System.EventHandler(this.TSBVolta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gravaToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.apagaToolStripMenuItem,
            this.pesquisaToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.voltaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gravaToolStripMenuItem
            // 
            this.gravaToolStripMenuItem.Name = "gravaToolStripMenuItem";
            this.gravaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.gravaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.gravaToolStripMenuItem.Text = "&Salva";
            this.gravaToolStripMenuItem.Click += new System.EventHandler(this.gravaToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // apagaToolStripMenuItem
            // 
            this.apagaToolStripMenuItem.Name = "apagaToolStripMenuItem";
            this.apagaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.apagaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.apagaToolStripMenuItem.Text = "&Apaga";
            this.apagaToolStripMenuItem.Click += new System.EventHandler(this.apagaToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pesquisaToolStripMenuItem.Text = "&Pesquisar";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // voltaToolStripMenuItem
            // 
            this.voltaToolStripMenuItem.Name = "voltaToolStripMenuItem";
            this.voltaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.voltaToolStripMenuItem.Text = "&Volta";
            this.voltaToolStripMenuItem.Click += new System.EventHandler(this.voltaToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            // 
            // btnCadMensagem
            // 
            this.btnCadMensagem.Location = new System.Drawing.Point(330, 107);
            this.btnCadMensagem.Name = "btnCadMensagem";
            this.btnCadMensagem.Size = new System.Drawing.Size(31, 23);
            this.btnCadMensagem.TabIndex = 114;
            this.btnCadMensagem.UseVisualStyleBackColor = true;
            this.btnCadMensagem.Click += new System.EventHandler(this.btnCadMensagem_Click);
            // 
            // cbMensagem
            // 
            this.cbMensagem.FormattingEnabled = true;
            this.cbMensagem.Location = new System.Drawing.Point(11, 109);
            this.cbMensagem.Name = "cbMensagem";
            this.cbMensagem.Size = new System.Drawing.Size(313, 21);
            this.cbMensagem.TabIndex = 112;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(8, 94);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(62, 13);
            this.label64.TabIndex = 113;
            this.label64.Text = "Mensagem:";
            // 
            // FrmClassFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 325);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmClassFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classificação Fiscal";
            this.Load += new System.EventHandler(this.FrmTipoRegiao_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMarca_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMarca_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlMarca.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriewDados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gravaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBGrava;
        private System.Windows.Forms.ToolStripButton TSBNovo;
        private System.Windows.Forms.ToolStripButton TSBDelete;
        private System.Windows.Forms.ToolStripButton TSBFiltro;
        private System.Windows.Forms.ToolStripButton TSBPrint;
        private System.Windows.Forms.ToolStripButton TSBVolta;
        private System.Windows.Forms.TabControl tabControlMarca;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtClassiFical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTotalPesquisa;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView DataGriewDados;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblObsField;
        private System.Windows.Forms.TextBox txtAliICMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaseReduzida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALIQICMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BASEREDUZIDA;
        private System.Windows.Forms.Button btnCadMensagem;
        private System.Windows.Forms.ComboBox cbMensagem;
        private System.Windows.Forms.Label label64;
    }
}