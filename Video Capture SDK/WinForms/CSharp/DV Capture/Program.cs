using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisioForge_SDK_4_DV_Capture_CSharp_Demo
{
    static class Program
    {
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