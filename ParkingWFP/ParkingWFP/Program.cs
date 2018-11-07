/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.View;
using System;
using System.Windows.Forms;

namespace ParkingWFP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
