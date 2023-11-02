namespace _200601038_odev1_1
{
    partial class TextScannerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFile = new Label();
            gbFile = new GroupBox();
            btnSelectFile = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnMorpAnalysis = new Button();
            lblTextProcessing = new Label();
            gbFile.SuspendLayout();
            SuspendLayout();
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(6, 19);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(38, 15);
            lblFile.TabIndex = 0;
            lblFile.Text = "label1";
            lblFile.Visible = false;
            // 
            // gbFile
            // 
            gbFile.Controls.Add(btnSelectFile);
            gbFile.Controls.Add(lblFile);
            gbFile.ForeColor = Color.White;
            gbFile.Location = new Point(12, 21);
            gbFile.Name = "gbFile";
            gbFile.Size = new Size(184, 81);
            gbFile.TabIndex = 1;
            gbFile.TabStop = false;
            gbFile.Text = "Dosya Seç";
            // 
            // btnSelectFile
            // 
            btnSelectFile.BackColor = Color.CadetBlue;
            btnSelectFile.Location = new Point(37, 52);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(101, 23);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "Dosya Gezgini";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 172);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(178, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CadetBlue;
            btnSearch.Location = new Point(210, 172);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnMorpAnalysis
            // 
            btnMorpAnalysis.BackColor = Color.CadetBlue;
            btnMorpAnalysis.Location = new Point(210, 34);
            btnMorpAnalysis.Name = "btnMorpAnalysis";
            btnMorpAnalysis.Size = new Size(116, 62);
            btnMorpAnalysis.TabIndex = 4;
            btnMorpAnalysis.Text = "Morfolojik Analiz Getir";
            btnMorpAnalysis.UseVisualStyleBackColor = false;
            btnMorpAnalysis.Click += btnMorpAnalysis_Click;
            // 
            // lblTextProcessing
            // 
            lblTextProcessing.AutoSize = true;
            lblTextProcessing.ForeColor = SystemColors.InactiveCaptionText;
            lblTextProcessing.Location = new Point(221, 110);
            lblTextProcessing.Name = "lblTextProcessing";
            lblTextProcessing.Size = new Size(91, 15);
            lblTextProcessing.TabIndex = 5;
            lblTextProcessing.Text = "Metin işleniyor..";
            lblTextProcessing.Visible = false;
            // 
            // TextScannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(338, 216);
            Controls.Add(lblTextProcessing);
            Controls.Add(btnMorpAnalysis);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(gbFile);
            ForeColor = Color.White;
            Name = "TextScannerForm";
            Text = "Metin Tarayıcı";
            Load += Form1_Load;
            gbFile.ResumeLayout(false);
            gbFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFile;
        private GroupBox gbFile;
        private Button btnSelectFile;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnMorpAnalysis;
        private Label lblTextProcessing;
    }
}