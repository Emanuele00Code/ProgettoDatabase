
namespace ProgettoDatabase
{
    partial class frmModificaAeroporti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificaAeroporti));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPiste = new System.Windows.Forms.Label();
            this.lblTerminal = new System.Windows.Forms.Label();
            this.lblInternazionale = new System.Windows.Forms.Label();
            this.lblMilitare = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
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
            this.btnSalva = new System.Windows.Forms.Button();
            this.tblAeroportiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAeroportiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPiste)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(73, 34);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblPiste
            // 
            this.lblPiste.AutoSize = true;
            this.lblPiste.Location = new System.Drawing.Point(73, 87);
            this.lblPiste.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiste.Name = "lblPiste";
            this.lblPiste.Size = new System.Drawing.Size(39, 17);
            this.lblPiste.TabIndex = 1;
            this.lblPiste.Text = "Piste";
            // 
            // lblTerminal
            // 
            this.lblTerminal.AutoSize = true;
            this.lblTerminal.Location = new System.Drawing.Point(74, 138);
            this.lblTerminal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminal.Name = "lblTerminal";
            this.lblTerminal.Size = new System.Drawing.Size(63, 17);
            this.lblTerminal.TabIndex = 5;
            this.lblTerminal.Text = "Terminal";
            // 
            // lblInternazionale
            // 
            this.lblInternazionale.AutoSize = true;
            this.lblInternazionale.Location = new System.Drawing.Point(64, 387);
            this.lblInternazionale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternazionale.Name = "lblInternazionale";
            this.lblInternazionale.Size = new System.Drawing.Size(97, 17);
            this.lblInternazionale.TabIndex = 7;
            this.lblInternazionale.Text = "Internazionale";
            // 
            // lblMilitare
            // 
            this.lblMilitare.AutoSize = true;
            this.lblMilitare.Location = new System.Drawing.Point(73, 328);
            this.lblMilitare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilitare.Name = "lblMilitare";
            this.lblMilitare.Size = new System.Drawing.Size(53, 17);
            this.lblMilitare.TabIndex = 6;
            this.lblMilitare.Text = "Militare";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(268, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 22);
            this.txtNome.TabIndex = 9;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblAeroporti";
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblGates
            // 
            this.lblGates.AutoSize = true;
            this.lblGates.Location = new System.Drawing.Point(80, 196);
            this.lblGates.Name = "lblGates";
            this.lblGates.Size = new System.Drawing.Size(46, 17);
            this.lblGates.TabIndex = 16;
            this.lblGates.Text = "Gates";
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(73, 269);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(36, 17);
            this.lblCitta.TabIndex = 17;
            this.lblCitta.Text = "Citta";
            // 
            // txtCitta
            // 
            this.txtCitta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Citta", true));
            this.txtCitta.Location = new System.Drawing.Point(268, 269);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(265, 22);
            this.txtCitta.TabIndex = 18;
            // 
            // cbkMilitare
            // 
            this.cbkMilitare.AutoSize = true;
            this.cbkMilitare.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "Militare", true));
            this.cbkMilitare.Location = new System.Drawing.Point(268, 328);
            this.cbkMilitare.Name = "cbkMilitare";
            this.cbkMilitare.Size = new System.Drawing.Size(18, 17);
            this.cbkMilitare.TabIndex = 19;
            this.cbkMilitare.UseVisualStyleBackColor = true;
            // 
            // cbkInternazionale
            // 
            this.cbkInternazionale.AutoSize = true;
            this.cbkInternazionale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource1, "Internazionale", true));
            this.cbkInternazionale.Location = new System.Drawing.Point(268, 382);
            this.cbkInternazionale.Name = "cbkInternazionale";
            this.cbkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.cbkInternazionale.TabIndex = 20;
            this.cbkInternazionale.UseVisualStyleBackColor = true;
            // 
            // lblNazione
            // 
            this.lblNazione.AutoSize = true;
            this.lblNazione.Location = new System.Drawing.Point(76, 236);
            this.lblNazione.Name = "lblNazione";
            this.lblNazione.Size = new System.Drawing.Size(60, 17);
            this.lblNazione.TabIndex = 21;
            this.lblNazione.Text = "Nazione";
            // 
            // txtNazione
            // 
            this.txtNazione.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nazione", true));
            this.txtNazione.Location = new System.Drawing.Point(268, 231);
            this.txtNazione.Name = "txtNazione";
            this.txtNazione.Size = new System.Drawing.Size(265, 22);
            this.txtNazione.TabIndex = 22;
            // 
            // updGates
            // 
            this.updGates.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Gates", true));
            this.updGates.Location = new System.Drawing.Point(268, 185);
            this.updGates.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updGates.Name = "updGates";
            this.updGates.Size = new System.Drawing.Size(120, 22);
            this.updGates.TabIndex = 46;
            // 
            // updTerminal
            // 
            this.updTerminal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Terminal", true));
            this.updTerminal.Location = new System.Drawing.Point(268, 133);
            this.updTerminal.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updTerminal.Name = "updTerminal";
            this.updTerminal.Size = new System.Drawing.Size(120, 22);
            this.updTerminal.TabIndex = 45;
            // 
            // updPiste
            // 
            this.updPiste.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "Piste", true));
            this.updPiste.Location = new System.Drawing.Point(268, 82);
            this.updPiste.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updPiste.Name = "updPiste";
            this.updPiste.Size = new System.Drawing.Size(120, 22);
            this.updPiste.TabIndex = 44;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.White;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(375, 387);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(158, 60);
            this.btnSalva.TabIndex = 47;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // tblAeroportiTableAdapter
            // 
            this.tblAeroportiTableAdapter.ClearBeforeFill = true;
            // 
            // frmModificaAeroporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 474);
            this.Controls.Add(this.btnSalva);
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
            this.Controls.Add(this.lblInternazionale);
            this.Controls.Add(this.lblMilitare);
            this.Controls.Add(this.lblTerminal);
            this.Controls.Add(this.lblPiste);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(629, 549);
            this.Name = "frmModificaAeroporti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Aeroporti";
            this.Load += new System.EventHandler(this.frmModificaAeroporti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPiste;
        private System.Windows.Forms.Label lblTerminal;
        private System.Windows.Forms.Label lblInternazionale;
        private System.Windows.Forms.Label lblMilitare;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblGates;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.CheckBox cbkMilitare;
        private System.Windows.Forms.CheckBox cbkInternazionale;
        private System.Windows.Forms.Label lblNazione;
        private System.Windows.Forms.TextBox txtNazione;
        private System.Windows.Forms.NumericUpDown updGates;
        private System.Windows.Forms.NumericUpDown updTerminal;
        private System.Windows.Forms.NumericUpDown updPiste;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSet aeroportoDataSet;
        private AeroportoDataSetTableAdapters.tblAeroportiTableAdapter tblAeroportiTableAdapter;
    }
}