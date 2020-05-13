using System;

using System.Windows.Forms;

namespace HProgramming
{
    public partial class Dashboardform : Form
    {
        public Dashboardform()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        

        void CurrentTime(object sender, EventArgs e)
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            int day = DateTime.Now.Day;
            int  month = DateTime.Now.Month;
            

            string time1 = "";
            string time2 = "";

            if (hours < 10)
            {
                time1 += "0" + hours;
            }
            else {
                time1 += hours;
            }
            time1 += ":";
            if (minutes < 10)
            {
                time1 += "0" + minutes;
            }
            else
            {
                time1 += minutes;
            }
            

            if (second < 10)
            {
                time2 += "0" + second;
            }
            else
            {
                time2 += second;
            }
            timelabeltxt.Text = time1;
            labelsecond.Text = time2;

            labelday.Text = DateTime.Now.ToString("dddd");
            labellongdate.Text = DateTime.Now.ToString("MM dd yyyy");
                
        }

        private void Dashboardform_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.CurrentTime);
            timer.Start();

        }
    }
}
