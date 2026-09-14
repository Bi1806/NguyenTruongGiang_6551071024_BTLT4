using System.Drawing;
namespace Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            domainColor.Items.Add("Red");
            domainColor.Items.Add("Green");
            domainColor.Items.Add("Blue");
            domainColor.Items.Add("Black");

            domainColor.SelectedIndex = 1;
        }

        private void numericSize_ValueChanged(object sender, EventArgs e)
        {
            lblSample.Font = new Font(
        lblSample.Font.FontFamily,
        (float)numericSize.Value,
        lblSample.Font.Style
    );
        }

        private void domainColor_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (domainColor.Text)
            {
                case "Red":
                    lblSample.ForeColor = Color.Red;
                    break;

                case "Green":
                    lblSample.ForeColor = Color.Green;
                    break;

                case "Blue":
                    lblSample.ForeColor = Color.Blue;
                    break;

                case "Black":
                    lblSample.ForeColor = Color.Black;
                    break;
            }
        }

        private void btnMoForm2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
