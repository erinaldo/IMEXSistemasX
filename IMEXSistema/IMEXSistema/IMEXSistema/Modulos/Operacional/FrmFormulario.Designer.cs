﻿namespace BmsSoftware.Modulos.Operacional
{
    partial class FrmFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormulario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblObsField = new System.Windows.Forms.Label();
            this.tabControlMarca = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCadGrupo = new System.Windows.Forms.Button();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFormulario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSeach = new System.Windows.Forms.Button();
            this.label91 = new System.Windows.Forms.Label();
            this.txtPesquisaRapida = new System.Windows.Forms.TextBox();
            this.lblTotalPesquisa = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.DataGriewDados = new System.Windows.Forms.DataGridView();
            this.NOMETELA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEFORMULARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEGRUPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFORMULARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(794, 506);
            this.panel1.TabIndex = 0;
            // 
            // lblObsField
            // 
            this.lblObsField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblObsField.AutoSize = true;
            this.lblObsField.ForeColor = System.Drawing.Color.Blue;
            this.lblObsField.Location = new System.Drawing.Point(13, 484);
            this.lblObsField.Name = "lblObsField";
            this.lblObsField.Size = new System.Drawing.Size(32, 13);
            this.lblObsField.TabIndex = 82;
            this.lblObsField.Text = "Obs.:";
            // 
            // tabControlMarca
            // 
            this.tabControlMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlMarca.Controls.Add(this.tabPage1);
            this.tabControlMarca.Controls.Add(this.tabPage3);
            this.tabControlMarca.Location = new System.Drawing.Point(12, 87);
            this.tabControlMarca.Name = "tabControlMarca";
            this.tabControlMarca.SelectedIndex = 0;
            this.tabControlMarca.Size = new System.Drawing.Size(770, 394);
            this.tabControlMarca.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.btnCadGrupo);
            this.tabPage1.Controls.Add(this.cbGrupo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNomeFormulario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Cadastrais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCadGrupo
            // 
            this.btnCadGrupo.FlatAppearance.BorderSize = 0;
            this.btnCadGrupo.Location = new System.Drawing.Point(380, 107);
            this.btnCadGrupo.Name = "btnCadGrupo";
            this.btnCadGrupo.Size = new System.Drawing.Size(26, 21);
            this.btnCadGrupo.TabIndex = 173;
            this.btnCadGrupo.UseVisualStyleBackColor = true;
            this.btnCadGrupo.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // cbGrupo
            // 
            this.cbGrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(11, 108);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(363, 21);
            this.cbGrupo.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 171;
            this.label3.Text = "Grupo:";
            // 
            // txtNomeFormulario
            // 
            this.txtNomeFormulario.Location = new System.Drawing.Point(11, 71);
            this.txtNomeFormulario.MaxLength = 50;
            this.txtNomeFormulario.Name = "txtNomeFormulario";
            this.txtNomeFormulario.Size = new System.Drawing.Size(397, 20);
            this.txtNomeFormulario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Social da Tela:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 32);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(397, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Técnico da Tela:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnpdf);
            this.tabPage3.Controls.Add(this.btnExcel);
            this.tabPage3.Controls.Add(this.btnPrint);
            this.tabPage3.Controls.Add(this.btnSeach);
            this.tabPage3.Controls.Add(this.label91);
            this.tabPage3.Controls.Add(this.txtPesquisaRapida);
            this.tabPage3.Controls.Add(this.lblTotalPesquisa);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.DataGriewDados);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 368);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pesquisa";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnpdf
            // 
            this.btnpdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpdf.Location = new System.Drawing.Point(655, 20);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(25, 23);
            this.btnpdf.TabIndex = 317;
            this.btnpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(684, 20);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(25, 23);
            this.btnExcel.TabIndex = 316;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(713, 20);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(25, 23);
            this.btnPrint.TabIndex = 315;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSeach
            // 
            this.btnSeach.FlatAppearance.BorderSize = 0;
            this.btnSeach.Image = ((System.Drawing.Image)(resources.GetObject("btnSeach.Image")));
            this.btnSeach.Location = new System.Drawing.Point(314, 18);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(26, 22);
            this.btnSeach.TabIndex = 314;
            this.btnSeach.UseVisualStyleBackColor = true;
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(6, 3);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(90, 13);
            this.label91.TabIndex = 313;
            this.label91.Text = "Pesquisa Rápida:";
            // 
            // txtPesquisaRapida
            // 
            this.txtPesquisaRapida.CausesValidation = false;
            this.txtPesquisaRapida.Location = new System.Drawing.Point(9, 20);
            this.txtPesquisaRapida.Name = "txtPesquisaRapida";
            this.txtPesquisaRapida.Size = new System.Drawing.Size(309, 20);
            this.txtPesquisaRapida.TabIndex = 312;
            this.txtPesquisaRapida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaRapida_KeyDown);
            // 
            // lblTotalPesquisa
            // 
            this.lblTotalPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPesquisa.AutoSize = true;
            this.lblTotalPesquisa.Location = new System.Drawing.Point(100, 342);
            this.lblTotalPesquisa.Name = "lblTotalPesquisa";
            this.lblTotalPesquisa.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPesquisa.TabIndex = 2;
            this.lblTotalPesquisa.Text = "0";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 342);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 13);
            this.label33.TabIndex = 1;
            this.label33.Text = "Total da pesquisa:";
            // 
            // DataGriewDados
            // 
            this.DataGriewDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGriewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMETELA,
            this.NOMEFORMULARIO,
            this.NOMEGRUPO,
            this.IDFORMULARIO});
            this.DataGriewDados.Location = new System.Drawing.Point(6, 46);
            this.DataGriewDados.Name = "DataGriewDados";
            this.DataGriewDados.ReadOnly = true;
            this.DataGriewDados.Size = new System.Drawing.Size(732, 293);
            this.DataGriewDados.TabIndex = 0;
            this.DataGriewDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriewDados_CellDoubleClick);
            this.DataGriewDados.Enter += new System.EventHandler(this.DataGriewDados_Enter);
            this.DataGriewDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGriewDados_KeyDown);
            this.DataGriewDados.Leave += new System.EventHandler(this.DataGriewDados_Leave);
            // 
            // NOMETELA
            // 
            this.NOMETELA.DataPropertyName = "NOMETELA";
            this.NOMETELA.HeaderText = "Tela";
            this.NOMETELA.Name = "NOMETELA";
            this.NOMETELA.ReadOnly = true;
            this.NOMETELA.Width = 200;
            // 
            // NOMEFORMULARIO
            // 
            this.NOMEFORMULARIO.DataPropertyName = "NOMEFORMULARIO";
            this.NOMEFORMULARIO.HeaderText = "Formulario";
            this.NOMEFORMULARIO.Name = "NOMEFORMULARIO";
            this.NOMEFORMULARIO.ReadOnly = true;
            this.NOMEFORMULARIO.Width = 200;
            // 
            // NOMEGRUPO
            // 
            this.NOMEGRUPO.DataPropertyName = "NOMEGRUPO";
            this.NOMEGRUPO.HeaderText = "Grupo";
            this.NOMEGRUPO.Name = "NOMEGRUPO";
            this.NOMEGRUPO.ReadOnly = true;
            this.NOMEGRUPO.Width = 200;
            // 
            // IDFORMULARIO
            // 
            this.IDFORMULARIO.DataPropertyName = "IDFORMULARIO";
            this.IDFORMULARIO.HeaderText = "Código";
            this.IDFORMULARIO.Name = "IDFORMULARIO";
            this.IDFORMULARIO.ReadOnly = true;
            this.IDFORMULARIO.Width = 50;
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
            this.toolStrip1.Size = new System.Drawing.Size(794, 51);
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
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gravaToolStripMenuItem
            // 
            this.gravaToolStripMenuItem.Name = "gravaToolStripMenuItem";
            this.gravaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.gravaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.gravaToolStripMenuItem.Text = "&Salva";
            this.gravaToolStripMenuItem.Click += new System.EventHandler(this.gravaToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "&Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // apagaToolStripMenuItem
            // 
            this.apagaToolStripMenuItem.Name = "apagaToolStripMenuItem";
            this.apagaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.apagaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.apagaToolStripMenuItem.Text = "&Apaga";
            this.apagaToolStripMenuItem.Click += new System.EventHandler(this.apagaToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisaToolStripMenuItem.Text = "&Pesquisar";
            this.pesquisaToolStripMenuItem.Click += new System.EventHandler(this.pesquisaToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // voltaToolStripMenuItem
            // 
            this.voltaToolStripMenuItem.Name = "voltaToolStripMenuItem";
            this.voltaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
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
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FrmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Formulario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMarca_FormClosing);
            this.Load += new System.EventHandler(this.FrmTipoRegiao_Load);
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
        private System.Windows.Forms.TextBox txtNome;
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
        private System.Windows.Forms.TextBox txtNomeFormulario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadGrupo;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMETELA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEFORMULARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEGRUPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFORMULARIO;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.TextBox txtPesquisaRapida;
        private System.Windows.Forms.Button btnSeach;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrint;
    }
}