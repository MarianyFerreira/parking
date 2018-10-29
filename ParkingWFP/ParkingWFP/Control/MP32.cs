/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System.Runtime.InteropServices;

namespace Parking
{
    class MP32
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
            string iModelo
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
    }
}
