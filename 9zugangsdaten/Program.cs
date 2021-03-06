﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

namespace _9zugangsdaten
{
    static class Program
    {

        public static String RootDir;

        public static String RootDirWin;

        public static String Version;

        public static List<String> Paths;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RootDir = ConfigurationManager.AppSettings["rootDir"];
            RootDirWin = RootDir.Replace("/", "\\");
            Version = Application.ProductVersion.Substring(0, 5);
            Paths = new List<String>(ConfigurationManager.AppSettings["paths"].Split(new char[] { ';' }));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
