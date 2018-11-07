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
    [Table("VehicleCategory")]
    public class VehicleCategory
    {
        /* MODEL -------------------------------------------------------------------------------- */

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


        /* LIST --------------------------------------------------------------------------------- */

        public List<VehicleCategory> FilterVehicleCategoriesContains(string category)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleCategory.Where(
                        dbVehicleCategory => dbVehicleCategory.Category.Contains(category)).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível filtrar as categorias",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public List<VehicleCategory> LoadCategoriesToList()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleCategory.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar as categorias",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        /* SELECT ------------------------------------------------------------------------------- */

        public bool ExistsCategory(string categoryName)
        {
            try
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
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível verificar a existência da categoria",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public VehicleCategory LoadCategoryById(int id)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.VehicleCategory.Where(dbCategory =>
                        dbCategory.IdVehicleCategory == id
                    ).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar a categoria usando o código",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* REMOVE ------------------------------------------------------------------------------- */

        public bool RemoveCategory(VehicleCategory category)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    VehicleModel modelUsingCategory = db.VehicleModel.Where(
                        dbVehicleModel => dbVehicleModel.CategorySuggestion == category.IdVehicleCategory
                    ).FirstOrDefault();

                    if (modelUsingCategory != null)
                    {
                        return false;
                    }

                    db.VehicleCategory.Remove(category);
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
                    "Não foi possível remover a categoria",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        /* INSERT ------------------------------------------------------------------------------ */

        public bool InsertCategory(VehicleCategory category)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleCategory.Add(category);
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
                    "Não foi possível inserir a categoria",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* UPDATE ------------------------------------------------------------------------------ */

        public bool UpdateCategory(VehicleCategory category)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.VehicleCategory.Update(category);
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
                    "Não foi possível atualizar a categoria",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }
    }
}
