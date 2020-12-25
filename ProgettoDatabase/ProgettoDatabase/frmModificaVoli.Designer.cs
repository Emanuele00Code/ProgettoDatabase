
namespace ProgettoDatabase
{
    partial class frmModificaVoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificaVoli));
            this.lblCodiceAereo = new System.Windows.Forms.Label();
            this.lblDurata = new System.Windows.Forms.Label();
            this.lblGatePartenza = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.txtCodiceAereo = new System.Windows.Forms.TextBox();
            this.lblPartenza = new System.Windows.Forms.Label();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.updGatePartenza = new System.Windows.Forms.NumericUpDown();
            this.updDurata = new System.Windows.Forms.NumericUpDown();
            this.btnSalva = new System.Windows.Forms.Button();
            this.tblVoliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblVoliTableAdapter();
            this.Internazionale = new System.Windows.Forms.Label();
            this.chkInternazionale = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataPartenza = new System.Windows.Forms.DateTimePicker();
            this.dtpDataArrivo = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbPartenza = new System.Windows.Forms.ComboBox();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAereiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAereiTableAdapter();
            this.cmbCodiceAereo = new System.Windows.Forms.ComboBox();
            this.tblAeroportiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAeroportiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodiceAereo
            // 
            this.lblCodiceAereo.AutoSize = true;
            this.lblCodiceAereo.Location = new System.Drawing.Point(62, 55);
            this.lblCodiceAereo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodiceAereo.Name = "lblCodiceAereo";
            this.lblCodiceAereo.Size = new System.Drawing.Size(92, 17);
            this.lblCodiceAereo.TabIndex = 0;
            this.lblCodiceAereo.Text = "Codice aereo";
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(62, 166);
            this.lblDurata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(51, 17);
            this.lblDurata.TabIndex = 1;
            this.lblDurata.Text = "Durata";
            // 
            // lblGatePartenza
            // 
            this.lblGatePartenza.AutoSize = true;
            this.lblGatePartenza.Location = new System.Drawing.Point(63, 217);
            this.lblGatePartenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGatePartenza.Name = "lblGatePartenza";
            this.lblGatePartenza.Size = new System.Drawing.Size(99, 17);
            this.lblGatePartenza.TabIndex = 5;
            this.lblGatePartenza.Text = "Gate partenza";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblVoli";
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCodiceAereo
            // 
            this.txtCodiceAereo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CodiceAereo", true));
            this.txtCodiceAereo.Location = new System.Drawing.Point(258, 13);
            this.txtCodiceAereo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodiceAereo.Name = "txtCodiceAereo";
            this.txtCodiceAereo.Size = new System.Drawing.Size(265, 22);
            this.txtCodiceAereo.TabIndex = 9;
            // 
            // lblPartenza
            // 
            this.lblPartenza.AutoSize = true;
            this.lblPartenza.Location = new System.Drawing.Point(61, 110);
            this.lblPartenza.Name = "lblPartenza";
            this.lblPartenza.Size = new System.Drawing.Size(132, 17);
            this.lblPartenza.TabIndex = 21;
            this.lblPartenza.Text = "Aeroporto Partenza";
            // 
            // txtPartenza
            // 
            this.txtPartenza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Partenza", true));
            this.txtPartenza.Location = new System.Drawing.Point(256, 85);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.Size = new System.Drawing.Size(265, 22);
            this.txtPartenza.TabIndex = 22;
            // 
            // updGatePartenza
            // 
            this.updGatePartenza.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "GatePartenza", true));
            this.updGatePartenza.Location = new System.Drawing.Point(257, 207);
            this.updGatePartenza.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updGatePartenza.Name = "updGatePartenza";
            this.updGatePartenza.Size = new System.Drawing.Size(120, 22);
            this.updGatePartenza.TabIndex = 45;
            this.updGatePartenza.ValueChanged += new System.EventHandler(this.updGatePartenza_ValueChanged);
            // 
            // updDurata
            // 
            this.updDurata.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Durata", true));
            this.updDurata.Enabled = false;
            this.updDurata.Location = new System.Drawing.Point(257, 161);
            this.updDurata.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updDurata.Name = "updDurata";
            this.updDurata.ReadOnly = true;
            this.updDurata.Size = new System.Drawing.Size(120, 22);
            this.updDurata.TabIndex = 44;
            this.updDurata.ValueChanged += new System.EventHandler(this.updDurata_ValueChanged);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.White;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Black;
            this.btnSalva.Location = new System.Drawing.Point(257, 473);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(158, 60);
            this.btnSalva.TabIndex = 47;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // tblVoliTableAdapter
            // 
            this.tblVoliTableAdapter.ClearBeforeFill = true;
            // 
            // Internazionale
            // 
            this.Internazionale.AutoSize = true;
            this.Internazionale.Location = new System.Drawing.Point(66, 275);
            this.Internazionale.Name = "Internazionale";
            this.Internazionale.Size = new System.Drawing.Size(97, 17);
            this.Internazionale.TabIndex = 50;
            this.Internazionale.Text = "Internazionale";
            // 
            // chkInternazionale
            // 
            this.chkInternazionale.AutoSize = true;
            this.chkInternazionale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "Internazionale", true));
            this.chkInternazionale.Location = new System.Drawing.Point(256, 275);
            this.chkInternazionale.Name = "chkInternazionale";
            this.chkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.chkInternazionale.TabIndex = 51;
            this.chkInternazionale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Data Partenza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Data Arrivo";
            // 
            // dtpDataPartenza
            // 
            this.dtpDataPartenza.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDataPartenza.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "DataOraPartenza", true));
            this.dtpDataPartenza.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPartenza.Location = new System.Drawing.Point(257, 351);
            this.dtpDataPartenza.Name = "dtpDataPartenza";
            this.dtpDataPartenza.Size = new System.Drawing.Size(200, 22);
            this.dtpDataPartenza.TabIndex = 54;
            this.dtpDataPartenza.ValueChanged += new System.EventHandler(this.dtpDataPartenza_ValueChanged);
            // 
            // dtpDataArrivo
            // 
            this.dtpDataArrivo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpDataArrivo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "DataOraArrivo", true));
            this.dtpDataArrivo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataArrivo.Location = new System.Drawing.Point(256, 397);
            this.dtpDataArrivo.Name = "dtpDataArrivo";
            this.dtpDataArrivo.Size = new System.Drawing.Size(200, 22);
            this.dtpDataArrivo.TabIndex = 55;
            this.dtpDataArrivo.ValueChanged += new System.EventHandler(this.dtpDataArrivo_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // cmbPartenza
            // 
            this.cmbPartenza.DataSource = this.bindingSource3;
            this.cmbPartenza.DisplayMember = "Sigla";
            this.cmbPartenza.FormattingEnabled = true;
            this.cmbPartenza.Location = new System.Drawing.Point(255, 113);
            this.cmbPartenza.Name = "cmbPartenza";
            this.cmbPartenza.Size = new System.Drawing.Size(265, 24);
            this.cmbPartenza.TabIndex = 57;
            this.cmbPartenza.ValueMember = "Sigla";
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "tblAeroporti";
            this.bindingSource3.DataSource = this.aeroportoDataSet;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tblAerei";
            this.bindingSource2.DataSource = this.aeroportoDataSet;
            // 
            // tblAereiTableAdapter
            // 
            this.tblAereiTableAdapter.ClearBeforeFill = true;
            // 
            // cmbCodiceAereo
            // 
            this.cmbCodiceAereo.DataSource = this.bindingSource2;
            this.cmbCodiceAereo.DisplayMember = "CodiceAereo";
            this.cmbCodiceAereo.FormattingEnabled = true;
            this.cmbCodiceAereo.Location = new System.Drawing.Point(255, 55);
            this.cmbCodiceAereo.Name = "cmbCodiceAereo";
            this.cmbCodiceAereo.Size = new System.Drawing.Size(266, 24);
            this.cmbCodiceAereo.TabIndex = 58;
            this.cmbCodiceAereo.ValueMember = "CodiceAereo";
            // 
            // tblAeroportiTableAdapter
            // 
            this.tblAeroportiTableAdapter.ClearBeforeFill = true;
            // 
            // frmModificaVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 592);
            this.Controls.Add(this.cmbCodiceAereo);
            this.Controls.Add(this.cmbPartenza);
            this.Controls.Add(this.dtpDataArrivo);
            this.Controls.Add(this.dtpDataPartenza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkInternazionale);
            this.Controls.Add(this.Internazionale);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.updGatePartenza);
            this.Controls.Add(this.updDurata);
            this.Controls.Add(this.txtPartenza);
            this.Controls.Add(this.lblPartenza);
            this.Controls.Add(this.txtCodiceAereo);
            this.Controls.Add(this.lblGatePartenza);
            this.Controls.Add(this.lblDurata);
            this.Controls.Add(this.lblCodiceAereo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificaVoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Voli";
            this.Load += new System.EventHandler(this.frmModificaVoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodiceAereo;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Label lblGatePartenza;
        private System.Windows.Forms.TextBox txtCodiceAereo;
        private System.Windows.Forms.Label lblPartenza;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.NumericUpDown updGatePartenza;
        private System.Windows.Forms.NumericUpDown updDurata;
        private System.Windows.Forms.Button btnSalva;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSetTableAdapters.tblVoliTableAdapter tblVoliTableAdapter;
        private System.Windows.Forms.Label Internazionale;
        private System.Windows.Forms.CheckBox chkInternazionale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataPartenza;
        private System.Windows.Forms.DateTimePicker dtpDataArrivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ComboBox cmbPartenza;
        private System.Windows.Forms.BindingSource bindingSource2;
        private AeroportoDataSetTableAdapters.tblAereiTableAdapter tblAereiTableAdapter;
        private System.Windows.Forms.ComboBox cmbCodiceAereo;
        private System.Windows.Forms.BindingSource bindingSource3;
        private AeroportoDataSetTableAdapters.tblAeroportiTableAdapter tblAeroportiTableAdapter;
    }
}