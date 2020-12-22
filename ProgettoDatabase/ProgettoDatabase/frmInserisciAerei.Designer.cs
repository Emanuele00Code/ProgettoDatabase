
namespace ProgettoDatabase
{
    partial class frmInserisciAerei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInserisciAerei));
            this.btnSalva = new System.Windows.Forms.Button();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.txtDataNascita = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.btnSalvaENuovo = new System.Windows.Forms.Button();
            this.chkInternazionale = new System.Windows.Forms.CheckBox();
            this.tblAereiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.txtCompagnia = new System.Windows.Forms.TextBox();
            this.txtPropulsione = new System.Windows.Forms.TextBox();
            this.updVelocita = new System.Windows.Forms.NumericUpDown();
            this.updRaggio = new System.Windows.Forms.NumericUpDown();
            this.updMotori = new System.Windows.Forms.NumericUpDown();
            this.updLitri = new System.Windows.Forms.NumericUpDown();
            this.updCapacita = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodice = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
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
            this.tblAereiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAereiTableAdapter();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbModello = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.modelliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.ModelliTableAdapter();
            this.marcheTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.MarcheTableAdapter();
            this.aeroportoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblAereiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updVelocita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updRaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMotori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCapacita)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.White;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(384, 630);
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
            this.btnSalvaENuovo.BackColor = System.Drawing.Color.White;
            this.btnSalvaENuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaENuovo.Location = new System.Drawing.Point(71, 630);
            this.btnSalvaENuovo.Name = "btnSalvaENuovo";
            this.btnSalvaENuovo.Size = new System.Drawing.Size(150, 43);
            this.btnSalvaENuovo.TabIndex = 20;
            this.btnSalvaENuovo.Text = "SALVA E NUOVO";
            this.btnSalvaENuovo.UseVisualStyleBackColor = false;
            this.btnSalvaENuovo.Click += new System.EventHandler(this.btnSalvaENuovo_Click);
            // 
            // chkInternazionale
            // 
            this.chkInternazionale.AutoSize = true;
            this.chkInternazionale.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.tblAereiBindingSource, "Internazionale", true));
            this.chkInternazionale.Location = new System.Drawing.Point(277, 404);
            this.chkInternazionale.Name = "chkInternazionale";
            this.chkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.chkInternazionale.TabIndex = 54;
            this.chkInternazionale.UseVisualStyleBackColor = true;
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
            // txtCompagnia
            // 
            this.txtCompagnia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAereiBindingSource, "CompagniaAerea", true));
            this.txtCompagnia.Location = new System.Drawing.Point(277, 560);
            this.txtCompagnia.Name = "txtCompagnia";
            this.txtCompagnia.Size = new System.Drawing.Size(265, 22);
            this.txtCompagnia.TabIndex = 53;
            this.txtCompagnia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCompagnia_KeyUp);
            // 
            // txtPropulsione
            // 
            this.txtPropulsione.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblAereiBindingSource, "TipoPropulsione", true));
            this.txtPropulsione.Location = new System.Drawing.Point(277, 345);
            this.txtPropulsione.Name = "txtPropulsione";
            this.txtPropulsione.Size = new System.Drawing.Size(265, 22);
            this.txtPropulsione.TabIndex = 52;
            this.txtPropulsione.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPropulsione_KeyUp);
            // 
            // updVelocita
            // 
            this.updVelocita.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "VelocitaMax", true));
            this.updVelocita.Location = new System.Drawing.Point(277, 501);
            this.updVelocita.Name = "updVelocita";
            this.updVelocita.Size = new System.Drawing.Size(120, 22);
            this.updVelocita.TabIndex = 51;
            this.updVelocita.ValueChanged += new System.EventHandler(this.updVelocita_ValueChanged);
            // 
            // updRaggio
            // 
            this.updRaggio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "Raggio", true));
            this.updRaggio.Location = new System.Drawing.Point(277, 446);
            this.updRaggio.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updRaggio.Name = "updRaggio";
            this.updRaggio.Size = new System.Drawing.Size(120, 22);
            this.updRaggio.TabIndex = 50;
            this.updRaggio.ValueChanged += new System.EventHandler(this.updRaggio_ValueChanged);
            // 
            // updMotori
            // 
            this.updMotori.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "NumeroMotori", true));
            this.updMotori.Location = new System.Drawing.Point(277, 295);
            this.updMotori.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.updMotori.Name = "updMotori";
            this.updMotori.Size = new System.Drawing.Size(120, 22);
            this.updMotori.TabIndex = 49;
            this.updMotori.ValueChanged += new System.EventHandler(this.updMotori_ValueChanged);
            // 
            // updLitri
            // 
            this.updLitri.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "LitriCarburante", true));
            this.updLitri.Location = new System.Drawing.Point(277, 242);
            this.updLitri.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updLitri.Name = "updLitri";
            this.updLitri.Size = new System.Drawing.Size(120, 22);
            this.updLitri.TabIndex = 48;
            this.updLitri.ValueChanged += new System.EventHandler(this.updLitri_ValueChanged);
            // 
            // updCapacita
            // 
            this.updCapacita.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblAereiBindingSource, "CapacitaMassima", true));
            this.updCapacita.Location = new System.Drawing.Point(277, 185);
            this.updCapacita.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updCapacita.Name = "updCapacita";
            this.updCapacita.Size = new System.Drawing.Size(120, 22);
            this.updCapacita.TabIndex = 47;
            this.updCapacita.ValueChanged += new System.EventHandler(this.updCapacita_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Raggio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 565);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Compagnia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Velocita Massima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Internazionale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tipo Propulsione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Numero Motori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Litri Carburante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Capacità Massima";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(75, 153);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(51, 17);
            this.lblCodice.TabIndex = 55;
            this.lblCodice.Text = "Codice";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(277, 150);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(265, 22);
            this.txtCodice.TabIndex = 56;
            this.txtCodice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodice_KeyUp);
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
            // tblAereiTableAdapter
            // 
            this.tblAereiTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DataSource = this.bindingSource2;
            this.cmbMarca.DisplayMember = "Nome";
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(277, 48);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(265, 24);
            this.cmbMarca.TabIndex = 60;
            this.cmbMarca.ValueMember = "Nome";
            this.cmbMarca.SelectionChangeCommitted += new System.EventHandler(this.cmbMarca_SelectionChangeCommitted);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Marche";
            this.bindingSource2.DataSource = this.aeroportoDataSet;
            // 
            // cmbModello
            // 
            this.cmbModello.DataSource = this.bindingSource1;
            this.cmbModello.DisplayMember = "Modello";
            this.cmbModello.FormattingEnabled = true;
            this.cmbModello.Location = new System.Drawing.Point(277, 101);
            this.cmbModello.Name = "cmbModello";
            this.cmbModello.Size = new System.Drawing.Size(265, 24);
            this.cmbModello.TabIndex = 59;
            this.cmbModello.ValueMember = "Modello";
            this.cmbModello.SelectedIndexChanged += new System.EventHandler(this.cmbModello_SelectedIndexChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Modelli";
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Marca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Modello";
            // 
            // modelliTableAdapter
            // 
            this.modelliTableAdapter.ClearBeforeFill = true;
            // 
            // marcheTableAdapter
            // 
            this.marcheTableAdapter.ClearBeforeFill = true;
            // 
            // aeroportoDataSetBindingSource
            // 
            this.aeroportoDataSetBindingSource.DataSource = this.aeroportoDataSet;
            this.aeroportoDataSetBindingSource.Position = 0;
            // 
            // frmInserisciAerei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 712);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.cmbModello);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.lblCodice);
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
            this.Controls.Add(this.btnSalvaENuovo);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtDataNascita);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.btnSalva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(616, 826);
            this.Name = "frmInserisciAerei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserisci Aerei";
            this.Load += new System.EventHandler(this.frmInserisciAerei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblAereiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updVelocita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updRaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMotori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCapacita)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalva;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblAereiBindingSource;
        private AeroportoDataSetTableAdapters.tblAereiTableAdapter tblAereiTableAdapter;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.TextBox txtDataNascita;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Button btnSalvaENuovo;
        private System.Windows.Forms.CheckBox chkInternazionale;
        private System.Windows.Forms.TextBox txtCompagnia;
        private System.Windows.Forms.TextBox txtPropulsione;
        private System.Windows.Forms.NumericUpDown updVelocita;
        private System.Windows.Forms.NumericUpDown updRaggio;
        private System.Windows.Forms.NumericUpDown updMotori;
        private System.Windows.Forms.NumericUpDown updLitri;
        private System.Windows.Forms.NumericUpDown updCapacita;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.TextBox txtCodice;
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
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbModello;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSetTableAdapters.ModelliTableAdapter modelliTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private AeroportoDataSetTableAdapters.MarcheTableAdapter marcheTableAdapter;
        private System.Windows.Forms.BindingSource aeroportoDataSetBindingSource;
    }
}