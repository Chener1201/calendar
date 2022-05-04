using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    public partial class Awork : UserControl
    {
        private Planitem job;

        public Planitem Job
        {
            get { return job; }
            set { job = value; }
        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public Awork(Planitem job)
        {
            InitializeComponent();

            comboBox1.DataSource = Planitem.ListStatus;

            this.Job = job;

            ShowInfo();
        }

        void ShowInfo()
        {
            textBox1.Text = Job.Job;
            Fromhour.Value = Job.FromTime.X;
            frommin.Value = Job.FromTime.Y;
            tohour.Value = Job.ToTime.X;
            tomin.Value = Job.ToTime.Y;
            comboBox1.SelectedIndex = Planitem.ListStatus.IndexOf(Job.Status);
            Box2.Checked = Planitem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Awork_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Job.Job = textBox1.Text;
            Job.FromTime = new Point((int)Fromhour.Value, (int)frommin.Value);
            Job.ToTime = new Point((int)tohour.Value, (int)tomin.Value);
            Job.Status = Planitem.ListStatus[comboBox1.SelectedIndex];
            if (edited != null)
                edited(this, new EventArgs());
        }

        private void Box2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Box2.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
        }
    }
}
