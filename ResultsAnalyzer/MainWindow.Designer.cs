
namespace ResultsAnalyzer
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChartsButton = new System.Windows.Forms.Button();
            this.PreviewDataBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MedianBox = new System.Windows.Forms.TextBox();
            this.StandardDeviationBox = new System.Windows.Forms.TextBox();
            this.MaxValueBox = new System.Windows.Forms.TextBox();
            this.MinValueBox = new System.Windows.Forms.TextBox();
            this.VarianceBox = new System.Windows.Forms.TextBox();
            this.MeanValueBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GenerateNewProbesStatus = new System.Windows.Forms.Label();
            this.SaveAnalysisStatus = new System.Windows.Forms.Label();
            this.SaveAnalysisButton = new System.Windows.Forms.Button();
            this.GenerateNewProbesButton = new System.Windows.Forms.Button();
            this.NumberOfNewProbesBox = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfNewProbesBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(309, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Results Analyzer";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.OpenFileButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Load data";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenFileButton.Location = new System.Drawing.Point(411, 24);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open...";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(299, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Load results from file:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.ChartsButton);
            this.groupBox2.Controls.Add(this.PreviewDataBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Preview data";
            // 
            // ChartsButton
            // 
            this.ChartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ChartsButton.Location = new System.Drawing.Point(358, 45);
            this.ChartsButton.Name = "ChartsButton";
            this.ChartsButton.Size = new System.Drawing.Size(75, 23);
            this.ChartsButton.TabIndex = 1;
            this.ChartsButton.Text = "Charts";
            this.ChartsButton.UseVisualStyleBackColor = true;
            // 
            // PreviewDataBox
            // 
            this.PreviewDataBox.Enabled = false;
            this.PreviewDataBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PreviewDataBox.Location = new System.Drawing.Point(6, 19);
            this.PreviewDataBox.Name = "PreviewDataBox";
            this.PreviewDataBox.ReadOnly = true;
            this.PreviewDataBox.Size = new System.Drawing.Size(764, 20);
            this.PreviewDataBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.MedianBox);
            this.groupBox3.Controls.Add(this.StandardDeviationBox);
            this.groupBox3.Controls.Add(this.MaxValueBox);
            this.groupBox3.Controls.Add(this.MinValueBox);
            this.groupBox3.Controls.Add(this.VarianceBox);
            this.groupBox3.Controls.Add(this.MeanValueBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 99);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Data analysis";
            // 
            // MedianBox
            // 
            this.MedianBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MedianBox.Location = new System.Drawing.Point(641, 53);
            this.MedianBox.Name = "MedianBox";
            this.MedianBox.Size = new System.Drawing.Size(100, 20);
            this.MedianBox.TabIndex = 11;
            // 
            // StandardDeviationBox
            // 
            this.StandardDeviationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StandardDeviationBox.Location = new System.Drawing.Point(641, 24);
            this.StandardDeviationBox.Name = "StandardDeviationBox";
            this.StandardDeviationBox.Size = new System.Drawing.Size(100, 20);
            this.StandardDeviationBox.TabIndex = 10;
            // 
            // MaxValueBox
            // 
            this.MaxValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaxValueBox.Location = new System.Drawing.Point(364, 55);
            this.MaxValueBox.Name = "MaxValueBox";
            this.MaxValueBox.Size = new System.Drawing.Size(100, 20);
            this.MaxValueBox.TabIndex = 9;
            // 
            // MinValueBox
            // 
            this.MinValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinValueBox.Location = new System.Drawing.Point(364, 25);
            this.MinValueBox.Name = "MinValueBox";
            this.MinValueBox.Size = new System.Drawing.Size(100, 20);
            this.MinValueBox.TabIndex = 8;
            // 
            // VarianceBox
            // 
            this.VarianceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VarianceBox.Location = new System.Drawing.Point(107, 56);
            this.VarianceBox.Name = "VarianceBox";
            this.VarianceBox.Size = new System.Drawing.Size(100, 20);
            this.VarianceBox.TabIndex = 7;
            // 
            // MeanValueBox
            // 
            this.MeanValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MeanValueBox.Location = new System.Drawing.Point(107, 26);
            this.MeanValueBox.Name = "MeanValueBox";
            this.MeanValueBox.Size = new System.Drawing.Size(100, 20);
            this.MeanValueBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(590, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Median:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(534, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Standard Deviation:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(299, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Max value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(302, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Min value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Variance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mean value:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.GenerateNewProbesStatus);
            this.groupBox4.Controls.Add(this.SaveAnalysisStatus);
            this.groupBox4.Controls.Add(this.SaveAnalysisButton);
            this.groupBox4.Controls.Add(this.GenerateNewProbesButton);
            this.groupBox4.Controls.Add(this.NumberOfNewProbesBox);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(12, 426);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 94);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4. Save to file";
            // 
            // GenerateNewProbesStatus
            // 
            this.GenerateNewProbesStatus.AutoSize = true;
            this.GenerateNewProbesStatus.Location = new System.Drawing.Point(547, 57);
            this.GenerateNewProbesStatus.Name = "GenerateNewProbesStatus";
            this.GenerateNewProbesStatus.Size = new System.Drawing.Size(48, 13);
            this.GenerateNewProbesStatus.TabIndex = 6;
            this.GenerateNewProbesStatus.Text = "label12";
            // 
            // SaveAnalysisStatus
            // 
            this.SaveAnalysisStatus.AutoSize = true;
            this.SaveAnalysisStatus.Location = new System.Drawing.Point(547, 27);
            this.SaveAnalysisStatus.Name = "SaveAnalysisStatus";
            this.SaveAnalysisStatus.Size = new System.Drawing.Size(48, 13);
            this.SaveAnalysisStatus.TabIndex = 5;
            this.SaveAnalysisStatus.Text = "label11";
            // 
            // SaveAnalysisButton
            // 
            this.SaveAnalysisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveAnalysisButton.Location = new System.Drawing.Point(453, 22);
            this.SaveAnalysisButton.Name = "SaveAnalysisButton";
            this.SaveAnalysisButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAnalysisButton.TabIndex = 4;
            this.SaveAnalysisButton.Text = "Save...";
            this.SaveAnalysisButton.UseVisualStyleBackColor = true;
            // 
            // GenerateNewProbesButton
            // 
            this.GenerateNewProbesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GenerateNewProbesButton.Location = new System.Drawing.Point(453, 51);
            this.GenerateNewProbesButton.Name = "GenerateNewProbesButton";
            this.GenerateNewProbesButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateNewProbesButton.TabIndex = 3;
            this.GenerateNewProbesButton.Text = "Save...";
            this.GenerateNewProbesButton.UseVisualStyleBackColor = true;
            // 
            // NumberOfNewProbesBox
            // 
            this.NumberOfNewProbesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfNewProbesBox.Location = new System.Drawing.Point(394, 54);
            this.NumberOfNewProbesBox.Name = "NumberOfNewProbesBox";
            this.NumberOfNewProbesBox.Size = new System.Drawing.Size(39, 20);
            this.NumberOfNewProbesBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(276, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Generate new probes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(280, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Export analysis to file:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "ResultsAnalyzer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfNewProbesBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreviewDataBox;
        private System.Windows.Forms.Button ChartsButton;
        private System.Windows.Forms.TextBox MedianBox;
        private System.Windows.Forms.TextBox StandardDeviationBox;
        private System.Windows.Forms.TextBox MaxValueBox;
        private System.Windows.Forms.TextBox MinValueBox;
        private System.Windows.Forms.TextBox VarianceBox;
        private System.Windows.Forms.TextBox MeanValueBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumberOfNewProbesBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveAnalysisButton;
        private System.Windows.Forms.Button GenerateNewProbesButton;
        private System.Windows.Forms.Label GenerateNewProbesStatus;
        private System.Windows.Forms.Label SaveAnalysisStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

