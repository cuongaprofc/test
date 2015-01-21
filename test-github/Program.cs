using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace test_github
{
    static class Program
    {
        //create new project
        //edit-1
        //edit-3
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
