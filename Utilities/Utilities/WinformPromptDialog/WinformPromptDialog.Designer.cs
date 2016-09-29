namespace Utilities
{
    partial class WinformPromptDialog
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
            this.labTitle = new System.Windows.Forms.Label();
            this.txtMyKey = new System.Windows.Forms.TextBox();
            this.btnInsertKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(12, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(60, 13);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Blah blah...";
            // 
            // txtMyKey
            // 
            this.txtMyKey.Location = new System.Drawing.Point(15, 26);
            this.txtMyKey.Name = "txtMyKey";
            this.txtMyKey.Size = new System.Drawing.Size(257, 20);
            this.txtMyKey.TabIndex = 1;
            this.txtMyKey.TextChanged += new System.EventHandler(this.txtMyKey_TextChanged);
            // 
            // btnInsertKey
            // 
            this.btnInsertKey.Location = new System.Drawing.Point(197, 52);
            this.btnInsertKey.Name = "btnInsertKey";
            this.btnInsertKey.Size = new System.Drawing.Size(75, 23);
            this.btnInsertKey.TabIndex = 2;
            this.btnInsertKey.Text = "Insert";
            this.btnInsertKey.UseVisualStyleBackColor = true;
            this.btnInsertKey.Click += new System.EventHandler(this.btnInsertKey_Click);
            // 
            // WinformPromptDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 138);
            this.Controls.Add(this.btnInsertKey);
            this.Controls.Add(this.txtMyKey);
            this.Controls.Add(this.labTitle);
            this.Name = "WinformPromptDialog";
            this.Text = "Blah blah...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.TextBox txtMyKey;
        private System.Windows.Forms.Button btnInsertKey;
    }
}