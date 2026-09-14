using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblStart.Text = e.Start.ToShortDateString();
            lblEnd.Text = e.End.ToShortDateString();
        }

        private void rdoLongDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLongDate.Checked)
            {
                dtpProductLaunch.Format = DateTimePickerFormat.Long;
            }
        }

        private void rdoShortDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoShortDate.Checked)
            {
                dtpProductLaunch.Format = DateTimePickerFormat.Short;
            }
        }
    }
}
