namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lstLopA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLopA.Items.Add("Trương Xuan Quang");
            lstLopA.Items.Add("Vu Thi Tuyet Minh");

            lstLopB.Items.Add("Le Duy Tinh");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() != "")
            {
                lstLopA.Items.Add(txtTen.Text);
                txtTen.Clear();
                txtTen.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!");
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItem != null)
            {
                lstLopB.Items.Add(lstLopA.SelectedItem);
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên ở lớp A!");
            }
        }

        private void btnChuyenTatCa_Click(object sender, EventArgs e)
        {
            while (lstLopA.Items.Count > 0)
            {
                lstLopB.Items.Add(lstLopA.Items[0]);
                lstLopA.Items.RemoveAt(0);
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItem != null)
            {
                lstLopA.Items.Add(lstLopB.SelectedItem);
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên ở lớp B!");
            }
        }

        private void btnTraTatCa_Click(object sender, EventArgs e)
        {
            while (lstLopB.Items.Count > 0)
            {
                lstLopA.Items.Add(lstLopB.Items[0]);
                lstLopB.Items.RemoveAt(0);
            }
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItem != null)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
            }
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItem != null)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "Bạn có muốn kết thúc chương trình?",
    "Xác nhận",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyen.PerformClick();
        }

        private void chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTra.PerformClick();
        }

        private void chuyểnHếtDsSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyenTatCa.PerformClick();
        }

        private void chuyểnHếtDsSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTraTatCa.PerformClick();
        }

        private void xóaDanhSáchLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaLopA.PerformClick();
        }

        private void xóaDanhSáchLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaLopB.PerformClick();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "Chương trình quản lý sinh viên lớp A và lớp B",
       "Thông Tin");
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKetThuc.PerformClick();
        }
    }
}
