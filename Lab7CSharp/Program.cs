﻿using System;
using System.Windows.Forms;

namespace Lab7CSharp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Task2());
            //Application.Run(new Task3());
        }
    }
}
