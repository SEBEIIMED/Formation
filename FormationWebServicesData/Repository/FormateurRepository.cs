using DataLayer.Context;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesData.Repository
{
    #region Class FormateurRepository----------------------------------------
    /// <summary>
    /// FormateurRepository
    /// </summary>
    public class FormateurRepository : GenericRepository<Formatteur>, IFormateurRepository
    {
        public FormateurRepository(DataContext context) : base(context)
        { }
        public void AddFormateur(string nom, string prenom)
        {
            Formatteur formateur = new Formatteur() { first_name = nom, last_name = prenom };
            this.Add(formateur);
        }

        public Formatteur GetById(int id)
        {
            return this.Find(s => s.GetHashCode() == id);
        }

        public Formatteur GetByName(string name)
        {
            return this.Find(s => s.first_name == name);
        }

        public List<Formatteur> GetFormateurs()
        {
            return this.GetAll().ToList();
        }

        public List<Formatteur> GetFormateursBySearchModel(Expression<Func<Formatteur, bool>> expression)
        {
            return this.FindAll(expression).ToList();
        }
    }
    #endregion
}
