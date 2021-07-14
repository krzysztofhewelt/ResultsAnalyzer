using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsAnalyzer
{
    public partial class ChartsWindow : Form
    {

        // read-only property that contains default colors list
        private readonly Color[] defaultColors = new Color[] {Color.Blue, Color.Green, Color.Red, Color.Yellow, Color.Orange, Color.Brown, Color.Pink};
        

        public ChartsWindow()
        {
            InitializeComponent();
            TickDefaultOptions();
            HideColorPreview();
        }
        
        /// <summary>
        /// Set default (not used before) color for series from defaultColors property.
        /// </summary>
        private void SetDefaultColorForSeries()
        {
            
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
        /// It hides the color preview button.
        /// </summary>
        private void HideColorPreview()
        {
            ColorPreview.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
