namespace Bai15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblColor = new Label();
            lblSize = new Label();
            domainColor = new DomainUpDown();
            numericSize = new NumericUpDown();
            lblSample = new Label();
            btnMoForm2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericSize).BeginInit();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(165, 89);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(48, 20);
            lblColor.TabIndex = 0;
            lblColor.Text = "Color:";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(165, 195);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(39, 20);
            lblSize.TabIndex = 1;
            lblSize.Text = "Size:";
            // 
            // domainColor
            // 
            domainColor.Location = new Point(420, 89);
            domainColor.Name = "domainColor";
            domainColor.Size = new Size(150, 27);
            domainColor.TabIndex = 2;
            domainColor.Text = "domainColor";
            domainColor.SelectedItemChanged += domainColor_SelectedItemChanged;
            // 
            // numericSize
            // 
            numericSize.Location = new Point(420, 201);
            numericSize.Maximum = new decimal(new int[] { 72, 0, 0, 0 });
            numericSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericSize.Name = "numericSize";
            numericSize.Size = new Size(150, 27);
            numericSize.TabIndex = 3;
            numericSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericSize.ValueChanged += numericSize_ValueChanged;
            // 
            // lblSample
            // 
            lblSample.AutoSize = true;
            lblSample.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblSample.Location = new Point(247, 315);
            lblSample.Name = "lblSample";
            lblSample.Size = new Size(294, 62);
            lblSample.TabIndex = 4;
            lblSample.Text = "Sample Text";
            // 
            // btnMoForm2
            // 
            btnMoForm2.Location = new Point(12, 12);
            btnMoForm2.Name = "btnMoForm2";
            btnMoForm2.Size = new Size(94, 29);
            btnMoForm2.TabIndex = 5;
            btnMoForm2.Text = "Mở Form 2";
            btnMoForm2.UseVisualStyleBackColor = true;
            btnMoForm2.Click += btnMoForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMoForm2);
            Controls.Add(lblSample);
            Controls.Add(numericSize);
            Controls.Add(domainColor);
            Controls.Add(lblSize);
            Controls.Add(lblColor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblColor;
        private Label lblSize;
        private DomainUpDown domainColor;
        private NumericUpDown numericSize;
        private Label lblSample;
        private Button btnMoForm2;
    }
}
