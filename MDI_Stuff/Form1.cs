using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI_Stuff
{
    public partial class Form1: Form
    {
        public FormChild lastActive;
        public string lastName
        {
            get => names[MdiChildren.ToList().IndexOf(lastActive)];
            set => names[MdiChildren.ToList().IndexOf(lastActive)] = value;
        }
        public List<string> names;

        public Color col = Color.Red;
        public float size;
        public Pen pen;

        public Form1()
        {
            names = new List<string>(0);
            size = 1;
            pen = new Pen(col, size);


            InitializeComponent();
        }

        private void new_Click(object sender, EventArgs e)
        {
            var f1 = new FormChild();
            f1.MdiParent = this;
            names.Add(string.Empty);
            f1.Show();
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            if (lastActive == null)
                return;

            var bm = lastActive.Bm;

            var sf = new SaveFileDialog
            {
                DefaultExt = "bmp",
                AddExtension = true,
                DereferenceLinks = true,
            };

            var res = sf.ShowDialog();
            //if (res == DialogResult.Yes || res == DialogResult.OK)
                using (var file = sf.OpenFile())
                {
                    lastName = sf.FileName;
                    bm.Save(file, ImageFormat.Bmp);
                }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (lastActive == null)
                return;

            var bm = lastActive.Bm;

            using (var fs =
                new FileStream(
                    $@"C:\Users\user\Documents\Visual Studio 2017\Projects\MDI_Stuff\{
                            MdiChildren.ToList().IndexOf(lastActive)
                        }.bmp", FileMode.Create))
                bm.Save(fs, ImageFormat.Bmp);
        }
        private void saveAll_Click(object sender, EventArgs e)
        {
            var temp = lastActive;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                lastActive = (FormChild)MdiChildren[i];
                if (lastName == string.Empty)
                    saveAs_Click(sender, e);
                else
                    save_Click(sender, e);
            }

            lastActive = temp;
        }
    }
}