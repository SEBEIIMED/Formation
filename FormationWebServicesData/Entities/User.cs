using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataLayer.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public User(string firstName, string lastName, string mail)
        {
            this.first_name = firstName;
            this.last_name = lastName;
            this.email = mail;
        }
        public override bool Equals(object obj)
        {
            if (obj is User other)
            {
                if (first_name == other.first_name && last_name == other.last_name && email == other.email)
                    return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.first_name.GetHashCode() ^
                this.last_name.GetHashCode() ^
                this.email.GetHashCode();
        }
    }
}