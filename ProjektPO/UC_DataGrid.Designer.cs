
namespace ProjektPO
{
    partial class UC_DataGrid
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridFIleLeft = new System.Windows.Forms.DataGridView();
            this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wielkośc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFIleLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFIleLeft
            // 
            this.dataGridFIleLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFIleLeft.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridFIleLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFIleLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwa,
            this.Typ,
            this.Wielkośc});
            this.dataGridFIleLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridFIleLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFIleLeft.Location = new System.Drawing.Point(0, 0);
            this.dataGridFIleLeft.Name = "dataGridFIleLeft";
            this.dataGridFIleLeft.RowHeadersVisible = false;
            this.dataGridFIleLeft.RowHeadersWidth = 51;
            this.dataGridFIleLeft.RowTemplate.Height = 24;
            this.dataGridFIleLeft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridFIleLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFIleLeft.Size = new System.Drawing.Size(511, 450);
            this.dataGridFIleLeft.TabIndex = 1;
            // 
            // nazwa
            // 
            this.nazwa.HeaderText = "name";
            this.nazwa.MinimumWidth = 6;
            this.nazwa.Name = "nazwa";
            // 
            // Typ
            // 
            this.Typ.HeaderText = "typ";
            this.Typ.MinimumWidth = 6;
            this.Typ.Name = "Typ";
            // 
            // Wielkośc
            // 
            this.Wielkośc.HeaderText = "size";
            this.Wielkośc.MinimumWidth = 6;
            this.Wielkośc.Name = "Wielkośc";
            // 
            // UC_DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridFIleLeft);
            this.Name = "UC_DataGrid";
            this.Size = new System.Drawing.Size(511, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFIleLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wielkośc;
        public System.Windows.Forms.DataGridView dataGridFIleLeft;
    }
}
