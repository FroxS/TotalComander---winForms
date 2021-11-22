
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
            this.btnLoadLeft = new System.Windows.Forms.Button();
            this.tboxDirectoryLeft = new System.Windows.Forms.TextBox();
            this.tboxDirectoryRight = new System.Windows.Forms.TextBox();
            this.btnLoadRight = new System.Windows.Forms.Button();
            this.dataGridLeft = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadLeft
            // 
            this.btnLoadLeft.Location = new System.Drawing.Point(435, 52);
            this.btnLoadLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadLeft.Name = "btnLoadLeft";
            this.btnLoadLeft.Size = new System.Drawing.Size(79, 30);
            this.btnLoadLeft.TabIndex = 1;
            this.btnLoadLeft.Text = "...";
            this.btnLoadLeft.UseVisualStyleBackColor = true;
            this.btnLoadLeft.Click += new System.EventHandler(this.btnLoadLeft_Click);
            // 
            // tboxDirectoryLeft
            // 
            this.tboxDirectoryLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDirectoryLeft.Location = new System.Drawing.Point(35, 52);
            this.tboxDirectoryLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxDirectoryLeft.Name = "tboxDirectoryLeft";
            this.tboxDirectoryLeft.ReadOnly = true;
            this.tboxDirectoryLeft.Size = new System.Drawing.Size(377, 30);
            this.tboxDirectoryLeft.TabIndex = 2;
            // 
            // tboxDirectoryRight
            // 
            this.tboxDirectoryRight.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDirectoryRight.Location = new System.Drawing.Point(717, 52);
            this.tboxDirectoryRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxDirectoryRight.Name = "tboxDirectoryRight";
            this.tboxDirectoryRight.ReadOnly = true;
            this.tboxDirectoryRight.Size = new System.Drawing.Size(375, 30);
            this.tboxDirectoryRight.TabIndex = 9;
            // 
            // btnLoadRight
            // 
            this.btnLoadRight.Location = new System.Drawing.Point(1117, 52);
            this.btnLoadRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadRight.Name = "btnLoadRight";
            this.btnLoadRight.Size = new System.Drawing.Size(77, 30);
            this.btnLoadRight.TabIndex = 8;
            this.btnLoadRight.Text = "...";
            this.btnLoadRight.UseVisualStyleBackColor = true;
            this.btnLoadRight.Click += new System.EventHandler(this.btnLoadRight_Click);
            // 
            // dataGridLeft
            // 
            this.dataGridLeft.AllowDrop = true;
            this.dataGridLeft.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridLeft.Location = new System.Drawing.Point(35, 149);
            this.dataGridLeft.Name = "dataGridLeft";
            this.dataGridLeft.ReadOnly = true;
            this.dataGridLeft.RowHeadersVisible = false;
            this.dataGridLeft.RowHeadersWidth = 51;
            this.dataGridLeft.RowTemplate.Height = 24;
            this.dataGridLeft.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLeft.Size = new System.Drawing.Size(479, 252);
            this.dataGridLeft.TabIndex = 10;
            this.dataGridLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridLeft_MouseDown);
            this.dataGridLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridLeft_MouseMove);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "path";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Wielkość";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Typ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridRight
            // 
            this.dataGridRight.AllowDrop = true;
            this.dataGridRight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridRight.Location = new System.Drawing.Point(717, 149);
            this.dataGridRight.Name = "dataGridRight";
            this.dataGridRight.ReadOnly = true;
            this.dataGridRight.RowHeadersVisible = false;
            this.dataGridRight.RowHeadersWidth = 51;
            this.dataGridRight.RowTemplate.Height = 24;
            this.dataGridRight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRight.Size = new System.Drawing.Size(479, 252);
            this.dataGridRight.TabIndex = 11;
            this.dataGridRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridRight_DragDrop);
            this.dataGridRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridRight_DragEnter);
            this.dataGridRight.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridRight_DragOver);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "path";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Wielkość";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Typ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 622);
            this.Controls.Add(this.dataGridRight);
            this.Controls.Add(this.dataGridLeft);
            this.Controls.Add(this.tboxDirectoryRight);
            this.Controls.Add(this.btnLoadRight);
            this.Controls.Add(this.tboxDirectoryLeft);
            this.Controls.Add(this.btnLoadLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadLeft;
        private System.Windows.Forms.TextBox tboxDirectoryLeft;
        private System.Windows.Forms.TextBox tboxDirectoryRight;
        private System.Windows.Forms.Button btnLoadRight;
        private System.Windows.Forms.DataGridView dataGridLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGridRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}

