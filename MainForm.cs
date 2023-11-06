using System;
using System.Windows.Forms;

namespace RaceApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //using (var context = new MyDbContext())
            //{
            //    var comps = new List<Comp>()
            //    {
            //        new Comp() {Name = "4 полумарафон", Date = DateTime.Now.ToString("d"), Individual = true, Biathlon = false},
            //        new Comp() {Name = "6 полумарафон", Date = DateTime.Now.ToString(), Individual = false, Biathlon = true}
            //    };

            //    context.Comps.AddRange(comps);
            //    context.SaveChanges();
            //}
        }

        private void buttonComp_Click(object sender, EventArgs e)
        {
            CompForm compForm = new CompForm();
            compForm.ShowDialog();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm();
            groupForm.ShowDialog();
        }

        private void buttonDistance_Click(object sender, EventArgs e)
        {
            DistanceForm groupForm = new DistanceForm();
            groupForm.ShowDialog();
        }

        private void buttonTiming_Click(object sender, EventArgs e)
        {
            TimingForm timingForm = new TimingForm();
            timingForm.Show();
        }
    }
}
