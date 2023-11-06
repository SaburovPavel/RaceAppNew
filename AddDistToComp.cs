using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RaceApp
{
    public partial class AddDistToComp : Form
    {
        TimingForm timingForm;

        public AddDistToComp(TimingForm owen)
        {
            timingForm = owen;
            InitializeComponent();
        }

        private void AddDistToComp_Load(object sender, EventArgs e)
        {
            labelComp.Text = timingForm.comboBoxComp.Text;

            using (var context = new MyDbContext())
            {
                var groups = context.Groups.Select(item => new {item.Id, item.Name}).ToList();                
                comboBoxGroup.DataSource = groups;
                comboBoxGroup.DisplayMember = "Name";
            }

            using (var context = new MyDbContext())
            {
                var dist = context.Distances.Select(item => new { item.Id, item.Name }).ToList();

                comboBoxDist.DataSource = dist;
                comboBoxDist.DisplayMember = "Name";
            }

            textBoxLap.Text = "1";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxLap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxLap.Text, out int value))
            {
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
