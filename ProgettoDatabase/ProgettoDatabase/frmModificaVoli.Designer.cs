
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
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblGatePartenza = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtCodiceAereo = new System.Windows.Forms.TextBox();
            this.lblPartenza = new System.Windows.Forms.Label();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.updGatePartenza = new System.Windows.Forms.NumericUpDown();
            this.updDurata = new System.Windows.Forms.NumericUpDown();
            this.btnSalva = new System.Windows.Forms.Button();
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblVoliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblVoliTableAdapter();
            this.txtDestinazione = new System.Windows.Forms.TextBox();
            this.lblDestinazione = new System.Windows.Forms.Label();
            this.Internazionale = new System.Windows.Forms.Label();
            this.chkInternazionale = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataPartenza = new System.Windows.Forms.DateTimePicker();
            this.dtpDataArrivo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodiceAereo
            // 
            this.lblCodiceAereo.AutoSize = true;
            this.lblCodiceAereo.Location = new System.Drawing.Point(67, 124);
            this.lblCodiceAereo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodiceAereo.Name = "lblCodiceAereo";
            this.lblCodiceAereo.Size = new System.Drawing.Size(92, 17);
            this.lblCodiceAereo.TabIndex = 0;
            this.lblCodiceAereo.Text = "Codice aereo";
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(67, 283);
            this.lblDurata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(51, 17);
            this.lblDurata.TabIndex = 1;
            this.lblDurata.Text = "Durata";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(67, 73);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(51, 17);
            this.lblCodice.TabIndex = 2;
            this.lblCodice.Text = "Codice";
            // 
            // lblGatePartenza
            // 
            this.lblGatePartenza.AutoSize = true;
            this.lblGatePartenza.Location = new System.Drawing.Point(68, 334);
            this.lblGatePartenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGatePartenza.Name = "lblGatePartenza";
            this.lblGatePartenza.Size = new System.Drawing.Size(99, 17);
            this.lblGatePartenza.TabIndex = 5;
            this.lblGatePartenza.Text = "Gate partenza";
            // 
            // txtCodice
            // 
            this.txtCodice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Codice", true));
            this.txtCodice.Location = new System.Drawing.Point(262, 70);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(265, 22);
            this.txtCodice.TabIndex = 8;
            // 
            // txtCodiceAereo
            // 
            this.txtCodiceAereo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CodiceAereo", true));
            this.txtCodiceAereo.Location = new System.Drawing.Point(262, 124);
            this.txtCodiceAereo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodiceAereo.Name = "txtCodiceAereo";
            this.txtCodiceAereo.Size = new System.Drawing.Size(265, 22);
            this.txtCodiceAereo.TabIndex = 9;
            // 
            // lblPartenza
            // 
            this.lblPartenza.AutoSize = true;
            this.lblPartenza.Location = new System.Drawing.Point(66, 179);
            this.lblPartenza.Name = "lblPartenza";
            this.lblPartenza.Size = new System.Drawing.Size(132, 17);
            this.lblPartenza.TabIndex = 21;
            this.lblPartenza.Text = "Aeroporto Partenza";
            // 
            // txtPartenza
            // 
            this.txtPartenza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Partenza", true));
            this.txtPartenza.Location = new System.Drawing.Point(262, 174);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.Size = new System.Drawing.Size(265, 22);
            this.txtPartenza.TabIndex = 22;
            // 
            // updGatePartenza
            // 
            this.updGatePartenza.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "GatePartenza", true));
            this.updGatePartenza.Location = new System.Drawing.Point(262, 324);
            this.updGatePartenza.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updGatePartenza.Name = "updGatePartenza";
            this.updGatePartenza.Size = new System.Drawing.Size(120, 22);
            this.updGatePartenza.TabIndex = 45;
            // 
            // updDurata
            // 
            this.updDurata.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Durata", true));
            this.updDurata.Location = new System.Drawing.Point(262, 278);
            this.updDurata.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updDurata.Name = "updDurata";
            this.updDurata.Size = new System.Drawing.Size(120, 22);
            this.updDurata.TabIndex = 44;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Gold;
            this.btnSalva.Location = new System.Drawing.Point(495, 349);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(158, 60);
            this.btnSalva.TabIndex = 47;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblVoli";
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            // 
            // tblVoliTableAdapter
            // 
            this.tblVoliTableAdapter.ClearBeforeFill = true;
            // 
            // txtDestinazione
            // 
            this.txtDestinazione.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Destinazione", true));
            this.txtDestinazione.Location = new System.Drawing.Point(261, 223);
            this.txtDestinazione.Name = "txtDestinazione";
            this.txtDestinazione.Size = new System.Drawing.Size(265, 22);
            this.txtDestinazione.TabIndex = 49;
            // 
            // lblDestinazione
            // 
            this.lblDestinazione.AutoSize = true;
            this.lblDestinazione.Location = new System.Drawing.Point(67, 228);
            this.lblDestinazione.Name = "lblDestinazione";
            this.lblDestinazione.Size = new System.Drawing.Size(157, 17);
            this.lblDestinazione.TabIndex = 48;
            this.lblDestinazione.Text = "Aeroporto Destinazione";
            // 
            // Internazionale
            // 
            this.Internazionale.AutoSize = true;
            this.Internazionale.Location = new System.Drawing.Point(71, 392);
            this.Internazionale.Name = "Internazionale";
            this.Internazionale.Size = new System.Drawing.Size(97, 17);
            this.Internazionale.TabIndex = 50;
            this.Internazionale.Text = "Internazionale";
            // 
            // chkInternazionale
            // 
            this.chkInternazionale.AutoSize = true;
            this.chkInternazionale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "Internazionale", true));
            this.chkInternazionale.Location = new System.Drawing.Point(261, 392);
            this.chkInternazionale.Name = "chkInternazionale";
            this.chkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.chkInternazionale.TabIndex = 51;
            this.chkInternazionale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Data Partenza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Data Arrivo";
            // 
            // dtpDataPartenza
            // 
            this.dtpDataPartenza.Location = new System.Drawing.Point(262, 468);
            this.dtpDataPartenza.Name = "dtpDataPartenza";
            this.dtpDataPartenza.Size = new System.Drawing.Size(200, 22);
            this.dtpDataPartenza.TabIndex = 54;
            // 
            // dtpDataArrivo
            // 
            this.dtpDataArrivo.Location = new System.Drawing.Point(261, 514);
            this.dtpDataArrivo.Name = "dtpDataArrivo";
            this.dtpDataArrivo.Size = new System.Drawing.Size(200, 22);
            this.dtpDataArrivo.TabIndex = 55;
            // 
            // frmModificaVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 633);
            this.Controls.Add(this.dtpDataArrivo);
            this.Controls.Add(this.dtpDataPartenza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkInternazionale);
            this.Controls.Add(this.Internazionale);
            this.Controls.Add(this.txtDestinazione);
            this.Controls.Add(this.lblDestinazione);
            this.Controls.Add(this.btnSalva);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificaVoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizza Voli";
            this.Load += new System.EventHandler(this.frmModificaVoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodiceAereo;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label lblGatePartenza;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtCodiceAereo;
        private System.Windows.Forms.Label lblPartenza;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.NumericUpDown updGatePartenza;
        private System.Windows.Forms.NumericUpDown updDurata;
        private System.Windows.Forms.Button btnSalva;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSetTableAdapters.tblVoliTableAdapter tblVoliTableAdapter;
        private System.Windows.Forms.TextBox txtDestinazione;
        private System.Windows.Forms.Label lblDestinazione;
        private System.Windows.Forms.Label Internazionale;
        private System.Windows.Forms.CheckBox chkInternazionale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataPartenza;
        private System.Windows.Forms.DateTimePicker dtpDataArrivo;
    }
}