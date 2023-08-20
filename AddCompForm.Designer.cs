namespace WindowsFormsApp1
{
    partial class AddCompForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxTimeReadTags = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTimePenalty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxBiathon = new System.Windows.Forms.CheckBox();
            this.checkBoxIndividualRace = new System.Windows.Forms.CheckBox();
            this.textBoxChiefSecretar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxChiefOrbitr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerComp = new System.Windows.Forms.DateTimePicker();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOrganizator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 387);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxTimeReadTags);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxTimePenalty);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.checkBoxBiathon);
            this.panel3.Controls.Add(this.checkBoxIndividualRace);
            this.panel3.Controls.Add(this.textBoxChiefSecretar);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxChiefOrbitr);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePickerComp);
            this.panel3.Controls.Add(this.textBoxPlace);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxOrganizator);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBoxName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 342);
            this.panel3.TabIndex = 1;
            // 
            // textBoxTimeReadTags
            // 
            this.textBoxTimeReadTags.Location = new System.Drawing.Point(476, 287);
            this.textBoxTimeReadTags.Name = "textBoxTimeReadTags";
            this.textBoxTimeReadTags.Size = new System.Drawing.Size(77, 20);
            this.textBoxTimeReadTags.TabIndex = 33;
            this.textBoxTimeReadTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTimeReadTags_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Интервал чтения меток в секундах";
            // 
            // textBoxTimePenalty
            // 
            this.textBoxTimePenalty.Enabled = false;
            this.textBoxTimePenalty.Location = new System.Drawing.Point(540, 232);
            this.textBoxTimePenalty.Name = "textBoxTimePenalty";
            this.textBoxTimePenalty.Size = new System.Drawing.Size(57, 20);
            this.textBoxTimePenalty.TabIndex = 31;
            this.textBoxTimePenalty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTimePenalty_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Штраф в секундах за 1 промах";
            // 
            // checkBoxBiathon
            // 
            this.checkBoxBiathon.AutoSize = true;
            this.checkBoxBiathon.Location = new System.Drawing.Point(279, 235);
            this.checkBoxBiathon.Name = "checkBoxBiathon";
            this.checkBoxBiathon.Size = new System.Drawing.Size(68, 17);
            this.checkBoxBiathon.TabIndex = 29;
            this.checkBoxBiathon.Text = "Биатлон";
            this.checkBoxBiathon.UseVisualStyleBackColor = true;
            this.checkBoxBiathon.CheckedChanged += new System.EventHandler(this.checkBoxBiathon_CheckedChanged);
            // 
            // checkBoxIndividualRace
            // 
            this.checkBoxIndividualRace.AutoSize = true;
            this.checkBoxIndividualRace.Location = new System.Drawing.Point(279, 183);
            this.checkBoxIndividualRace.Name = "checkBoxIndividualRace";
            this.checkBoxIndividualRace.Size = new System.Drawing.Size(264, 17);
            this.checkBoxIndividualRace.TabIndex = 28;
            this.checkBoxIndividualRace.Text = "Индивидуальная гонка с раздельным стартом";
            this.checkBoxIndividualRace.UseVisualStyleBackColor = true;
            // 
            // textBoxChiefSecretar
            // 
            this.textBoxChiefSecretar.Location = new System.Drawing.Point(12, 287);
            this.textBoxChiefSecretar.Name = "textBoxChiefSecretar";
            this.textBoxChiefSecretar.Size = new System.Drawing.Size(200, 20);
            this.textBoxChiefSecretar.TabIndex = 27;
            this.textBoxChiefSecretar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxChiefSecretar_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Главный секретарь";
            // 
            // textBoxChiefOrbitr
            // 
            this.textBoxChiefOrbitr.Location = new System.Drawing.Point(12, 233);
            this.textBoxChiefOrbitr.Name = "textBoxChiefOrbitr";
            this.textBoxChiefOrbitr.Size = new System.Drawing.Size(200, 20);
            this.textBoxChiefOrbitr.TabIndex = 25;
            this.textBoxChiefOrbitr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxChiefOrbitr_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Главный судья";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Дата проведения";
            // 
            // dateTimePickerComp
            // 
            this.dateTimePickerComp.Location = new System.Drawing.Point(12, 181);
            this.dateTimePickerComp.Name = "dateTimePickerComp";
            this.dateTimePickerComp.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerComp.TabIndex = 22;
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(12, 129);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(383, 20);
            this.textBoxPlace.TabIndex = 21;
            this.textBoxPlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPlace_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Место проведения";
            // 
            // textBoxOrganizator
            // 
            this.textBoxOrganizator.Location = new System.Drawing.Point(12, 80);
            this.textBoxOrganizator.Name = "textBoxOrganizator";
            this.textBoxOrganizator.Size = new System.Drawing.Size(749, 20);
            this.textBoxOrganizator.TabIndex = 19;
            this.textBoxOrganizator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOrganizator_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Организатор";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(749, 20);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 45);
            this.panel2.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(675, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(540, 7);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(120, 30);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // AddCompForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(807, 387);
            this.Controls.Add(this.panel1);
            this.Name = "AddCompForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить соревнование";
            this.Load += new System.EventHandler(this.AddCompForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxTimePenalty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxBiathon;
        private System.Windows.Forms.CheckBox checkBoxIndividualRace;
        private System.Windows.Forms.TextBox textBoxChiefSecretar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxChiefOrbitr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerComp;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOrganizator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxTimeReadTags;
        private System.Windows.Forms.Label label8;
    }
}