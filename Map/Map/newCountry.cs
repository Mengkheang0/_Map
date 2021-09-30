using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map.Map
{
    public partial class newCountry : UserControl
    {
        Point llc, nlc;
        int bx, by, mx, my;
        bool _move;
        Form frm;
        string pathFile;
        _move mv = new _move();

        Random rn = new Random();
        string fv, lv;
        public newCountry(Form f)
        {
            frm = f;
            InitializeComponent();
            pcb.AllowDrop = true;
            this.MouseDown += new MouseEventHandler(mDown);
            this.MouseMove += new MouseEventHandler(mMove);
            this.MouseUp += new MouseEventHandler(mUp);
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
        }
        PictureBox pc;
        private void button1_Click(object sender, EventArgs e)
        {
            pc = new PictureBox();
            pc.Image = pcb.Image;
            pc.SizeMode = PictureBoxSizeMode.Zoom;
            pc.Size = new Size(40, 40);
            pc.Name = countryName.Text;
            pc.AccessibleDescription = description.Text;
            pc.Location = new Point(frm.Width / 2, frm.Height / 2);
            frm.Controls.Add(pc);
            pc.BringToFront();
            mv.movePictureBox(frm);


            //frm.Controls.Add();//picturebox   
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.ShowDialog();

            if (f.FileName.Length != 0)
            {
                f.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                pathFile = f.FileName;
                pcb.Image = new Bitmap(pathFile);
            }

        }

        private void pcb_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileName = data as String[];// same thing as (String[])data;
                if (fileName.Length > 0)
                {
                    pcb.Image = Image.FromFile(fileName[0]);
                }
            }

        }

        private void pcb_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
