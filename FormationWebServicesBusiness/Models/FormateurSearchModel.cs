using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesBusiness.Models
{
    #region Class FormateurSearchModel--------------------------------------- 
    /// <summary>
    /// Class FormateurSearchModel 
    /// </summary>
    public class FormateurSearchModel
    {
        #region Attributs----------------------------------------------------
        public string name { get; set; }
        public string localisation { get; set; }
        public string prixFormationmax { get; set; }
        //liste des competences
        public List<Competence> competences { get; set; }
        #endregion

    }
    #endregion
}
