using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace ResultsAnalyzer
{
    public partial class MainWindow : Form
    {
        private String filename = ""; // file path
        private Double meanValue, variance, minValue, maxValue, standardDeviation, median;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens measurements file and shows analysis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt",
                FilterIndex = 1,
                RestoreDirectory = false,

                ReadOnlyChecked = false,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;

                try
                {
                    ResetAllFields();

                    Double[] inputData = ReadMeasurements(filename);

                    if (inputData.Length > 0)
                    {
                        EnableAllButtons();

                        DisplayContentInPreviewData(filename);

                        HelperCalculations helperCalc = new HelperCalculations(inputData);
                        meanValue = Math.Round(helperCalc.CalcMeanValue(), 8);
                        variance = Math.Round(helperCalc.CalcVariance(), 8);
                        minValue = helperCalc.FindMin();
                        maxValue = helperCalc.FindMax();
                        median = Math.Round(helperCalc.CalcMedian(), 8);
                        standardDeviation = Math.Round(helperCalc.CalcStandardDeviation(), 8);

                        DisplayInBoxes();
                    }
                }
                catch
                {
                    MessageBox.Show("An error occurred during opening file!\nFile may be used by other process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        /// <summary>
        /// Clears all fields and disables buttons.
        /// </summary>
        private void ResetAllFields()
        {
            // "Preview data" groupbox
            PreviewDataBox.Text = "";
            ChartsButton.Enabled = false;

            // "Data analysis" groupbox
            MeanValueBox.Text = "";
            VarianceBox.Text = "";
            MinValueBox.Text = "";
            MaxValueBox.Text = "";
            StandardDeviationBox.Text = "";
            MedianBox.Text = "";

            // "Save to file" groupbox
            NumberOfNewProbesBox.Value = 0;
            NumberOfNewProbesBox.Enabled = false;
            SaveAnalysisButton.Enabled = false;
            GenerateNewProbesButton.Enabled = false;
            SaveAnalysisStatus.Text = "";
            GenerateNewProbesStatus.Text = "";
        }

        /// <summary>
        /// Reads all file and returns data in the table.
        /// </summary>
        /// <param name="filename">Full file path</param>
        /// <returns>Processed results in an table</returns>
        private Double[] ReadMeasurements(String filename)
        {
            String line;
            Double number;
            Boolean success;

            List<Double> dataFromFile = new List<Double>();
            Double[] arrayFromList = { };

            try
            {
                StreamReader sr = new StreamReader(filename);
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine().Trim(new Char[] { ';' });
                    success = Double.TryParse(line, out number);

                    if (success)
                    {
                        dataFromFile.Add(number);
                    }
                }

                arrayFromList = dataFromFile.ToArray();
                sr.Close();
            }
            catch
            {
                MessageBox.Show("This file doesn't exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return arrayFromList;
            }

            return arrayFromList;
        }

        /// <summary>
        /// Enables chart and saving buttons.
        /// </summary>
        private void EnableAllButtons()
        {
            // Chart button
            ChartsButton.Enabled = true;

            // Saving buttons
            SaveAnalysisButton.Enabled = true;
            GenerateNewProbesButton.Enabled = true;

            // Inputs (NumberUpDown)
            NumberOfNewProbesBox.Enabled = true;
        }

        /// <summary>
        /// Displays calculates in boxes in the "Data analysis" groupbox.
        /// </summary>
        private void DisplayInBoxes()
        {
            MeanValueBox.Text = meanValue.ToString();
            VarianceBox.Text = variance.ToString();
            MinValueBox.Text = minValue.ToString();
            MaxValueBox.Text = maxValue.ToString();
            StandardDeviationBox.Text = standardDeviation.ToString();
            MedianBox.Text = median.ToString();
        }

        /// <summary>
        /// Displays whole file content in the PreviewDataBox.
        /// </summary>
        /// <param name="filename">File path</param>
        private void DisplayContentInPreviewData(String filename)
        {
            PreviewDataBox.Text = File.ReadAllText(filename);
        }


        private void SaveAnalysisButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream stream = null;
                    stream = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.WriteLine("Mean value: " + meanValue);
                        sw.WriteLine("Variance: " + variance);
                        sw.WriteLine("Minimum value: " + minValue);
                        sw.WriteLine("Maximum value: " + maxValue);
                        sw.WriteLine("Standard Deviation: " + standardDeviation);
                        sw.WriteLine("Median: " + median);
                    }

                    stream.Close();

                    MessageBox.Show("File saved successfully", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveAnalysisStatus.Text = "Saved";
                }
                catch
                {
                    MessageBox.Show("An error occurred during saving file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GenerateNewProbesButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog2 = new SaveFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = false
            };
           
            try
            {
                Int32 howManyProbes = Convert.ToInt32(NumberOfNewProbesBox.Value);

                if(howManyProbes > 0)
                {
                    if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                        GenerateNewProbesFile(saveFileDialog2.FileName, howManyProbes, minValue, maxValue);
                }
                else
                {
                    MessageBox.Show("The number of new probes must be greater than 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("The given number of new probes isn't number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Generate n new probes in given range.
        /// </summary>
        /// <param name="howMany">How many probes to generate</param>
        /// <param name="min">Minimum value from range</param>
        /// <param name="max">Maximum vaue from range</param>
        private void GenerateNewProbesFile(String filename, Int32 howMany, Double min, Double max)
        {
            try
            {
                FileStream stream = null;

                stream = new FileStream(filename, FileMode.Create);

                Random value = new Random();
                Double randomValue;

                using (StreamWriter sw = new StreamWriter(stream))
                {
                    for (Int32 i = 1; i <= howMany; i++)
                    {
                        randomValue = value.NextDouble() * (max - min) + min;
                        sw.WriteLine(randomValue + ";");
                    }
                }

                stream.Close();

                MessageBox.Show("Probes generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GenerateNewProbesStatus.Text = "Saved";
            }
            catch
            {
                MessageBox.Show("An error occurred during saving file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowChartWindow_Click(object sender, EventArgs e)
        {
            Double[] inputData = ReadMeasurements(filename);

            ChartsWindow chart = new ChartsWindow(inputData);
            chart.ShowDialog();
        }
    }
}
