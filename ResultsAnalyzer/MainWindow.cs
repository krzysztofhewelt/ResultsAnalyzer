using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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

                try
                {
                    ResetAllFields();

                    double[] inputData = ReadMeasurements(this.filename);

                    // TODO
                    // method that enables buttons to save analysis
                    // calculating methods
                    // display in boxes
 
                }
                catch
                {
                    MessageBox.Show("Nie udało się otworzyć pliku!\nPlik może być używany przez proces", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private double[] ReadMeasurements(String filename)
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
                    line = sr.ReadLine().Trim(new Char[] { ';' });
                    success = Double.TryParse(line, out number);

                    if (success)
                    {
                        dataFromFile.Add(number);
                    }

                    arrayFromList = dataFromFile.ToArray();
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("This file doesn't exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return arrayFromList;
        }
    }
}
