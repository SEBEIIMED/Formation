using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer.Entities
{
    public class Formatteur : User
    {
        public string cv { get; set; }
        public string professionalEmail { get; set; }
        public Formatteur() : base("", "", "")
        {
        }
        public Formatteur(string firstName, string lastName, string mail) : base(firstName, lastName, mail)
        {
        }
    }
}