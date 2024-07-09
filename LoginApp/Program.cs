using System;
using System.Windows.Forms;

namespace MultiApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginApp.Form1()); 
            // Change this line to switch between forms
            // Application.Run(new AddressBookApp.Form2());
            // Application.Run(new DrawingApp.Form3());
        }
    }
}
