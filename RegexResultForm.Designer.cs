namespace _200601038_odev1_1
{
    partial class RegexResultForm
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
            this.rtBoxResults = new System.Windows.Forms.RichTextBox();
            this.gbRegex = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegex = new System.Windows.Forms.Label();
            this.gbRegex.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtBoxResults
            // 
            this.rtBoxResults.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtBoxResults.Location = new System.Drawing.Point(20, 57);
            this.rtBoxResults.Name = "rtBoxResults";
            this.rtBoxResults.Size = new System.Drawing.Size(274, 329);
            this.rtBoxResults.TabIndex = 0;
            this.rtBoxResults.Text = "";
            // 
            // gbRegex
            // 
            this.gbRegex.BackColor = System.Drawing.SystemColors.Desktop;
            this.gbRegex.Controls.Add(this.lblRegex);
            this.gbRegex.Controls.Add(this.label3);
            this.gbRegex.Controls.Add(this.rtBoxResults);
            this.gbRegex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbRegex.Location = new System.Drawing.Point(5, 12);
            this.gbRegex.Name = "gbRegex";
            this.gbRegex.Size = new System.Drawing.Size(312, 394);
            this.gbRegex.TabIndex = 1;
            this.gbRegex.TabStop = false;
            this.gbRegex.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Koşul:";
            // 
            // lblRegex
            // 
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new System.Drawing.Point(59, 28);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(48, 13);
            this.lblRegex.TabIndex = 4;
            this.lblRegex.Text = "lblRegex";
            // 
            // RegexResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(329, 410);
            this.Controls.Add(this.gbRegex);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "RegexResultForm";
            this.Text = "Arama Sonuçları";
            this.Load += new System.EventHandler(this.RegexResultForm_Load);
            this.gbRegex.ResumeLayout(false);
            this.gbRegex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoxResults;
        private System.Windows.Forms.GroupBox gbRegex;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.Label label3;
    }
}