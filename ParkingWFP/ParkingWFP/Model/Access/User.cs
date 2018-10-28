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


        public List<User> LoadUsersToList()
        {
            using (var db = new ParkingContext())
            {
                return db.User.ToList();
            }
        }

        public User LoadUserById(int id)
        {
            using (var db = new ParkingContext())
            {
                return db.User.Where(dbUser =>
                    dbUser.IdUser == id
                ).FirstOrDefault();
            }
        }

        public User LoadUserByUsername(string username)
        {
            using (var db = new ParkingContext())
            {
                return db.User
                    .Where(dbUser => dbUser.Username == username)
                    .FirstOrDefault();
            }
        }

        public bool ExistsUsername(string username)
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
            }
            return false;
        }

        public bool InsertUser(User user)
        {
            using (var db = new ParkingContext())
            {
                if(user.IdUser == 0)
                {
                    db.User.Add(user);
                }
                else
                {
                    db.User.Update(user);
                }
                var count = db.SaveChanges();
                if (count == 1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool RemoveUser(User user)
        {
            using (var db = new ParkingContext())
            {
                db.User.Remove(user);

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
