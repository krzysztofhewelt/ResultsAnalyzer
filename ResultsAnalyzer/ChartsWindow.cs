using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ResultsAnalyzer
{
    public partial class ChartsWindow : Form
    {
        // index legend
        // 0 - measurement series
        // 1 - variance series
        // 2 - mean value series
        // 3 - min value series
        // 4 - max value series
        // 5 - standard deviation series
        // 6 - median series

        // stores the color of the series
        private Color[] colorsForSeries = new Color[7] { Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Orange, Color.Brown, Color.Pink };
        
        // stores the all probes values
        private Double[] measurementsData;

        // helper calcuations class
        private HelperCalculations helperCalc;

        public ChartsWindow(Double[] inputData)
        {
            InitializeComponent();

            // initial methods
            TickDefaultOptions();
            HideColoringOptions();

            // init the necessary properties
            measurementsData = inputData; // stores all measurements taken from main window
            helperCalc = new HelperCalculations(measurementsData); // init helper class for calculating operations

            // drawing the chart
            DrawChart();
        }

        /// <summary>
        /// Draws the analysis chart
        /// </summary>
        private void DrawChart()
        {
            // get the length of probes
            int inputTableLength = measurementsData.Length; 

            // clear the chart
            MainChart.Series.Clear();

            // draw measurements (probes) series and show it on the chart
            Series resultsSeries = MainChart.Series.Add("Measurements");
            resultsSeries.ChartType = SeriesChartType.Line;
            for(int i = 0; i < inputTableLength; i++)
            {
                resultsSeries.Points.AddXY(i + 1, measurementsData[i]);
            }


            // draw mean value series and show it on the chart
            double meanValue = helperCalc.CalcMeanValue();
            Series meanValueSeries = MainChart.Series.Add("Mean value");
            meanValueSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < inputTableLength; i++)
            {
                meanValueSeries.Points.AddXY(i + 1, meanValue);
            }


            // draw variance series and hide it
            double variance = helperCalc.CalcVariance();
            Series varianceSeries = MainChart.Series.Add("Variance");
            varianceSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < inputTableLength; i++)
            {
                varianceSeries.Points.AddXY(i + 1, variance);
            }
            varianceSeries.Enabled = false; // hide the variance series


            // draw min value series and hide it
            double minValue = helperCalc.FindMin();
            Series minValueSeries = MainChart.Series.Add("Min value");
            minValueSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < inputTableLength; i++)
            {
                minValueSeries.Points.AddXY(i + 1, minValue);
            }
            minValueSeries.Enabled = false; // hide the min value series


            // draw max value series and hide it
            double maxValue = helperCalc.FindMax();
            Series maxValueSeries = MainChart.Series.Add("Max value");
            maxValueSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < inputTableLength; i++)
            {
                maxValueSeries.Points.AddXY(i + 1, maxValue);
            }
            maxValueSeries.Enabled = false; // hide the max value series


            // draw standard deviation series and hide it
            double standardDeviation = helperCalc.CalcStandardDeviation();
            Series standardDeviationSeries = MainChart.Series.Add("Standard deviation");
            standardDeviationSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < inputTableLength; i++)
            {
                standardDeviationSeries.Points.AddXY(i + 1, standardDeviation);
            }
            standardDeviationSeries.Enabled = false; // hide the standard deviation series


            // draw median series and hide it
            double median = helperCalc.CalcMedian();
            Series medianSeries = MainChart.Series.Add("Median");
            medianSeries.ChartType = SeriesChartType.Line;
            for (int i = 0; i < inputTableLength; i++)
            {
                medianSeries.Points.AddXY(i + 1, median);
            }
            medianSeries.Enabled = false; // hide the median series


            // color each of series from colorForSeries defined before
            for(int i = 0; i < 7; i++)
            {
                MainChart.Series[i].BorderWidth = 2;
                MainChart.Series[i].Color = colorsForSeries[i];
            }

            // recalculate the XY axis
            MainChart.ChartAreas[0].AxisY.IsStartedFromZero = false;
            MainChart.ChartAreas[0].RecalculateAxesScale();

            // make the chart zoomable
            ChartArea CA = MainChart.ChartAreas[0]; // quick reference
            CA.AxisX.ScaleView.Zoomable = true;
            CA.CursorX.AutoScroll = true;
            CA.CursorX.IsUserSelectionEnabled = true;
        }
        
        /// <summary>
        /// Tick default options after open chart window. Ticks legend and title checkbox and two default series.
        /// </summary>
        private void TickDefaultOptions()
        {
            SeriesCheckedListBox.SetItemChecked(0, true); // tick Measurements series
            SeriesCheckedListBox.SetItemChecked(1, true); // tick Mean value series

            LegendCheckBox.Checked = true; // tick legend checkbox
            TitleCheckBox.Checked = true; // tick title checkbox

        }

        /// <summary>
        /// Hides the color preview button and disable "select color" button.
        /// </summary>
        private void HideColoringOptions()
        {
            ColorPreview.Visible = false;
            SetColorButton.Enabled = false;
        }

        /// <summary>
        /// Shows the color preview button and enable "select color" button.
        /// </summary>
        private void ShowColoringOptions()
        {
            ColorPreview.Visible = true;
            SetColorButton.Enabled = true;
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeriesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SeriesCheckedListBox.SelectedIndex; // get the selected index from the listbox

            // if the selected item is checked
            if (SeriesCheckedListBox.CheckedItems.Contains(SeriesCheckedListBox.SelectedItem))
            {
                ShowColoringOptions(); // enable necessary buttons

                ColorPreview.BackColor = colorsForSeries[selectedIndex]; // get the series line color
                MainChart.Series[selectedIndex].Enabled = true; // show the series on the chart
            }
            else
            {
                HideColoringOptions(); // disable coloring buttons
                MainChart.Series[selectedIndex].Enabled = false; // hide the series on the chart
            }

            // recalculate the XY axis after addding/removing series
            MainChart.ChartAreas[0].RecalculateAxesScale();
        }

        private void SetColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true; // allow rgb picker

            int selectedIndex = SeriesCheckedListBox.SelectedIndex; // get the selected index from the listbox

            // Update the series color if the user clicks OK 
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // set the background color of color preview button
                ColorPreview.BackColor = colorDialog.Color;

                // set the series line color
                MainChart.Series[selectedIndex].Color = colorDialog.Color;

                // save the chosed color in table
                colorsForSeries[selectedIndex] = colorDialog.Color;
            }
        }

        private void LegendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LegendCheckBox.Checked)
                MainChart.Legends[0].Enabled = true;
            else
                MainChart.Legends[0].Enabled = false;
        }

        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(TitleCheckBox.Checked)
            {
                MainChart.Titles.Clear();
                Title title = MainChart.Titles.Add("Analysis chart");
                title.Font = new Font("Microsoft Sans Serif", (float) 14.25, FontStyle.Bold);
            }
            else
            {
                MainChart.Titles.Clear();
            }
        }
    }
}
