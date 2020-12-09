
namespace ProgettoDatabase
{
    partial class frmInserisciAeroporti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserisciAeroporti));
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.btnSalvaENuovo = new System.Windows.Forms.Button();
            this.txtNazione = new System.Windows.Forms.TextBox();
            this.lblNazione = new System.Windows.Forms.Label();
            this.cbkInternazionale = new System.Windows.Forms.CheckBox();
            this.cbkMilitare = new System.Windows.Forms.CheckBox();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.lblCitta = new System.Windows.Forms.Label();
            this.lblGates = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.lblInternazionale = new System.Windows.Forms.Label();
            this.lblMilitare = new System.Windows.Forms.Label();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblPiste = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tblAeroportiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAeroportiTableAdapter();
            this.updPiste = new System.Windows.Forms.NumericUpDown();
            this.updTerminal = new System.Windows.Forms.NumericUpDown();
            this.updGates = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGates)).BeginInit();
            this.SuspendLayout();
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.White;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(382, 434);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(150, 43);
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
            this.btnSalvaENuovo.BackColor = System.Drawing.Color.White;
            this.btnSalvaENuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaENuovo.Location = new System.Drawing.Point(382, 366);
            this.btnSalvaENuovo.Name = "btnSalvaENuovo";
            this.btnSalvaENuovo.Size = new System.Drawing.Size(150, 43);
            this.btnSalvaENuovo.TabIndex = 20;
            this.btnSalvaENuovo.Text = "SALVA E NUOVO";
            this.btnSalvaENuovo.UseVisualStyleBackColor = false;
            this.btnSalvaENuovo.Click += new System.EventHandler(this.btnSalvaENuovo_Click);
            // 
            // txtNazione
            // 
            this.txtNazione.Location = new System.Drawing.Point(272, 283);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.Size = new System.Drawing.Size(265, 22);
            this.txtNazione.TabIndex = 40;
            // 
            // lblNazione
            // 
            this.lblNazione.AutoSize = true;
            this.lblNazione.Location = new System.Drawing.Point(77, 288);
            this.lblNazione.Name = "lblNazione";
            this.lblNazione.Size = new System.Drawing.Size(60, 17);
            this.lblNazione.TabIndex = 39;
            this.lblNazione.Text = "Nazione";
            // 
            // cbkInternazionale
            // 
            this.cbkInternazionale.AutoSize = true;
            this.cbkInternazionale.Location = new System.Drawing.Point(272, 434);
            this.cbkInternazionale.Name = "cbkInternazionale";
            this.cbkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.cbkInternazionale.TabIndex = 38;
            this.cbkInternazionale.UseVisualStyleBackColor = true;
            // 
            // cbkMilitare
            // 
            this.cbkMilitare.AutoSize = true;
            this.cbkMilitare.Location = new System.Drawing.Point(272, 380);
            this.cbkMilitare.Name = "cbkMilitare";
            this.cbkMilitare.Size = new System.Drawing.Size(18, 17);
            this.cbkMilitare.TabIndex = 37;
            this.cbkMilitare.UseVisualStyleBackColor = true;
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(272, 321);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(265, 22);
            this.txtCitta.TabIndex = 36;
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(77, 321);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(36, 17);
            this.lblCitta.TabIndex = 35;
            this.lblCitta.Text = "Citta";
            // 
            // lblGates
            // 
            this.lblGates.AutoSize = true;
            this.lblGates.Location = new System.Drawing.Point(77, 247);
            this.lblGates.Name = "lblGates";
            this.lblGates.Size = new System.Drawing.Size(46, 17);
            this.lblGates.TabIndex = 34;
            this.lblGates.Text = "Gates";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(272, 86);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 22);
            this.txtNome.TabIndex = 30;
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(272, 32);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(265, 22);
            this.txtSigla.TabIndex = 29;
            // 
            // lblInternazionale
            // 
            this.lblInternazionale.AutoSize = true;
            this.lblInternazionale.Location = new System.Drawing.Point(77, 434);
            this.lblInternazionale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternazionale.Name = "lblInternazionale";
            this.lblInternazionale.Size = new System.Drawing.Size(97, 17);
            this.lblInternazionale.TabIndex = 28;
            this.lblInternazionale.Text = "Internazionale";
            // 
            // lblMilitare
            // 
            this.lblMilitare.AutoSize = true;
            this.lblMilitare.Location = new System.Drawing.Point(77, 379);
            this.lblMilitare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilitare.Name = "lblMilitare";
            this.lblMilitare.Size = new System.Drawing.Size(53, 17);
            this.lblMilitare.TabIndex = 27;
            this.lblMilitare.Text = "Militare";
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Location = new System.Drawing.Point(77, 190);
            this.lblTerminal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(63, 17);
            this.lblTerminal.TabIndex = 26;
            this.lblTerminal.Text = "Terminal";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(77, 35);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(39, 17);
            this.lblSigla.TabIndex = 25;
            this.lblSigla.Text = "Sigla";
            // 
            // lblPiste
            // 
            this.lblPiste.AutoSize = true;
            this.lblPiste.Location = new System.Drawing.Point(77, 139);
            this.lblPiste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiste.Name = "lblPiste";
            this.lblPiste.Size = new System.Drawing.Size(39, 17);
            this.lblPiste.TabIndex = 24;
            this.lblPiste.Text = "Piste";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(77, 86);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome";
            // 
            // tblAeroportiTableAdapter
            // 
            this.tblAeroportiTableAdapter.ClearBeforeFill = true;
            // 
            // updPiste
            // 
            this.updPiste.Location = new System.Drawing.Point(272, 139);
            this.updPiste.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updPiste.Name = "updPiste";
            this.updPiste.Size = new System.Drawing.Size(120, 22);
            this.updPiste.TabIndex = 41;
            // 
            // updTerminal
            // 
            this.updTerminal.Location = new System.Drawing.Point(272, 185);
            this.updTerminal.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updTerminal.Name = "updTerminal";
            this.updTerminal.Size = new System.Drawing.Size(120, 22);
            this.updTerminal.TabIndex = 42;
            // 
            // updGates
            // 
            this.updGates.Location = new System.Drawing.Point(272, 242);
            this.updGates.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updGates.Name = "updGates";
            this.updGates.Size = new System.Drawing.Size(120, 22);
            this.updGates.TabIndex = 43;
            // 
            // frmInserisciAeroporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 502);
            this.Controls.Add(this.updGates);
            this.Controls.Add(this.updTerminal);
            this.Controls.Add(this.updPiste);
            this.Controls.Add(this.txtNazione);
            this.Controls.Add(this.lblNazione);
            this.Controls.Add(this.cbkInternazionale);
            this.Controls.Add(this.cbkMilitare);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.lblCitta);
            this.Controls.Add(this.lblGates);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.lblInternazionale);
            this.Controls.Add(this.lblMilitare);
            this.Controls.Add(this.lblTerminal);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPiste);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSalvaENuovo);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.btnSalva);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(639, 549);
            this.Name = "frmInserisciAeroporti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserisci Aeroporto";
            this.Load += new System.EventHandler(this.frmInserisciPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGates)).EndInit();
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
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.Label lblNazione;
        private System.Windows.Forms.CheckBox cbkInternazionale;
        private System.Windows.Forms.CheckBox cbkMilitare;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.Label lblGates;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label lblInternazionale;
        private System.Windows.Forms.Label lblMilitare;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblPiste;
        private System.Windows.Forms.Label lblNome;
        private AeroportoDataSetTableAdapters.tblAeroportiTableAdapter tblAeroportiTableAdapter;
        private System.Windows.Forms.NumericUpDown updPiste;
        private System.Windows.Forms.NumericUpDown updTerminal;
        private System.Windows.Forms.NumericUpDown updGates;
    }
}