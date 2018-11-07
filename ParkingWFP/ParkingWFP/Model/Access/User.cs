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
    [Table("User")]
    public class User
    {
        /* MODEL -------------------------------------------------------------------------------- */

        [Key]
        public int IdUser { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        public bool Enabled { get; set; }
        [Required]
        public string AccessType { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }


        /* LIST --------------------------------------------------------------------------------- */

        public List<User> LoadAdminUsersToList()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.User.Where(
                        dbUser => dbUser.AccessType.Contains("Admin")
                    ).ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar os usuários Admin",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public List<User> LoadUsersToList()
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.User.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar os usuários",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* SELECT ------------------------------------------------------------------------------- */

        public bool ExistsUsername(string username)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    var user = db.User
                        .Where(dbUser => dbUser.Username == username)
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
                    "Não foi possível verificar a existencia do usuário",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public User LoadUserById(int id)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.User.Where(dbUser =>
                        dbUser.IdUser == id
                    ).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar o usuário usando o código",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        public User LoadUserByUsername(string username)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    return db.User
                        .Where(dbUser => dbUser.Username == username)
                        .FirstOrDefault();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar o usuário usando o nome de usuário",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* INSERT ------------------------------------------------------------------------------- */

        public bool InsertUser(User user)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.User.Add(user);
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
                    "Não foi possível inserir o usuário",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }


        /* INSERT ------------------------------------------------------------------------------- */

        public bool UpdateUser(User user)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.User.Update(user);
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
                    "Não foi possível atualizar o usuário",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }

        /* REMOVE ------------------------------------------------------------------------------- */

        public bool RemoveUser(User user)
        {
            try
            {
                using (var db = new ParkingContext())
                {
                    db.User.Remove(user);

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
                    "Não foi possível remover o usuário",
                    "Atenção",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error
                );
                throw;
            }
        }
    }
}
