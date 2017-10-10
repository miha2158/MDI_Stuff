using System.Drawing;

namespace MDI_Stuff
{
    partial class Form1
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SaveAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileItem
            // 
            this.FileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.OpenItem,
            this.SaveItem,
            this.SaveAsItem,
            this.SaveAllItem,
            this.ExitItem});
            this.FileItem.Name = "FileItem";
            this.FileItem.Size = new System.Drawing.Size(37, 20);
            this.FileItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(152, 22);
            this.NewItem.Text = "New";
            this.NewItem.Click += new System.EventHandler(this.new_Click);
            // 
            // OpenItem
            // 
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.Size = new System.Drawing.Size(152, 22);
            this.OpenItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(152, 22);
            this.SaveItem.Text = "Save";
            this.SaveItem.Click += new System.EventHandler(this.save_Click);
            // 
            // SaveAsItem
            // 
            this.SaveAsItem.Name = "SaveAsItem";
            this.SaveAsItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAsItem.Text = "Save as";
            this.SaveAsItem.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(152, 22);
            this.ExitItem.Text = "Exit";
            // 
            // saveAllToolStripMenuItem
            // 
            this.SaveAllItem.Name = "SaveAllItem";
            this.SaveAllItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAllItem.Text = "Save all";
            this.SaveAllItem.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Arial", 13F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = this.Size;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem FileItem;
        private System.Windows.Forms.ToolStripMenuItem NewItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAllItem;
    }
}

