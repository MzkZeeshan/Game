using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr LoadCursorFromFile(string filename);

        public Form1()
        {
            //Bitmap bmp = (Bitmap)Bitmap.FromFile(WindowsFormsApplication4.Properties.Resources.));
            Bitmap bmp = new Bitmap(WindowsFormsApplication4.Properties.Resources.b1);
            bmp.MakeTransparent(Color.Black);
            IntPtr ptr1 = bmp.GetHicon();

            Cursor cur = new Cursor(ptr1);
            this.Cursor = cur;
            InitializeComponent();
        }
       
        void play_sound()
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();

           // player.Stream = Properties.Resources.b2;
          //  player.Play();



           // System.Media.SoundPlayer play = new System.Media.SoundPlayer(Properties.Resources.b2);
           // play.Play();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.CancelButton = this.button1;
           // this.button1.Visible = false;
            //Form1 a=new Form1();
          //  this.AcceptButton = a.Show();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
           //this.label1.Location=new Point(10,10);
            int a = this.label1.Location.X;
                 int b = this.label1.Location.Y;
            int x=rnd.Next(0,1500);
             int y=rnd.Next(400,800);
            this.label1.Location=new Point(x,y);
         //   this.label2.Text = x.ToString() +"  "+ y.ToString();
           /* if( a==32 && b==166 )
            {

                this.label1.Location = new Point(36, 100);
            }
            else
            {
                this.label1.Location = new Point(32, 166);
            }
            */
        }

        private void label4_Click(object sender, EventArgs e)
        {
            play_sound();
        }
        int i = 0;
        private void label1_Click(object sender, EventArgs e)
        {
          
            ++i;

            this.label9.Text = i.ToString();
            this.label11.Text = (i*100).ToString();

            play_sound();
            
              int a=this.label7.Size.Width;
           
            this.label7.Width = a - 44;
            if (a == 44)
            {
                Form4 aaa = new Form4();
                aaa.Show();

                    this.Hide();
            }
        
        }

        private void label3_Click(object sender, EventArgs e)
        {
            play_sound();

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt16(this.label10.Text);
            a=a-1;
            if (a== 0)
            {
                Form3 aaaaa = new Form3();
                aaaaa.Show();
                this.Hide();
            }
            this.label10.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 a = new Form2();
           
            a.Show();
        }
    }
}
