/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows.Forms;

namespace ParkingWFP.Model
{
    [Table("VehicleModel")]
    public class VehicleModel
    {
        /* MODEL -------------------------------------------------------------------------------- */

        [Key]
        public int IdVehicleModel { get; set; }
        [Required]
        public string Model { get; set; }

        [Required]
        public int CategorySuggestion { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }


        /* LIST --------------------------------------------------------------------------------- */

        public List<VehicleModel> FilterVehicleModelsContains(string model)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleModel.Where(
                        dbVehicleModel => dbVehicleModel.Model.Contains(model)).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível filtar o modelo",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public List<VehicleModel> LoadVehicleModelsToList()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleModel.OrderBy(
                        dbVehicleModel => dbVehicleModel.Model).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar os modelos",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        
        /* SELECT ------------------------------------------------------------------------------- */

        public VehicleModel LoadVehicleModelById(int id)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleModel.Where(dbVehicleModel =>
                        dbVehicleModel.IdVehicleModel == id
                    ).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar o modelo usando o código",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public bool ExistsVehicleModel(string model)
        {
            try
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
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                       "Não foi possível verificar a existência do modelo",
                       "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                   );
                throw;
            }
        }


        /* REMOVE ------------------------------------------------------------------------------- */

        public bool RemoveVehicleModel(VehicleModel vehicleModel)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleModel.Remove(vehicleModel);

                    var count = db.SaveChanges();
                    if (count == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível remover o modelo",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
            
        }

        /* INSERT ------------------------------------------------------------------------------- */

        public bool InsertVehicleModel(VehicleModel vehicleModel)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleModel.Add(vehicleModel);
                    var count = db.SaveChanges();
                    if (count == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível inserir o modelo",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* UPDATE ------------------------------------------------------------------------------- */

        public bool UpdateVehicleModel(VehicleModel vehicleModel)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleModel.Update(vehicleModel);
                    var count = db.SaveChanges();
                    if (count == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível atualizar o modelo",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }
    }
}
