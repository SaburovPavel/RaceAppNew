using RaceApp;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();

            dataGridViewGroup.SetDoubleBuffered(true);

            RefreshGroup();
        }

        private void RefreshGroup()
        {
            using (var context = new MyDbContext())
            {
                var groups = from row in context.Groups
                             select new
                             {
                                 row.Name,
                                 row.Id,
                                 row.AgeAt,
                                 row.AgeTo,
                                 row.Gender,
                                 row.FullName,
                                 row.ForTeam
                             };
                dataGridViewGroup.DataSource = groups.ToList();
                dataGridViewGroup.Columns["Id"].Visible = false;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TwoButtonForm twoButtonForm = new TwoButtonForm("Создать группу по годам рождения участников", "Создать группу по возрасту участников");
            twoButtonForm.ShowDialog();

        }

        private void dataGridViewGroup_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewGroup.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();

                if (row.Index % 2 != 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
            this.dataGridViewGroup.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
