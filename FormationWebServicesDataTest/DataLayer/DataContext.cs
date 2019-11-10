using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationWebServicesData.Repository;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;

namespace FormationTest.DataLayer
{
    [TestClass]
    public class DataContext
    {

        [TestMethod]
        public void CheckAccess()
        {
            //DataLayer.Context.DataContext dataContext = new DataLayer.Context.DataContext( );
            // IFormateurRepository forrmateurRepository = new FormateurRepository(dataContext);
            //forrmateurRepository.AddFormateur("test1", "test2");

        }
    }
}
