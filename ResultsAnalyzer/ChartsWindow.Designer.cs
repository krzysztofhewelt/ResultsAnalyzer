
namespace ResultsAnalyzer
{
    partial class ChartsWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LegendCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SeriesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetColorButton = new System.Windows.Forms.Button();
            this.ColorPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea6);
            this.MainChart.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend6.Name = "Legend1";
            this.MainChart.Legends.Add(legend6);
            this.MainChart.Location = new System.Drawing.Point(12, 12);
            this.MainChart.Name = "MainChart";
            this.MainChart.Padding = new System.Windows.Forms.Padding(3);
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.LabelBorderWidth = 5;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.LabelBorderWidth = 5;
            series12.Legend = "Legend1";
            series12.Name = "Series2";
            this.MainChart.Series.Add(series11);
            this.MainChart.Series.Add(series12);
            this.MainChart.Size = new System.Drawing.Size(1057, 350);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title6.Name = "Title1";
            title6.Text = "Analysis chart";
            this.MainChart.Titles.Add(title6);
            // 
            // LegendCheckBox
            // 
            this.LegendCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LegendCheckBox.AutoSize = true;
            this.LegendCheckBox.Location = new System.Drawing.Point(691, 396);
            this.LegendCheckBox.Name = "LegendCheckBox";
            this.LegendCheckBox.Size = new System.Drawing.Size(88, 17);
            this.LegendCheckBox.TabIndex = 5;
            this.LegendCheckBox.Text = "Show legend";
            this.LegendCheckBox.UseVisualStyleBackColor = true;
            this.LegendCheckBox.CheckedChanged += new System.EventHandler(this.LegendCheckBox_CheckedChanged);
            // 
            // TitleCheckBox
            // 
            this.TitleCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TitleCheckBox.AutoSize = true;
            this.TitleCheckBox.Location = new System.Drawing.Point(691, 422);
            this.TitleCheckBox.Name = "TitleCheckBox";
            this.TitleCheckBox.Size = new System.Drawing.Size(72, 17);
            this.TitleCheckBox.TabIndex = 6;
            this.TitleCheckBox.Text = "Show title";
            this.TitleCheckBox.UseVisualStyleBackColor = true;
            this.TitleCheckBox.CheckedChanged += new System.EventHandler(this.TitleCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(994, 431);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SeriesCheckedListBox
            // 
            this.SeriesCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SeriesCheckedListBox.FormattingEnabled = true;
            this.SeriesCheckedListBox.Items.AddRange(new object[] {
            "Measurements",
            "Mean value",
            "Variance",
            "Min value",
            "Max value",
            "Standard Deviation",
            "Median"});
            this.SeriesCheckedListBox.Location = new System.Drawing.Point(346, 390);
            this.SeriesCheckedListBox.Name = "SeriesCheckedListBox";
            this.SeriesCheckedListBox.Size = new System.Drawing.Size(140, 64);
            this.SeriesCheckedListBox.TabIndex = 8;
            this.SeriesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.SeriesCheckedListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Set color of the selected series:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Show/Hide series:";
            // 
            // SetColorButton
            // 
            this.SetColorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SetColorButton.Location = new System.Drawing.Point(518, 390);
            this.SetColorButton.Name = "SetColorButton";
            this.SetColorButton.Size = new System.Drawing.Size(75, 23);
            this.SetColorButton.TabIndex = 14;
            this.SetColorButton.Text = "Select color";
            this.SetColorButton.UseVisualStyleBackColor = true;
            this.SetColorButton.Click += new System.EventHandler(this.SetColorButton_Click);
            // 
            // ColorPreview
            // 
            this.ColorPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ColorPreview.Enabled = false;
            this.ColorPreview.Location = new System.Drawing.Point(599, 390);
            this.ColorPreview.Name = "ColorPreview";
            this.ColorPreview.Size = new System.Drawing.Size(20, 23);
            this.ColorPreview.TabIndex = 15;
            this.ColorPreview.UseVisualStyleBackColor = true;
            // 
            // ChartsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 462);
            this.Controls.Add(this.ColorPreview);
            this.Controls.Add(this.SetColorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SeriesCheckedListBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TitleCheckBox);
            this.Controls.Add(this.LegendCheckBox);
            this.Controls.Add(this.MainChart);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ChartsWindow";
            this.Text = "Charts";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.CheckBox LegendCheckBox;
        private System.Windows.Forms.CheckBox TitleCheckBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckedListBox SeriesCheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetColorButton;
        private System.Windows.Forms.Button ColorPreview;
    }
}