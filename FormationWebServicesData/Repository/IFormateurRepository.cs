using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesData.Repository
{
    public interface IFormateurRepository
    {
        void AddFormateur(string nom, string prenom);
    }
}
