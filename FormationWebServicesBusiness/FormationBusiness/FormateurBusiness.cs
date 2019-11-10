using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;
using DataLayer.Entities;
using FormationWebServicesData.Repository;

namespace BusinessLayer.FormationBusiness
{
    #region Class FormateurBusiness------------------------------------------
    /// <summary>
    /// Class FormateurBusiness
    /// </summary>
    public class FormateurBusiness : IFormateurBusiness
    {
        #region Attributs----------------------------------------------------
        /// <summary>
        /// Attribute FormateurRepository.
        /// </summary>
        private IFormateurRepository FormateurRepository = null;
        #endregion
        #region Constructor--------------------------------------------------
        public FormateurBusiness(IFormateurRepository formateurRepository)
        {
            this.FormateurRepository = formateurRepository;
        }
        #endregion
        public FormateurDTO GetById(int id)
        {
            Formatteur formateur = this.FormateurRepository.GetById(id);

            return new FormateurDTO(formateur);
        }

        public FormateurDTO GetByName(string name)
        {
            Formatteur formateur = this.FormateurRepository.GetByName(name);

            return new FormateurDTO(formateur);
        }

        public List<FormateurDTO> GetFormateurs()
        {
            List<Formatteur> formateurs = this.FormateurRepository.GetFormateurs();
            List<FormateurDTO> dtos = new List<FormateurDTO>();
            foreach (var formateur in formateurs)
            {
                dtos.Add(new FormateurDTO(formateur));
            }
            return dtos;
        }

        public List<FormateurDTO> GetFormateursBySearchModel(FormateurSearchModel searchModel)
        {
            // L'idée ici est de transformer searchModel vers une function avec l'expression lambda et de l'utiliser au niveau de repository
            Expression<Func<Formatteur, bool>> expression = x => x.first_name == searchModel.name;  // A crée ton expression
            List<Formatteur> formateurs = this.FormateurRepository.GetFormateursBySearchModel(expression);
            List<FormateurDTO> dtos = new List<FormateurDTO>();
            foreach (var formateur in formateurs)
            {
                dtos.Add(new FormateurDTO(formateur));
            }
            return dtos;
        }
    }
    #endregion
}
