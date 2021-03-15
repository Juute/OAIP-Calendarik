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
    public struct _data
    {
        public string h, m, day, month;
        public int dayNumber, year;
    }
    public partial class CalendarOnDay : Form
    {
        public _data _Data;
        public bool Exit = false;
        private readonly Dictionary <int, string> months = new Dictionary<int, string> {{1,"Январь"},
            {2,"Февраль"},{3,"Март"},{4,"Апрель"},{5,"Май"},{6,"Июнь"},{7,"Июль"},
            { 8,"Август"},{9,"Сентябрь"},{10,"Октябрь"},{11,"Ноябрь"},{12,"Декабрь"} };
        private readonly Dictionary <string, string> days = new Dictionary<string, string> { { "Monday", "Понедельник" },
            { "Tuesday","Вторник" },{ "Wednesday","Среда" },{ "Thursday","Четверг" },{ "Friday","Пятница" },
            { "Saturday","Суббота" },{ "Sunday","Воскресенье" }};
        public CalendarOnDay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;

            _Data.h = dt.Hour < 10 ? "0" + dt.Hour.ToString() : dt.Hour.ToString();
            _Data.m = dt.Minute < 10 ? "0" + dt.Minute.ToString() : dt.Minute.ToString();
            _Data.day = days[dt.DayOfWeek.ToString()];
            _Data.dayNumber = dt.Day;
            _Data.month = months[dt.Month];
            _Data.year = dt.Year;
            Exit = true;
            Close();

        }
    }
}
