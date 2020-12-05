
namespace TestDatabase
{
    partial class frmInserisciPersona
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblNazione = new System.Windows.Forms.Label();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.tblPersoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new TestDatabase.AeroportoDataSet();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNazione = new System.Windows.Forms.TextBox();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.grpSesso = new System.Windows.Forms.GroupBox();
            this.radNonSpecificato = new System.Windows.Forms.RadioButton();
            this.radAltro = new System.Windows.Forms.RadioButton();
            this.radFemmina = new System.Windows.Forms.RadioButton();
            this.radMaschio = new System.Windows.Forms.RadioButton();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tblTipiDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.tblTipiDocumentoTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.tblTipiDocumentoTableAdapter();
            this.tblPersoneTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.tblPersoneTableAdapter();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.btnSalvaENuovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            this.grpSesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipiDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(67, 124);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(67, 177);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(68, 17);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
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
            // lblNazione
            // 
            this.lblNazione.AutoSize = true;
            this.lblNazione.Location = new System.Drawing.Point(68, 228);
            this.lblNazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazione.Name = "lblNazione";
            this.lblNazione.Size = new System.Drawing.Size(60, 17);
            this.lblNazione.TabIndex = 5;
            this.lblNazione.Text = "Nazione";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Location = new System.Drawing.Point(68, 279);
            this.lblDataNascita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(87, 17);
            this.lblDataNascita.TabIndex = 3;
            this.lblDataNascita.Text = "Data nascita";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(67, 603);
            this.lblNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(132, 17);
            this.lblNumeroDocumento.TabIndex = 7;
            this.lblNumeroDocumento.Text = "Numero documento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(67, 544);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(110, 17);
            this.lblTipoDocumento.TabIndex = 6;
            this.lblTipoDocumento.Text = "Tipo documento";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(271, 64);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(265, 22);
            this.txtCodice.TabIndex = 8;
            // 
            // tblPersoneBindingSource
            // 
            this.tblPersoneBindingSource.DataMember = "tblPersone";
            this.tblPersoneBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(271, 121);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 22);
            this.txtNome.TabIndex = 9;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(271, 174);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(4);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(265, 22);
            this.txtCognome.TabIndex = 10;
            // 
            // txtNazione
            // 
            this.txtNazione.Location = new System.Drawing.Point(271, 228);
            this.txtNazione.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.Size = new System.Drawing.Size(265, 22);
            this.txtNazione.TabIndex = 11;
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(271, 279);
            this.dtpDataNascita.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(265, 22);
            this.dtpDataNascita.TabIndex = 12;
            this.dtpDataNascita.ValueChanged += new System.EventHandler(this.dtpDataNascita_ValueChanged);
            // 
            // grpSesso
            // 
            this.grpSesso.Controls.Add(this.radNonSpecificato);
            this.grpSesso.Controls.Add(this.radAltro);
            this.grpSesso.Controls.Add(this.radFemmina);
            this.grpSesso.Controls.Add(this.radMaschio);
            this.grpSesso.Location = new System.Drawing.Point(71, 340);
            this.grpSesso.Margin = new System.Windows.Forms.Padding(4);
            this.grpSesso.Name = "grpSesso";
            this.grpSesso.Padding = new System.Windows.Forms.Padding(4);
            this.grpSesso.Size = new System.Drawing.Size(467, 159);
            this.grpSesso.TabIndex = 13;
            this.grpSesso.TabStop = false;
            this.grpSesso.Text = "Sesso";
            // 
            // radNonSpecificato
            // 
            this.radNonSpecificato.AutoSize = true;
            this.radNonSpecificato.Location = new System.Drawing.Point(255, 94);
            this.radNonSpecificato.Margin = new System.Windows.Forms.Padding(4);
            this.radNonSpecificato.Name = "radNonSpecificato";
            this.radNonSpecificato.Size = new System.Drawing.Size(126, 21);
            this.radNonSpecificato.TabIndex = 3;
            this.radNonSpecificato.Text = "Non specificato";
            this.radNonSpecificato.UseVisualStyleBackColor = true;
            this.radNonSpecificato.CheckedChanged += new System.EventHandler(this.radNonSpecificato_CheckedChanged);
            // 
            // radAltro
            // 
            this.radAltro.AutoSize = true;
            this.radAltro.Location = new System.Drawing.Point(255, 42);
            this.radAltro.Margin = new System.Windows.Forms.Padding(4);
            this.radAltro.Name = "radAltro";
            this.radAltro.Size = new System.Drawing.Size(58, 21);
            this.radAltro.TabIndex = 2;
            this.radAltro.Text = "Altro";
            this.radAltro.UseVisualStyleBackColor = true;
            this.radAltro.CheckedChanged += new System.EventHandler(this.radAltro_CheckedChanged);
            // 
            // radFemmina
            // 
            this.radFemmina.AutoSize = true;
            this.radFemmina.Location = new System.Drawing.Point(29, 94);
            this.radFemmina.Margin = new System.Windows.Forms.Padding(4);
            this.radFemmina.Name = "radFemmina";
            this.radFemmina.Size = new System.Drawing.Size(86, 21);
            this.radFemmina.TabIndex = 1;
            this.radFemmina.Text = "Femmina";
            this.radFemmina.UseVisualStyleBackColor = true;
            this.radFemmina.CheckedChanged += new System.EventHandler(this.radFemmina_CheckedChanged);
            // 
            // radMaschio
            // 
            this.radMaschio.AutoSize = true;
            this.radMaschio.Checked = true;
            this.radMaschio.Location = new System.Drawing.Point(29, 42);
            this.radMaschio.Margin = new System.Windows.Forms.Padding(4);
            this.radMaschio.Name = "radMaschio";
            this.radMaschio.Size = new System.Drawing.Size(81, 21);
            this.radMaschio.TabIndex = 0;
            this.radMaschio.TabStop = true;
            this.radMaschio.Text = "Maschio";
            this.radMaschio.UseVisualStyleBackColor = true;
            this.radMaschio.CheckedChanged += new System.EventHandler(this.radMaschio_CheckedChanged);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DataSource = this.tblTipiDocumentoBindingSource;
            this.cmbTipoDocumento.DisplayMember = "TipoDocumento";
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(271, 544);
            this.cmbTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(265, 24);
            this.cmbTipoDocumento.TabIndex = 14;
            this.cmbTipoDocumento.ValueMember = "TipoDocumento";
            this.cmbTipoDocumento.SelectionChangeCommitted += new System.EventHandler(this.cmbTipoDocumento_SelectionChangeCommitted);
            // 
            // tblTipiDocumentoBindingSource
            // 
            this.tblTipiDocumentoBindingSource.DataMember = "tblTipiDocumento";
            this.tblTipiDocumentoBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(271, 599);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(265, 22);
            this.txtNumeroDocumento.TabIndex = 15;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(400, 682);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(137, 43);
            this.btnSalva.TabIndex = 16;
            this.btnSalva.Text = "SALVA E CHIUDI";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // tblTipiDocumentoTableAdapter
            // 
            this.tblTipiDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // tblPersoneTableAdapter
            // 
            this.tblPersoneTableAdapter.ClearBeforeFill = true;
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
            this.btnSalvaENuovo.Location = new System.Drawing.Point(158, 682);
            this.btnSalvaENuovo.Name = "btnSalvaENuovo";
            this.btnSalvaENuovo.Size = new System.Drawing.Size(150, 43);
            this.btnSalvaENuovo.TabIndex = 20;
            this.btnSalvaENuovo.Text = "SALVA E NUOVO";
            this.btnSalvaENuovo.UseVisualStyleBackColor = true;
            this.btnSalvaENuovo.Click += new System.EventHandler(this.btnSalvaENuovo_Click);
            // 
            // frmInserisciPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 779);
            this.Controls.Add(this.btnSalvaENuovo);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.grpSesso);
            this.Controls.Add(this.dtpDataNascita);
            this.Controls.Add(this.txtNazione);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNazione);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.lblCodice);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInserisciPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserisci persona";
            this.Load += new System.EventHandler(this.frmInserisciPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            this.grpSesso.ResumeLayout(false);
            this.grpSesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipiDocumentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.Label lblNazione;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.GroupBox grpSesso;
        private System.Windows.Forms.RadioButton radNonSpecificato;
        private System.Windows.Forms.RadioButton radAltro;
        private System.Windows.Forms.RadioButton radFemmina;
        private System.Windows.Forms.RadioButton radMaschio;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Button btnSalva;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblTipiDocumentoBindingSource;
        private AeroportoDataSetTableAdapters.tblTipiDocumentoTableAdapter tblTipiDocumentoTableAdapter;
        private System.Windows.Forms.BindingSource tblPersoneBindingSource;
        private AeroportoDataSetTableAdapters.tblPersoneTableAdapter tblPersoneTableAdapter;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Button btnSalvaENuovo;
    }
}