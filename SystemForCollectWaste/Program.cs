﻿using System;
using System.Windows.Forms;

namespace SystemForCollectWaste
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(new DataAccessLayer.ApplicationDbContext()));
        }
    }
}
