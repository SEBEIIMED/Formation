﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormationWebServicesBusiness.Models;

namespace FormationWebServicesBusiness.FormationBusiness
{
    #region Interface IFormateurBusiness-------------------------------------
    public interface IFormateurBusiness
    {
        #region Methods------------------------------------------------------
        FormateurDTO GetByName(string name);
        FormateurDTO GetById(string id);
        List<FormateurDTO> GetFormateurs();
        /// <summary>
        /// Méthode GetFormateursBySearchModel
        /// </summary>
        /// <param name="searchModel">searchModel<see cref="FormateurSearchModel"/></param>
        /// <returns></returns>
        List<FormateurDTO> GetFormateursBySearchModel(FormateurSearchModel searchModel);
        #endregion 
    }
    #endregion
}