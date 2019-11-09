using FormationWebServicesData.Context;
using FormationWebServicesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesData.Repository
{
     //DataContext db = new DataContext();
    public class FormateurRepository : GenericRepository<Formatteur>, IFormateurRepository
    {
        public FormateurRepository(DataContext context) : base(context)
        { }
        public void  AddFormateur(string nom, string prenom)
        {
            Formatteur formateur = new Formatteur() { first_name = nom, last_name = prenom };
            this.Add(formateur);
        }

        public void GetById(string id)
        {
            var formateur = this.Find(id);
            return formateur;
        }

        public void GetByName(string nom)
        {
            var formateur = DataContext.formateur.where(x=>x.first_name==nom);
            return formateur;
        }

        public void GetFormateurs()
        {
            var formateur = DataContext.formateur.Tolist();
            return formateur;
        }

        public void GetFormateursBySearchModel(FormateurSearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}
