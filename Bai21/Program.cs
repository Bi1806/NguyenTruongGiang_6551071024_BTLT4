using Bai21;
using System;
using System.Windows.Forms;

namespace Bai21
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            frmFlashForm f = new frmFlashForm();

            if (f.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }
    }
}