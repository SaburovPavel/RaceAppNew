using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace RaceApp
{
    public partial class GroupForm : Form
    {
        public bool toEdit = false;
        public bool createByYear = false;
        public bool createByAge = false;
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
            TwoButtonForm twoButtonForm = new TwoButtonForm("Создать группу по ГОДАМ рождения участников (2002-2004)", "Создать группу по Возрасту участников (14-15)");
            twoButtonForm.ShowDialog();
            if (twoButtonForm.left)
            {
                createByYear = true;

                AddGroupForm addGroupForm = new AddGroupForm(this);
                addGroupForm.ShowDialog();

                if (addGroupForm.DialogResult == DialogResult.OK)
                {
                    RefreshGroup();
                }
            }

            if (twoButtonForm.right)
            {
                createByAge = true;

                AddGroupForm addGroupForm = new AddGroupForm(this);
                addGroupForm.ShowDialog();

                if (addGroupForm.DialogResult == DialogResult.OK)
                {
                    RefreshGroup();
                }
            }
            createByYear = false;
            createByAge = false;
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            toEdit = true;
            createByYear = true;

            AddGroupForm addGroupForm = new AddGroupForm(this);
            addGroupForm.ShowDialog();

            if (addGroupForm.DialogResult == DialogResult.OK)
            {
                RefreshGroup();
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (CheckDataGrid.CheckDataGridForEmty(dataGridViewGroup))
            {
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить ВСЕ записи?", "Удаление записей",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (var context = new MyDbContext())
                {
                    context.Groups.RemoveRange(context.Groups);
                    context.SaveChanges();
                }
                RefreshGroup();
            }
        }        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CheckDataGrid.CheckDataGridForEmty(dataGridViewGroup))
            {
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записей",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (var context = new MyDbContext())
                {
                    var group = context.Set<Group>().Find(dataGridViewGroup.CurrentRow.Cells["Id"].Value);

                    if (group != null)
                    {
                        context.Set<Group>().Remove(group);
                        context.SaveChanges();
                    }
                }
                RefreshGroup();
            }
        }

        private void dataGridViewGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                buttonDelete_Click(sender, e);
            }
        }

        private void dataGridViewGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEdit_Click(sender, e);
        }
    }
}
