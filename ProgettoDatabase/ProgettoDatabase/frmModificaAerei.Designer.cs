
namespace ProgettoDatabase
{
    partial class frmModificaAerei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificaAerei));
            this.lblModello = new System.Windows.Forms.Label();
            this.tblAereiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.txtModello = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.tblAereiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAereiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.updCapacita = new System.Windows.Forms.NumericUpDown();
            this.updLitri = new System.Windows.Forms.NumericUpDown();
            this.updMotori = new System.Windows.Forms.NumericUpDown();
            this.updRaggio = new System.Windows.Forms.NumericUpDown();
            this.updVelocita = new System.Windows.Forms.NumericUpDown();
            this.txtPropulsione = new System.Windows.Forms.TextBox();
            this.txtCompagnia = new System.Windows.Forms.TextBox();
            this.chkInternazionale = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.marcheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet1 = new ProgettoDatabase.AeroportoDataSet();
            this.cmbModello = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marcheTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.MarcheTableAdapter();
            this.modelliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.ModelliTableAdapter();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblModelloCorrente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblAereiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCapacita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMotori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updRaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updVelocita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModello
            // 
            this.lblModello.AutoSize = true;
            this.lblModello.Location = new System.Drawing.Point(67, 85);
            this.lblModello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModello.Name = "lblModello";
            this.lblModello.Size = new System.Drawing.Size(102, 17);
            this.lblModello.TabIndex = 1;
            this.lblModello.Text = "Nuovo Modello";
            // 
            // tblAereiBindingSource
            // 
            this.tblAereiBindingSource.DataMember = "tblAerei";
            this.tblAereiBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtModello
            // 
            this.txtModello.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAereiBindingSource, "Modello", true));
            this.txtModello.Location = new System.Drawing.Point(271, 117);
            this.txtModello.Margin = new System.Windows.Forms.Padding(4);
            this.txtModello.Name = "txtModello";
            this.txtModello.ReadOnly = true;
            this.txtModello.Size = new System.Drawing.Size(265, 22);
            this.txtModello.TabIndex = 10;
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalva.BackColor = System.Drawing.Color.White;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(238, 586);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(123, 52);
            this.btnSalva.TabIndex = 16;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // tblAereiTableAdapter
            // 
            this.tblAereiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Capacità Massima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Litri Carburante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero Motori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tipo Propulsione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Internazionale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Velocita Massima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Compagnia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Raggio";
            // 
            // updCapacita
            // 
            this.updCapacita.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "CapacitaMassima", true));
            this.updCapacita.Location = new System.Drawing.Point(271, 162);
            this.updCapacita.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updCapacita.Name = "updCapacita";
            this.updCapacita.Size = new System.Drawing.Size(120, 22);
            this.updCapacita.TabIndex = 27;
            this.updCapacita.ValueChanged += new System.EventHandler(this.updCapacita_ValueChanged);
            // 
            // updLitri
            // 
            this.updLitri.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "LitriCarburante", true));
            this.updLitri.Location = new System.Drawing.Point(271, 208);
            this.updLitri.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updLitri.Name = "updLitri";
            this.updLitri.Size = new System.Drawing.Size(120, 22);
            this.updLitri.TabIndex = 28;
            this.updLitri.ValueChanged += new System.EventHandler(this.updLitri_ValueChanged);
            // 
            // updMotori
            // 
            this.updMotori.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "NumeroMotori", true));
            this.updMotori.Location = new System.Drawing.Point(271, 256);
            this.updMotori.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.updMotori.Name = "updMotori";
            this.updMotori.Size = new System.Drawing.Size(120, 22);
            this.updMotori.TabIndex = 29;
            this.updMotori.ValueChanged += new System.EventHandler(this.updMotori_ValueChanged);
            // 
            // updRaggio
            // 
            this.updRaggio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "Raggio", true));
            this.updRaggio.Location = new System.Drawing.Point(271, 407);
            this.updRaggio.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updRaggio.Name = "updRaggio";
            this.updRaggio.Size = new System.Drawing.Size(120, 22);
            this.updRaggio.TabIndex = 30;
            this.updRaggio.ValueChanged += new System.EventHandler(this.updRaggio_ValueChanged);
            // 
            // updVelocita
            // 
            this.updVelocita.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "VelocitaMax", true));
            this.updVelocita.Location = new System.Drawing.Point(271, 462);
            this.updVelocita.Name = "updVelocita";
            this.updVelocita.Size = new System.Drawing.Size(120, 22);
            this.updVelocita.TabIndex = 31;
            this.updVelocita.ValueChanged += new System.EventHandler(this.updVelocita_ValueChanged);
            // 
            // txtPropulsione
            // 
            this.txtPropulsione.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAereiBindingSource, "TipoPropulsione", true));
            this.txtPropulsione.Location = new System.Drawing.Point(271, 306);
            this.txtPropulsione.Name = "txtPropulsione";
            this.txtPropulsione.Size = new System.Drawing.Size(265, 22);
            this.txtPropulsione.TabIndex = 32;
            this.txtPropulsione.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPropulsione_KeyUp);
            // 
            // txtCompagnia
            // 
            this.txtCompagnia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAereiBindingSource, "CompagniaAerea", true));
            this.txtCompagnia.Location = new System.Drawing.Point(271, 521);
            this.txtCompagnia.Name = "txtCompagnia";
            this.txtCompagnia.Size = new System.Drawing.Size(265, 22);
            this.txtCompagnia.TabIndex = 33;
            this.txtCompagnia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCompagnia_KeyUp);
            // 
            // chkInternazionale
            // 
            this.chkInternazionale.AutoSize = true;
            this.chkInternazionale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblAereiBindingSource, "Internazionale", true));
            this.chkInternazionale.Location = new System.Drawing.Point(271, 365);
            this.chkInternazionale.Name = "chkInternazionale";
            this.chkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.chkInternazionale.TabIndex = 34;
            this.chkInternazionale.UseVisualStyleBackColor = true;
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
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            // 
            // errorProvider10
            // 
            this.errorProvider10.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Seleziona Marca";
            // 
            // marcheBindingSource
            // 
            this.marcheBindingSource.DataMember = "Marche";
            this.marcheBindingSource.DataSource = this.aeroportoDataSet1;
            // 
            // aeroportoDataSet1
            // 
            this.aeroportoDataSet1.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbModello
            // 
            this.cmbModello.DataSource = this.bindingSource1;
            this.cmbModello.DisplayMember = "Modello";
            this.cmbModello.FormattingEnabled = true;
            this.cmbModello.Location = new System.Drawing.Point(271, 85);
            this.cmbModello.Name = "cmbModello";
            this.cmbModello.Size = new System.Drawing.Size(265, 24);
            this.cmbModello.TabIndex = 37;
            this.cmbModello.Text = "*Seleziona una Marca*";
            this.cmbModello.ValueMember = "Modello";
            this.cmbModello.SelectionChangeCommitted += new System.EventHandler(this.cmbModello_SelectionChangeCommitted);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Modelli";
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            // 
            // marcheTableAdapter
            // 
            this.marcheTableAdapter.ClearBeforeFill = true;
            // 
            // modelliTableAdapter
            // 
            this.modelliTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DataSource = this.marcheBindingSource;
            this.cmbMarca.DisplayMember = "Nome";
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(271, 50);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(265, 24);
            this.cmbMarca.TabIndex = 38;
            this.cmbMarca.ValueMember = "Nome";
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.cmbMarca_SelectionChangeCommitted);
            // 
            // lblModelloCorrente
            // 
            this.lblModelloCorrente.AutoSize = true;
            this.lblModelloCorrente.Location = new System.Drawing.Point(67, 117);
            this.lblModelloCorrente.Name = "lblModelloCorrente";
            this.lblModelloCorrente.Size = new System.Drawing.Size(116, 17);
            this.lblModelloCorrente.TabIndex = 39;
            this.lblModelloCorrente.Text = "Modello Corrente";
            // 
            // frmModificaAerei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 688);
            this.Controls.Add(this.lblModelloCorrente);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbModello);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkInternazionale);
            this.Controls.Add(this.txtCompagnia);
            this.Controls.Add(this.txtPropulsione);
            this.Controls.Add(this.updVelocita);
            this.Controls.Add(this.updRaggio);
            this.Controls.Add(this.updMotori);
            this.Controls.Add(this.updLitri);
            this.Controls.Add(this.updCapacita);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.lblModello);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(609, 826);
            this.Name = "frmModificaAerei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica Aerei";
            this.Load += new System.EventHandler(this.frmModificaAerei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAereiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCapacita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMotori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updRaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updVelocita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModello;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Button btnSalva;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblAereiBindingSource;
        private AeroportoDataSetTableAdapters.tblAereiTableAdapter tblAereiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown updCapacita;
        private System.Windows.Forms.NumericUpDown updLitri;
        private System.Windows.Forms.NumericUpDown updMotori;
        private System.Windows.Forms.NumericUpDown updRaggio;
        private System.Windows.Forms.NumericUpDown updVelocita;
        private System.Windows.Forms.TextBox txtPropulsione;
        private System.Windows.Forms.TextBox txtCompagnia;
        private System.Windows.Forms.CheckBox chkInternazionale;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider10;
        private System.Windows.Forms.ComboBox cmbModello;
        private System.Windows.Forms.Label label9;
        private AeroportoDataSet aeroportoDataSet1;
        private System.Windows.Forms.BindingSource marcheBindingSource;
        private AeroportoDataSetTableAdapters.MarcheTableAdapter marcheTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSetTableAdapters.ModelliTableAdapter modelliTableAdapter;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblModelloCorrente;
    }
}