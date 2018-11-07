/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using ParkingWFP.Model;

namespace ParkingWFP.Control

{
    public class PrinterControl
    {
        public Printer printer = new Printer();

        /* CUT PAPER ---------------------------------------------------------------------------- */

        public int CutPaperPartially()
        {
            return MP32.AcionaGuilhotina(0);
        }

        public int CutPaper()
        {
            return MP32.AcionaGuilhotina(1);
        }


        /* PRINTER ------------------------------------------------------------------------------ */

        public void PrintBreakLine()
        {
            MP32.ComandoTX("\xA\xD", 2);
        }

        public void PrintCentralizedText(int Bold, int Expanded, int Font, int Italic,
                                         int Underline, string Text)
        {
            MP32.ComandoTX("\x1B\x61\x1", 3);
            MP32.FormataTX(Text, Font, Italic, Underline, Expanded, Bold);
            MP32.ComandoTX("\x1B\x61\x0", 3);
        }

        public void PrintMultilineText(int Bold, bool Centralized, int Expanded, int Font,
                                       int Italic, int Underline, string Text)
        {
            string[] text = Text.Split('\n');
            if (Centralized)
            {
                foreach (string line in text)
                {
                    PrintCentralizedText(Bold, Expanded, Font, Italic, Underline, line);
                    PrintBreakLine();
                }
                return;
            }
            foreach (string line in text)
            {
                PrintText(Bold, Expanded, Font, Italic, Underline, line);
                PrintBreakLine();
            }
        }

        public int PrintText(int Bold, int Expanded, int Font, int Italic, int Underline,
                             string Text)
        {
            return MP32.FormataTX(Text, Font, Italic, Underline, Expanded, Bold);
        }

        /* COMMAND ------------------------------------------------------------------------------ */


        public void SendCommand(string command, int length)
        {
            MP32.ComandoTX(command, length);
        }

        /* SETUP -------------------------------------------------------------------------------- */

        public int ClosePrinterConnection()
        {
            return MP32.FechaPorta();
        }

        public int GetPrinterStatus()
        {
            return MP32.Le_Status();
        }

        public int SetupPrinterModel()
        {
            printer.LoadPrinter();
            return MP32.ConfiguraModeloImpressora(printer.Model);
        }

        public int SetupPrinterConnection()
        {
            printer.LoadPrinter();
            return MP32.IniciaPorta(printer.Port);
        }

        /* PRINT -------------------------------------------------------------------------------- */

        public void PrintStartParkingBody(string Category, string Color, string IdParking,
            string Model, string Plate, string StartedAt)
        {
            PrintCentralizedText(1, 1, 2, 0, 0, "N: " + IdParking);
            PrintBreakLine();
            PrintBreakLine();

            PrintCentralizedText(1, 1, 2, 0, 0, Plate + "  " + Category);
            PrintBreakLine();
            PrintBreakLine();

            PrintCentralizedText(1, 1, 2, 0, 0, Model + "  " + Color);
            PrintBreakLine();
            PrintBreakLine();

            string startDate = StartedAt;
            PrintCentralizedText(1, 1, 2, 0, 0, startDate);
        }

        public void PrintStartParkingKey(string Category, string Color,
            string Model, string Plate, string StartedAt)
        {
            PrintBreakLine();
            PrintBreakLine();

            PrintText(1, 1, 2, 0, 0, Plate);
            PrintBreakLine();
            PrintText(1, 1, 2, 0, 0, Model);
            PrintBreakLine();
            PrintText(1, 1, 2, 0, 0, Color);
            PrintBreakLine();

            PrintText(1, 0, 1, 0, 0, StartedAt);
            PrintBreakLine();
        }

        public void PrintStartParking(Parking parking, string Category, string Color, string Model)
        {
            printer = printer.LoadPrinter();
            SetupPrinterModel();
            SetupPrinterConnection();
            string IdParking = parking.IdParking.ToString();
            string StartedAt = parking.StartedAt.ToString();
            string Plate = parking.Plate;

            PrintMultilineText(0, true, 0, 1, 0, 0, printer.Header);
            PrintBreakLine();

            PrintStartParkingBody(Category, Color, IdParking, Model, Plate, StartedAt);
            PrintBreakLine();
            PrintBreakLine();

            PrintMultilineText(0, true, 0, 1, 0, 0, printer.Footer);

            CutPaperPartially();

            PrintStartParkingKey(Category, Color, Model, Plate, StartedAt);

            CutPaper();
        }

        /* TEST --------------------------------------------------------------------------------- */

        /* Check Printer Status
         * 0 Erro de comunicação
         * 5 Impressora com pouco papel
         * 9 Tampa aberta
         * 24 Impressora "ONLINE"
         * 32 Impressora sem papel
         */
        public string TestPrinterConnection()
        {
            printer = printer.LoadPrinter();
            SetupPrinterModel();
            SetupPrinterConnection();
            int status = GetPrinterStatus();

            switch (status)
            {
                case 0:
                    return "Não foi possível estabelecer a conexão";
                case 5:
                    return "Impressora com pouco papel";
                case 9:
                    return "Impressora com tampa aberta";
                case 24:
                    return "Conexão bem sucedida";
                case 32:
                    return "Impressora sem papel";
                default:
                    return "Não foi possível efetuar o teste";
            }
        }
    }
}
               