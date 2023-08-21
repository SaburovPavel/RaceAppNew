using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TwoButtonForm : Form
    {
        public bool left = false;
        public bool right = false;
        public TwoButtonForm(string textLeft, string textRight)
        {
            InitializeComponent();

            buttonLeft.Text = textLeft;
            buttonRight.Text = textRight;
        }

        private void TwoButtonForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            left = true;
            DialogResult = DialogResult.OK;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            right = true;
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
