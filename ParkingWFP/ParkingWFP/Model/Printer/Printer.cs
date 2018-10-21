/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
