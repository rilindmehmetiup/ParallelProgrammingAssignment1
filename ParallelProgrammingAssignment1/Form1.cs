﻿using System;
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
            populate_processors_combobox();
        }

        private void populate_processors_combobox()
        {           
            for(int i= 1; i <= number_of_processors; i++)
            {
                ComboboxItem item = new ComboboxItem(i.ToString()+" Processor", i);
                cmb_processors.Items.Add(item);
            }
        }
    }
}
