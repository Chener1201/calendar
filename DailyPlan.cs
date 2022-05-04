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
    public partial class DailyPlan : Form
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;
            
            fPanel.Width = panelJob.Width;
            fPanel.Height = panelJob.Height;
            panelJob.Controls.Add(fPanel);

            datetimepk.Value = Date;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DailyPlan_Load(object sender, EventArgs e)
        {

        }

        void ShowWorkByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (job != null && Job.Job != null)
            {
                List<Planitem> todayJob = GetJobByDate(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddWork(todayJob[i]);
                }
            }
        }

        void AddWork(Planitem job)
        {
            Awork awork = new Awork(job);
            awork.Edited += awork_Edited;
            awork.Deleted += awork_Deleted;
            fPanel.Controls.Add(awork);
        }

        private void awork_Deleted(object sender, EventArgs e)
        {
            Awork uc = sender as Awork;
            Planitem job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        private void awork_Edited(object sender, EventArgs e)
        {

        }

        List<Planitem> GetJobByDate(DateTime date)
        {
            return Job.Job.Where(p => p.date.Year == date.Year && p.date.Month == date.Month && p.date.Day == date.Day).ToList();
        }

        private void datetime2_ValueChanged(object sender, EventArgs e)
        {
            ShowWorkByDate((sender as DateTimePicker).Value);
        }

        private void preday_Click(object sender, EventArgs e)
        {
            datetimepk.Value = datetimepk.Value.AddDays(-1);
        }

        private void Nextday_Click(object sender, EventArgs e)
        {
            datetimepk.Value = datetimepk.Value.AddDays(1);
        }

        private void addWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planitem item = new Planitem() { date = datetimepk.Value };
            Job.Job.Add(item);
            AddWork(item);
        }

        private void todayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datetimepk.Value = DateTime.Now;
        }
    }
}
