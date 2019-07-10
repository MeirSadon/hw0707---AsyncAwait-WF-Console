using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw0707___UI_Thread___Exrice1_Winform_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(1000);
                });
                label1.Text = DateTime.Now.Millisecond.ToString();
                label1.ForeColor = DateTime.Now.Second % 2 == 0 ? Color.Green : Color.Red;
            }
        }
    }
}
