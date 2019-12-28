using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWebsocket
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string str;//定义的私有变量
        public string STR //为窗体Form2定义的属性
        {
            get { return str; }//读
            set//写
            {
                str = value;
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 20;
            this.timer1.Enabled = true;
            this.WindowState = FormWindowState.Maximized;
            label1.ForeColor = Color.Red;
            label1.Text = str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left -= 2;
            if (label1.Right < 0)
            {
                label1.Left = this.Width;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
