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
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }

        private Label labela = new Label();
        public string text = "csdn baihe_591";
        System.Timers.Timer timer1 = new System.Timers.Timer(400);
        public int paintX = 0;
        private void FrmShow_Load(object sender, EventArgs e)
        {
            this.labela.Location = new Point(149, 50);
            this.labela.Size = new Size(134, 32);
            this.Controls.Add(labela);
            this.labela.Text = "";
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(OrderTimer_Tick);//到时间的时候执行事件； 
            timer1.AutoReset = true;   //设置是执行一次（false）还是一直执行(true)； 
            timer1.Enabled = true;     //是否执行System.Timers.Timer.Elapsed事件； 
            p = new PointF(this.labela.Size.Width, 0);
            
        }

        PointF p;
        Font f = new Font("宋体", 10);
        Color c = Color.White;
        string temp;
        private void OrderTimer_Tick(object sender, EventArgs e)
        {

            Graphics g = this.labela.CreateGraphics();
            SizeF s = new SizeF();
            s = g.MeasureString(text, f);//测量文字长度  
            //Brush brush = Brushes.Black;
            Brush brush = Brushes.Red;
            g.Clear(c);//清除背景  

            if (temp != text)//文字改变时,重新显示  
            {
                p = new PointF(this.labela.Size.Width, 0);
                temp = text;
            }
            else
                p = new PointF(p.X - 100, 0);//每次偏移10  
            if (p.X <= -s.Width)
            {
                p = new PointF(this.labela.Size.Width, 0);
            }    
            g.DrawString(text, f, brush, p);
        }

    }
}
