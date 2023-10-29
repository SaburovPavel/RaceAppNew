using System;
using System.Windows.Forms;

namespace RaceApp
{
    public partial class AddGroupForm : Form
    {
        GroupForm groupForm;

        private int from = 0;
        private int to = 0;
        private string gender = "";
        private bool forTteam = false;
        public AddGroupForm(GroupForm owen)
        {
            groupForm = owen;

            InitializeComponent();

            if (!groupForm.toEdit)
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                using(var context = new MyDbContext())
                {
                    var group = context.Set<Group>().Find(groupForm.dataGridViewGroup.CurrentRow.Cells["Id"].Value);
                    textBoxNameShort.Text = group.Name;
                    textBoxNameFull.Text = group.FullName;
                    textBoxFrom.Text = group.AgeAt.ToString();
                    textBoxTo.Text = group.AgeTo.ToString();
                    checkBoxTeam.Checked = group.ForTeam;

                    if (group.Gender == "М")
                    {
                        radioButtonMale.Checked = true;
                    }
                    else
                    {
                        radioButtonFemail.Checked = true;
                    }
                }
            }

            if (groupForm.createByYear)
            {
                labelFrom.Text = "Год рождения ОТ";
                labelTo.Text = "Год рождения ДО";
                labelTextFrom.Text = "Возраст ДО";
                labelTextTo.Text = "Возраст ОТ";
            }
            else
            {
                labelTextTo.Text = "Год рождения ОТ";
                labelTextFrom.Text = "Год рождения ДО";
                labelTo.Text = "Возраст ДО";
                labelFrom.Text = "Возраст ОТ";
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameShort.Text))
            {
                MessageBox.Show("Введите короткое название");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNameFull.Text))
            {
                MessageBox.Show("Введите полное название");
                return;
            }
            
            if (int.TryParse(textBoxFrom.Text, out int result))
            {
                if (groupForm.createByYear)
                {
                    if(result < (DateTime.Now.Year - 100) ||  result > DateTime.Now.Year)
                    {
                        MessageBox.Show($"Введите год рождения в диапазоне {DateTime.Now.Year - 100} - {DateTime.Now.Year}");
                        return;
                    }
                    else
                    {
                        from = result;
                    }
                }
                else
                {
                    if (result < 1 || result > 99)
                    {
                        MessageBox.Show($"Введите год рождения в диапазоне {DateTime.Now.Year - 100} - {DateTime.Now.Year}");
                        return;
                    }
                    else
                    {
                        from = DateTime.Now.Year - result;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            if (int.TryParse(textBoxTo.Text, out int result1))
            {
                if (groupForm.createByYear)
                {
                    if (result < (DateTime.Now.Year - 100) || result > DateTime.Now.Year)
                    {
                        MessageBox.Show($"Введите год рождения в диапазоне {DateTime.Now.Year - 100} - {DateTime.Now.Year}");
                        return;
                    }
                    else
                    {
                        to = result1;
                    }
                }
                else
                {
                    if (result < 1 || result > 99)
                    {
                        MessageBox.Show($"Введите год рождения в диапазоне {DateTime.Now.Year - 100} - {DateTime.Now.Year}");
                        return;
                    }
                    else
                    {
                        to = DateTime.Now.Year - result1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите целое число");
                return;
            }

            if (result > result1)
            {
                var a = result;
                result = result1;
                result1 = a;
            }

            if (radioButtonMale.Checked)
            {
                gender = "М";
            }
            else
            {
                gender = "Ж";
            }

            if (checkBoxTeam.Checked)
            {
                forTteam = true;
            }
            else
            {
                forTteam = false;
            }

            if (!groupForm.toEdit)
            {
                

                using (var context = new MyDbContext())
                {
                    var group = new Group()
                    {
                        Name = textBoxNameShort.Text,
                        FullName = textBoxNameFull.Text,
                        AgeAt = from,
                        AgeTo = to,
                        Gender = gender,
                        ForTeam = forTteam
                    };

                    context.Groups.Add(group);
                    context.SaveChanges();
                }

            }
            else
            {                
                using (var context = new MyDbContext())
                {
                    var group = context.Set<Group>().Find(groupForm.dataGridViewGroup.CurrentRow.Cells["Id"].Value);
                    group.Name = textBoxNameShort.Text;
                    group.FullName = textBoxNameFull.Text;
                    group.AgeAt = from;
                    group.AgeTo = to;
                    group.ForTeam = forTteam;
                    group.Gender = gender;

                    context.SaveChanges();
                }
            }


            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxNameShort_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click((object)sender, e);
            }            
        }

        private void textBoxNameFull_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click((object)sender, e);
            }
        }

        private void textBoxFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click((object)sender, e);
            }
        }

        private void textBoxTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonOk_Click((object)sender, e);
            }
        }       

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFrom.Text, out int result))
            {
                labelItemFrom.Text = (DateTime.Now.Year - result).ToString();
            }
            else
            {
                labelItemFrom.Text = "Error";
            }
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTo.Text, out int result))
            {
                labelItemTo.Text = (DateTime.Now.Year - result).ToString();
            }
            else
            {
                labelItemTo.Text = "Error";
            }
        }
    }
}
