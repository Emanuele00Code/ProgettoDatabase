
namespace ProgettoDatabase
{
    partial class frmAeroporti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAeroporti));
            this.tblPersoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnFittizia = new System.Windows.Forms.Button();
            this.tblAeroportiTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblAeroportiTableAdapter();
            this.dvgAeroporti = new System.Windows.Forms.DataGridView();
            this.siglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.militareDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.internazionaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblAeroportiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAeroporti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAeroportiBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalva.Location = new System.Drawing.Point(43, 309);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(124, 44);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnModifica.Location = new System.Drawing.Point(471, 309);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(197, 44);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnNuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuovo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnNuovo.Location = new System.Drawing.Point(215, 309);
            this.btnNuovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(197, 44);
            this.btnNuovo.TabIndex = 3;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = false;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnVisualizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizza.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVisualizza.Location = new System.Drawing.Point(1150, 309);
            this.btnVisualizza.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(197, 44);
            this.btnVisualizza.TabIndex = 4;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = false;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnElimina.Location = new System.Drawing.Point(915, 309);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(215, 44);
            this.btnElimina.TabIndex = 5;
            this.btnElimina.Text = "ELIMINAZIONE VERA E PROPRIA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnFittizia
            // 
            this.btnFittizia.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnFittizia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFittizia.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFittizia.Location = new System.Drawing.Point(692, 309);
            this.btnFittizia.Name = "btnFittizia";
            this.btnFittizia.Size = new System.Drawing.Size(197, 43);
            this.btnFittizia.TabIndex = 6;
            this.btnFittizia.Text = "ELIMINAZIONE FITTIZIA";
            this.btnFittizia.UseVisualStyleBackColor = false;
            this.btnFittizia.Click += new System.EventHandler(this.btnFittizia_Click);
            // 
            // tblAeroportiTableAdapter
            // 
            this.tblAeroportiTableAdapter.ClearBeforeFill = true;
            // 
            // dvgAeroporti
            // 
            this.dvgAeroporti.AutoGenerateColumns = false;
            this.dvgAeroporti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAeroporti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siglaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.pisteDataGridViewTextBoxColumn,
            this.terminalDataGridViewTextBoxColumn,
            this.gatesDataGridViewTextBoxColumn,
            this.nazioneDataGridViewTextBoxColumn,
            this.cittaDataGridViewTextBoxColumn,
            this.militareDataGridViewCheckBoxColumn,
            this.internazionaleDataGridViewCheckBoxColumn});
            this.dvgAeroporti.DataSource = this.tblAeroportiBindingSource;
            this.dvgAeroporti.Location = new System.Drawing.Point(43, 12);
            this.dvgAeroporti.Name = "dvgAeroporti";
            this.dvgAeroporti.RowHeadersWidth = 51;
            this.dvgAeroporti.RowTemplate.Height = 24;
            this.dvgAeroporti.Size = new System.Drawing.Size(1297, 166);
            this.dvgAeroporti.TabIndex = 7;
            // 
            // siglaDataGridViewTextBoxColumn
            // 
            this.siglaDataGridViewTextBoxColumn.DataPropertyName = "Sigla";
            this.siglaDataGridViewTextBoxColumn.HeaderText = "Sigla";
            this.siglaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siglaDataGridViewTextBoxColumn.Name = "siglaDataGridViewTextBoxColumn";
            this.siglaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pisteDataGridViewTextBoxColumn
            // 
            this.pisteDataGridViewTextBoxColumn.DataPropertyName = "Piste";
            this.pisteDataGridViewTextBoxColumn.HeaderText = "Piste";
            this.pisteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pisteDataGridViewTextBoxColumn.Name = "pisteDataGridViewTextBoxColumn";
            this.pisteDataGridViewTextBoxColumn.Width = 125;
            // 
            // terminalDataGridViewTextBoxColumn
            // 
            this.terminalDataGridViewTextBoxColumn.DataPropertyName = "Terminal";
            this.terminalDataGridViewTextBoxColumn.HeaderText = "Terminal";
            this.terminalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminalDataGridViewTextBoxColumn.Name = "terminalDataGridViewTextBoxColumn";
            this.terminalDataGridViewTextBoxColumn.Width = 125;
            // 
            // gatesDataGridViewTextBoxColumn
            // 
            this.gatesDataGridViewTextBoxColumn.DataPropertyName = "Gates";
            this.gatesDataGridViewTextBoxColumn.HeaderText = "Gates";
            this.gatesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gatesDataGridViewTextBoxColumn.Name = "gatesDataGridViewTextBoxColumn";
            this.gatesDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazioneDataGridViewTextBoxColumn
            // 
            this.nazioneDataGridViewTextBoxColumn.DataPropertyName = "Nazione";
            this.nazioneDataGridViewTextBoxColumn.HeaderText = "Nazione";
            this.nazioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazioneDataGridViewTextBoxColumn.Name = "nazioneDataGridViewTextBoxColumn";
            this.nazioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cittaDataGridViewTextBoxColumn
            // 
            this.cittaDataGridViewTextBoxColumn.DataPropertyName = "Citta";
            this.cittaDataGridViewTextBoxColumn.HeaderText = "Citta";
            this.cittaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cittaDataGridViewTextBoxColumn.Name = "cittaDataGridViewTextBoxColumn";
            this.cittaDataGridViewTextBoxColumn.Width = 125;
            // 
            // militareDataGridViewCheckBoxColumn
            // 
            this.militareDataGridViewCheckBoxColumn.DataPropertyName = "Militare";
            this.militareDataGridViewCheckBoxColumn.HeaderText = "Militare";
            this.militareDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.militareDataGridViewCheckBoxColumn.Name = "militareDataGridViewCheckBoxColumn";
            this.militareDataGridViewCheckBoxColumn.Width = 125;
            // 
            // internazionaleDataGridViewCheckBoxColumn
            // 
            this.internazionaleDataGridViewCheckBoxColumn.DataPropertyName = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.HeaderText = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.internazionaleDataGridViewCheckBoxColumn.Name = "internazionaleDataGridViewCheckBoxColumn";
            this.internazionaleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // tblAeroportiBindingSource
            // 
            this.tblAeroportiBindingSource.DataMember = "tblAeroporti";
            this.tblAeroportiBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // frmAeroporti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1428, 404);
            this.Controls.Add(this.dvgAeroporti);
            this.Controls.Add(this.btnFittizia);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSalva);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1446, 451);
            this.Name = "frmAeroporti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aeroporti";
            this.Load += new System.EventHandler(this.frmPersone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAeroporti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAeroportiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblPersoneBindingSource;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnFittizia;
        private AeroportoDataSetTableAdapters.tblAeroportiTableAdapter tblAeroportiTableAdapter;
        private System.Windows.Forms.DataGridView dvgAeroporti;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn militareDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internazionaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tblAeroportiBindingSource;
    }
}