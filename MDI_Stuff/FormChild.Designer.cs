using System.Drawing;

namespace MDI_Stuff
{
    partial class FormChild
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(500, 300);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picMouseUp);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picMouseClick);
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MDI_Stuff.Properties.Resources.grid;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.pic);
            this.Font = new System.Drawing.Font("Arial", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.MinimumSize = this.Size;
            this.Name = "FormChild";
            this.ShowIcon = false;
            this.ResizeEnd += new System.EventHandler(this.FormChild_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pic;
    }
}