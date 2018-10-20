using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
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
        public ulong primes_till = 1000;                  

        private void MainForm_Load(object sender, EventArgs e)
        {
            number_of_processors = Environment.ProcessorCount;
            populate_processors_combobox();
            cmb_processors.SelectedIndex = 0;            
        }

        private void populate_processors_combobox()
        {           
            for(int i= 1; i <= number_of_processors; i++)
            {
                ComboboxItem item = new ComboboxItem(i.ToString()+this.pluralize(" Processor", i), i);
                cmb_processors.Items.Add(item);
            }
        }

        private string pluralize(string text, int counter)
        {
            return counter <= 1 ? text : text + "s";
        }
        
        static IEnumerable<ulong> Range(ulong fromInclusive, ulong toInclusive)
        {
            for (ulong i = fromInclusive; i <= toInclusive; i++)
                yield return i;
        }

        int Calculate()
        {            
            PrimeNumbers obj_prime = new PrimeNumbers();            
            var results_table = new bool[primes_till];
            var loop = Parallel.ForEach(Range(1, primes_till), i =>
            {
                results_table[i - 1] = obj_prime.IsPrime(i);
            });                   
            while (!loop.IsCompleted) {; }
           
            return results_table.Count(x => x);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                DateTime time_1 = DateTime.Now;
                string time_1_s = time_1.ToString("h:mm:ss:fff");                    
                var result = Calculate();
                DateTime time_2 = DateTime.Now;
                string time_2_s = time_2.ToString("h:mm:ss:fff");
                string time_difference_seconds = Convert.ToDecimal((time_2 - time_1).TotalSeconds).ToString().Substring(0,8);
                string time_difference_minutes = Convert.ToDecimal((time_2 - time_1).TotalMinutes).ToString().Substring(0, 8);
                string[] row = new string[] { number_of_processors.ToString(), primes_till.ToString(), time_1_s, time_2_s, String.Format("{0} minutes, {1} seconds", time_difference_minutes, time_difference_seconds), result.ToString()};
                dg_result.Rows.Add(row);                
            });
        }

        private void txt_prime_TextChanged(object sender, EventArgs e)
        {
            try {
                primes_till = Convert.ToUInt64(txt_prime.Text);
            }
            catch {
                MessageBox.Show(String.Format("Maximum allowed number is {0}", ulong.MaxValue));
                txt_prime.Text = String.Format("{0}", 100);
            }            
        }
    }
}
