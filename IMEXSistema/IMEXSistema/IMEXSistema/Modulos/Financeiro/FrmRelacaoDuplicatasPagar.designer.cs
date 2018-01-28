﻿namespace BmsSoftware.Modulos.Financeiro
{
    partial class FrmRelacaoDuplicatasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelacaoDuplicatasPagar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtLocalizarDuplicata = new System.Windows.Forms.TextBox();
            this.btnpdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCentroCusto = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDataPagto = new System.Windows.Forms.RadioButton();
            this.rdDataEmissao = new System.Windows.Forms.RadioButton();
            this.rdDataVencto = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mkdatafinal = new System.Windows.Forms.MaskedTextBox();
            this.bntDateSelecFinal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mkDtInicial = new System.Windows.Forms.MaskedTextBox();
            this.bntDateSelecInicial = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTotalRecebido = new System.Windows.Forms.Label();
            this.lblTotalDevedor = new System.Windows.Forms.Label();
            this.lblTotalDuplicata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpaPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.DataGridRelaDupl = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEFORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAEMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAVECTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATAPAGTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORDUPLICATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORDEVEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMESTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIASATRASO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CENTROCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMECENTROCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMETIPODUPLICATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVencidasVencer = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbPagas = new System.Windows.Forms.RadioButton();
            this.rbVencer = new System.Windows.Forms.RadioButton();
            this.rbVencidas = new System.Windows.Forms.RadioButton();
            this.lblObsField = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sfdExportToxcel = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRelaDupl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtLocalizarDuplicata);
            this.panel1.Controls.Add(this.btnpdf);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbFornecedor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbCentroCusto);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.lblTotalRecebido);
            this.panel1.Controls.Add(this.lblTotalDevedor);
            this.panel1.Controls.Add(this.lblTotalDuplicata);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnLimpaPesquisa);
            this.panel1.Controls.Add(this.btnPesquisa);
            this.panel1.Controls.Add(this.DataGridRelaDupl);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblObsField);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 566);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 306;
            this.label14.Text = "Pesquisa:";
            // 
            // txtLocalizarDuplicata
            // 
            this.txtLocalizarDuplicata.Location = new System.Drawing.Point(15, 167);
            this.txtLocalizarDuplicata.Name = "txtLocalizarDuplicata";
            this.txtLocalizarDuplicata.Size = new System.Drawing.Size(156, 20);
            this.txtLocalizarDuplicata.TabIndex = 305;
            this.txtLocalizarDuplicata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLocalizarDuplicata_KeyDown);
            // 
            // btnpdf
            // 
            this.btnpdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpdf.Location = new System.Drawing.Point(1006, 164);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(25, 23);
            this.btnpdf.TabIndex = 304;
            this.btnpdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(1037, 164);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(25, 23);
            this.btnExcel.TabIndex = 303;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1068, 164);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(25, 23);
            this.btnPrint.TabIndex = 302;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(783, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 246;
            this.label7.Text = "Fornecedor:";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(787, 124);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(306, 21);
            this.cbFornecedor.TabIndex = 245;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(782, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 244;
            this.label6.Text = "Tipo de Pagamento:";
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(786, 84);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(307, 21);
            this.cbTipo.TabIndex = 242;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(782, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 240;
            this.label11.Text = "Centro de Custo:";
            // 
            // cbCentroCusto
            // 
            this.cbCentroCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCentroCusto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCentroCusto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCentroCusto.FormattingEnabled = true;
            this.cbCentroCusto.Location = new System.Drawing.Point(785, 43);
            this.cbCentroCusto.Name = "cbCentroCusto";
            this.cbCentroCusto.Size = new System.Drawing.Size(308, 21);
            this.cbCentroCusto.TabIndex = 239;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rdDataPagto);
            this.groupBox2.Controls.Add(this.rdDataEmissao);
            this.groupBox2.Controls.Add(this.rdDataVencto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mkdatafinal);
            this.groupBox2.Controls.Add(this.bntDateSelecFinal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mkDtInicial);
            this.groupBox2.Controls.Add(this.bntDateSelecInicial);
            this.groupBox2.Location = new System.Drawing.Point(502, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 87);
            this.groupBox2.TabIndex = 185;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // rdDataPagto
            // 
            this.rdDataPagto.AutoSize = true;
            this.rdDataPagto.Location = new System.Drawing.Point(181, 17);
            this.rdDataPagto.Name = "rdDataPagto";
            this.rdDataPagto.Size = new System.Drawing.Size(79, 17);
            this.rdDataPagto.TabIndex = 189;
            this.rdDataPagto.Text = "Pagamento";
            this.rdDataPagto.UseVisualStyleBackColor = true;
            // 
            // rdDataEmissao
            // 
            this.rdDataEmissao.AutoSize = true;
            this.rdDataEmissao.Location = new System.Drawing.Point(102, 17);
            this.rdDataEmissao.Name = "rdDataEmissao";
            this.rdDataEmissao.Size = new System.Drawing.Size(64, 17);
            this.rdDataEmissao.TabIndex = 188;
            this.rdDataEmissao.Text = "Emissão";
            this.rdDataEmissao.UseVisualStyleBackColor = true;
            // 
            // rdDataVencto
            // 
            this.rdDataVencto.AutoSize = true;
            this.rdDataVencto.Checked = true;
            this.rdDataVencto.Location = new System.Drawing.Point(15, 17);
            this.rdDataVencto.Name = "rdDataVencto";
            this.rdDataVencto.Size = new System.Drawing.Size(81, 17);
            this.rdDataVencto.TabIndex = 187;
            this.rdDataVencto.TabStop = true;
            this.rdDataVencto.Text = "Vencimento";
            this.rdDataVencto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 185;
            this.label5.Text = "Final:";
            // 
            // mkdatafinal
            // 
            this.mkdatafinal.Location = new System.Drawing.Point(140, 60);
            this.mkdatafinal.Mask = "00/00/0000";
            this.mkdatafinal.Name = "mkdatafinal";
            this.mkdatafinal.Size = new System.Drawing.Size(79, 20);
            this.mkdatafinal.TabIndex = 184;
            this.mkdatafinal.ValidatingType = typeof(System.DateTime);
            // 
            // bntDateSelecFinal
            // 
            this.bntDateSelecFinal.FlatAppearance.BorderSize = 0;
            this.bntDateSelecFinal.Location = new System.Drawing.Point(225, 60);
            this.bntDateSelecFinal.Name = "bntDateSelecFinal";
            this.bntDateSelecFinal.Size = new System.Drawing.Size(26, 21);
            this.bntDateSelecFinal.TabIndex = 186;
            this.bntDateSelecFinal.UseVisualStyleBackColor = true;
            this.bntDateSelecFinal.Click += new System.EventHandler(this.bntDateSelecFinal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 182;
            this.label2.Text = "Inicial:";
            // 
            // mkDtInicial
            // 
            this.mkDtInicial.Location = new System.Drawing.Point(23, 60);
            this.mkDtInicial.Mask = "00/00/0000";
            this.mkDtInicial.Name = "mkDtInicial";
            this.mkDtInicial.Size = new System.Drawing.Size(79, 20);
            this.mkDtInicial.TabIndex = 181;
            this.mkDtInicial.ValidatingType = typeof(System.DateTime);
            // 
            // bntDateSelecInicial
            // 
            this.bntDateSelecInicial.FlatAppearance.BorderSize = 0;
            this.bntDateSelecInicial.Location = new System.Drawing.Point(108, 60);
            this.bntDateSelecInicial.Name = "bntDateSelecInicial";
            this.bntDateSelecInicial.Size = new System.Drawing.Size(26, 21);
            this.bntDateSelecInicial.TabIndex = 183;
            this.bntDateSelecInicial.UseVisualStyleBackColor = true;
            this.bntDateSelecInicial.Click += new System.EventHandler(this.bntDateSelecInicial_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(258, 41);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 177;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTotalRecebido
            // 
            this.lblTotalRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRecebido.AutoSize = true;
            this.lblTotalRecebido.Location = new System.Drawing.Point(101, 522);
            this.lblTotalRecebido.Name = "lblTotalRecebido";
            this.lblTotalRecebido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalRecebido.Size = new System.Drawing.Size(28, 13);
            this.lblTotalRecebido.TabIndex = 173;
            this.lblTotalRecebido.Text = "0,00";
            this.lblTotalRecebido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDevedor
            // 
            this.lblTotalDevedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalDevedor.AutoSize = true;
            this.lblTotalDevedor.Location = new System.Drawing.Point(100, 500);
            this.lblTotalDevedor.Name = "lblTotalDevedor";
            this.lblTotalDevedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalDevedor.Size = new System.Drawing.Size(28, 13);
            this.lblTotalDevedor.TabIndex = 172;
            this.lblTotalDevedor.Text = "0,00";
            this.lblTotalDevedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalDuplicata
            // 
            this.lblTotalDuplicata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalDuplicata.AutoSize = true;
            this.lblTotalDuplicata.Location = new System.Drawing.Point(100, 478);
            this.lblTotalDuplicata.Name = "lblTotalDuplicata";
            this.lblTotalDuplicata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalDuplicata.Size = new System.Drawing.Size(28, 13);
            this.lblTotalDuplicata.TabIndex = 171;
            this.lblTotalDuplicata.Text = "0,00";
            this.lblTotalDuplicata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 170;
            this.label4.Text = "Total Recebido:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 169;
            this.label3.Text = "Total Devedor:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 168;
            this.label1.Text = "Total Duplicata:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(177, 41);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 167;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpaPesquisa
            // 
            this.btnLimpaPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpaPesquisa.Image")));
            this.btnLimpaPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpaPesquisa.Location = new System.Drawing.Point(96, 41);
            this.btnLimpaPesquisa.Name = "btnLimpaPesquisa";
            this.btnLimpaPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpaPesquisa.TabIndex = 166;
            this.btnLimpaPesquisa.Text = "&Limpar";
            this.btnLimpaPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpaPesquisa.UseVisualStyleBackColor = true;
            this.btnLimpaPesquisa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Location = new System.Drawing.Point(15, 41);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // DataGridRelaDupl
            // 
            this.DataGridRelaDupl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridRelaDupl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRelaDupl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.NUMERO,
            this.NOMEFORNECEDOR,
            this.DATAEMISSAO,
            this.DATAVECTO,
            this.DATAPAGTO,
            this.VALORDUPLICATA,
            this.VALORDEVEDOR,
            this.VALORPAGO,
            this.NOMESTATUS,
            this.DIASATRASO,
            this.CENTROCUSTO,
            this.NOMECENTROCUSTO,
            this.NOMETIPODUPLICATA,
            this.OBSERVACAO});
            this.DataGridRelaDupl.Location = new System.Drawing.Point(12, 192);
            this.DataGridRelaDupl.Name = "DataGridRelaDupl";
            this.DataGridRelaDupl.ReadOnly = true;
            this.DataGridRelaDupl.Size = new System.Drawing.Size(1081, 268);
            this.DataGridRelaDupl.TabIndex = 164;
            this.DataGridRelaDupl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDuplicatas_CellDoubleClick);
            this.DataGridRelaDupl.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDuplicatas_CellEnter);
            this.DataGridRelaDupl.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridDuplicatas_ColumnHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Baixa";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Excluir";
            this.Column2.Image = ((System.Drawing.Image)(resources.GetObject("Column2.Image")));
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "NUMERO";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NUMERO.DefaultCellStyle = dataGridViewCellStyle15;
            this.NUMERO.HeaderText = "Duplicata";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.ReadOnly = true;
            // 
            // NOMEFORNECEDOR
            // 
            this.NOMEFORNECEDOR.DataPropertyName = "NOMEFORNECEDOR";
            this.NOMEFORNECEDOR.HeaderText = "Fornecedor";
            this.NOMEFORNECEDOR.Name = "NOMEFORNECEDOR";
            this.NOMEFORNECEDOR.ReadOnly = true;
            this.NOMEFORNECEDOR.Width = 300;
            // 
            // DATAEMISSAO
            // 
            this.DATAEMISSAO.DataPropertyName = "DATAEMISSAO";
            this.DATAEMISSAO.HeaderText = "Dt Emissão";
            this.DATAEMISSAO.Name = "DATAEMISSAO";
            this.DATAEMISSAO.ReadOnly = true;
            this.DATAEMISSAO.Width = 80;
            // 
            // DATAVECTO
            // 
            this.DATAVECTO.DataPropertyName = "DATAVECTO";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.DATAVECTO.DefaultCellStyle = dataGridViewCellStyle16;
            this.DATAVECTO.HeaderText = "Dt. Vecto";
            this.DATAVECTO.Name = "DATAVECTO";
            this.DATAVECTO.ReadOnly = true;
            this.DATAVECTO.Width = 80;
            // 
            // DATAPAGTO
            // 
            this.DATAPAGTO.DataPropertyName = "DATAPAGTO";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.DATAPAGTO.DefaultCellStyle = dataGridViewCellStyle17;
            this.DATAPAGTO.HeaderText = "Dt Pagto";
            this.DATAPAGTO.Name = "DATAPAGTO";
            this.DATAPAGTO.ReadOnly = true;
            this.DATAPAGTO.Width = 80;
            // 
            // VALORDUPLICATA
            // 
            this.VALORDUPLICATA.DataPropertyName = "VALORDUPLICATA";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = null;
            this.VALORDUPLICATA.DefaultCellStyle = dataGridViewCellStyle18;
            this.VALORDUPLICATA.HeaderText = "Vl. Duplicata";
            this.VALORDUPLICATA.Name = "VALORDUPLICATA";
            this.VALORDUPLICATA.ReadOnly = true;
            // 
            // VALORDEVEDOR
            // 
            this.VALORDEVEDOR.DataPropertyName = "VALORDEVEDOR";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            this.VALORDEVEDOR.DefaultCellStyle = dataGridViewCellStyle19;
            this.VALORDEVEDOR.HeaderText = "Vl. Devedor";
            this.VALORDEVEDOR.Name = "VALORDEVEDOR";
            this.VALORDEVEDOR.ReadOnly = true;
            // 
            // VALORPAGO
            // 
            this.VALORPAGO.DataPropertyName = "VALORPAGO";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            dataGridViewCellStyle20.NullValue = null;
            this.VALORPAGO.DefaultCellStyle = dataGridViewCellStyle20;
            this.VALORPAGO.HeaderText = "Vl. Recebido";
            this.VALORPAGO.Name = "VALORPAGO";
            this.VALORPAGO.ReadOnly = true;
            this.VALORPAGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NOMESTATUS
            // 
            this.NOMESTATUS.DataPropertyName = "NOMESTATUS";
            this.NOMESTATUS.HeaderText = "Status";
            this.NOMESTATUS.Name = "NOMESTATUS";
            this.NOMESTATUS.ReadOnly = true;
            // 
            // DIASATRASO
            // 
            this.DIASATRASO.DataPropertyName = "DIASATRASO";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DIASATRASO.DefaultCellStyle = dataGridViewCellStyle21;
            this.DIASATRASO.HeaderText = "Atraso";
            this.DIASATRASO.Name = "DIASATRASO";
            this.DIASATRASO.ReadOnly = true;
            this.DIASATRASO.Width = 70;
            // 
            // CENTROCUSTO
            // 
            this.CENTROCUSTO.DataPropertyName = "CENTROCUSTO";
            this.CENTROCUSTO.HeaderText = "Centro Custo";
            this.CENTROCUSTO.Name = "CENTROCUSTO";
            this.CENTROCUSTO.ReadOnly = true;
            // 
            // NOMECENTROCUSTO
            // 
            this.NOMECENTROCUSTO.DataPropertyName = "NOMECENTROCUSTO";
            this.NOMECENTROCUSTO.HeaderText = "Nome Centro Custo";
            this.NOMECENTROCUSTO.Name = "NOMECENTROCUSTO";
            this.NOMECENTROCUSTO.ReadOnly = true;
            this.NOMECENTROCUSTO.Width = 200;
            // 
            // NOMETIPODUPLICATA
            // 
            this.NOMETIPODUPLICATA.DataPropertyName = "NOMETIPODUPLICATA";
            this.NOMETIPODUPLICATA.HeaderText = "Tipo Duplicata";
            this.NOMETIPODUPLICATA.Name = "NOMETIPODUPLICATA";
            this.NOMETIPODUPLICATA.ReadOnly = true;
            this.NOMETIPODUPLICATA.Width = 200;
            // 
            // OBSERVACAO
            // 
            this.OBSERVACAO.DataPropertyName = "OBSERVACAO";
            this.OBSERVACAO.HeaderText = "Observação";
            this.OBSERVACAO.Name = "OBSERVACAO";
            this.OBSERVACAO.ReadOnly = true;
            this.OBSERVACAO.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVencidasVencer);
            this.groupBox1.Controls.Add(this.rbTodas);
            this.groupBox1.Controls.Add(this.rbPagas);
            this.groupBox1.Controls.Add(this.rbVencer);
            this.groupBox1.Controls.Add(this.rbVencidas);
            this.groupBox1.Location = new System.Drawing.Point(15, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 75);
            this.groupBox1.TabIndex = 163;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status da Duplicatas";
            // 
            // rbVencidasVencer
            // 
            this.rbVencidasVencer.AutoSize = true;
            this.rbVencidasVencer.Location = new System.Drawing.Point(187, 18);
            this.rbVencidasVencer.Name = "rbVencidasVencer";
            this.rbVencidasVencer.Size = new System.Drawing.Size(118, 17);
            this.rbVencidasVencer.TabIndex = 176;
            this.rbVencidasVencer.Text = "Vencidas/A Vencer";
            this.rbVencidasVencer.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(99, 52);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 174;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // rbPagas
            // 
            this.rbPagas.AutoSize = true;
            this.rbPagas.Location = new System.Drawing.Point(11, 52);
            this.rbPagas.Name = "rbPagas";
            this.rbPagas.Size = new System.Drawing.Size(55, 17);
            this.rbPagas.TabIndex = 173;
            this.rbPagas.Text = "Pagas";
            this.rbPagas.UseVisualStyleBackColor = true;
            // 
            // rbVencer
            // 
            this.rbVencer.AutoSize = true;
            this.rbVencer.Location = new System.Drawing.Point(99, 18);
            this.rbVencer.Name = "rbVencer";
            this.rbVencer.Size = new System.Drawing.Size(69, 17);
            this.rbVencer.TabIndex = 172;
            this.rbVencer.Text = "A Vencer";
            this.rbVencer.UseVisualStyleBackColor = true;
            // 
            // rbVencidas
            // 
            this.rbVencidas.AutoSize = true;
            this.rbVencidas.Checked = true;
            this.rbVencidas.Location = new System.Drawing.Point(11, 18);
            this.rbVencidas.Name = "rbVencidas";
            this.rbVencidas.Size = new System.Drawing.Size(69, 17);
            this.rbVencidas.TabIndex = 171;
            this.rbVencidas.TabStop = true;
            this.rbVencidas.Text = "Vencidas";
            this.rbVencidas.UseVisualStyleBackColor = true;
            // 
            // lblObsField
            // 
            this.lblObsField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblObsField.AutoSize = true;
            this.lblObsField.ForeColor = System.Drawing.Color.Blue;
            this.lblObsField.Location = new System.Drawing.Point(9, 544);
            this.lblObsField.Name = "lblObsField";
            this.lblObsField.Size = new System.Drawing.Size(41, 13);
            this.lblObsField.TabIndex = 158;
            this.lblObsField.Text = "Obs. 1:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 180;
            this.menuStrip1.Text = "menuStrip1";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmRelacaoDuplicatasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 566);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmRelacaoDuplicatasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de Contas a Pagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmExtratoDuplReceber_FormClosing);
            this.Load += new System.EventHandler(this.FrmExtratoDuplReceber_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmExtratoDuplReceber_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRelaDupl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblObsField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpaPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView DataGridRelaDupl;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rbVencer;
        private System.Windows.Forms.RadioButton rbVencidas;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbPagas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalRecebido;
        private System.Windows.Forms.Label lblTotalDevedor;
        private System.Windows.Forms.Label lblTotalDuplicata;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mkdatafinal;
        private System.Windows.Forms.Button bntDateSelecFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkDtInicial;
        private System.Windows.Forms.Button bntDateSelecInicial;
        private System.Windows.Forms.RadioButton rdDataPagto;
        private System.Windows.Forms.RadioButton rdDataEmissao;
        private System.Windows.Forms.RadioButton rdDataVencto;
        private System.Windows.Forms.SaveFileDialog sfdExportToxcel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCentroCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.RadioButton rbVencidasVencer;
        private System.Windows.Forms.Button btnpdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLocalizarDuplicata;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEFORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAEMISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAVECTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATAPAGTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORDUPLICATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORDEVEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMESTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIASATRASO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CENTROCUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMECENTROCUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMETIPODUPLICATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACAO;
    }
}