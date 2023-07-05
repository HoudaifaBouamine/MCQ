using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCM.UserControls
{
    public partial class ucTimer : UserControl
    {
        public ucTimer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void set(byte min,byte sec)
        {
            total_sec = new TimeSpan(0,min,sec);

            label1.Text = total_sec.Minutes.ToString("00") + ":" + total_sec.Seconds.ToString("00");
        }

        TimeSpan total_sec;

        public void start()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(total_sec.TotalSeconds > 0)
            {
                total_sec.Subtract(new TimeSpan(0,0,1));
                label1.Text = total_sec.Minutes.ToString("00") + ":" + total_sec.Seconds.ToString("00");

            }
            else 
            {
                timer1.Stop();
                MessageBox.Show("Your test time is over", "Test Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
