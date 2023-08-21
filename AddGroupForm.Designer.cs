namespace WindowsFormsApp1
{
    partial class AddGroupForm
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
            this.checkBoxTeam = new System.Windows.Forms.CheckBox();
            this.labelItemTo = new System.Windows.Forms.Label();
            this.labelItemFrom = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxNameFull = new System.Windows.Forms.TextBox();
            this.textBoxNameShort = new System.Windows.Forms.TextBox();
            this.radioButtonFemail = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelTextTo = new System.Windows.Forms.Label();
            this.labelTextFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(639, 280);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxTeam);
            this.panel3.Controls.Add(this.labelItemTo);
            this.panel3.Controls.Add(this.labelItemFrom);
            this.panel3.Controls.Add(this.textBoxTo);
            this.panel3.Controls.Add(this.textBoxFrom);
            this.panel3.Controls.Add(this.textBoxNameFull);
            this.panel3.Controls.Add(this.textBoxNameShort);
            this.panel3.Controls.Add(this.radioButtonFemail);
            this.panel3.Controls.Add(this.radioButtonMale);
            this.panel3.Controls.Add(this.labelTextTo);
            this.panel3.Controls.Add(this.labelTextFrom);
            this.panel3.Controls.Add(this.labelTo);
            this.panel3.Controls.Add(this.labelFrom);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 240);
            this.panel3.TabIndex = 1;
            // 
            // checkBoxTeam
            // 
            this.checkBoxTeam.AutoSize = true;
            this.checkBoxTeam.Location = new System.Drawing.Point(224, 180);
            this.checkBoxTeam.Name = "checkBoxTeam";
            this.checkBoxTeam.Size = new System.Drawing.Size(88, 17);
            this.checkBoxTeam.TabIndex = 14;
            this.checkBoxTeam.Text = "Для команд";
            this.checkBoxTeam.UseVisualStyleBackColor = true;
            // 
            // labelItemTo
            // 
            this.labelItemTo.AutoSize = true;
            this.labelItemTo.Location = new System.Drawing.Point(54, 134);
            this.labelItemTo.Name = "labelItemTo";
            this.labelItemTo.Size = new System.Drawing.Size(19, 13);
            this.labelItemTo.TabIndex = 13;
            this.labelItemTo.Text = "00";
            // 
            // labelItemFrom
            // 
            this.labelItemFrom.AutoSize = true;
            this.labelItemFrom.Location = new System.Drawing.Point(199, 134);
            this.labelItemFrom.Name = "labelItemFrom";
            this.labelItemFrom.Size = new System.Drawing.Size(19, 13);
            this.labelItemFrom.TabIndex = 12;
            this.labelItemFrom.Text = "00";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(162, 81);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 11;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBoxTo_TextChanged);
            this.textBoxTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTo_KeyDown);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(15, 81);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 10;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBoxFrom_TextChanged);
            this.textBoxFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFrom_KeyDown);
            // 
            // textBoxNameFull
            // 
            this.textBoxNameFull.Location = new System.Drawing.Point(224, 25);
            this.textBoxNameFull.Name = "textBoxNameFull";
            this.textBoxNameFull.Size = new System.Drawing.Size(390, 20);
            this.textBoxNameFull.TabIndex = 9;
            this.textBoxNameFull.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNameFull_KeyDown);
            // 
            // textBoxNameShort
            // 
            this.textBoxNameShort.Location = new System.Drawing.Point(12, 25);
            this.textBoxNameShort.Name = "textBoxNameShort";
            this.textBoxNameShort.Size = new System.Drawing.Size(182, 20);
            this.textBoxNameShort.TabIndex = 8;
            this.textBoxNameShort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNameShort_KeyDown);
            // 
            // radioButtonFemail
            // 
            this.radioButtonFemail.AutoSize = true;
            this.radioButtonFemail.Location = new System.Drawing.Point(117, 179);
            this.radioButtonFemail.Name = "radioButtonFemail";
            this.radioButtonFemail.Size = new System.Drawing.Size(77, 17);
            this.radioButtonFemail.TabIndex = 7;
            this.radioButtonFemail.TabStop = true;
            this.radioButtonFemail.Text = "Женщины";
            this.radioButtonFemail.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(30, 179);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(72, 17);
            this.radioButtonMale.TabIndex = 6;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужчины";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelTextTo
            // 
            this.labelTextTo.AutoSize = true;
            this.labelTextTo.Location = new System.Drawing.Point(27, 117);
            this.labelTextTo.Name = "labelTextTo";
            this.labelTextTo.Size = new System.Drawing.Size(35, 13);
            this.labelTextTo.TabIndex = 5;
            this.labelTextTo.Text = "label6";
            // 
            // labelTextFrom
            // 
            this.labelTextFrom.AutoSize = true;
            this.labelTextFrom.Location = new System.Drawing.Point(176, 117);
            this.labelTextFrom.Name = "labelTextFrom";
            this.labelTextFrom.Size = new System.Drawing.Size(35, 13);
            this.labelTextFrom.TabIndex = 4;
            this.labelTextFrom.Text = "label5";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(159, 65);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(35, 13);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "label4";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 65);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(35, 13);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Полное название групы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Короткое название группы";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 40);
            this.panel2.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(517, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 30);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(401, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(110, 30);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 280);
            this.Controls.Add(this.panel1);
            this.Name = "AddGroupForm";
            this.Text = "Добавить группу";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelItemTo;
        private System.Windows.Forms.Label labelItemFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxNameFull;
        private System.Windows.Forms.TextBox textBoxNameShort;
        private System.Windows.Forms.RadioButton radioButtonFemail;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelTextTo;
        private System.Windows.Forms.Label labelTextFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.CheckBox checkBoxTeam;
    }
}