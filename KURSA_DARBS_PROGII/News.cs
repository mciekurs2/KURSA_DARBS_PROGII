using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSA_DARBS_PROGII
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //lai atjainotu info
            newsDataGridView.Rows.Clear();
            newsDataGridView.Refresh();

            //izsauc metodi
            Scripts.Functions.GetNewsData(countryCode.Text, newsDataGridView);
        }

    }
}
