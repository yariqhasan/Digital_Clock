using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            IblTime.Text = DateTime.Now.ToString("HH:mm");
            IblSecond.Text = DateTime.Now.ToString("ss");
            IblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            IblDay.Text = DateTime.Now.ToString("dddd");
            IblSecond.Location = new Point(IblTime.Location.X + IblTime.Width-5, IblSecond.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
