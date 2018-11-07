/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows.Forms;

namespace ParkingWFP.Model
{
    /* MODEL -------------------------------------------------------------------------------- */

    [Table("Printer")]
    public class Printer
    {
        [Key]
        public int IdPrinter { get; set; }
        [Required]
        public int Model { get; set; }
        [Required]
        public string Port { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }

        [Required]
        public int Font { get; set; }

        [Required]
        public int Italic { get; set; }

        [Required]
        public int Underline { get; set; }

        [Required]
        public int Expanded { get; set; }

        [Required]
        public int Bold { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }


        /* SELECT ------------------------------------------------------------------------------- */

        public Printer LoadPrinter()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.Printer.FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar as configurações da impressora",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* UPDATE ------------------------------------------------------------------------------- */

        public bool UpdatePrinter(Printer newPrinter)
        {

            try
            {
                using (var db = new ParkingContext())
                {
                    db.Printer.Update(newPrinter);

                    var count = db.SaveChanges();
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível atualizar as configurações da impressora",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }
    }
}
