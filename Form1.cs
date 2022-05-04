using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace calendar
{
    public partial class Form1 : Form
    {
        #region Properties
        private int appTime;

        public int AppTime
        {
            get { return appTime; }
            set { appTime = value; }
        }

        private string filePath = "data.xml";
        
        private List<List<Button>> matrix_1;

        public List<List<Button>> Matrix1
        {
            get { return Matrix1; }
            set { Matrix1 = value; }
        }

        private PlanData job;

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public Form1()
        {
            InitializeComponent();

            timer.Start();
            appTime = 0;
            LoadMatrix();
            try
            {
                job = DeserializeFromXML(filePath) as PlanData;
            }
            catch 
            {
                setDefaultJob();
            }
        }
        void setDefaultJob()
        {
            job = new PlanData();
            job.Job = new List<Planitem>();
            job.Job.Add(new Planitem()
            {
                date = DateTime.Now.AddDays(-3),
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Nhi cute",
                Status = Planitem.ListStatus[(int)EPlanItem.COMING]
            });
            job.Job.Add(new Planitem()
            {
                date = DateTime.Now.AddDays(-2),
                FromTime = new Point(5, 0),
                ToTime = new Point(6, 0),
                Job = "chuan bi do an C#",
                Status = Planitem.ListStatus[(int)EPlanItem.COMING]
            });
            job.Job.Add(new Planitem()
            {
                date = DateTime.Now.AddDays(-1),
                FromTime = new Point(7, 0),
                ToTime = new Point(10, 0),
                Job = "Lam do an C#",
                Status = Planitem.ListStatus[(int)EPlanItem.DONE]
            });
            job.Job.Add(new Planitem()
            {
                date = DateTime.Now,
                FromTime = new Point(12, 0),
                ToTime = new Point(15, 0),
                Job = "Lam do an C# va ban giao",
                Status = Planitem.ListStatus[(int)EPlanItem.COMING]
            });
        }

        void LoadMatrix()
        {
            matrix_1 = new List<List<Button>>();
            Button oldBtn = new Button() { Width =0, Height = 0, Location = new Point(-Cons.margin, 0)};
            for(int i = 0; i < Cons.DayOfColumn; i++)
            {
                matrix_1.Add(new List<Button>());
                for(int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth + Cons.margin, Height = Cons.dateButtonHeight};
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += Btn_Click;

                    Matrix.Controls.Add(btn);
                    matrix_1[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            setDefaultDate();
        }

        void Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text)) ;
            DailyPlan daily = new DailyPlan(new DateTime(datetimepk.Value.Year, datetimepk.Value.Month, Convert.ToInt32((sender as Button).Text)),job);
            daily.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30;
            }
        }

        void NumOfDay(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = matrix_1[line][column];
                btn.Text = i.ToString();

                if(isEqualDate(useDate,DateTime.Now))
                {
                    btn.BackColor = Color.Red;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Yellow;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);

            }
        }

        bool isEqualDate(DateTime DateA, DateTime DateB)
        {
            return DateA.Year == DateB.Year && DateA.Month == DateB.Month && DateA.Day == DateB.Day;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void ClearMatrix()
        {
            for(int i = 0; i < matrix_1.Count; i++)
            {
                for(int j = 0; j < matrix_1[i].Count; j++)
                {
                    Button btn = matrix_1[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        void setDefaultDate()
        {
            datetimepk.Value = DateTime.Now;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            NumOfDay((sender as DateTimePicker).Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            datetimepk.Value = datetimepk.Value.AddMonths(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            datetimepk.Value = datetimepk.Value.AddMonths(1);
        }

        private void buttoday_Click(object sender, EventArgs e)
        {
            setDefaultDate();
        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);

            fs.Close();
        }
        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));

                object result = sr.Deserialize(fs);

                fs.Close();

                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }

            return null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(job, filePath);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!Box1.Checked)
                return; 

            AppTime++;
            if (AppTime < Cons.notify)
                return;
            if (job == null || job.Job == null)
                return;

            DateTime currentDate = DateTime.Now;
            List<Planitem> todayjobs = job.Job.Where(p => p.date.Year == currentDate.Year && p.date.Month == currentDate.Month && p.date.Day == currentDate.Day).ToList();
            Notify.ShowBalloonTip(Cons.notifyTimeOut, "Calendar", String.Format("You have {0} work for today", todayjobs.Count), ToolTipIcon.Info);

            AppTime = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Cons.notify = (int)numericUpDown1.Value;
        }

        private void Box1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = Box1.Checked;
        }
    }
}
