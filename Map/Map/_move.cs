using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Map
{
    public class _move
    {
        bool isMove;
        int bx, by, mx, my;
        Point lastlocation;
        Point newlocation;
        string itemProp;
        Guna2GradientPanel cp;
        Changeinfo uinfo;
        public void movePictureBox(Form f)
        {
            foreach (Control c in f.Controls)
                {
                    if (c is PictureBox && c.GetType().Name != "Guna2PictureBox")
                    {
                        PictureBox picture = c as PictureBox;
                        picture.Cursor = Cursors.SizeAll;

                        picture.MouseDown += new MouseEventHandler(mDown);
                        picture.MouseMove += new MouseEventHandler(mMove);
                        picture.MouseUp += new MouseEventHandler(mUp);
                        picture.MouseEnter += new EventHandler(mEnter);
                        picture.MouseLeave += new EventHandler(mLeave);
                        picture.DoubleClick += new EventHandler(dbClick);
                        void dbClick(object sender, EventArgs e)
                        {

                            itemProp = picture.Name;
                            uinfo = new Changeinfo(itemProp, picture,f);
                            uinfo.Location = new Point(picture.Right + cp.Width, picture.Top);
                            f.Controls.Add(uinfo);
                            uinfo.BringToFront();

                            if (!uinfo.Visible)
                                uinfo.Visible = true;

                        }

                        void mEnter(object sender, EventArgs e)
                        {
                            picture.Cursor = Cursors.SizeAll;
                            Customize(f, picture);
                            f.Controls.Add(cp);
                            cp.BringToFront();
                            addText(cp, picture.Name, picture.AccessibleDescription);

                        }
                        void mLeave(object sender, EventArgs e)
                        {
                            picture.Cursor = Cursors.Default;
                            f.Controls.Remove(cp);
                        }

                        void mDown(object sender, MouseEventArgs e)
                        {
                            isMove = true;
                            bx = Cursor.Position.X - f.Bounds.X;
                            by = Cursor.Position.Y - f.Bounds.Y;
                            lastlocation = e.Location;
                        }
                        void mMove(object sender, MouseEventArgs e)
                        {
                            if (isMove)
                            {
                                picture.Cursor = Cursors.SizeAll;
                                mx = Cursor.Position.X - bx;
                                mx = Cursor.Position.Y - by;

                                newlocation.X = picture.Location.X - lastlocation.X;
                                newlocation.Y = picture.Location.Y - lastlocation.Y;
                                picture.Location = new Point(newlocation.X + e.X, newlocation.Y + e.Y);
                                cp.Location = new Point(picture.Right, picture.Top);

                                //picture.Location = new Point((picture.Location.X - lastlocation.X) + e.X, (picture.Location.Y - lastlocation.Y) + e.Y);

                            }
                        }
                        void mUp(object sender, MouseEventArgs e)
                        {
                            isMove = false;
                            picture.Cursor = Cursors.Default;
                        }

                        //Info panel
                        void Customize(Form frm, PictureBox pb)
                        {
                            Guna2GradientPanel gpn = new Guna2GradientPanel(); // need to initially if not animation will stop animated
                            cp = gpn;
                            Timer time = new Timer();


                            gpn.Width = 50;
                            gpn.Height = pb.Height * 2;
                            //gpn.Size = new Size(200, pb.Height);
                            gpn.FillColor = Color.Purple;
                            gpn.FillColor2 = Color.DarkSlateBlue;
                            gpn.Location = new Point(pb.Right, pb.Top);
                            gpn.BorderRadius = 8;
                            gpn.BackColor = Color.Transparent;

                            time.Interval = 5;
                            time.Tick += new EventHandler(tick);
                            time.Start();
                            void tick(object sender, EventArgs e)
                            {
                                if (gpn.Width < 200)
                                    gpn.Width += 10;
                            }


                            //Resize Controls


                        }
                        void addText(Guna2GradientPanel pn, string header, string sub)
                        {
                            //Header Text
                            Label txt = new Label();
                            txt.Text = header;
                            txt.Font = new Font("Coolvetica Rg", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            txt.ForeColor = Color.White;
                            txt.Location = new Point(0, 0);
                            pn.Controls.Add(txt);

                            //Sub text
                            Label subTxt = new Label();
                            subTxt.MaximumSize = new Size(200, 0);
                            subTxt.AutoSize = true;
                            subTxt.Text = sub;
                            subTxt.Location = new Point(0, txt.Bottom + 10);
                            subTxt.ForeColor = Color.WhiteSmoke;
                            subTxt.Font = new Font("Consolas", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            pn.Controls.Add(subTxt);

                            if (subTxt.Bottom >= pn.Width)
                            {
                                pn.Height += subTxt.Height;
                            }

                        }

                    }
                }
        }
        
    }
}
