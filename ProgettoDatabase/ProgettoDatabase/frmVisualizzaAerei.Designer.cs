
namespace ProgettoDatabase
{
    partial class frmVisualizzaAerei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizzaAerei));
            this.chkInternazionale = new System.Windows.Forms.CheckBox();
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
            this.txtModello = new System.Windows.Forms.TextBox();
            this.lblModello = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.tblAereiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAereiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.updVelocita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updRaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMotori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCapacita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chkInternazionale
            // 
            this.chkInternazionale.AutoSize = true;
            this.chkInternazionale.Location = new System.Drawing.Point(274, 406);
            this.chkInternazionale.Name = "chkInternazionale";
            this.chkInternazionale.Size = new System.Drawing.Size(18, 17);
            this.chkInternazionale.TabIndex = 54;
            this.chkInternazionale.UseVisualStyleBackColor = true;
            // 
            // txtCompagnia
            // 
            this.txtCompagnia.Location = new System.Drawing.Point(274, 562);
            this.txtCompagnia.Name = "txtCompagnia";
            this.txtCompagnia.Size = new System.Drawing.Size(265, 22);
            this.txtCompagnia.TabIndex = 53;
            // 
            // txtPropulsione
            // 
            this.txtPropulsione.Location = new System.Drawing.Point(274, 347);
            this.txtPropulsione.Name = "txtPropulsione";
            this.txtPropulsione.Size = new System.Drawing.Size(265, 22);
            this.txtPropulsione.TabIndex = 52;
            // 
            // updVelocita
            // 
            this.updVelocita.Location = new System.Drawing.Point(274, 503);
            this.updVelocita.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.updVelocita.Name = "updVelocita";
            this.updVelocita.Size = new System.Drawing.Size(120, 22);
            this.updVelocita.TabIndex = 51;
            // 
            // updRaggio
            // 
            this.updRaggio.Location = new System.Drawing.Point(274, 448);
            this.updRaggio.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updRaggio.Name = "updRaggio";
            this.updRaggio.Size = new System.Drawing.Size(120, 22);
            this.updRaggio.TabIndex = 50;
            // 
            // updMotori
            // 
            this.updMotori.Location = new System.Drawing.Point(274, 297);
            this.updMotori.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.updMotori.Name = "updMotori";
            this.updMotori.Size = new System.Drawing.Size(120, 22);
            this.updMotori.TabIndex = 49;
            // 
            // updLitri
            // 
            this.updLitri.Location = new System.Drawing.Point(274, 244);
            this.updLitri.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updLitri.Name = "updLitri";
            this.updLitri.Size = new System.Drawing.Size(120, 22);
            this.updLitri.TabIndex = 48;
            // 
            // updCapacita
            // 
            this.updCapacita.Location = new System.Drawing.Point(274, 187);
            this.updCapacita.Maximum = new decimal(new int[] {
            32766,
            0,
            0,
            0});
            this.updCapacita.Name = "updCapacita";
            this.updCapacita.Size = new System.Drawing.Size(120, 22);
            this.updCapacita.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Raggio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Compagnia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Velocita Massima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Internazionale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tipo Propulsione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Numero Motori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Litri Carburante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Capacità Massima";
            // 
            // txtModello
            // 
            this.txtModello.Location = new System.Drawing.Point(274, 140);
            this.txtModello.Margin = new System.Windows.Forms.Padding(4);
            this.txtModello.Name = "txtModello";
            this.txtModello.Size = new System.Drawing.Size(265, 22);
            this.txtModello.TabIndex = 38;
            // 
            // lblModello
            // 
            this.lblModello.AutoSize = true;
            this.lblModello.Location = new System.Drawing.Point(70, 140);
            this.lblModello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModello.Name = "lblModello";
            this.lblModello.Size = new System.Drawing.Size(57, 17);
            this.lblModello.TabIndex = 36;
            this.lblModello.Text = "Modello";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(274, 82);
            this.txtCodice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(265, 22);
            this.txtCodice.TabIndex = 56;
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(70, 82);
            this.lblCodice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(51, 17);
            this.lblCodice.TabIndex = 55;
            this.lblCodice.Text = "Codice";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblAerei";
            this.bindingSource1.DataSource = this.aeroportoDataSet;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAereiTableAdapter
            // 
            this.tblAereiTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizzaAerei
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(595, 557);
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
            this.Controls.Add(this.txtModello);
            this.Controls.Add(this.lblModello);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(613, 703);
            this.Name = "frmVisualizzaAerei";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizza Aerei";
            this.Load += new System.EventHandler(this.frmVisualizzaAerei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updVelocita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updRaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMotori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCapacita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.Label lblModello;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label lblCodice;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AeroportoDataSet aeroportoDataSet;
        private AeroportoDataSetTableAdapters.tblAereiTableAdapter tblAereiTableAdapter;
    }
}