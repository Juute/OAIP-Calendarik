using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_and_time_v._2.Controls
{
    public struct _Object
    {
        public string month, time, title, note, day;
        public int day_number;
        public Color color;
    }

    public partial class Day : UserControl
    {
        public string NameDay { get { return label1.Text; } set { label1.Text = value; } }
        Color pink = Color.FromArgb(255, 192, 203);
        Color OverControl = Color.FromArgb(255, 183, 135);
        public _Object note;
        ToolTip toolTip = new ToolTip();
        public Day()
        {
            InitializeComponent();
        }
        private readonly Dictionary<int, string> months = new Dictionary<int, string> {{1,"Январь"},
            {2,"Февраль"},{3,"Март"},{4,"Апрель"},{5,"Май"},{6,"Июнь"},{7,"Июль"},
            { 8,"Август"},{9,"Сентябрь"},{10,"Октябрь"},{11,"Ноябрь"},{12,"Декабрь"} };
        private readonly Dictionary<string, string> days = new Dictionary<string, string> { { "Monday", "Понедельник" },
            { "Tuesday","Вторник" },{ "Wednesday","Среда" },{ "Thursday","Четверг" },{ "Friday","Пятница" },
            { "Saturday","Суббота" },{ "Sunday","Воскресенье" }};

        public void Note(int Year, int Mouth, int i);
        {
        note = new _Object()
        {
            month = months[Mouth],
            title = "",
            note = "",
            day_number = i;
            day = days[new DateTime(Year, Mouth, i).DayOfWeek.ToString()],
            color = Color.White
        };

        }
    }
}
