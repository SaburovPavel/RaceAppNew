using System;
using System.Windows.Forms;

namespace RaceApp
{
    public partial class AddDistance : Form
    {
        DistanceForm distanceForm;

        public string name;
        public int lenth;
        public int high;
        public AddDistance(DistanceForm owen)
        {
            distanceForm = owen;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AddDistance_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AddDistance_Load(object sender, EventArgs e)
        {
            textBoxName.Select();

            if (distanceForm.toEdit)
            {
                textBoxName.Text = distanceForm.dataGridViewDistance.CurrentRow.Cells["Name"].Value.ToString();
                textBoxHigh.Text = distanceForm.dataGridViewDistance.CurrentRow.Cells["LenthLap"].Value.ToString();
                textBoxLenth.Text = distanceForm.dataGridViewDistance.CurrentRow.Cells["HighLap"].Value.ToString();   
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text.Length < 50 || !string.IsNullOrEmpty(name))
            {
                name = textBoxName.Text;
            }

            if(!int.TryParse(textBoxLenth.Text, out lenth))
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            if (!int.TryParse(textBoxHigh.Text, out high))
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonOk_Click(sender, e);
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
