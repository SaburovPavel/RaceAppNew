using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RaceApp
{
    public partial class DistanceForm : Form
    {
        public bool toEdit = false;
        public DistanceForm()
        {
            InitializeComponent();

            dataGridViewDistance.SetDoubleBuffered(true);
        }
        void RefreshDistForm()
        {

            using (var context  = new MyDbContext())
            {
                var distance = context.Distances.Select(item => new { item.Id, item.Name, item.LenthLap, item.HighLap });
                var results = distance.ToList();

                dataGridViewDistance.DataSource = results;
                dataGridViewDistance.Columns["Id"].Visible = false;
            }            
        }

        private void DistanceForm_Load(object sender, EventArgs e)
        {
            RefreshDistForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddDistance addDistance = new AddDistance(this);
            if(addDistance.ShowDialog() == DialogResult.OK)
            {
                using(var context = new MyDbContext())
                {
                    var distance = new Distance()
                    {
                        Name = addDistance.name,
                        LenthLap = addDistance.lenth,
                        HighLap = addDistance.high
                    };

                    context.Distances.Add(distance);
                    context.SaveChanges();
                }

                RefreshDistForm();
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (CheckDataGrid.CheckDataGridForEmty(dataGridViewDistance))
            {
                return;
            }

            toEdit = true;
            buttonAdd_Click(sender, e);
            toEdit = false;

        }

        private void dataGridViewDistance_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buttonEdit_Click(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CheckDataGrid.CheckDataGridForEmty(dataGridViewDistance))
            {
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записей",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (var context = new MyDbContext())
                {
                    var distance = context.Set<Distance>().Find(dataGridViewDistance.CurrentRow.Cells["Id"].Value);

                    if (distance != null)
                    {
                        context.Set<Distance>().Remove(distance);
                        context.SaveChanges();
                    }
                }
                RefreshDistForm();
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (CheckDataGrid.CheckDataGridForEmty(dataGridViewDistance))
            {
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить ВСЕ записи?", "Удаление записей",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (var context = new MyDbContext())
                {
                    context.Distances.RemoveRange(context.Distances);
                    context.SaveChanges();
                }
                RefreshDistForm();
            }
        }

        private void dataGridViewDistance_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewDistance.Rows)
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
            this.dataGridViewDistance.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
