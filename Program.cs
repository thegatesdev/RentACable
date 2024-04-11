using RentACable.Views;
using System;
using System.Windows.Forms;

namespace RentACable
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm(new LendData()));
        }
    }
}
