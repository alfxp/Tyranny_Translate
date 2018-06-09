// Copyright (c) 2010 Alfxp
// License: Code Project Open License

using System;
using System.Windows.Forms;

namespace Tyranny.GoogleTranslator
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
            Application.Run(new TyrannyGoogleTranslatorFrm());
        }
    }
}
