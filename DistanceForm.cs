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
    public partial class DistanceForm : Form
    {
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
            }
        }

        private void DistanceForm_Load(object sender, EventArgs e)
        {
            RefreshDistForm();
        }
    }
}
