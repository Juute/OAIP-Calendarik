
namespace Date_and_time_v._2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.создатьКалендарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наДеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наМесяцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьКалендарьToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(736, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // создатьКалендарьToolStripMenuItem
            // 
            this.создатьКалендарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наДеньToolStripMenuItem,
            this.наМесяцToolStripMenuItem,
            this.наГодToolStripMenuItem});
            this.создатьКалендарьToolStripMenuItem.Name = "создатьКалендарьToolStripMenuItem";
            this.создатьКалендарьToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.создатьКалендарьToolStripMenuItem.Text = "Создать календарь";
            // 
            // наДеньToolStripMenuItem
            // 
            this.наДеньToolStripMenuItem.Name = "наДеньToolStripMenuItem";
            this.наДеньToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.наДеньToolStripMenuItem.Text = "на день";
            this.наДеньToolStripMenuItem.Click += new System.EventHandler(this.наДеньToolStripMenuItem_Click);
            // 
            // наМесяцToolStripMenuItem
            // 
            this.наМесяцToolStripMenuItem.Name = "наМесяцToolStripMenuItem";
            this.наМесяцToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.наМесяцToolStripMenuItem.Text = "на месяц";
            // 
            // наГодToolStripMenuItem
            // 
            this.наГодToolStripMenuItem.Name = "наГодToolStripMenuItem";
            this.наГодToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.наГодToolStripMenuItem.Text = "на год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 920);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem создатьКалендарьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наДеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наМесяцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наГодToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}