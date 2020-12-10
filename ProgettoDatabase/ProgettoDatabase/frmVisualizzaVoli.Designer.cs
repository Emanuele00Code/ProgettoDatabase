
namespace ProgettoDatabase
{
    partial class frmVisualizzaVoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizzaVoli));
            this.chkInternazionale = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.lblInternazionale = new System.Windows.Forms.Label();
            this.dtpDataPartenza = new System.Windows.Forms.DateTimePicker();
            this.lblDataOraPartenza = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtpDataArrivo = new System.Windows.Forms.DateTimePicker();
            this.lblDataOraArrivo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDestinazione = new System.Windows.Forms.TextBox();
            this.lblDestinazione = new System.Windows.Forms.Label();
            this.updGatePartenza = new System.Windows.Forms.NumericUpDown();
            this.updDurata = new System.Windows.Forms.NumericUpDown();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.lblPartenza = new System.Windows.Forms.Label();
            this.txtCodiceAereo = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.lblGatePartenza = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDurata = new System.Windows.Forms.Label();
            this.lblCodiceAereo = new System.Windows.Forms.Label();
            this.tblVoliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblVoliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // chkInternazionale
            // 
            this.chkInternazionale.AutoSize = true;
            this.chkInternazionale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "Internazionale", true));
            this.chkInternazionale.Enabled = false;
            this.chkInternazionale.Location = new System.Drawing.Point(268, 426);
            this.chkInternazionale.Name = "chkInternazionale";
            this.chkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.chkInternazionale.TabIndex = 94;
            this.chkInternazionale.UseVisualStyleBackColor = true;
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
            // lblInternazionale
            // 
            this.lblInternazionale.AutoSize = true;
            this.lblInternazionale.Location = new System.Drawing.Point(73, 426);
            this.lblInternazionale.Name = "lblInternazionale";
            this.lblInternazionale.Size = new System.Drawing.Size(97, 17);
            this.lblInternazionale.TabIndex = 93;
            this.lblInternazionale.Text = "Internazionale";
            // 
            // dtpDataPartenza
            // 
            this.dtpDataPartenza.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "DataOraPartenza", true));
            this.dtpDataPartenza.Enabled = false;
            this.dtpDataPartenza.Location = new System.Drawing.Point(274, 307);
            this.dtpDataPartenza.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataPartenza.Name = "dtpDataPartenza";
            this.dtpDataPartenza.Size = new System.Drawing.Size(265, 22);
            this.dtpDataPartenza.TabIndex = 91;
            // 
            // lblDataOraPartenza
            // 
            this.lblDataOraPartenza.AutoSize = true;
            this.lblDataOraPartenza.Location = new System.Drawing.Point(71, 307);
            this.lblDataOraPartenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataOraPartenza.Name = "lblDataOraPartenza";
            this.lblDataOraPartenza.Size = new System.Drawing.Size(99, 17);
            this.lblDataOraPartenza.TabIndex = 90;
            this.lblDataOraPartenza.Text = "Data Partenza";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(274, 307);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 22);
            this.textBox2.TabIndex = 92;
            // 
            // dtpDataArrivo
            // 
            this.dtpDataArrivo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "DataOraArrivo", true));
            this.dtpDataArrivo.Enabled = false;
            this.dtpDataArrivo.Location = new System.Drawing.Point(273, 374);
            this.dtpDataArrivo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataArrivo.Name = "dtpDataArrivo";
            this.dtpDataArrivo.Size = new System.Drawing.Size(265, 22);
            this.dtpDataArrivo.TabIndex = 88;
            // 
            // lblDataOraArrivo
            // 
            this.lblDataOraArrivo.AutoSize = true;
            this.lblDataOraArrivo.Location = new System.Drawing.Point(70, 374);
            this.lblDataOraArrivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataOraArrivo.Name = "lblDataOraArrivo";
            this.lblDataOraArrivo.Size = new System.Drawing.Size(79, 17);
            this.lblDataOraArrivo.TabIndex = 87;
            this.lblDataOraArrivo.Text = "Data Arrivo";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(273, 374);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 89;
            // 
            // txtDestinazione
            // 
            this.txtDestinazione.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Destinazione", true));
            this.txtDestinazione.Location = new System.Drawing.Point(268, 260);
            this.txtDestinazione.Name = "txtDestinazione";
            this.txtDestinazione.ReadOnly = true;
            this.txtDestinazione.Size = new System.Drawing.Size(265, 22);
            this.txtDestinazione.TabIndex = 86;
            // 
            // lblDestinazione
            // 
            this.lblDestinazione.AutoSize = true;
            this.lblDestinazione.Location = new System.Drawing.Point(75, 260);
            this.lblDestinazione.Name = "lblDestinazione";
            this.lblDestinazione.Size = new System.Drawing.Size(90, 17);
            this.lblDestinazione.TabIndex = 85;
            this.lblDestinazione.Text = "Destinazione";
            // 
            // updGatePartenza
            // 
            this.updGatePartenza.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "GatePartenza", true));
            this.updGatePartenza.Location = new System.Drawing.Point(268, 159);
            this.updGatePartenza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updGatePartenza.Name = "updGatePartenza";
            this.updGatePartenza.ReadOnly = true;
            this.updGatePartenza.Size = new System.Drawing.Size(120, 22);
            this.updGatePartenza.TabIndex = 84;
            // 
            // updDurata
            // 
            this.updDurata.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Durata", true));
            this.updDurata.Location = new System.Drawing.Point(268, 113);
            this.updDurata.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updDurata.Name = "updDurata";
            this.updDurata.ReadOnly = true;
            this.updDurata.Size = new System.Drawing.Size(120, 22);
            this.updDurata.TabIndex = 83;
            // 
            // txtPartenza
            // 
            this.txtPartenza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Partenza", true));
            this.txtPartenza.Location = new System.Drawing.Point(268, 203);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.ReadOnly = true;
            this.txtPartenza.Size = new System.Drawing.Size(265, 22);
            this.txtPartenza.TabIndex = 82;
            // 
            // lblPartenza
            // 
            this.lblPartenza.AutoSize = true;
            this.lblPartenza.Location = new System.Drawing.Point(75, 203);
            this.lblPartenza.Name = "lblPartenza";
            this.lblPartenza.Size = new System.Drawing.Size(65, 17);
            this.lblPartenza.TabIndex = 81;
            this.lblPartenza.Text = "Partenza";
            // 
            // txtCodiceAereo
            // 
            this.txtCodiceAereo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CodiceAereo", true));
            this.txtCodiceAereo.Location = new System.Drawing.Point(268, 60);
            this.txtCodiceAereo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodiceAereo.Name = "txtCodiceAereo";
            this.txtCodiceAereo.ReadOnly = true;
            this.txtCodiceAereo.Size = new System.Drawing.Size(265, 22);
            this.txtCodiceAereo.TabIndex = 80;
            // 
            // txtCodice
            // 
            this.txtCodice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Codice", true));
            this.txtCodice.Location = new System.Drawing.Point(268, 6);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.ReadOnly = true;
            this.txtCodice.Size = new System.Drawing.Size(265, 22);
            this.txtCodice.TabIndex = 79;
            // 
            // lblGatePartenza
            // 
            this.lblGatePartenza.AutoSize = true;
            this.lblGatePartenza.Location = new System.Drawing.Point(74, 164);
            this.lblGatePartenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGatePartenza.Name = "lblGatePartenza";
            this.lblGatePartenza.Size = new System.Drawing.Size(96, 17);
            this.lblGatePartenza.TabIndex = 78;
            this.lblGatePartenza.Text = "GatePartenza";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(73, 9);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(51, 17);
            this.lblCodice.TabIndex = 77;
            this.lblCodice.Text = "Codice";
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(73, 113);
            this.lblDurata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(51, 17);
            this.lblDurata.TabIndex = 76;
            this.lblDurata.Text = "Durata";
            // 
            // lblCodiceAereo
            // 
            this.lblCodiceAereo.AutoSize = true;
            this.lblCodiceAereo.Location = new System.Drawing.Point(73, 60);
            this.lblCodiceAereo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodiceAereo.Name = "lblCodiceAereo";
            this.lblCodiceAereo.Size = new System.Drawing.Size(92, 17);
            this.lblCodiceAereo.TabIndex = 75;
            this.lblCodiceAereo.Text = "Codice aereo";
            // 
            // tblVoliTableAdapter
            // 
            this.tblVoliTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizzaVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 489);
            this.Controls.Add(this.chkInternazionale);
            this.Controls.Add(this.lblInternazionale);
            this.Controls.Add(this.dtpDataPartenza);
            this.Controls.Add(this.lblDataOraPartenza);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtpDataArrivo);
            this.Controls.Add(this.lblDataOraArrivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDestinazione);
            this.Controls.Add(this.lblDestinazione);
            this.Controls.Add(this.updGatePartenza);
            this.Controls.Add(this.updDurata);
            this.Controls.Add(this.txtPartenza);
            this.Controls.Add(this.lblPartenza);
            this.Controls.Add(this.txtCodiceAereo);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.lblGatePartenza);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.lblDurata);
            this.Controls.Add(this.lblCodiceAereo);
            this.Name = "frmVisualizzaVoli";
            this.Text = "frmVisualizzaVoli";
            this.Load += new System.EventHandler(this.frmVisualizzaVoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkInternazionale;
        private System.Windows.Forms.Label lblInternazionale;
        private System.Windows.Forms.DateTimePicker dtpDataPartenza;
        private System.Windows.Forms.Label lblDataOraPartenza;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtpDataArrivo;
        private System.Windows.Forms.Label lblDataOraArrivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDestinazione;
        private System.Windows.Forms.Label lblDestinazione;
        private System.Windows.Forms.NumericUpDown updGatePartenza;
        private System.Windows.Forms.NumericUpDown updDurata;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.Label lblPartenza;
        private System.Windows.Forms.TextBox txtCodiceAereo;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label lblGatePartenza;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Label lblCodiceAereo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSet aeroportoDataSet;
        private AeroportoDataSetTableAdapters.tblVoliTableAdapter tblVoliTableAdapter;
    }
}