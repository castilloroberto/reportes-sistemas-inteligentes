
namespace ReportesSistemasInteligentes
{
    partial class ReporteProductos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemasIDBDataSet = new ReportesSistemasInteligentes.SistemasIDBDataSet();
            this.sp_rptProductrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_rptProductrosTableAdapter = new ReportesSistemasInteligentes.SistemasIDBDataSetTableAdapters.sp_rptProductrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemasIDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rptProductrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_rptProductrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesSistemasInteligentes.RPTGeneral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1395, 723);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemasIDBDataSet
            // 
            this.SistemasIDBDataSet.DataSetName = "SistemasIDBDataSet";
            this.SistemasIDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_rptProductrosBindingSource
            // 
            this.sp_rptProductrosBindingSource.DataMember = "sp_rptProductros";
            this.sp_rptProductrosBindingSource.DataSource = this.SistemasIDBDataSet;
            // 
            // sp_rptProductrosTableAdapter
            // 
            this.sp_rptProductrosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 723);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReporteProductos";
            this.Load += new System.EventHandler(this.ReporteProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemasIDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_rptProductrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_rptProductrosBindingSource;
        private SistemasIDBDataSet SistemasIDBDataSet;
        private SistemasIDBDataSetTableAdapters.sp_rptProductrosTableAdapter sp_rptProductrosTableAdapter;
    }
}