namespace calendar
{
    partial class Awork
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Del = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.frommin = new System.Windows.Forms.NumericUpDown();
            this.tomin = new System.Windows.Forms.NumericUpDown();
            this.tohour = new System.Windows.Forms.NumericUpDown();
            this.Fromhour = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frommin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fromhour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Box2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Del);
            this.panel3.Controls.Add(this.Edit);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(699, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 24);
            this.panel3.TabIndex = 4;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(172, 1);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(62, 23);
            this.Del.TabIndex = 2;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(108, 1);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(58, 23);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.frommin);
            this.panel2.Controls.Add(this.tomin);
            this.panel2.Controls.Add(this.tohour);
            this.panel2.Controls.Add(this.Fromhour);
            this.panel2.Location = new System.Drawing.Point(470, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 24);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frommin
            // 
            this.frommin.Location = new System.Drawing.Point(52, 0);
            this.frommin.Name = "frommin";
            this.frommin.Size = new System.Drawing.Size(43, 22);
            this.frommin.TabIndex = 4;
            // 
            // tomin
            // 
            this.tomin.Location = new System.Drawing.Point(180, 0);
            this.tomin.Name = "tomin";
            this.tomin.Size = new System.Drawing.Size(43, 22);
            this.tomin.TabIndex = 3;
            // 
            // tohour
            // 
            this.tohour.Location = new System.Drawing.Point(131, 0);
            this.tohour.Name = "tohour";
            this.tohour.Size = new System.Drawing.Size(43, 22);
            this.tohour.TabIndex = 2;
            // 
            // Fromhour
            // 
            this.Fromhour.Location = new System.Drawing.Point(3, 0);
            this.Fromhour.Name = "Fromhour";
            this.Fromhour.Size = new System.Drawing.Size(43, 22);
            this.Fromhour.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Box2
            // 
            this.Box2.AutoSize = true;
            this.Box2.Location = new System.Drawing.Point(3, 3);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(18, 17);
            this.Box2.TabIndex = 1;
            this.Box2.UseVisualStyleBackColor = true;
            this.Box2.CheckedChanged += new System.EventHandler(this.Box2_CheckedChanged);
            // 
            // Awork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Awork";
            this.Size = new System.Drawing.Size(948, 40);
            this.Load += new System.EventHandler(this.Awork_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frommin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tohour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fromhour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Box2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown frommin;
        private System.Windows.Forms.NumericUpDown tomin;
        private System.Windows.Forms.NumericUpDown tohour;
        private System.Windows.Forms.NumericUpDown Fromhour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
