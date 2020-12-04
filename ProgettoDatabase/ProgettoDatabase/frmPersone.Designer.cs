
namespace TestDatabase
{
    partial class frmPersone
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
            this.dgvPersone = new System.Windows.Forms.DataGridView();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnFittizia = new System.Windows.Forms.Button();
            this.codicePersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportoDataSet = new TestDatabase.AeroportoDataSet();
            this.tblPersoneTableAdapter = new TestDatabase.AeroportoDataSetTableAdapters.tblPersoneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersone
            // 
            this.dgvPersone.AutoGenerateColumns = false;
            this.dgvPersone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codicePersonaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.nazioneDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn,
            this.sessoDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn});
            this.dgvPersone.DataSource = this.tblPersoneBindingSource;
            this.dgvPersone.Location = new System.Drawing.Point(32, 60);
            this.dgvPersone.MultiSelect = false;
            this.dgvPersone.Name = "dgvPersone";
            this.dgvPersone.Size = new System.Drawing.Size(978, 150);
            this.dgvPersone.TabIndex = 0;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(32, 244);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(93, 36);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(314, 244);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(148, 36);
            this.btnModifica.TabIndex = 2;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(141, 244);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(148, 36);
            this.btnNuovo.TabIndex = 3;
            this.btnNuovo.Text = "NUOVO";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(862, 244);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(148, 36);
            this.btnVisualizza.TabIndex = 4;
            this.btnVisualizza.Text = "VISUALIZZA";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(480, 244);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(207, 36);
            this.btnElimina.TabIndex = 5;
            this.btnElimina.Text = "ELIMINAZIONE VERA E PROPRIA";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnFittizia
            // 
            this.btnFittizia.Location = new System.Drawing.Point(701, 244);
            this.btnFittizia.Name = "btnFittizia";
            this.btnFittizia.Size = new System.Drawing.Size(148, 36);
            this.btnFittizia.TabIndex = 6;
            this.btnFittizia.Text = "ELIMINAZIONE FITTIZIA";
            this.btnFittizia.UseVisualStyleBackColor = true;
            this.btnFittizia.Click += new System.EventHandler(this.btnFittizia_Click);
            // 
            // codicePersonaDataGridViewTextBoxColumn
            // 
            this.codicePersonaDataGridViewTextBoxColumn.DataPropertyName = "CodicePersona";
            this.codicePersonaDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.codicePersonaDataGridViewTextBoxColumn.Name = "codicePersonaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // nazioneDataGridViewTextBoxColumn
            // 
            this.nazioneDataGridViewTextBoxColumn.DataPropertyName = "Nazione";
            this.nazioneDataGridViewTextBoxColumn.HeaderText = "Nazione";
            this.nazioneDataGridViewTextBoxColumn.Name = "nazioneDataGridViewTextBoxColumn";
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "Data nascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            // 
            // sessoDataGridViewTextBoxColumn
            // 
            this.sessoDataGridViewTextBoxColumn.DataPropertyName = "Sesso";
            this.sessoDataGridViewTextBoxColumn.HeaderText = "Sesso";
            this.sessoDataGridViewTextBoxColumn.Name = "sessoDataGridViewTextBoxColumn";
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo documento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "Numero documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.Width = 150;
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
            // tblPersoneTableAdapter
            // 
            this.tblPersoneTableAdapter.ClearBeforeFill = true;
            // 
            // frmPersone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 328);
            this.Controls.Add(this.btnFittizia);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.dgvPersone);
            this.Name = "frmPersone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persone";
            this.Load += new System.EventHandler(this.frmPersone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersone;
        private AeroportoDataSet aeroportoDataSet;
        private System.Windows.Forms.BindingSource tblPersoneBindingSource;
        private AeroportoDataSetTableAdapters.tblPersoneTableAdapter tblPersoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codicePersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnFittizia;
    }
}