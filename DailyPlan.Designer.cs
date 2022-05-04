namespace calendar
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.addWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelJob = new System.Windows.Forms.Panel();
            this.datetimepk = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.preday = new System.Windows.Forms.Button();
            this.Nextday = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.menuMain);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 463);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkToolStripMenuItem,
            this.todayToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(955, 28);
            this.menuMain.TabIndex = 3;
            this.menuMain.Text = "menuStrip1";
            // 
            // addWorkToolStripMenuItem
            // 
            this.addWorkToolStripMenuItem.Name = "addWorkToolStripMenuItem";
            this.addWorkToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.addWorkToolStripMenuItem.Text = "Add work";
            this.addWorkToolStripMenuItem.Click += new System.EventHandler(this.addWorkToolStripMenuItem_Click);
            // 
            // todayToolStripMenuItem
            // 
            this.todayToolStripMenuItem.Name = "todayToolStripMenuItem";
            this.todayToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.todayToolStripMenuItem.Text = "Today";
            this.todayToolStripMenuItem.Click += new System.EventHandler(this.todayToolStripMenuItem_Click);
            // 
            // panelJob
            // 
            this.panelJob.Location = new System.Drawing.Point(9, 83);
            this.panelJob.Name = "panelJob";
            this.panelJob.Size = new System.Drawing.Size(940, 382);
            this.panelJob.TabIndex = 0;
            // 
            // datetimepk
            // 
            this.datetimepk.Location = new System.Drawing.Point(356, 3);
            this.datetimepk.Name = "datetimepk";
            this.datetimepk.Size = new System.Drawing.Size(247, 22);
            this.datetimepk.TabIndex = 1;
            this.datetimepk.ValueChanged += new System.EventHandler(this.datetime2_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.preday);
            this.panel3.Controls.Add(this.Nextday);
            this.panel3.Controls.Add(this.datetimepk);
            this.panel3.Location = new System.Drawing.Point(12, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 34);
            this.panel3.TabIndex = 2;
            // 
            // preday
            // 
            this.preday.Location = new System.Drawing.Point(3, 3);
            this.preday.Name = "preday";
            this.preday.Size = new System.Drawing.Size(105, 26);
            this.preday.TabIndex = 3;
            this.preday.Text = "Previous day";
            this.preday.UseVisualStyleBackColor = true;
            this.preday.Click += new System.EventHandler(this.preday_Click);
            // 
            // Nextday
            // 
            this.Nextday.Location = new System.Drawing.Point(827, 3);
            this.Nextday.Name = "Nextday";
            this.Nextday.Size = new System.Drawing.Size(105, 26);
            this.Nextday.TabIndex = 2;
            this.Nextday.Text = "Next day";
            this.Nextday.UseVisualStyleBackColor = true;
            this.Nextday.Click += new System.EventHandler(this.Nextday_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelJob);
            this.Controls.Add(this.panel1);
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daily Plan";
            this.Load += new System.EventHandler(this.DailyPlan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker datetimepk;
        private System.Windows.Forms.Panel panelJob;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem addWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayToolStripMenuItem;
        private System.Windows.Forms.Button preday;
        private System.Windows.Forms.Button Nextday;
    }
}