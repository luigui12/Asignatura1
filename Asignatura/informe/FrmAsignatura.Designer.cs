namespace Asignatura.informe
{
    partial class FrmAsignatura
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
            this.dsAsignatura = new Asignatura.ds.dsAsignatura();
            this.asignaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturaTableAdapter = new Asignatura.ds.dsAsignaturaTableAdapters.AsignaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsAsignatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.asignaturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Asignatura.informe.Asignatura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(799, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsAsignatura
            // 
            this.dsAsignatura.DataSetName = "dsAsignatura";
            this.dsAsignatura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignaturaBindingSource
            // 
            this.asignaturaBindingSource.DataMember = "Asignatura";
            this.asignaturaBindingSource.DataSource = this.dsAsignatura;
            // 
            // asignaturaTableAdapter
            // 
            this.asignaturaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 389);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmAsignatura";
            this.Text = "FrmAsignatura";
            this.Load += new System.EventHandler(this.FrmAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAsignatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ds.dsAsignatura dsAsignatura;
        private System.Windows.Forms.BindingSource asignaturaBindingSource;
        private ds.dsAsignaturaTableAdapters.AsignaturaTableAdapter asignaturaTableAdapter;
    }
}