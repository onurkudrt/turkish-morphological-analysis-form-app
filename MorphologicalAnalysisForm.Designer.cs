namespace _200601038_odev1_1
{
    partial class MorphologicalAnalysisForm
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
            gbMorphologicalAnalysis = new GroupBox();
            lvMorphologicalAnalysis = new ListView();
            lblUniqueWord1 = new Label();
            lblUniqueWord2 = new Label();
            lblUniqueWordNumber1 = new Label();
            lblUniqueWordNumber2 = new Label();
            gbMorphologicalAnalysis.SuspendLayout();
            SuspendLayout();
            // 
            // gbMorphologicalAnalysis
            // 
            gbMorphologicalAnalysis.Controls.Add(lvMorphologicalAnalysis);
            gbMorphologicalAnalysis.ForeColor = Color.Snow;
            gbMorphologicalAnalysis.Location = new Point(12, 12);
            gbMorphologicalAnalysis.Name = "gbMorphologicalAnalysis";
            gbMorphologicalAnalysis.Size = new Size(593, 475);
            gbMorphologicalAnalysis.TabIndex = 0;
            gbMorphologicalAnalysis.TabStop = false;
            gbMorphologicalAnalysis.Text = "groupBox1";
            // 
            // lvMorphologicalAnalysis
            // 
            lvMorphologicalAnalysis.Location = new Point(6, 22);
            lvMorphologicalAnalysis.Name = "lvMorphologicalAnalysis";
            lvMorphologicalAnalysis.Size = new Size(581, 432);
            lvMorphologicalAnalysis.TabIndex = 0;
            lvMorphologicalAnalysis.UseCompatibleStateImageBehavior = false;
            lvMorphologicalAnalysis.View = View.Details;
            // 
            // lblUniqueWord1
            // 
            lblUniqueWord1.AutoSize = true;
            lblUniqueWord1.Location = new Point(40, 514);
            lblUniqueWord1.MaximumSize = new Size(110, 30);
            lblUniqueWord1.Name = "lblUniqueWord1";
            lblUniqueWord1.Size = new Size(103, 30);
            lblUniqueWord1.TabIndex = 1;
            lblUniqueWord1.Text = "Kök alma öncesi eşsiz kelime sayısı:";
            // 
            // lblUniqueWord2
            // 
            lblUniqueWord2.AutoSize = true;
            lblUniqueWord2.Location = new Point(241, 514);
            lblUniqueWord2.MaximumSize = new Size(110, 30);
            lblUniqueWord2.Name = "lblUniqueWord2";
            lblUniqueWord2.Size = new Size(103, 30);
            lblUniqueWord2.TabIndex = 2;
            lblUniqueWord2.Text = "Kök alma sonrası eşsiz kelime sayısı:";
            // 
            // lblUniqueWordNumber1
            // 
            lblUniqueWordNumber1.AutoSize = true;
            lblUniqueWordNumber1.Location = new Point(149, 529);
            lblUniqueWordNumber1.Name = "lblUniqueWordNumber1";
            lblUniqueWordNumber1.Size = new Size(38, 15);
            lblUniqueWordNumber1.TabIndex = 3;
            lblUniqueWordNumber1.Text = "label3";
            // 
            // lblUniqueWordNumber2
            // 
            lblUniqueWordNumber2.AutoSize = true;
            lblUniqueWordNumber2.Location = new Point(350, 529);
            lblUniqueWordNumber2.Name = "lblUniqueWordNumber2";
            lblUniqueWordNumber2.Size = new Size(38, 15);
            lblUniqueWordNumber2.TabIndex = 4;
            lblUniqueWordNumber2.Text = "label4";
            // 
            // MorphologicalAnalysisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(617, 565);
            Controls.Add(lblUniqueWordNumber2);
            Controls.Add(lblUniqueWordNumber1);
            Controls.Add(lblUniqueWord2);
            Controls.Add(lblUniqueWord1);
            Controls.Add(gbMorphologicalAnalysis);
            ForeColor = Color.Snow;
            Name = "MorphologicalAnalysisForm";
            Text = "Morfolojik Analiz";
            Load += MorphologicalAnalysisForm_Load;
            gbMorphologicalAnalysis.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbMorphologicalAnalysis;
        private ListView lvMorphologicalAnalysis;
        private Label lblUniqueWord1;
        private Label lblUniqueWord2;
        private Label lblUniqueWordNumber1;
        private Label lblUniqueWordNumber2;
    }
}