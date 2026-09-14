namespace Bai15
{
    partial class Form2
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
            lblTitle = new Label();
            monthCalendar1 = new MonthCalendar();
            dtpProductLaunch = new DateTimePicker();
            rdoLongDate = new RadioButton();
            lblStartDate = new Label();
            lblEnd = new Label();
            lblStart = new Label();
            lblEndDate = new Label();
            rdoShortDate = new RadioButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.Location = new Point(62, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Select the days you will travel\n";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(62, 73);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // dtpProductLaunch
            // 
            dtpProductLaunch.Location = new Point(62, 365);
            dtpProductLaunch.Name = "dtpProductLaunch";
            dtpProductLaunch.Size = new Size(250, 27);
            dtpProductLaunch.TabIndex = 2;
            // 
            // rdoLongDate
            // 
            rdoLongDate.AutoSize = true;
            rdoLongDate.Checked = true;
            rdoLongDate.Location = new Point(62, 414);
            rdoLongDate.Name = "rdoLongDate";
            rdoLongDate.Size = new Size(99, 24);
            rdoLongDate.TabIndex = 3;
            rdoLongDate.TabStop = true;
            rdoLongDate.Text = "Long Date";
            rdoLongDate.UseVisualStyleBackColor = true;
            rdoLongDate.CheckedChanged += rdoLongDate_CheckedChanged;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(433, 88);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(83, 20);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = " Start Date:";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(444, 208);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(50, 20);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "label3";
            lblEnd.Click += label3_Click;
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(443, 127);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(50, 20);
            lblStart.TabIndex = 6;
            lblStart.Text = "label4";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(443, 168);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(73, 20);
            lblEndDate.TabIndex = 7;
            lblEndDate.Text = "End Date:";
            lblEndDate.Click += label5_Click;
            // 
            // rdoShortDate
            // 
            rdoShortDate.AutoSize = true;
            rdoShortDate.Location = new Point(195, 414);
            rdoShortDate.Name = "rdoShortDate";
            rdoShortDate.Size = new Size(101, 24);
            rdoShortDate.TabIndex = 8;
            rdoShortDate.Text = "Short Date";
            rdoShortDate.UseVisualStyleBackColor = true;
            rdoShortDate.CheckedChanged += rdoShortDate_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdoShortDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStart);
            Controls.Add(lblEnd);
            Controls.Add(lblStartDate);
            Controls.Add(rdoLongDate);
            Controls.Add(dtpProductLaunch);
            Controls.Add(monthCalendar1);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private MonthCalendar monthCalendar1;
        private DateTimePicker dtpProductLaunch;
        private RadioButton rdoLongDate;
        private Label lblStartDate;
        private Label lblEnd;
        private Label lblStart;
        private Label lblEndDate;
        private RadioButton rdoShortDate;
    }
}