using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_and_time_v._2
{
    public partial class CalendarOnMonth : Form
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public bool Exit = false;
        public CalendarOnMonth()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != "")
            {
                try
                {
                    Year = int.Parse(textBox1.Text);
                    Month = comboBox1.Text;
                    Exit = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
