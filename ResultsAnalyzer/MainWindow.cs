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
                this.filename = openFileDialog1.FileName;
                Console.WriteLine("OK");

                try
                {
                    ResetAllFields();

                    Double[] inputData = ReadMeasurements(this.filename);

                    if (inputData.Length > 0)
                    {
                        Double meanValue, variance, minValue, maxValue, standardDeviation, median;

                        EnableAllButtons();

                        DisplayContentInPreviewData(filename);

                        HelperCalculations helperCalc = new HelperCalculations(inputData);
                        meanValue = helperCalc.CalcMeanValue();
                        variance  = helperCalc.CalcVariance();
                        minValue  = inputData.Min();
                        maxValue  = inputData.Max();
                        median    = helperCalc.CalcMedian();
                        standardDeviation = helperCalc.CalcStandardDeviation();

                        DisplayInBoxes(meanValue, variance, minValue, maxValue, standardDeviation, median);
                    }
                }
                catch
                {
                    MessageBox.Show("Nie udało się otworzyć pliku!\nPlik może być używany przez proces", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                while(!sr.EndOfStream)
                {
                    line = sr.ReadLine().Trim(new Char[] {';'});
                    success = Double.TryParse(line, out number);

                    if(success)
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
        /// <param name="meanValue">Calculated mean value</param>
        /// <param name="variance">Calculated variance</param>
        /// <param name="minValue">Minimum value</param>
        /// <param name="maxValue">Maximum value</param>
        /// <param name="standardDeviation">Calculated standard deviation</param>
        /// <param name="median">Calculated median</param>
        private void DisplayInBoxes(Double meanValue, Double variance, Double minValue, Double maxValue, Double standardDeviation, Double median)
        {
            MeanValueBox.Text = meanValue.ToString();
            VarianceBox.Text = variance.ToString();
            MinValueBox.Text = minValue.ToString();
            MaxValueBox.Text = maxValue.ToString();
            StandardDeviationBox.Text = standardDeviation.ToString();
            MedianBox.Text = median.ToString();
        }

        private void DisplayContentInPreviewData(String filename)
        {
            PreviewDataBox.Text = File.ReadAllText(filename);
        }
    }
}
