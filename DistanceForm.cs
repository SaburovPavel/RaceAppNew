using System;
using System.Data;
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
                var distance = context.Distances.Select(item => new { item.Name, item.LenthLap, item.HighLap });
                var results = distance.ToList();

                dataGridViewDistance.DataSource = results;
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
    }
}
