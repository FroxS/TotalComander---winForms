
namespace ProjektPO
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.tboxDirectory = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tboxDrag = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wielkośc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(326, 42);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(59, 24);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tboxDirectory
            // 
            this.tboxDirectory.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDirectory.Location = new System.Drawing.Point(26, 42);
            this.tboxDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.tboxDirectory.Name = "tboxDirectory";
            this.tboxDirectory.ReadOnly = true;
            this.tboxDirectory.Size = new System.Drawing.Size(284, 26);
            this.tboxDirectory.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.AllowDrop = true;
            this.panelLeft.Location = new System.Drawing.Point(34, 110);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(291, 282);
            this.panelLeft.TabIndex = 3;
            // 
            // panelRight
            // 
            this.panelRight.AllowDrop = true;
            this.panelRight.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelRight.Location = new System.Drawing.Point(814, 28);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(121, 108);
            this.panelRight.TabIndex = 4;
            this.panelRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panelRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panelRight.DragLeave += new System.EventHandler(this.panel1_DragLeave);
            // 
            // tboxDrag
            // 
            this.tboxDrag.Location = new System.Drawing.Point(498, 28);
            this.tboxDrag.Name = "tboxDrag";
            this.tboxDrag.Size = new System.Drawing.Size(188, 20);
            this.tboxDrag.TabIndex = 5;
            // 
            // dataGrid1
            // 
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwa,
            this.Typ,
            this.Wielkośc,
            this.path});
            this.dataGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid1.Location = new System.Drawing.Point(348, 191);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid1.Size = new System.Drawing.Size(196, 172);
            this.dataGrid1.TabIndex = 6;
            this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDown);
            this.dataGrid1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseMove);
            // 
            // nazwa
            // 
            this.nazwa.HeaderText = "name";
            this.nazwa.MinimumWidth = 6;
            this.nazwa.Name = "nazwa";
            this.nazwa.ReadOnly = true;
            // 
            // Typ
            // 
            this.Typ.HeaderText = "typ";
            this.Typ.MinimumWidth = 6;
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            // 
            // Wielkośc
            // 
            this.Wielkośc.HeaderText = "size";
            this.Wielkośc.MinimumWidth = 6;
            this.Wielkośc.Name = "Wielkośc";
            this.Wielkośc.ReadOnly = true;
            // 
            // path
            // 
            this.path.HeaderText = "path";
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Visible = false;
            // 
            // dataGrid2
            // 
            this.dataGrid2.AllowDrop = true;
            this.dataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGrid2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid2.Location = new System.Drawing.Point(592, 191);
            this.dataGrid2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.ReadOnly = true;
            this.dataGrid2.RowHeadersVisible = false;
            this.dataGrid2.RowHeadersWidth = 51;
            this.dataGrid2.RowTemplate.Height = 24;
            this.dataGrid2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid2.Size = new System.Drawing.Size(196, 172);
            this.dataGrid2.TabIndex = 7;
            this.dataGrid2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGrid2_DragDrop);
            this.dataGrid2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGrid2_DragEnter);
            this.dataGrid2.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGrid2_DragOver);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "typ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "size";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "path";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 505);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.tboxDrag);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.tboxDirectory);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tboxDirectory;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        public System.Windows.Forms.TextBox tboxDrag;
        public System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wielkośc;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        public System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

