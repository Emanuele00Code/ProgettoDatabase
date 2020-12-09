
namespace ProgettoDatabase
{
    partial class frmVoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoli));
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnFittizia = new System.Windows.Forms.Button();
            this.dvgVoli = new System.Windows.Forms.DataGridView();
            this.aeroportoDataSet = new ProgettoDatabase.AeroportoDataSet();
            this.tblVoliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblVoliTableAdapter = new ProgettoDatabase.AeroportoDataSetTableAdapters.tblVoliTableAdapter();
            this.codiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOraPartenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOraArrivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internazionaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.partenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gatePartenzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceAereoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Gold;
            this.btnSalva.Location = new System.Drawing.Point(93, 309);
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
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.Gold;
            this.btnModifica.Location = new System.Drawing.Point(410, 311);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(124, 44);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNuovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuovo.ForeColor = System.Drawing.Color.Gold;
            this.btnNuovo.Location = new System.Drawing.Point(253, 310);
            this.btnNuovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(124, 44);
            this.btnNuovo.TabIndex = 3;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = false;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnVisualizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizza.ForeColor = System.Drawing.Color.Gold;
            this.btnVisualizza.Location = new System.Drawing.Point(1071, 309);
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
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.Color.Gold;
            this.btnElimina.Location = new System.Drawing.Point(818, 309);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(215, 44);
            this.btnElimina.TabIndex = 5;
            this.btnElimina.Text = "ELIMINAZIONE VERA E PROPRIA";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnFittizia
            // 
            this.btnFittizia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnFittizia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFittizia.ForeColor = System.Drawing.Color.Gold;
            this.btnFittizia.Location = new System.Drawing.Point(581, 311);
            this.btnFittizia.Name = "btnFittizia";
            this.btnFittizia.Size = new System.Drawing.Size(197, 43);
            this.btnFittizia.TabIndex = 6;
            this.btnFittizia.Text = "ELIMINAZIONE FITTIZIA";
            this.btnFittizia.UseVisualStyleBackColor = false;
            this.btnFittizia.Click += new System.EventHandler(this.btnFittizia_Click);
            // 
            // dvgVoli
            // 
            this.dvgVoli.AutoGenerateColumns = false;
            this.dvgVoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVoli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codiceDataGridViewTextBoxColumn,
            this.dataOraPartenzaDataGridViewTextBoxColumn,
            this.dataOraArrivoDataGridViewTextBoxColumn,
            this.internazionaleDataGridViewCheckBoxColumn,
            this.partenzaDataGridViewTextBoxColumn,
            this.gatePartenzaDataGridViewTextBoxColumn,
            this.durataDataGridViewTextBoxColumn,
            this.destinazioneDataGridViewTextBoxColumn,
            this.codiceAereoDataGridViewTextBoxColumn});
            this.dvgVoli.DataSource = this.tblVoliBindingSource;
            this.dvgVoli.Location = new System.Drawing.Point(93, 75);
            this.dvgVoli.Name = "dvgVoli";
            this.dvgVoli.ReadOnly = true;
            this.dvgVoli.RowHeadersWidth = 51;
            this.dvgVoli.RowTemplate.Height = 24;
            this.dvgVoli.Size = new System.Drawing.Size(1175, 166);
            this.dvgVoli.TabIndex = 7;
            // 
            // aeroportoDataSet
            // 
            this.aeroportoDataSet.DataSetName = "AeroportoDataSet";
            this.aeroportoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVoliBindingSource
            // 
            this.tblVoliBindingSource.DataMember = "tblVoli";
            this.tblVoliBindingSource.DataSource = this.aeroportoDataSet;
            // 
            // tblVoliTableAdapter
            // 
            this.tblVoliTableAdapter.ClearBeforeFill = true;
            // 
            // codiceDataGridViewTextBoxColumn
            // 
            this.codiceDataGridViewTextBoxColumn.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceDataGridViewTextBoxColumn.Name = "codiceDataGridViewTextBoxColumn";
            this.codiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.codiceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataOraPartenzaDataGridViewTextBoxColumn
            // 
            this.dataOraPartenzaDataGridViewTextBoxColumn.DataPropertyName = "DataOraPartenza";
            this.dataOraPartenzaDataGridViewTextBoxColumn.HeaderText = "DataOraPartenza";
            this.dataOraPartenzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataOraPartenzaDataGridViewTextBoxColumn.Name = "dataOraPartenzaDataGridViewTextBoxColumn";
            this.dataOraPartenzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataOraPartenzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataOraArrivoDataGridViewTextBoxColumn
            // 
            this.dataOraArrivoDataGridViewTextBoxColumn.DataPropertyName = "DataOraArrivo";
            this.dataOraArrivoDataGridViewTextBoxColumn.HeaderText = "DataOraArrivo";
            this.dataOraArrivoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataOraArrivoDataGridViewTextBoxColumn.Name = "dataOraArrivoDataGridViewTextBoxColumn";
            this.dataOraArrivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataOraArrivoDataGridViewTextBoxColumn.Width = 125;
            // 
            // internazionaleDataGridViewCheckBoxColumn
            // 
            this.internazionaleDataGridViewCheckBoxColumn.DataPropertyName = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.HeaderText = "Internazionale";
            this.internazionaleDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.internazionaleDataGridViewCheckBoxColumn.Name = "internazionaleDataGridViewCheckBoxColumn";
            this.internazionaleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.internazionaleDataGridViewCheckBoxColumn.Width = 125;
            // 
            // partenzaDataGridViewTextBoxColumn
            // 
            this.partenzaDataGridViewTextBoxColumn.DataPropertyName = "Partenza";
            this.partenzaDataGridViewTextBoxColumn.HeaderText = "Partenza";
            this.partenzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partenzaDataGridViewTextBoxColumn.Name = "partenzaDataGridViewTextBoxColumn";
            this.partenzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.partenzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // gatePartenzaDataGridViewTextBoxColumn
            // 
            this.gatePartenzaDataGridViewTextBoxColumn.DataPropertyName = "GatePartenza";
            this.gatePartenzaDataGridViewTextBoxColumn.HeaderText = "GatePartenza";
            this.gatePartenzaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gatePartenzaDataGridViewTextBoxColumn.Name = "gatePartenzaDataGridViewTextBoxColumn";
            this.gatePartenzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.gatePartenzaDataGridViewTextBoxColumn.Width = 125;
            // 
            // durataDataGridViewTextBoxColumn
            // 
            this.durataDataGridViewTextBoxColumn.DataPropertyName = "Durata";
            this.durataDataGridViewTextBoxColumn.HeaderText = "Durata";
            this.durataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durataDataGridViewTextBoxColumn.Name = "durataDataGridViewTextBoxColumn";
            this.durataDataGridViewTextBoxColumn.ReadOnly = true;
            this.durataDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinazioneDataGridViewTextBoxColumn
            // 
            this.destinazioneDataGridViewTextBoxColumn.DataPropertyName = "Destinazione";
            this.destinazioneDataGridViewTextBoxColumn.HeaderText = "Destinazione";
            this.destinazioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinazioneDataGridViewTextBoxColumn.Name = "destinazioneDataGridViewTextBoxColumn";
            this.destinazioneDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinazioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // codiceAereoDataGridViewTextBoxColumn
            // 
            this.codiceAereoDataGridViewTextBoxColumn.DataPropertyName = "CodiceAereo";
            this.codiceAereoDataGridViewTextBoxColumn.HeaderText = "CodiceAereo";
            this.codiceAereoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codiceAereoDataGridViewTextBoxColumn.Name = "codiceAereoDataGridViewTextBoxColumn";
            this.codiceAereoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codiceAereoDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmVoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1428, 404);
            this.Controls.Add(this.dvgVoli);
            this.Controls.Add(this.btnFittizia);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSalva);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1446, 451);
            this.MinimumSize = new System.Drawing.Size(1446, 451);
            this.Name = "frmVoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voli";
            this.Load += new System.EventHandler(this.frmPersone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVoliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AeroportoDataSet aeroportoDataSet;

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnFittizia;
        private System.Windows.Forms.DataGridView dvgVoli;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr8DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr9DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr14DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr16DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr17DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expr18DataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource tblVoliBindingSource;
        private AeroportoDataSetTableAdapters.tblVoliTableAdapter tblVoliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOraPartenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOraArrivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn internazionaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gatePartenzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceAereoDataGridViewTextBoxColumn;
    }
}