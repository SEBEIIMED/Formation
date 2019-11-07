using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormationWebServicesData.Entities
{
    public class User 
    {
        [Key]
        public int Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
    }
}