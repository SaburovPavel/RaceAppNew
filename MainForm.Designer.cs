namespace RaceApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonComp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTiming = new System.Windows.Forms.Button();
            this.buttonTeams = new System.Windows.Forms.Button();
            this.buttonDistance = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonComp
            // 
            this.buttonComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComp.Location = new System.Drawing.Point(16, 26);
            this.buttonComp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComp.Name = "buttonComp";
            this.buttonComp.Size = new System.Drawing.Size(284, 42);
            this.buttonComp.TabIndex = 0;
            this.buttonComp.Text = "Мероприятия";
            this.buttonComp.UseVisualStyleBackColor = true;
            this.buttonComp.Click += new System.EventHandler(this.buttonComp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 554);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSettings);
            this.panel2.Controls.Add(this.buttonTiming);
            this.panel2.Controls.Add(this.buttonTeams);
            this.panel2.Controls.Add(this.buttonDistance);
            this.panel2.Controls.Add(this.buttonGroups);
            this.panel2.Controls.Add(this.buttonComp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 554);
            this.panel2.TabIndex = 1;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(16, 498);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(284, 42);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Настройки ридеров";
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonTiming
            // 
            this.buttonTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTiming.Location = new System.Drawing.Point(16, 306);
            this.buttonTiming.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTiming.Name = "buttonTiming";
            this.buttonTiming.Size = new System.Drawing.Size(284, 42);
            this.buttonTiming.TabIndex = 2;
            this.buttonTiming.Text = "Тайминг";
            this.buttonTiming.UseVisualStyleBackColor = true;
            // 
            // buttonTeams
            // 
            this.buttonTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTeams.Location = new System.Drawing.Point(16, 236);
            this.buttonTeams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTeams.Name = "buttonTeams";
            this.buttonTeams.Size = new System.Drawing.Size(284, 42);
            this.buttonTeams.TabIndex = 2;
            this.buttonTeams.Text = "Команды";
            this.buttonTeams.UseVisualStyleBackColor = true;
            // 
            // buttonDistance
            // 
            this.buttonDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDistance.Location = new System.Drawing.Point(16, 165);
            this.buttonDistance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDistance.Name = "buttonDistance";
            this.buttonDistance.Size = new System.Drawing.Size(284, 42);
            this.buttonDistance.TabIndex = 2;
            this.buttonDistance.Text = "Дистанции";
            this.buttonDistance.UseVisualStyleBackColor = true;
            this.buttonDistance.Click += new System.EventHandler(this.buttonDistance_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroups.Location = new System.Drawing.Point(16, 95);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(284, 42);
            this.buttonGroups.TabIndex = 2;
            this.buttonGroups.Text = "Группы";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "RaceApp";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonComp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDistance;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonTiming;
        private System.Windows.Forms.Button buttonTeams;
    }
}

