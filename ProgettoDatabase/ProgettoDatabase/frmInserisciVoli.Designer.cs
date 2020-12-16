
namespace ProgettoDatabase
{
    partial class frmInserisciVoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserisciVoli));
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.btnSalvaENuovo = new System.Windows.Forms.Button();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblPartenza = new System.Windows.Forms.Label();
            this.txtCodiceAereo = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.lblGatePartenza = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDurata = new System.Windows.Forms.Label();
            this.lblCodiceAereo = new System.Windows.Forms.Label();
            this.updDurata = new System.Windows.Forms.NumericUpDown();
            this.updGatePartenza = new System.Windows.Forms.NumericUpDown();
            this.tblVoliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblVoliTableAdapter();
            this.lblDestinazione = new System.Windows.Forms.Label();
            this.txtDestinazione = new System.Windows.Forms.TextBox();
            this.dtpDataArrivo = new System.Windows.Forms.DateTimePicker();
            this.lblDataOraArrivo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDataPartenza = new System.Windows.Forms.DateTimePicker();
            this.lblDataOraPartenza = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblInternazionale = new System.Windows.Forms.Label();
            this.chkInternazionale = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Gold;
            this.btnSalva.Location = new System.Drawing.Point(382, 506);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(137, 43);
            this.btnSalva.TabIndex = 16;
            this.btnSalva.Text = "SALVA E CHIUDI";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(635, 370);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(224, 22);
            this.txtSesso.TabIndex = 17;
            this.txtSesso.Text = "Maschio";
            // 
            // txtDataNascita
            // 
            this.txtDataNascita.Location = new System.Drawing.Point(647, 281);
            this.txtDataNascita.Name = "txtDataNascita";
            this.txtDataNascita.Size = new System.Drawing.Size(224, 22);
            this.txtDataNascita.TabIndex = 18;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(635, 444);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(224, 22);
            this.txtTipoDocumento.TabIndex = 19;
            this.txtTipoDocumento.Text = "Carta identità";
            // 
            // btnSalvaENuovo
            // 
            this.btnSalvaENuovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalvaENuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaENuovo.ForeColor = System.Drawing.Color.Gold;
            this.btnSalvaENuovo.Location = new System.Drawing.Point(140, 506);
            this.btnSalvaENuovo.Name = "btnSalvaENuovo";
            this.btnSalvaENuovo.Size = new System.Drawing.Size(150, 43);
            this.btnSalvaENuovo.TabIndex = 20;
            this.btnSalvaENuovo.Text = "SALVA E NUOVO";
            this.btnSalvaENuovo.UseVisualStyleBackColor = false;
            this.btnSalvaENuovo.Click += new System.EventHandler(this.btnSalvaENuovo_Click);
            // 
            // txtPartenza
            // 
            this.txtPartenza.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Destinazione", true));
            this.txtPartenza.Location = new System.Drawing.Point(272, 229);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.Size = new System.Drawing.Size(265, 22);
            this.txtPartenza.TabIndex = 40;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblVoli";
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            // 
            // lblPartenza
            // 
            this.lblPartenza.AutoSize = true;
            this.lblPartenza.Location = new System.Drawing.Point(79, 229);
            this.lblPartenza.Name = "lblPartenza";
            this.lblPartenza.Size = new System.Drawing.Size(65, 17);
            this.lblPartenza.TabIndex = 39;
            this.lblPartenza.Text = "Partenza";
            // 
            // txtCodiceAereo
            // 
            this.txtCodiceAereo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "CodiceAereo", true));
            this.txtCodiceAereo.Location = new System.Drawing.Point(272, 86);
            this.txtCodiceAereo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodiceAereo.Name = "txtCodiceAereo";
            this.txtCodiceAereo.Size = new System.Drawing.Size(265, 22);
            this.txtCodiceAereo.TabIndex = 30;
            // 
            // txtCodice
            // 
            this.txtCodice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Codice", true));
            this.txtCodice.Location = new System.Drawing.Point(272, 32);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(265, 22);
            this.txtCodice.TabIndex = 29;
            // 
            // lblGatePartenza
            // 
            this.lblGatePartenza.AutoSize = true;
            this.lblGatePartenza.Location = new System.Drawing.Point(78, 190);
            this.lblGatePartenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGatePartenza.Name = "lblGatePartenza";
            this.lblGatePartenza.Size = new System.Drawing.Size(96, 17);
            this.lblGatePartenza.TabIndex = 26;
            this.lblGatePartenza.Text = "GatePartenza";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(77, 35);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(51, 17);
            this.lblCodice.TabIndex = 25;
            this.lblCodice.Text = "Codice";
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(77, 139);
            this.lblDurata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(51, 17);
            this.lblDurata.TabIndex = 24;
            this.lblDurata.Text = "Durata";
            // 
            // lblCodiceAereo
            // 
            this.lblCodiceAereo.AutoSize = true;
            this.lblCodiceAereo.Location = new System.Drawing.Point(77, 86);
            this.lblCodiceAereo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodiceAereo.Name = "lblCodiceAereo";
            this.lblCodiceAereo.Size = new System.Drawing.Size(92, 17);
            this.lblCodiceAereo.TabIndex = 23;
            this.lblCodiceAereo.Text = "Codice aereo";
            // 
            // updDurata
            // 
            this.updDurata.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Durata", true));
            this.updDurata.Location = new System.Drawing.Point(272, 139);
            this.updDurata.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updDurata.Name = "updDurata";
            this.updDurata.Size = new System.Drawing.Size(120, 22);
            this.updDurata.TabIndex = 41;
            // 
            // updGatePartenza
            // 
            this.updGatePartenza.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "GatePartenza", true));
            this.updGatePartenza.Location = new System.Drawing.Point(272, 185);
            this.updGatePartenza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updGatePartenza.Name = "updGatePartenza";
            this.updGatePartenza.Size = new System.Drawing.Size(120, 22);
            this.updGatePartenza.TabIndex = 42;
            // 
            // tblVoliTableAdapter
            // 
            this.tblVoliTableAdapter.ClearBeforeFill = true;
            // 
            // lblDestinazione
            // 
            this.lblDestinazione.AutoSize = true;
            this.lblDestinazione.Location = new System.Drawing.Point(79, 286);
            this.lblDestinazione.Name = "lblDestinazione";
            this.lblDestinazione.Size = new System.Drawing.Size(90, 17);
            this.lblDestinazione.TabIndex = 43;
            this.lblDestinazione.Text = "Destinazione";
            // 
            // txtDestinazione
            // 
            this.txtDestinazione.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Destinazione", true));
            this.txtDestinazione.Location = new System.Drawing.Point(272, 286);
            this.txtDestinazione.Name = "txtDestinazione";
            this.txtDestinazione.Size = new System.Drawing.Size(265, 22);
            this.txtDestinazione.TabIndex = 44;
            // 
            // dtpDataArrivo
            // 
            this.dtpDataArrivo.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtpDataArrivo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "DataOraArrivo", true));
            this.dtpDataArrivo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataArrivo.Location = new System.Drawing.Point(277, 400);
            this.dtpDataArrivo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataArrivo.Name = "dtpDataArrivo";
            this.dtpDataArrivo.Size = new System.Drawing.Size(265, 22);
            this.dtpDataArrivo.TabIndex = 46;
            this.dtpDataArrivo.ValueChanged += new System.EventHandler(this.dtpDataArrivo_ValueChanged);
            // 
            // lblDataOraArrivo
            // 
            this.lblDataOraArrivo.AutoSize = true;
            this.lblDataOraArrivo.Location = new System.Drawing.Point(74, 400);
            this.lblDataOraArrivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataOraArrivo.Name = "lblDataOraArrivo";
            this.lblDataOraArrivo.Size = new System.Drawing.Size(79, 17);
            this.lblDataOraArrivo.TabIndex = 45;
            this.lblDataOraArrivo.Text = "Data Arrivo";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(277, 400);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 47;
            // 
            // dtpDataPartenza
            // 
            this.dtpDataPartenza.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtpDataPartenza.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "DataOraPartenza", true));
            this.dtpDataPartenza.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPartenza.Location = new System.Drawing.Point(278, 333);
            this.dtpDataPartenza.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataPartenza.Name = "dtpDataPartenza";
            this.dtpDataPartenza.Size = new System.Drawing.Size(265, 22);
            this.dtpDataPartenza.TabIndex = 49;
            this.dtpDataPartenza.ValueChanged += new System.EventHandler(this.dtpDataPartenza_ValueChanged);
            // 
            // lblDataOraPartenza
            // 
            this.lblDataOraPartenza.AutoSize = true;
            this.lblDataOraPartenza.Location = new System.Drawing.Point(75, 333);
            this.lblDataOraPartenza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataOraPartenza.Name = "lblDataOraPartenza";
            this.lblDataOraPartenza.Size = new System.Drawing.Size(99, 17);
            this.lblDataOraPartenza.TabIndex = 48;
            this.lblDataOraPartenza.Text = "Data Partenza";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(278, 333);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 22);
            this.textBox2.TabIndex = 50;
            // 
            // lblInternazionale
            // 
            this.lblInternazionale.AutoSize = true;
            this.lblInternazionale.Location = new System.Drawing.Point(77, 452);
            this.lblInternazionale.Name = "lblInternazionale";
            this.lblInternazionale.Size = new System.Drawing.Size(97, 17);
            this.lblInternazionale.TabIndex = 51;
            this.lblInternazionale.Text = "Internazionale";
            // 
            // chkInternazionale
            // 
            this.chkInternazionale.AutoSize = true;
            this.chkInternazionale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "Internazionale", true));
            this.chkInternazionale.Location = new System.Drawing.Point(272, 452);
            this.chkInternazionale.Name = "chkInternazionale";
            this.chkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.chkInternazionale.TabIndex = 52;
            this.chkInternazionale.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInserisciVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 563);
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
            this.Controls.Add(this.btnSalvaENuovo);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.btnSalva);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInserisciVoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserisci Volo";
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updDurata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGatePartenza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalva;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Button btnSalvaENuovo;
        private System.Windows.Forms.TextBox txtPartenza;
        private System.Windows.Forms.Label lblPartenza;
        private System.Windows.Forms.TextBox txtCodiceAereo;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label lblGatePartenza;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Label lblCodiceAereo;
        private System.Windows.Forms.NumericUpDown updDurata;
        private System.Windows.Forms.NumericUpDown updGatePartenza;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSetTableAdapters.tblVoliTableAdapter tblVoliTableAdapter;
        private System.Windows.Forms.Label lblDestinazione;
        private System.Windows.Forms.TextBox txtDestinazione;
        private System.Windows.Forms.DateTimePicker dtpDataArrivo;
        private System.Windows.Forms.Label lblDataOraArrivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpDataPartenza;
        private System.Windows.Forms.Label lblDataOraPartenza;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblInternazionale;
        private System.Windows.Forms.CheckBox chkInternazionale;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}