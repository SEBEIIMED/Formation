using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesData.Repository
{
    #region interface IFormateurRepository ----------------------------------
    public interface IFormateurRepository
    {
        void AddFormateur(string nom, string prenom);
        Formatteur GetById(int id);
        Formatteur GetByName(string nom);
        List<Formatteur> GetFormateurs();
        List<Formatteur> GetFormateursBySearchModel(Expression<Func<Formatteur, bool>> expression);
    }
    #endregion
}
