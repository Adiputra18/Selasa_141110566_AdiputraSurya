using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if(maks.Value<mini.Value)
            {
                max.Text = mini.Value.ToString();
                min.Text = maks.Value.ToString();
            }

            else
            {
                max.Text = maks.Value.ToString();
                min.Text = mini.Value.ToString();
            }

            DateTime kalender = new DateTime(DateTime.Today.Year+Math.Abs(maks.Value-mini.Value),DateTime.Today.Month,DateTime.Today.Day);
            Hari.MinDate = DateTime.Today.Date;
            Hari.MaxDate = kalender;
        }
    }
}
