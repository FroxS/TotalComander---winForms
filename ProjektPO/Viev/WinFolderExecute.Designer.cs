
namespace ProjektPO.Viev
{
    partial class WinFolderExecute
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
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCoppy = new System.Windows.Forms.Button();
            this.labCom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnMove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMove.Location = new System.Drawing.Point(60, 95);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(135, 50);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Tak";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCoppy
            // 
            this.btnCoppy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnCoppy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCoppy.FlatAppearance.BorderSize = 0;
            this.btnCoppy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoppy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCoppy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCoppy.Location = new System.Drawing.Point(379, 95);
            this.btnCoppy.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoppy.Name = "btnCoppy";
            this.btnCoppy.Size = new System.Drawing.Size(135, 50);
            this.btnCoppy.TabIndex = 2;
            this.btnCoppy.Text = "Nie";
            this.btnCoppy.UseVisualStyleBackColor = false;
            this.btnCoppy.Click += new System.EventHandler(this.btnCoppy_Click);
            // 
            // labCom
            // 
            this.labCom.AutoSize = true;
            this.labCom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labCom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labCom.Location = new System.Drawing.Point(56, 29);
            this.labCom.Name = "labCom";
            this.labCom.Size = new System.Drawing.Size(94, 21);
            this.labCom.TabIndex = 3;
            this.labCom.Text = "Komunikat";
            // 
            // WinFolderExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(584, 181);
            this.Controls.Add(this.labCom);
            this.Controls.Add(this.btnCoppy);
            this.Controls.Add(this.btnMove);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(600, 220);
            this.MinimumSize = new System.Drawing.Size(600, 220);
            this.Name = "WinFolderExecute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wybierz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCoppy;
        private System.Windows.Forms.Label labCom;
    }
}