using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceApp
{
    public partial class TimingForm : Form
    {
        public TimingForm()
        {
            InitializeComponent();
            dataGridViewGroupStart.SetDoubleBuffered(true);
        }
        void RefreshDistToComp()
        {
            using (var context = new MyDbContext())
            {
                var list = context.CompsStarts.ToList();
                dataGridViewGroupStart.DataSource = list;
            }
        }
        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            AddDistToComp addDistToComp = new AddDistToComp(this);
            if (addDistToComp.ShowDialog() == DialogResult.OK)
            {
                using (var context = new MyDbContext())
                {
                    int compId = 0;
                    int groupId = 0;
                    int distId = 0;

                    var selectedComp = comboBoxComp.SelectedItem as dynamic;
                    if (selectedComp != null)
                    {
                        compId = selectedComp.Id;
                    }

                    var selectedGroup = addDistToComp.comboBoxGroup.SelectedItem as dynamic;
                    if (selectedGroup != null)
                    {
                        groupId = selectedGroup.Id;                        
                    }

                    var selectedDist = addDistToComp.comboBoxDist.SelectedItem as dynamic;
                    if (selectedDist != null)
                    {
                        distId = selectedDist.Id;
                    }

                    int lap = Convert.ToInt32(addDistToComp.textBoxLap.Text);

                    var compSatrt = new CompStart()
                    {
                        CompId = compId,
                        GroupId = groupId,
                        DistanceId = distId
                    };

                    context.CompsStarts.Add(compSatrt);
                    context.SaveChanges();

                    RefreshDistToComp();
                }
            }
        }

        private void TimingForm_Load(object sender, EventArgs e)
        {
            using(var context = new MyDbContext())
            {
                var comp = context.Comps.Select(item => new {item.Id, item.Name }).ToList();                

                comboBoxComp.DataSource = comp;
                comboBoxComp.DisplayMember = "Name";
                
                int itemCount = comboBoxComp.Items.Count;
                if (itemCount > 1)
                {
                    comboBoxComp.SelectedIndex = itemCount - 1;
                }
            }
        }
    }
}
