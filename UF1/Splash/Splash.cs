using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            progress.PerformStep();
            percent.Text = progress.Value.ToString() + "%";

            if (counter > 100)
            {
                timer1.Stop();
                Hide();
            }
        }
    }
}
