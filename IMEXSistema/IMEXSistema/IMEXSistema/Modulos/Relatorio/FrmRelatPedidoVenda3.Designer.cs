﻿namespace BmsSoftware.Modulos.Relatorio
{
    partial class FrmRelatPedidoVenda3
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EMPRESACollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ARQUIVOBINARIOCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LIS_CLIENTECollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LIS_PEDIDOCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LIS_PRODUTOSPEDIDOCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LIS_PRODUTOSPEDIDOMTQCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESACollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARQUIVOBINARIOCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_CLIENTECollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_PEDIDOCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_PRODUTOSPEDIDOCollectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_PRODUTOSPEDIDOMTQCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EMPRESACollectionBindingSource
            // 
            this.EMPRESACollectionBindingSource.DataMember = "EMPRESACollection";
            // 
            // ARQUIVOBINARIOCollectionBindingSource
            // 
            this.ARQUIVOBINARIOCollectionBindingSource.DataMember = "ARQUIVOBINARIOCollection";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EMPRESACollectionBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ARQUIVOBINARIOCollectionBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.LIS_CLIENTECollectionBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.LIS_PEDIDOCollectionBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.LIS_PRODUTOSPEDIDOCollectionBindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.LIS_PRODUTOSPEDIDOMTQCollectionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BmsSoftware.Modulos.Relatorio.PedidoVenda3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(952, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // LIS_CLIENTECollectionBindingSource
            // 
            this.LIS_CLIENTECollectionBindingSource.DataSource = typeof(BMSworks.Model.LIS_CLIENTECollection);
            // 
            // LIS_PEDIDOCollectionBindingSource
            // 
            this.LIS_PEDIDOCollectionBindingSource.DataSource = typeof(BMSworks.Model.LIS_PEDIDOCollection);
            // 
            // LIS_PRODUTOSPEDIDOCollectionBindingSource
            // 
            this.LIS_PRODUTOSPEDIDOCollectionBindingSource.DataSource = typeof(BMSworks.Model.LIS_PRODUTOSPEDIDOCollection);
            // 
            // LIS_PRODUTOSPEDIDOMTQCollectionBindingSource
            // 
            this.LIS_PRODUTOSPEDIDOMTQCollectionBindingSource.DataSource = typeof(BMSworks.Model.LIS_PRODUTOSPEDIDOMTQCollection);
            // 
            // FrmRelatPedidoVenda3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatPedidoVenda3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Venda - Modelo 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatPedidoVenda3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMPRESACollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARQUIVOBINARIOCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_CLIENTECollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_PEDIDOCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_PRODUTOSPEDIDOCollectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIS_PRODUTOSPEDIDOMTQCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EMPRESACollectionBindingSource;
        private System.Windows.Forms.BindingSource ARQUIVOBINARIOCollectionBindingSource;
        private System.Windows.Forms.BindingSource LIS_CLIENTECollectionBindingSource;
        private System.Windows.Forms.BindingSource LIS_PEDIDOCollectionBindingSource;
        private System.Windows.Forms.BindingSource LIS_PRODUTOSPEDIDOCollectionBindingSource;
        private System.Windows.Forms.BindingSource LIS_PRODUTOSPEDIDOMTQCollectionBindingSource;
    }
}