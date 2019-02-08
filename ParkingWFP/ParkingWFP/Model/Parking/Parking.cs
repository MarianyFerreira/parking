/* *************************************************************************************************
*                       Copyright © 2018 MYF Sotwares. All rights reserved. 
* *********************************************************************************************** */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows.Forms;

namespace ParkingWFP.Model
{
    [Table("Parking")]
    public class Parking
    {
        /* MODEL -------------------------------------------------------------------------------- */

        [Key]
        public int IdParking { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Plate { get; set; }

        [Required]
        public int VehicleModel { get; set; }

        [Required]
        public int VehicleCategory { get; set; }
        [Required]
        public int VehicleColor { get; set; }

        public double Increase { get; set; }

        public double Discount { get; set; }

        public double TotalValue { get; set; }

        [Required]
        public int RegisteredBy { get; set; }

        [Required]
        public DateTime StartedAt { get; set; }

        public DateTime FinalizedAt { get; set; }

        public DateTime CanceledAt { get; set; }

        [Required]
        public string Status { get; set; }

        /* LIST --------------------------------------------------------------------------------- */

        public static string CodeGenerator()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 4)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public List<Parking> LoadParkingsToList()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.Parking.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar os estacionamentos",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public List<Parking> LoadParkingsToListFilteredByRegisteredBy(int IdUser)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.Parking.Where(
                        dbParking => dbParking.RegisteredBy == IdUser
                    ).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar os estacionamentos",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public List<Parking> LoadNotFinishParkingsToList()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.Parking.Where(
                        dbParking => dbParking.Status != "FINALIZADO"
                    ).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar os estacionamentos não finalizados",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }

        }

        public List<Parking> FilterParking(string value)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.Parking.Where(
                        dbParking =>
                            dbParking.Plate.Contains(value.ToUpper())
                            || dbParking.Status.Contains(value.ToUpper())
                            || dbParking.Code.Contains(value.ToUpper()))
                    .OrderByDescending(r => r.StartedAt)
                    .ToList();
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

        /* SELECT ------------------------------------------------------------------------------- */

        public bool ExistsParkingPlate(string plate)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    var parking = db.Parking
                        .Where(dbParking => dbParking.Plate == plate)
                        .FirstOrDefault();

                    if (parking != null)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível verificar a existência do estacionamento usando a placa",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public bool ExistsParkingCode(string code)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    var parking = db.Parking
                        .Where(dbParking => dbParking.Code == code)
                        .FirstOrDefault();

                    if (parking != null)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível verificar a existência do estacionamento usando a placa",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public bool ExistsParkingStarted()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    var parking = db.Parking
                        .Where(dbParking => dbParking.Status.Contains("EM ABERTO"))
                        .FirstOrDefault();

                    if (parking != null)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível verificar a existencia de estacionamentos iniciados",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public Parking LoadParkingByCode(string code)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.Parking.Where(dbParking =>
                        dbParking.Code == code
                    ).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar o estacionamento usando o código",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public Parking LoadParkingByPlate(string plate)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.Parking
                        .Where(dbParking => dbParking.Plate == plate)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar o estacionamento usando a placa",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* INSERT ------------------------------------------------------------------------------- */

        public bool InsertParking(Parking parking)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.Parking.Add(parking);
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
                    "Não foi possível inserir o estacionamento",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* UPDATE ------------------------------------------------------------------------------- */

        public bool UpdateParking(Parking parking)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.Parking.Update(parking);
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
                    "Não foi possível atualizar o estacionamento",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* REMOVE ------------------------------------------------------------------------------- */

        public bool TruncateParking()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.Parking.RemoveRange(db.Parking);
                    var count = db.SaveChanges();
                    if (count > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível remover os estacionamentos",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }
    }
}
