/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ParkingWFP.Model
{
    [Table("VehicleColor")]
    public class VehicleColor
    {
        [Key]
        public int IdVehicleColor { get; set; }
        [Required]
        public string Color { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public List<VehicleColor> LoadColorsToList()
        {
            using (var db = new ParkingContext())
            {
                return db.VehicleColor.ToList();
            }
        }

        public VehicleColor LoadColorById(int id)
        {
            using (var db = new ParkingContext())
            {
                return db.VehicleColor.Where(dbColor =>
                    dbColor.IdVehicleColor == id
                ).FirstOrDefault();
            }
        }

        public bool ExistsColor(string colorName)
        {
            using (var db = new ParkingContext())
            {
                var user = db.VehicleColor
                    .Where(dbColor => dbColor.Color == colorName)
                    .FirstOrDefault();

                if (user != null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RemoveColor(VehicleColor color)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleColor.Remove(color);

                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool InsertColor(VehicleColor color)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleColor.Add(color);
                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateColor(VehicleColor color)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleColor.Update(color);
                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
