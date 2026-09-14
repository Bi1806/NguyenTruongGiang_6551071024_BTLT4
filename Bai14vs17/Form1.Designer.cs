namespace Bai14
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
            lblTenSV = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnChuyen = new Button();
            btnChuyenTatCa = new Button();
            btnTra = new Button();
            btnTraTatCa = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpAToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtLớpBToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            chuyểnHếtDsSangLớpAToolStripMenuItem = new ToolStripMenuItem();
            chuyểnHếtDsSangLớpBToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            xóaDanhSáchLớpAToolStripMenuItem = new ToolStripMenuItem();
            xóaDanhSáchLớpBToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            kếtThúcToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Location = new Point(124, 53);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(56, 20);
            lblTenSV.TabIndex = 0;
            lblTenSV.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(198, 53);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(200, 27);
            txtTen.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(521, 49);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(124, 110);
            lstLopA.Name = "lstLopA";
            lstLopA.Size = new Size(186, 224);
            lstLopA.TabIndex = 3;
            lstLopA.SelectedIndexChanged += lstLopA_SelectedIndexChanged;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(486, 110);
            lstLopB.Name = "lstLopB";
            lstLopB.Size = new Size(191, 224);
            lstLopB.TabIndex = 4;
            // 
            // btnChuyen
            // 
            btnChuyen.Location = new Point(353, 125);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(94, 29);
            btnChuyen.TabIndex = 5;
            btnChuyen.Text = ">";
            btnChuyen.UseVisualStyleBackColor = true;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // btnChuyenTatCa
            // 
            btnChuyenTatCa.Location = new Point(353, 178);
            btnChuyenTatCa.Name = "btnChuyenTatCa";
            btnChuyenTatCa.Size = new Size(94, 29);
            btnChuyenTatCa.TabIndex = 6;
            btnChuyenTatCa.Text = ">>";
            btnChuyenTatCa.UseVisualStyleBackColor = true;
            btnChuyenTatCa.Click += btnChuyenTatCa_Click;
            // 
            // btnTra
            // 
            btnTra.Location = new Point(353, 238);
            btnTra.Name = "btnTra";
            btnTra.Size = new Size(94, 29);
            btnTra.TabIndex = 7;
            btnTra.Text = "<";
            btnTra.UseVisualStyleBackColor = true;
            btnTra.Click += btnTra_Click;
            // 
            // btnTraTatCa
            // 
            btnTraTatCa.Location = new Point(353, 292);
            btnTraTatCa.Name = "btnTraTatCa";
            btnTraTatCa.Size = new Size(94, 29);
            btnTraTatCa.TabIndex = 8;
            btnTraTatCa.Text = ">>";
            btnTraTatCa.UseVisualStyleBackColor = true;
            btnTraTatCa.Click += btnTraTatCa_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Location = new Point(107, 361);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(94, 29);
            btnXoaLopA.TabIndex = 9;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(339, 361);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(94, 29);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Location = new Point(559, 361);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(94, 29);
            btnXoaLopB.TabIndex = 11;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(771, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtLớpAToolStripMenuItem, cậpNhậtLớpBToolStripMenuItem, chuyểnPhầnTửChọnSangLớpAToolStripMenuItem, chuyểnPhầnTửChọnSangLớpBToolStripMenuItem, toolStripSeparator1, chuyểnHếtDsSangLớpAToolStripMenuItem, chuyểnHếtDsSangLớpBToolStripMenuItem, toolStripSeparator2, xóaDanhSáchLớpAToolStripMenuItem, xóaDanhSáchLớpBToolStripMenuItem });
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(85, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            cậpNhậtToolStripMenuItem.Click += cậpNhậtToolStripMenuItem_Click;
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            cậpNhậtLớpAToolStripMenuItem.Size = new Size(314, 44);
            cậpNhậtLớpAToolStripMenuItem.Text = "Cập Nhật Lớp A";
            // 
            // cậpNhậtLớpBToolStripMenuItem
            // 
            cậpNhậtLớpBToolStripMenuItem.Name = "cậpNhậtLớpBToolStripMenuItem";
            cậpNhậtLớpBToolStripMenuItem.Size = new Size(314, 44);
            cậpNhậtLớpBToolStripMenuItem.Text = "Cập Nhật Lớp B";
            // 
            // chuyểnPhầnTửChọnSangLớpAToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpAToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Size = new Size(314, 44);
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp A";
            chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnPhầnTửChọnSangLớpBToolStripMenuItem
            // 
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpBToolStripMenuItem";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Size = new Size(314, 44);
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Text = "Chuyển Phần Tử Chọn Sang Lớp B";
            chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Click += chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(311, 6);
            // 
            // chuyểnHếtDsSangLớpAToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpAToolStripMenuItem.Name = "chuyểnHếtDsSangLớpAToolStripMenuItem";
            chuyểnHếtDsSangLớpAToolStripMenuItem.Size = new Size(314, 44);
            chuyểnHếtDsSangLớpAToolStripMenuItem.Text = "Chuyển hết ds sang lớp A\n";
            chuyểnHếtDsSangLớpAToolStripMenuItem.Click += chuyểnHếtDsSangLớpAToolStripMenuItem_Click;
            // 
            // chuyểnHếtDsSangLớpBToolStripMenuItem
            // 
            chuyểnHếtDsSangLớpBToolStripMenuItem.Name = "chuyểnHếtDsSangLớpBToolStripMenuItem";
            chuyểnHếtDsSangLớpBToolStripMenuItem.Size = new Size(314, 44);
            chuyểnHếtDsSangLớpBToolStripMenuItem.Text = "Chuyển hết ds sang lớp B";
            chuyểnHếtDsSangLớpBToolStripMenuItem.Click += chuyểnHếtDsSangLớpBToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(311, 6);
            // 
            // xóaDanhSáchLớpAToolStripMenuItem
            // 
            xóaDanhSáchLớpAToolStripMenuItem.Name = "xóaDanhSáchLớpAToolStripMenuItem";
            xóaDanhSáchLớpAToolStripMenuItem.Size = new Size(314, 44);
            xóaDanhSáchLớpAToolStripMenuItem.Text = "Xóa Danh Sách Lớp A\n";
            xóaDanhSáchLớpAToolStripMenuItem.Click += xóaDanhSáchLớpAToolStripMenuItem_Click;
            // 
            // xóaDanhSáchLớpBToolStripMenuItem
            // 
            xóaDanhSáchLớpBToolStripMenuItem.Name = "xóaDanhSáchLớpBToolStripMenuItem";
            xóaDanhSáchLớpBToolStripMenuItem.Size = new Size(314, 44);
            xóaDanhSáchLớpBToolStripMenuItem.Text = "Xóa Danh Sách Lớp B";
            xóaDanhSáchLớpBToolStripMenuItem.Click += xóaDanhSáchLớpBToolStripMenuItem_Click;
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, kếtThúcToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(224, 26);
            thôngTinToolStripMenuItem.Text = "Thông Tin";
            thôngTinToolStripMenuItem.Click += thôngTinToolStripMenuItem_Click;
            // 
            // kếtThúcToolStripMenuItem
            // 
            kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            kếtThúcToolStripMenuItem.Size = new Size(224, 26);
            kếtThúcToolStripMenuItem.Text = "Kết Thúc";
            kếtThúcToolStripMenuItem.Click += kếtThúcToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(771, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "Sẵn sàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 450);
            Controls.Add(statusStrip1);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnTraTatCa);
            Controls.Add(btnTra);
            Controls.Add(btnChuyenTatCa);
            Controls.Add(btnChuyen);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lblTenSV);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenSV;
        private TextBox txtTen;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btnChuyen;
        private Button btnChuyenTatCa;
        private Button btnTra;
        private Button btnTraTatCa;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtLớpBToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnPhầnTửChọnSangLớpBToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem chuyểnHếtDsSangLớpAToolStripMenuItem;
        private ToolStripMenuItem chuyểnHếtDsSangLớpBToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem xóaDanhSáchLớpAToolStripMenuItem;
        private ToolStripMenuItem xóaDanhSáchLớpBToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem kếtThúcToolStripMenuItem;
    }
}
