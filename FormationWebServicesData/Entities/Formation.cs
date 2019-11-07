using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FormationWebServicesData.Entities
{
    public class Formation 
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        //[ForeignKey("Formatter")]
        //public int formatterId { get; set; }
        //public virtual Formatteur Formatter { get; set; }
    }
}