using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormationWebServicesData.Entities
{
    public class Formatteur:User
    {
        public string cv { get; set; }
        public string professionalEmail { get; set; }
      //  public virtual List<Formation> formations { get; set; }

        //[ForeignKey ("User")]
        //public int userId { get; set; }
        //public virtual User User { get; set; }

        //public virtual List<Course> courses { get; set; }
    }
}