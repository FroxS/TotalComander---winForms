
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
            this.btnLoadRight = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelRightSource = new System.Windows.Forms.Label();
            this.labelLeftSource = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.chboxMove = new System.Windows.Forms.CheckBox();
            this.chboxOverwrite = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMoveAll = new System.Windows.Forms.Button();
            this.btnMoveOne = new System.Windows.Forms.Button();
            this.panelRightGrid = new System.Windows.Forms.Panel();
            this.panelLeftGrid = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbRightDrive = new System.Windows.Forms.ComboBox();
            this.tboxSearchRight = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbLeftDrive = new System.Windows.Forms.ComboBox();
            this.tboxSearchLeft = new System.Windows.Forms.TextBox();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panelBottom.Controls.Add(this.labelRightSource);
            this.panelBottom.Controls.Add(this.labelLeftSource);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 701);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1244, 40);
            this.panelBottom.TabIndex = 12;
            // 
            // labelRightSource
            // 
            this.labelRightSource.AutoSize = true;
            this.labelRightSource.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRightSource.Location = new System.Drawing.Point(652, 14);
            this.labelRightSource.Name = "labelRightSource";
            this.labelRightSource.Size = new System.Drawing.Size(85, 17);
            this.labelRightSource.TabIndex = 1;
            this.labelRightSource.Text = "Prawa Strona";
            // 
            // labelLeftSource
            // 
            this.labelLeftSource.AutoSize = true;
            this.labelLeftSource.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelLeftSource.Location = new System.Drawing.Point(4, 15);
            this.labelLeftSource.Name = "labelLeftSource";
            this.labelLeftSource.Size = new System.Drawing.Size(79, 17);
            this.labelLeftSource.TabIndex = 0;
            this.labelLeftSource.Text = "Lewa Strona";
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
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMoveAll);
            this.panel3.Controls.Add(this.btnMoveOne);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(595, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(54, 555);
            this.panel3.TabIndex = 2;
            // 
            // btnMoveAll
            // 
            this.btnMoveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnMoveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveAll.FlatAppearance.BorderSize = 0;
            this.btnMoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMoveAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMoveAll.Location = new System.Drawing.Point(2, 243);
            this.btnMoveAll.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveAll.Name = "btnMoveAll";
            this.btnMoveAll.Size = new System.Drawing.Size(48, 28);
            this.btnMoveAll.TabIndex = 5;
            this.btnMoveAll.Text = "<<>>";
            this.btnMoveAll.UseVisualStyleBackColor = false;
            // 
            // btnMoveOne
            // 
            this.btnMoveOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnMoveOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoveOne.FlatAppearance.BorderSize = 0;
            this.btnMoveOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveOne.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMoveOne.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMoveOne.Location = new System.Drawing.Point(2, 209);
            this.btnMoveOne.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMoveOne.Name = "btnMoveOne";
            this.btnMoveOne.Size = new System.Drawing.Size(48, 28);
            this.btnMoveOne.TabIndex = 4;
            this.btnMoveOne.Text = "<>";
            this.btnMoveOne.UseVisualStyleBackColor = false;
            this.btnMoveOne.Click += new System.EventHandler(this.btnMoveOne_Click);
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
            this.panel2.Controls.Add(this.cmbRightDrive);
            this.panel2.Controls.Add(this.tboxSearchRight);
            this.panel2.Controls.Add(this.btnLoadRight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(655, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(586, 44);
            this.panel2.TabIndex = 10;
            // 
            // cmbRightDrive
            // 
            this.cmbRightDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cmbRightDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbRightDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRightDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRightDrive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRightDrive.FormattingEnabled = true;
            this.cmbRightDrive.Location = new System.Drawing.Point(11, 10);
            this.cmbRightDrive.Name = "cmbRightDrive";
            this.cmbRightDrive.Size = new System.Drawing.Size(121, 25);
            this.cmbRightDrive.TabIndex = 10;
            // 
            // tboxSearchRight
            // 
            this.tboxSearchRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSearchRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tboxSearchRight.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxSearchRight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxSearchRight.Location = new System.Drawing.Point(152, 9);
            this.tboxSearchRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxSearchRight.Name = "tboxSearchRight";
            this.tboxSearchRight.Size = new System.Drawing.Size(368, 26);
            this.tboxSearchRight.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbLeftDrive);
            this.panel1.Controls.Add(this.btnLoadLeft);
            this.panel1.Controls.Add(this.tboxSearchLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(586, 44);
            this.panel1.TabIndex = 10;
            // 
            // cmbLeftDrive
            // 
            this.cmbLeftDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.cmbLeftDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLeftDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLeftDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLeftDrive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLeftDrive.FormattingEnabled = true;
            this.cmbLeftDrive.Location = new System.Drawing.Point(9, 11);
            this.cmbLeftDrive.Name = "cmbLeftDrive";
            this.cmbLeftDrive.Size = new System.Drawing.Size(121, 25);
            this.cmbLeftDrive.TabIndex = 3;
            // 
            // tboxSearchLeft
            // 
            this.tboxSearchLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSearchLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tboxSearchLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxSearchLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxSearchLeft.Location = new System.Drawing.Point(146, 10);
            this.tboxSearchLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tboxSearchLeft.Name = "tboxSearchLeft";
            this.tboxSearchLeft.Size = new System.Drawing.Size(362, 26);
            this.tboxSearchLeft.TabIndex = 2;
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TotalComander_MouseDown);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadLeft;
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
        private System.Windows.Forms.Label labelRightSource;
        private System.Windows.Forms.Label labelLeftSource;
        private System.Windows.Forms.ComboBox cmbLeftDrive;
        private System.Windows.Forms.ComboBox cmbRightDrive;
        private System.Windows.Forms.TextBox tboxSearchRight;
        private System.Windows.Forms.TextBox tboxSearchLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMoveAll;
        private System.Windows.Forms.Button btnMoveOne;
    }
}

