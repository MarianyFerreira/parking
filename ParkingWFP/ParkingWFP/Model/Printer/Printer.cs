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
    [Table("Printer")]
    public class Printer
    {
        [Key]
        public int IdPrinter { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Host { get; set; }
        [Required]
        public string Port { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        private bool CheckPrinter(Printer newPrinter)
        {
            if (string.IsNullOrWhiteSpace(newPrinter.Model))
            {
                MessageBox.Show($"Modelo é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newPrinter.Host))
            {
                MessageBox.Show($"Host é um campo obrigatório");
                return false;
            }

            if (string.IsNullOrWhiteSpace(newPrinter.Port))
            {
                MessageBox.Show($"Porta é um campo obrigatório");
                return false;
            }

            return true;
        }

        public Printer LoadPrinter()
        {
            using (var db = new ParkingContext())
            {
                return db.Printer.FirstOrDefault();
            }
        }

        public void UpdatePrinter(Printer newPrinter)
        {
            CheckPrinter(newPrinter);

            using (var db = new ParkingContext())
            {
                db.Printer.Update(newPrinter);

                var count = db.SaveChanges();
                if (count == 1)
                {
                    MessageBox.Show($"Cadastro de impressora atualizado");
                }
                else
                {
                    MessageBox.Show($"ERRO: Não foi possível atualizar os dados da Impressora");
                }
            }

            return;
        }
    }
}
