
namespace ProgettoDatabase
{
    partial class frmVisualizzaAeroporti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizzaAeroporti));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPiste = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblInternazionale = new System.Windows.Forms.Label();
            this.lblMilitare = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblGates = new System.Windows.Forms.Label();
            this.lblCitta = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.cbkMilitare = new System.Windows.Forms.CheckBox();
            this.cbkInternazionale = new System.Windows.Forms.CheckBox();
            this.lblNazione = new System.Windows.Forms.Label();
            this.txtNazione = new System.Windows.Forms.TextBox();
            this.updGates = new System.Windows.Forms.NumericUpDown();
            this.updTerminal = new System.Windows.Forms.NumericUpDown();
            this.updPiste = new System.Windows.Forms.NumericUpDown();
            this.tblPersoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.tblAeroportiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAeroportiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.updGates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
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
            // lblPiste
            // 
            this.lblPiste.AutoSize = true;
            this.lblPiste.Location = new System.Drawing.Point(67, 177);
            this.lblPiste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiste.Name = "lblPiste";
            this.lblPiste.Size = new System.Drawing.Size(39, 17);
            this.lblPiste.TabIndex = 1;
            this.lblPiste.Text = "Piste";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(67, 73);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(39, 17);
            this.lblSigla.TabIndex = 2;
            this.lblSigla.Text = "Sigla";
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Location = new System.Drawing.Point(67, 223);
            this.lblTerminal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(63, 17);
            this.lblTerminal.TabIndex = 5;
            this.lblTerminal.Text = "Terminal";
            // 
            // lblInternazionale
            // 
            this.lblInternazionale.AutoSize = true;
            this.lblInternazionale.Location = new System.Drawing.Point(67, 472);
            this.lblInternazionale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternazionale.Name = "lblInternazionale";
            this.lblInternazionale.Size = new System.Drawing.Size(97, 17);
            this.lblInternazionale.TabIndex = 7;
            this.lblInternazionale.Text = "Internazionale";
            // 
            // lblMilitare
            // 
            this.lblMilitare.AutoSize = true;
            this.lblMilitare.Location = new System.Drawing.Point(67, 418);
            this.lblMilitare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilitare.Name = "lblMilitare";
            this.lblMilitare.Size = new System.Drawing.Size(53, 17);
            this.lblMilitare.TabIndex = 6;
            this.lblMilitare.Text = "Militare";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(262, 70);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.ReadOnly = true;
            this.txtSigla.Size = new System.Drawing.Size(265, 22);
            this.txtSigla.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(262, 124);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(265, 22);
            this.txtNome.TabIndex = 9;
            // 
            // lblGates
            // 
            this.lblGates.AutoSize = true;
            this.lblGates.Location = new System.Drawing.Point(67, 280);
            this.lblGates.Name = "lblGates";
            this.lblGates.Size = new System.Drawing.Size(46, 17);
            this.lblGates.TabIndex = 16;
            this.lblGates.Text = "Gates";
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(67, 359);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(36, 17);
            this.lblCitta.TabIndex = 17;
            this.lblCitta.Text = "Citta";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(262, 359);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.ReadOnly = true;
            this.txtCitta.Size = new System.Drawing.Size(265, 22);
            this.txtCitta.TabIndex = 18;
            // 
            // cbkMilitare
            // 
            this.cbkMilitare.AutoSize = true;
            this.cbkMilitare.Enabled = false;
            this.cbkMilitare.Location = new System.Drawing.Point(262, 418);
            this.cbkMilitare.Name = "cbkMilitare";
            this.cbkMilitare.Size = new System.Drawing.Size(18, 17);
            this.cbkMilitare.TabIndex = 19;
            this.cbkMilitare.UseVisualStyleBackColor = true;
            // 
            // cbkInternazionale
            // 
            this.cbkInternazionale.AutoSize = true;
            this.cbkInternazionale.Enabled = false;
            this.cbkInternazionale.Location = new System.Drawing.Point(262, 472);
            this.cbkInternazionale.Name = "cbkInternazionale";
            this.cbkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.cbkInternazionale.TabIndex = 20;
            this.cbkInternazionale.UseVisualStyleBackColor = true;
            // 
            // lblNazione
            // 
            this.lblNazione.AutoSize = true;
            this.lblNazione.Location = new System.Drawing.Point(67, 324);
            this.lblNazione.Name = "lblNazione";
            this.lblNazione.Size = new System.Drawing.Size(60, 17);
            this.lblNazione.TabIndex = 21;
            this.lblNazione.Text = "Nazione";
            // 
            // txtNazione
            // 
            this.txtNazione.Location = new System.Drawing.Point(262, 321);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.ReadOnly = true;
            this.txtNazione.Size = new System.Drawing.Size(265, 22);
            this.txtNazione.TabIndex = 22;
            // 
            // updGates
            // 
            this.updGates.Enabled = false;
            this.updGates.Location = new System.Drawing.Point(262, 275);
            this.updGates.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updGates.Name = "updGates";
            this.updGates.ReadOnly = true;
            this.updGates.Size = new System.Drawing.Size(120, 22);
            this.updGates.TabIndex = 46;
            this.updGates.ValueChanged += new System.EventHandler(this.updGates_ValueChanged);
            // 
            // updTerminal
            // 
            this.updTerminal.Enabled = false;
            this.updTerminal.Location = new System.Drawing.Point(262, 218);
            this.updTerminal.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updTerminal.Name = "updTerminal";
            this.updTerminal.ReadOnly = true;
            this.updTerminal.Size = new System.Drawing.Size(120, 22);
            this.updTerminal.TabIndex = 45;
            this.updTerminal.ValueChanged += new System.EventHandler(this.updTerminal_ValueChanged);
            // 
            // updPiste
            // 
            this.updPiste.Enabled = false;
            this.updPiste.Location = new System.Drawing.Point(262, 172);
            this.updPiste.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updPiste.Name = "updPiste";
            this.updPiste.ReadOnly = true;
            this.updPiste.Size = new System.Drawing.Size(120, 22);
            this.updPiste.TabIndex = 44;
            this.updPiste.ValueChanged += new System.EventHandler(this.updPiste_ValueChanged);
            // 
            // tblPersoneBindingSource
            // 
            this.tblPersoneBindingSource.DataMember = "tblAeroporti";
            this.tblPersoneBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAeroportiTableAdapter
            // 
            this.tblAeroportiTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizzaAeroporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(586, 511);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(604, 558);
            this.Name = "frmVisualizzaAeroporti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizza Aeroporti";
            this.Load += new System.EventHandler(this.frmVisualizzaPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updGates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPiste;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Label lblInternazionale;
        private System.Windows.Forms.Label lblMilitare;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtNome;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblPersoneBindingSource;
        private System.Windows.Forms.Label lblGates;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.CheckBox cbkMilitare;
        private System.Windows.Forms.CheckBox cbkInternazionale;
        private AeroportoDataSetTableAdapters.tblAeroportiTableAdapter tblAeroportiTableAdapter;
        private System.Windows.Forms.Label lblNazione;
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.NumericUpDown updGates;
        private System.Windows.Forms.NumericUpDown updTerminal;
        private System.Windows.Forms.NumericUpDown updPiste;
    }
}