using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Stuff
{
    public partial class FormChild : Form
    {
        public Bitmap bm = new Bitmap(300,300,PixelFormat.Format1bppIndexed);

        public FormChild()
        {
            InitializeComponent();
            Graphics gr = CreateGraphics();
            gr.DrawImage(bm, 0, 0);
        }
    }
}
