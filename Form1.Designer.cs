namespace calendar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Box1 = new System.Windows.Forms.CheckBox();
            this.buttoday = new System.Windows.Forms.Button();
            this.datetimepk = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Matrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.sun = new System.Windows.Forms.Button();
            this.sat = new System.Windows.Forms.Button();
            this.fri = new System.Windows.Forms.Button();
            this.thu = new System.Windows.Forms.Button();
            this.wed = new System.Windows.Forms.Button();
            this.Tue = new System.Windows.Forms.Button();
            this.Mon = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 409);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.Box1);
            this.panel3.Controls.Add(this.buttoday);
            this.panel3.Controls.Add(this.datetimepk);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 27);
            this.panel3.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(78, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Box1
            // 
            this.Box1.AutoSize = true;
            this.Box1.Location = new System.Drawing.Point(9, 4);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(63, 20);
            this.Box1.TabIndex = 0;
            this.Box1.Text = "Notify";
            this.Box1.UseVisualStyleBackColor = true;
            this.Box1.CheckedChanged += new System.EventHandler(this.Box1_CheckedChanged);
            // 
            // buttoday
            // 
            this.buttoday.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttoday.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttoday.Location = new System.Drawing.Point(670, 2);
            this.buttoday.Name = "buttoday";
            this.buttoday.Size = new System.Drawing.Size(85, 23);
            this.buttoday.TabIndex = 1;
            this.buttoday.Text = "Today";
            this.buttoday.UseVisualStyleBackColor = false;
            this.buttoday.Click += new System.EventHandler(this.buttoday_Click);
            // 
            // datetimepk
            // 
            this.datetimepk.Location = new System.Drawing.Point(424, 3);
            this.datetimepk.Name = "datetimepk";
            this.datetimepk.Size = new System.Drawing.Size(240, 22);
            this.datetimepk.TabIndex = 0;
            this.datetimepk.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Matrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 367);
            this.panel2.TabIndex = 0;
            // 
            // Matrix
            // 
            this.Matrix.Location = new System.Drawing.Point(142, 63);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(890, 300);
            this.Matrix.TabIndex = 1;
            this.Matrix.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPrevious);
            this.panel4.Controls.Add(this.sun);
            this.panel4.Controls.Add(this.sat);
            this.panel4.Controls.Add(this.fri);
            this.panel4.Controls.Add(this.thu);
            this.panel4.Controls.Add(this.wed);
            this.panel4.Controls.Add(this.Tue);
            this.panel4.Controls.Add(this.Mon);
            this.panel4.Location = new System.Drawing.Point(3, -58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1161, 115);
            this.panel4.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.Info;
            this.btnNext.Location = new System.Drawing.Point(1035, 61);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 51);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next-month";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.SystemColors.Info;
            this.btnPrevious.Location = new System.Drawing.Point(11, 61);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(122, 51);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous month";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // sun
            // 
            this.sun.BackColor = System.Drawing.SystemColors.Info;
            this.sun.Location = new System.Drawing.Point(907, 61);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(122, 51);
            this.sun.TabIndex = 6;
            this.sun.Text = "Sunday";
            this.sun.UseVisualStyleBackColor = false;
            // 
            // sat
            // 
            this.sat.BackColor = System.Drawing.SystemColors.Info;
            this.sat.Location = new System.Drawing.Point(779, 61);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(122, 51);
            this.sat.TabIndex = 5;
            this.sat.Text = "Saturday";
            this.sat.UseVisualStyleBackColor = false;
            // 
            // fri
            // 
            this.fri.BackColor = System.Drawing.SystemColors.Info;
            this.fri.Location = new System.Drawing.Point(651, 61);
            this.fri.Name = "fri";
            this.fri.Size = new System.Drawing.Size(122, 51);
            this.fri.TabIndex = 4;
            this.fri.Text = "Friday";
            this.fri.UseVisualStyleBackColor = false;
            // 
            // thu
            // 
            this.thu.BackColor = System.Drawing.SystemColors.Info;
            this.thu.Location = new System.Drawing.Point(523, 61);
            this.thu.Name = "thu";
            this.thu.Size = new System.Drawing.Size(122, 51);
            this.thu.TabIndex = 3;
            this.thu.Text = "Thursday";
            this.thu.UseVisualStyleBackColor = false;
            // 
            // wed
            // 
            this.wed.BackColor = System.Drawing.SystemColors.Info;
            this.wed.Location = new System.Drawing.Point(395, 61);
            this.wed.Name = "wed";
            this.wed.Size = new System.Drawing.Size(122, 51);
            this.wed.TabIndex = 2;
            this.wed.Text = "Wednesday";
            this.wed.UseVisualStyleBackColor = false;
            // 
            // Tue
            // 
            this.Tue.BackColor = System.Drawing.SystemColors.Info;
            this.Tue.Location = new System.Drawing.Point(267, 61);
            this.Tue.Name = "Tue";
            this.Tue.Size = new System.Drawing.Size(122, 51);
            this.Tue.TabIndex = 1;
            this.Tue.Text = "Tuesday";
            this.Tue.UseVisualStyleBackColor = false;
            // 
            // Mon
            // 
            this.Mon.BackColor = System.Drawing.SystemColors.Info;
            this.Mon.Location = new System.Drawing.Point(139, 61);
            this.Mon.Name = "Mon";
            this.Mon.Size = new System.Drawing.Size(122, 51);
            this.Mon.TabIndex = 0;
            this.Mon.Text = "Monday";
            this.Mon.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "notifyIcon1";
            this.Notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 425);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calendar ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker datetimepk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Matrix;
        private System.Windows.Forms.Button buttoday;
        private System.Windows.Forms.Button Mon;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox Box1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button sun;
        private System.Windows.Forms.Button sat;
        private System.Windows.Forms.Button fri;
        private System.Windows.Forms.Button thu;
        private System.Windows.Forms.Button wed;
        private System.Windows.Forms.Button Tue;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon Notify;
    }
}

