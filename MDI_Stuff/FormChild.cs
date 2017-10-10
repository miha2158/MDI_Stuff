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
        private bool Draw;
        private MouseEventArgs PrevArgs;
        public Bitmap Bm;
        public Color col => ((Form1)MdiParent).col;
        public float size => ((Form1)MdiParent).size;
        private Pen pen => ((Form1)MdiParent).pen;

        public FormChild()
        {
            InitializeComponent();

            Bm = new Bitmap(Width, Height, PixelFormat.Format64bppArgb);
            Bm.MakeTransparent();

            pic.Size = Bm.Size;
            pic.Image = Bm;
            pic.SizeMode = PictureBoxSizeMode.Normal;
            FormChild_ResizeEnd(null, null);
        }

        private void picMouseUp(object sender, MouseEventArgs e)
        {
            Draw = false;
        }
        private void picMouseDown(object sender, MouseEventArgs e)
        {
            Draw = true;
            PrevArgs = e;
        }
        private void picMouseMove(object sender, MouseEventArgs e)
        {
            if (Draw)
            {
                Graphics.FromImage(Bm).DrawLine(pen, e.X, e.Y, PrevArgs.X, PrevArgs.Y);
                
                pic.Image = Bm;
                PrevArgs = e;
            }
        }

        private void FormChild_ResizeEnd(object sender, EventArgs e)
        {
            pic.Size = ClientSize;
        }

        private void picMouseClick(object sender, MouseEventArgs e)
        {
            Bm.SetPixel(e.X, e.Y, col);
            pic.Image = Bm;
        }
    }
}
