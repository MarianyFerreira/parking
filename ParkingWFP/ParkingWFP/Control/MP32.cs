/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System.Runtime.InteropServices;

namespace ParkingWFP
{
    public class MP32
    {
        /* Send a commant to Printer */
        [DllImport("mp2032")]
        public static extern int ComandoTX(
            string comando,
            int tComando
        );

        /* Open communication port */
        [DllImport("mp2032")]
        public static extern int IniciaPorta(
            string porta
        );

        /* Close communication port */
        [DllImport("mp2032")]
        public static extern int FechaPorta();

        /* Set Printer Model */
        [DllImport("mp2032")]
        public static extern int ConfiguraModeloImpressora(
            int iModelo
        );

        /* Operates the printer's guillotine for paper cutting */
        [DllImport("mp2032")]
        public static extern int AcionaGuilhotina(
            int guilhotina
        );

        /* Print Formated Text */
        [DllImport("mp2032")]
        public static extern int FormataTX(
            string texto,
            int tipoLetra,
            int italico,
            int sublinhado,
            int expandido,
            int enfatizado
        );

        /* Check Printer Status
         * 24 Printer "ONLINE"
         * 32 Printer without Paper
         * 68 Communication Error/ Printer"OFFLINE"
         * */
        [DllImport("mp2032")]
        public static extern int Le_Status();
    }
}
