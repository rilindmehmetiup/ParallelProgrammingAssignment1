using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelProgrammingAssignment1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int number_of_processors;

        private void MainForm_Load(object sender, EventArgs e)
        {
            number_of_processors = Environment.ProcessorCount;
            MessageBox.Show("Number of available processors is " + number_of_processors.ToString());
        }
    }
}
