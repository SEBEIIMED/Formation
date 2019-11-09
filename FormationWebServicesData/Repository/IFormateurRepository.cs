using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesData.Repository
{
    #region interface IFormateurRepository ----------------------------------
    public interface IFormateurRepository
    {
        void AddFormateur(string nom, string prenom);
        void GetById(string id);
        void GetByName(string nom);
        void GetFormateurs();
        void GetFormateursBySearchModel(FormateurSearchModel searchModel);
    }
    #endregion
}
