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
    [Table("VehicleCategory")]
    public class VehicleCategory
    {
        [Key]
        public int IdVehicleCategory { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Value { get; set; }

        [Required]
        public int Tolerance { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public List<VehicleCategory> LoadCategoriesToList()
        {
            using (var db = new ParkingContext())
            {
                return db.VehicleCategory.ToList();
            }
        }

        public VehicleCategory LoadCategoryById(int id)
        {
            using (var db = new ParkingContext())
            {
                return db.VehicleCategory.Where(dbCategory =>
                    dbCategory.IdVehicleCategory == id
                ).FirstOrDefault();
            }
        }

        public bool ExistsCategory(string categoryName)
        {
            using (var db = new ParkingContext())
            {
                var user = db.VehicleCategory
                    .Where(dbCategory => dbCategory.Category == categoryName)
                    .FirstOrDefault();

                if (user != null)
                {
                    return true;
                }
            }
            return false;
        }
        

        public bool RemoveCategory(VehicleCategory category)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleCategory.Remove(category);

                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool InsertCategory(VehicleCategory category)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleCategory.Add(category);
                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateCategory(VehicleCategory category)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleCategory.Update(category);
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
