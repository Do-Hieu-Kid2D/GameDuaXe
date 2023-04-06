using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameDuaXe
{   
    
    internal static class Program
    {   
        static public ChaoMung papa;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(papa = new ChaoMung());
            //LibPlayMp3.PlayMp3 nhac = new LibPlayMp3.PlayMp3("C:\\Users\\Dkid_22\\Music\\nhac\\chill.mp3");
            //nhac.lenNhac();



        }
    }
}
