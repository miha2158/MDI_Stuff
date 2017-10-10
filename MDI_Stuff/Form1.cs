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
        public string name(Form f) => names[MdiChildren.ToList().IndexOf(f)];

        public string lastName
        {
            get => name(ActiveMdiChild);
            set => names[MdiChildren.ToList().IndexOf(ActiveMdiChild)] = value;
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

        public void save_Item(FormChild child, bool choice)
        {
            if (ActiveMdiChild == null)
                return;

            var bm = ((FormChild)ActiveMdiChild).Bm;

            SaveFileDialog sf = new SaveFileDialog();

            if (choice)
            {
                sf.DefaultExt = "bmp";
                sf.AddExtension = true;
                sf.DereferenceLinks = true;
                sf.SupportMultiDottedExtensions = true;

                sf.ShowDialog();

                lastName = sf.FileName;
            }

            try
            {
                using (var fs = new FileStream(lastName, FileMode.Create))
                    bm.Save(fs, ImageFormat.Bmp);
            }
            catch { }
        }
        private void saveAs_Click(object sender, EventArgs e)
        {
            save_Item((FormChild)ActiveMdiChild, true);
        }
        private void save_Click(object sender, EventArgs e)
        {
            save_Item((FormChild)ActiveMdiChild, lastName == string.Empty);
        }

        private void saveAll_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
                save_Item((FormChild)f, name(f) == string.Empty);
        }
    }
}