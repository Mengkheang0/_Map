using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Changeinfo : UserControl
    {
        Point llc, nlc;
        int bx, by, mx, my;

     

        bool _move;
        public Changeinfo()
        {
            InitializeComponent();
            

        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        public Changeinfo(string ItemsName,PictureBox pb, Form f) 
        {
            InitializeComponent();

            ///Add information
            pictureBox1.Image = pb.Image;
            
            label1.Text = ItemsName;
            listBox1.Text += $"-Type : {pb.GetType().Name}\r\n" +
                $"-Name : {pb.Name}\r\n" +
                $"-Location : {pb.Location} \r\n" +
                $"-Size : {pb.Size} \r\n" +
                $"-Description : {pb.AccessibleDescription}";
            
            //Events
            this.MouseDown += new MouseEventHandler(mDown);
            this.MouseMove += new MouseEventHandler(mMove);
            this.MouseUp += new MouseEventHandler(mUp);
            guna2Button1.Click += new EventHandler(click);
            guna2Button2.Click += new EventHandler(removePc);
            void removePc(object sender, EventArgs e)
            {
                f.Controls.Remove(pb);
            }
            void mDown(object sender, MouseEventArgs e)
            {
                _move = true;
                llc = e.Location;
                bx = MousePosition.X - Bounds.X;
                by = MousePosition.Y - Bounds.Y;

            }
            void mMove(object sender, MouseEventArgs e)
            {
                if (_move)
                {
                    nlc.X = e.X - llc.X;
                    nlc.Y = e.Y - llc.Y;
                    mx = MousePosition.X - bx;
                    my = MousePosition.Y - by;

                    this.Location = new Point(mx, my);
                }
            }
            void mUp(object sender, MouseEventArgs e)
            {
                _move = false;
            }
            void click(object sender, EventArgs e)
            {
                if (guna2TextBox1.Text != "" && guna2TextBox2.Text != "")
                {
                    try
                    {
                        pb.Width = int.Parse(guna2TextBox1.Text);
                        pb.Height = int.Parse(guna2TextBox2.Text);
                    }
                    catch (Exception)
                    {
                    }
                    
                }
            }
        }



    }
}
