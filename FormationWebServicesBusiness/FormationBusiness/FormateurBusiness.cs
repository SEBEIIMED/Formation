using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormationWebServicesBusiness.Models;
using FormationWebServicesData.Repository;

namespace FormationWebServicesBusiness.FormationBusiness
{
    #region Class FormateurBusiness------------------------------------------
    /// <summary>
    /// Class FormateurBusiness
    /// </summary>
    public class FormateurBusiness : IFormateurBusiness
    {
        public FormateurDTO  GetById(string id)
        {
            using (FormationWebServicesData.Context.DataContext context = new FormationWebServicesData.Context.DataContext())
            {
                IFormateurRepository forrmateurRepository = new FormateurRepository(context);
                forrmateurRepository.GetById("3");
            }
            return null;
        }

        public FormateurDTO  GetByName(string name)
        {
            using (FormationWebServicesData.Context.DataContext context = new FormationWebServicesData.Context.DataContext())
            {
                IFormateurRepository forrmateurRepository = new FormateurRepository(context);
                forrmateurRepository.GetByName("test1");
            }
            return null;
        }

        public List<FormateurDTO>  GetFormateurs()
        {
            using (FormationWebServicesData.Context.DataContext context = new FormationWebServicesData.Context.DataContext())
            {
                IFormateurRepository forrmateurRepository = new FormateurRepository(context);
                forrmateurRepository.GetFormateurs();
            }
            return null;
        }

        public List<FormateurDTO>  GetFormateursBySearchModel(FormateurSearchModel searchModel)
        {
            using (FormationWebServicesData.Context.DataContext context = new FormationWebServicesData.Context.DataContext())
            {
                IFormateurRepository forrmateurRepository = new FormateurRepository(context);
                forrmateurRepository.GetFormateursBySearchModel();
            }
            return null;
        }
    }
    #endregion
}
