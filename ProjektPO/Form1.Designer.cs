
namespace ProjektPO
{
    partial class TotalComander
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.chboxMove = new System.Windows.Forms.CheckBox();
            this.chboxOverwrite = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRightGrid = new System.Windows.Forms.Panel();
            this.panelLeftGrid = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadLeft
            // 
            this.btnLoadLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLoadLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadLeft.FlatAppearance.BorderSize = 0;
            this.btnLoadLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadLeft.Location = new System.Drawing.Point(530, 8);
            this.btnLoadLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLoadLeft.Name = "btnLoadLeft";
            this.btnLoadLeft.Size = new System.Drawing.Size(48, 28);
            this.btnLoadLeft.TabIndex = 1;
            this.btnLoadLeft.Text = "...";
            this.btnLoadLeft.UseVisualStyleBackColor = false;
            this.btnLoadLeft.Click += new System.EventHandler(this.btnLoadLeft_Click);
            // 
            // tboxDirectoryLeft
            // 
            this.tboxDirectoryLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tboxDirectoryLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxDirectoryLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDirectoryLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxDirectoryLeft.Location = new System.Drawing.Point(8, 8);
            this.tboxDirectoryLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxDirectoryLeft.Name = "tboxDirectoryLeft";
            this.tboxDirectoryLeft.ReadOnly = true;
            this.tboxDirectoryLeft.Size = new System.Drawing.Size(488, 26);
            this.tboxDirectoryLeft.TabIndex = 2;
            // 
            // tboxDirectoryRight
            // 
            this.tboxDirectoryRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tboxDirectoryRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.tboxDirectoryRight.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDirectoryRight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxDirectoryRight.Location = new System.Drawing.Point(8, 8);
            this.tboxDirectoryRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxDirectoryRight.Name = "tboxDirectoryRight";
            this.tboxDirectoryRight.ReadOnly = true;
            this.tboxDirectoryRight.Size = new System.Drawing.Size(491, 26);
            this.tboxDirectoryRight.TabIndex = 9;
            // 
            // btnLoadRight
            // 
            this.btnLoadRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnLoadRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadRight.FlatAppearance.BorderSize = 0;
            this.btnLoadRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadRight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoadRight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadRight.Location = new System.Drawing.Point(535, 8);
            this.btnLoadRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLoadRight.Name = "btnLoadRight";
            this.btnLoadRight.Size = new System.Drawing.Size(43, 28);
            this.btnLoadRight.TabIndex = 8;
            this.btnLoadRight.Text = "...";
            this.btnLoadRight.UseVisualStyleBackColor = false;
            this.btnLoadRight.Click += new System.EventHandler(this.btnLoadRight_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 701);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1244, 40);
            this.panelBottom.TabIndex = 12;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.chboxMove);
            this.panelTop.Controls.Add(this.chboxOverwrite);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1244, 90);
            this.panelTop.TabIndex = 13;
            // 
            // chboxMove
            // 
            this.chboxMove.AutoSize = true;
            this.chboxMove.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chboxMove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chboxMove.Location = new System.Drawing.Point(24, 40);
            this.chboxMove.Name = "chboxMove";
            this.chboxMove.Size = new System.Drawing.Size(75, 21);
            this.chboxMove.TabIndex = 1;
            this.chboxMove.Text = "Przenoś";
            this.chboxMove.UseVisualStyleBackColor = true;
            // 
            // chboxOverwrite
            // 
            this.chboxOverwrite.AutoSize = true;
            this.chboxOverwrite.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chboxOverwrite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chboxOverwrite.Location = new System.Drawing.Point(24, 13);
            this.chboxOverwrite.Name = "chboxOverwrite";
            this.chboxOverwrite.Size = new System.Drawing.Size(80, 21);
            this.chboxOverwrite.TabIndex = 0;
            this.chboxOverwrite.Text = "Nadpisuj";
            this.chboxOverwrite.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelRightGrid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelLeftGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 611);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panelRightGrid
            // 
            this.panelRightGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightGrid.Location = new System.Drawing.Point(655, 53);
            this.panelRightGrid.Name = "panelRightGrid";
            this.panelRightGrid.Padding = new System.Windows.Forms.Padding(5);
            this.panelRightGrid.Size = new System.Drawing.Size(586, 555);
            this.panelRightGrid.TabIndex = 12;
            // 
            // panelLeftGrid
            // 
            this.panelLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeftGrid.Location = new System.Drawing.Point(3, 53);
            this.panelLeftGrid.Name = "panelLeftGrid";
            this.panelLeftGrid.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeftGrid.Size = new System.Drawing.Size(586, 555);
            this.panelLeftGrid.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tboxDirectoryRight);
            this.panel2.Controls.Add(this.btnLoadRight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(655, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(586, 44);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadLeft);
            this.panel1.Controls.Add(this.tboxDirectoryLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(586, 44);
            this.panel1.TabIndex = 10;
            // 
            // TotalComander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1244, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1260, 780);
            this.Name = "TotalComander";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TotalComander";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadLeft;
        private System.Windows.Forms.TextBox tboxDirectoryLeft;
        private System.Windows.Forms.TextBox tboxDirectoryRight;
        private System.Windows.Forms.Button btnLoadRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRightGrid;
        private System.Windows.Forms.Panel panelLeftGrid;
        public System.Windows.Forms.CheckBox chboxMove;
        public System.Windows.Forms.CheckBox chboxOverwrite;
    }
}

