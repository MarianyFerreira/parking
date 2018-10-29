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
    [Table("VehicleModel")]
    public class VehicleModel
    {
        [Key]
        public int IdVehicleModel { get; set; }
        [Required]
        public string Model { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public List<VehicleModel> LoadVehicleModelsToList()
        {
            using (var db = new ParkingContext())
            {
                return db.VehicleModel.ToList();
            }
        }

        public VehicleModel LoadVehicleModelById(int id)
        {
            using (var db = new ParkingContext())
            {
                return db.VehicleModel.Where(dbVehicleModel =>
                    dbVehicleModel.IdVehicleModel == id
                ).FirstOrDefault();
            }
        }

        public bool ExistsVehicleModel(string model)
        {
            using (var db = new ParkingContext())
            {
                var user = db.VehicleModel
                    .Where(dbVehicleModel => dbVehicleModel.Model == model)
                    .FirstOrDefault();

                if (user != null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RemoveVehicleModel(VehicleModel vehicleModel)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleModel.Remove(vehicleModel);

                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool InsertVehicleModel(VehicleModel vehicleModel)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleModel.Add(vehicleModel);
                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateVehicleModel(VehicleModel vehicleModel)
        {
            using (var db = new ParkingContext())
            {
                db.VehicleModel.Update(vehicleModel);
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
