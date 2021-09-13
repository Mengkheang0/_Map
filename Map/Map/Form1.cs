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
    public partial class Form1 : Form
    {
        _move mv = new _move();
        public Form1()
        {
            InitializeComponent();
            US.ImageLocation = "https://findicons.com/files/icons/281/flag_3/256/united_kingdom_flag.png";
            China.ImageLocation = "https://cdn.pixabay.com/photo/2013/07/13/09/53/china-156219_960_720.png";
            Cambodia.ImageLocation = "https://cdn.pixabay.com/photo/2013/07/13/09/54/cambodia-156281_1280.png";
            mv.movePictureBox(this);
        }
    }
}
