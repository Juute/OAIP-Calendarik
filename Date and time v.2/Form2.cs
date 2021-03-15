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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void наДеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalendarOnDay onDay = new CalendarOnDay();
            onDay.FormClosing += OnDay_FormClosing;
            onDay.ShowDialog();
        }
        private void OnDay_FormClossing(object sender, FormClosedEventArgs e)
        {
            CalendarOnDay onDay = (CalendarOnDay)sender;
            if (onDay.Exit)
            {
                mode = 1;
                flowLayoutPanel1.Controls.Clear();
                months.Clear();
                onDay = new Calendar.Controls.OnDay();

                year = Day._Data.year;

            }
        }
    }
}
