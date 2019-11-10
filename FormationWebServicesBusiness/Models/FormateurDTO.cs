using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace BusinessLayer.Models
{
    #region Class FormateurDTO----------------------------------------------- 
    /// <summary>
    /// Class FormateurDTO 
    /// </summary>
    public class FormateurDTO
    {
        #region Attributs----------------------------------------------------
        public string first_name { get; set; }
        public string last_name { get; set; }

        public FormateurDTO(string first_name, string last_name) { }
        public FormateurDTO(Formatteur f)
        {
            // Implémnter la transformation.
            
        }
        #endregion
    }
    #endregion
}
