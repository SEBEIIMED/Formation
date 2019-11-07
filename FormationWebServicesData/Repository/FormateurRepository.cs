using FormationWebServicesData.Context;
using FormationWebServicesData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesData.Repository
{

    public class FormateurRepository : GenericRepository<Formatteur>, IFormateurRepository
    {
        public FormateurRepository(DataContext context) : base(context)
        { }
        public void  AddFormateur(string nom, string prenom)
        {
            Formatteur formateur = new Formatteur() { first_name = nom, last_name = prenom };
            this.Add(formateur);
        }
    }
}
