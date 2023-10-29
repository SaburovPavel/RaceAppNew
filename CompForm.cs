using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace RaceApp
{
    public partial class CompForm : Form
    {
        public static object locker = new object();
        public bool toEdit = false;
        public CompForm()
        {
            InitializeComponent();

            this.dataGridViewComp.SetDoubleBuffered(true);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCompForm addCompForm = new AddCompForm(this);
            addCompForm.ShowDialog();
            if (addCompForm.DialogResult == DialogResult.OK)
            {
                RefreshComp();
            }
        }

        private void CompForm_Load(object sender, EventArgs e)
        {
            RefreshComp();            
        }

        private void RefreshComp()
        {
            using (var context = new MyDbContext())
            {
                var comps = from row in context.Comps 
                            select new
                            {
                                row.Id,
                                row.Name,
                                row.Organizer,
                                row.Place,
                                row.Orbitr,
                                row.Secretar,
                                row.Date,
                                row.Individual,
                                row.TimeIntervalStart,
                                row.Biathlon,
                                row.TimePenalty,
                                row.TimeIntervalReadTag
                            };

                dataGridViewComp.DataSource = comps.ToList();
                dataGridViewComp.Columns["Id"].Visible = false;
                dataGridViewComp.Columns["TimeIntervalStart"].Visible = false;

                comps.ToList().Select(item => item.Date == DateTime.Now && item.TimePenalty > 30);
            }
        }

        private void dataGridViewComp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewComp.Rows)
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
            this.dataGridViewComp.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CheckDataGrid.CheckDataGridForEmty(dataGridViewComp))
            {
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записей", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                using (var context = new MyDbContext())
                {
                    var comp = context.Set<Comp>().Find(dataGridViewComp.CurrentRow.Cells["Id"].Value);

                    if (comp != null)
                    {
                        context.Set<Comp>().Remove(comp);
                        context.SaveChanges();
                    }
                }
                RefreshComp();
            }            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditComp();
            int positionRow = dataGridViewComp.CurrentCell.RowIndex;
            int positionColumn = dataGridViewComp.CurrentCell.ColumnIndex;
            RefreshComp();
            dataGridViewComp.CurrentCell = dataGridViewComp[positionColumn, positionRow];
        }
        private void EditComp()
        {
            if (CheckDataGrid.CheckDataGridForEmty(dataGridViewComp))
            {
                return;
            }

            toEdit = true;                            

            AddCompForm compForm = new AddCompForm(this);
            compForm.ShowDialog();

            if (compForm.DialogResult == DialogResult.OK)
            {
                int positionRow = dataGridViewComp.CurrentCell.RowIndex;
                int positionColumn = dataGridViewComp.CurrentCell.ColumnIndex;
                RefreshComp();
                dataGridViewComp.CurrentCell = dataGridViewComp[positionColumn, positionRow];
                toEdit = false;
            }
        }

        private void dataGridViewComp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditComp();
        }

        private void dataGridViewComp_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                buttonDelete_Click(sender, e);
            }
        }
    }
}
