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
    [Table("VehicleColor")]
    public class VehicleColor
    {
        /* MODEL -------------------------------------------------------------------------------- */

        [Key]
        public int IdVehicleColor { get; set; }
        [Required]
        public string Color { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        /* LIST --------------------------------------------------------------------------------- */

        public List<VehicleColor> FilterVehicleColorsContains(string color)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleColor.Where(
                        dbVehicleColor =>
                            dbVehicleColor.Color.Contains(color)
                    ).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível filtrar as cores",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public List<VehicleColor> LoadColorsToList()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleColor.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar as cores",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        /* SELECT ------------------------------------------------------------------------------- */

        public bool ExistsColor(string colorName)
        {
            try
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
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível verificar a existencia da cor",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public VehicleColor LoadColorById(int id)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleColor.Where(dbColor =>
                        dbColor.IdVehicleColor == id
                    ).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar a cor usando o código",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        /* REMOVE ------------------------------------------------------------------------------- */

        public bool RemoveColor(VehicleColor color)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleColor.Remove(color);

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
                    "Não foi possível remover a cor",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        /* INSERT ------------------------------------------------------------------------------- */

        public bool InsertColor(VehicleColor color)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleColor.Add(color);
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
                    "Não foi possível inserir a cor",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* UPDATE ------------------------------------------------------------------------------- */

        public bool UpdateColor(VehicleColor color)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleColor.Update(color);
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
                    "Não foi possível atualizar a cor",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }
    }
}
