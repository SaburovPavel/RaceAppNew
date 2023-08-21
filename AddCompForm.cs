using RaceApp;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddCompForm : Form
    {
        private int timePenalty = 0;

        CompForm compForm;
        public AddCompForm(CompForm owen)
        {
            this.compForm = owen;
            InitializeComponent();
            textBoxName.Select();

            if (compForm.toEdit)
            {
                using (var context = new MyDbContext())
                {
                    var comp = context.Set<Comp>().Find(compForm.dataGridViewComp.CurrentRow.Cells["Id"].Value);                    

                    dateTimePickerComp.Value = comp.Date;
                    textBoxName.Text = comp.Name;
                    textBoxChiefOrbitr.Text = comp.Orbitr;
                    textBoxChiefSecretar.Text = comp.Secretar;
                    textBoxOrganizator.Text = comp.Organizer;
                    textBoxPlace.Text = comp.Place;
                    textBoxTimePenalty.Text = comp.TimePenalty.ToString();
                    textBoxTimeReadTags.Text = comp.TimeIntervalReadTag.ToString();

                    if (comp.Biathlon)
                    {
                        checkBoxBiathon.Checked = true;
                    }

                    if (comp.Individual)
                    {
                        checkBoxIndividualRace.Checked = true;
                    }
                }
                
            }
            else
            {
                dateTimePickerComp.Value = DateTime.Now;
            }      
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            AddButton();
        }
        private void AddButton()
        {
            try
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("Название не может быть пустым");
                    return;
                }
                var name = textBoxName.Text;
                var place = "";
                var organizator = "";
                var orbitr = "";
                var secretar = "";
                int timeReadTag = 1;
                
                if (textBoxTimeReadTags.Text != "")
                {
                    if (int.TryParse(textBoxTimeReadTags.Text, out int result))
                    {
                        if (result > 0)
                        {
                            timeReadTag = result;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите целое положительное число");
                        return;
                    }
                }
                
                if (textBoxPlace.Text != "")
                {
                    place = textBoxPlace.Text;
                }

                if (textBoxOrganizator.Text != "")
                {
                    organizator = textBoxOrganizator.Text;
                }

                if (textBoxChiefOrbitr.Text != "")
                {
                    orbitr = textBoxChiefOrbitr.Text;
                }

                if (textBoxChiefSecretar.Text != "")
                {
                    secretar = textBoxChiefSecretar.Text;
                }

                if (checkBoxBiathon.Checked)
                {
                    if (textBoxTimePenalty.Text == "")
                    {
                        timePenalty = 0;
                    }
                    else
                    {
                        if (int.TryParse(textBoxTimePenalty.Text, out int resultpenalty))
                        {
                            if (resultpenalty < 0)
                            {
                                timePenalty = 0;
                            }
                            else
                            {
                                timePenalty = resultpenalty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите целое положительное число");
                            return;
                        }
                    }
                                      
                }

                if (!compForm.toEdit)
                {
                    using (var context = new MyDbContext())
                    {
                        var comp = new Comp()
                        {
                            Name = name,
                            Place = place,
                            Organizer = organizator,
                            Orbitr = orbitr,
                            Secretar = secretar,
                            Date = dateTimePickerComp.Value.Date,
                            Individual = checkBoxIndividualRace.Checked,
                            Biathlon = checkBoxBiathon.Checked,
                            TimePenalty = timePenalty,
                            TimeIntervalReadTag = timeReadTag
                        };

                        context.Comps.Add(comp);
                        context.SaveChanges();
                    }
                }
                else
                {
                    using (var context = new MyDbContext())
                    {
                        var comp = context.Set<Comp>().Find(compForm.dataGridViewComp.CurrentRow.Cells["Id"].Value);
                        
                        comp.Name = name;
                        comp.Place = place;
                        comp.Organizer = organizator;
                        comp.Orbitr = orbitr;
                        comp.Secretar = secretar;
                        comp.Date = dateTimePickerComp.Value.Date;
                        comp.Individual = checkBoxIndividualRace.Checked;
                        comp.Biathlon = checkBoxBiathon.Checked;
                        comp.TimePenalty = timePenalty;
                        comp.TimeIntervalReadTag = timeReadTag; 
                        
                        context.SaveChanges();
                    }
                }                

                DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите цифры, а не символы!");
                return;
            }
            
        }

        private void checkBoxBiathon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBiathon.Checked == true)
            {
                textBoxTimePenalty.Enabled = true;
            }
            else
            {
                textBoxTimePenalty.Enabled = false;
            }
        }

        private void AddCompForm_Load(object sender, EventArgs e)
        {
            textBoxTimeReadTags.Text = "30";
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AddButton();
                } 
            }
        }

        private void textBoxOrganizator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton();
            }
        }

        private void textBoxPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton();
            }
        }

        private void textBoxChiefOrbitr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton();
            }
        }

        private void textBoxChiefSecretar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton();
            }
        }

        private void textBoxTimePenalty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton();
            }
        }

        private void textBoxTimeReadTags_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddButton();
            }
        }
    }
}
