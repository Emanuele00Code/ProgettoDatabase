﻿
namespace TestDatabase
{
    partial class frmModificaPersona
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
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            this.grpSesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipiDocumentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(50, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(50, 144);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(50, 59);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(40, 13);
            this.lblCodice.TabIndex = 2;
            this.lblCodice.Text = "Codice";
            // 
            // lblNazione
            // 
            this.lblNazione.AutoSize = true;
            this.lblNazione.Location = new System.Drawing.Point(51, 185);
            this.lblNazione.Name = "lblNazione";
            this.lblNazione.Size = new System.Drawing.Size(46, 13);
            this.lblNazione.TabIndex = 5;
            this.lblNazione.Text = "Nazione";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Location = new System.Drawing.Point(51, 227);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(67, 13);
            this.lblDataNascita.TabIndex = 3;
            this.lblDataNascita.Text = "Data nascita";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(50, 490);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroDocumento.TabIndex = 7;
            this.lblNumeroDocumento.Text = "Numero documento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(50, 442);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(84, 13);
            this.lblTipoDocumento.TabIndex = 6;
            this.lblTipoDocumento.Text = "Tipo documento";
            // 
            // txtCodice
            // 
            this.txtCodice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "CodicePersona", true));
            this.txtCodice.Location = new System.Drawing.Point(203, 52);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.ReadOnly = true;
            this.txtCodice.Size = new System.Drawing.Size(200, 20);
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
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(203, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtCognome
            // 
            this.txtCognome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "Cognome", true));
            this.txtCognome.Location = new System.Drawing.Point(203, 141);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(200, 20);
            this.txtCognome.TabIndex = 10;
            // 
            // txtNazione
            // 
            this.txtNazione.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "Nazione", true));
            this.txtNazione.Location = new System.Drawing.Point(203, 185);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.Size = new System.Drawing.Size(200, 20);
            this.txtNazione.TabIndex = 11;
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(203, 224);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascita.TabIndex = 12;
            this.dtpDataNascita.ValueChanged += new System.EventHandler(this.dtpDataNascita_ValueChanged);
            // 
            // grpSesso
            // 
            this.grpSesso.Controls.Add(this.radNonSpecificato);
            this.grpSesso.Controls.Add(this.radAltro);
            this.grpSesso.Controls.Add(this.radFemmina);
            this.grpSesso.Controls.Add(this.radMaschio);
            this.grpSesso.Location = new System.Drawing.Point(53, 283);
            this.grpSesso.Name = "grpSesso";
            this.grpSesso.Size = new System.Drawing.Size(350, 129);
            this.grpSesso.TabIndex = 13;
            this.grpSesso.TabStop = false;
            this.grpSesso.Text = "Sesso";
            // 
            // radNonSpecificato
            // 
            this.radNonSpecificato.AutoSize = true;
            this.radNonSpecificato.Location = new System.Drawing.Point(191, 76);
            this.radNonSpecificato.Name = "radNonSpecificato";
            this.radNonSpecificato.Size = new System.Drawing.Size(99, 17);
            this.radNonSpecificato.TabIndex = 3;
            this.radNonSpecificato.TabStop = true;
            this.radNonSpecificato.Text = "Non specificato";
            this.radNonSpecificato.UseVisualStyleBackColor = true;
            this.radNonSpecificato.CheckedChanged += new System.EventHandler(this.radNonSpecificato_CheckedChanged);
            // 
            // radAltro
            // 
            this.radAltro.AutoSize = true;
            this.radAltro.Location = new System.Drawing.Point(191, 34);
            this.radAltro.Name = "radAltro";
            this.radAltro.Size = new System.Drawing.Size(46, 17);
            this.radAltro.TabIndex = 2;
            this.radAltro.TabStop = true;
            this.radAltro.Text = "Altro";
            this.radAltro.UseVisualStyleBackColor = true;
            this.radAltro.CheckedChanged += new System.EventHandler(this.radAltro_CheckedChanged);
            // 
            // radFemmina
            // 
            this.radFemmina.AutoSize = true;
            this.radFemmina.Location = new System.Drawing.Point(22, 76);
            this.radFemmina.Name = "radFemmina";
            this.radFemmina.Size = new System.Drawing.Size(67, 17);
            this.radFemmina.TabIndex = 1;
            this.radFemmina.TabStop = true;
            this.radFemmina.Text = "Femmina";
            this.radFemmina.UseVisualStyleBackColor = true;
            this.radFemmina.CheckedChanged += new System.EventHandler(this.radFemmina_CheckedChanged);
            // 
            // radMaschio
            // 
            this.radMaschio.AutoSize = true;
            this.radMaschio.Location = new System.Drawing.Point(22, 34);
            this.radMaschio.Name = "radMaschio";
            this.radMaschio.Size = new System.Drawing.Size(65, 17);
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
            this.cmbTipoDocumento.Location = new System.Drawing.Point(203, 434);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(200, 21);
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
            this.txtNumeroDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "NumeroDocumento", true));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(203, 487);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroDocumento.TabIndex = 15;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(300, 554);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(103, 35);
            this.btnSalva.TabIndex = 16;
            this.btnSalva.Text = "SALVA";
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
            // txtDataNascita
            // 
            this.txtDataNascita.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "DataNascita", true));
            this.txtDataNascita.Enabled = false;
            this.txtDataNascita.Location = new System.Drawing.Point(203, 224);
            this.txtDataNascita.Name = "txtDataNascita";
            this.txtDataNascita.Size = new System.Drawing.Size(174, 20);
            this.txtDataNascita.TabIndex = 17;
            // 
            // txtSesso
            // 
            this.txtSesso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "Sesso", true));
            this.txtSesso.Enabled = false;
            this.txtSesso.Location = new System.Drawing.Point(203, 141);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(174, 20);
            this.txtSesso.TabIndex = 18;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPersoneBindingSource, "TipoDocumento", true));
            this.txtTipoDocumento.Location = new System.Drawing.Point(203, 435);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(167, 20);
            this.txtTipoDocumento.TabIndex = 19;
            // 
            // frmModificaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 633);
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
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.txtTipoDocumento);
            this.Name = "frmModificaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica persona";
            this.Load += new System.EventHandler(this.frmModificaPersona_Load);
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
        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.TextBox txtTipoDocumento;
    }
}