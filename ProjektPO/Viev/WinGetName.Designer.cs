
namespace ProjektPO.Viev
{
    partial class WinGetName
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
            this.btnCommit = new System.Windows.Forms.Button();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCommit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCommit.FlatAppearance.BorderSize = 0;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCommit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCommit.Location = new System.Drawing.Point(396, 56);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(135, 50);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "Zatwierdź";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            this.btnCommit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCommit_KeyDown);
            // 
            // tboxName
            // 
            this.tboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tboxName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tboxName.Location = new System.Drawing.Point(24, 62);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(318, 38);
            this.tboxName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wprowadź nazwę folderu";
            // 
            // WinGetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(582, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.btnCommit);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 220);
            this.MinimumSize = new System.Drawing.Size(600, 220);
            this.Name = "WinGetName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wybierz";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WinGetName_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label label1;
    }
}