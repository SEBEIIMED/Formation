using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationWebServicesData.Repository;
using FormationWebServicesData.Context;

namespace FormationWebServicesDataTest
{
    [TestClass]
    public class FormationWebServicicesDataTest
    {

        [TestMethod]
        public void CheckAccess()
        {
            DataContext dataContext = new DataContext(null);
            IFormateurRepository forrmateurRepository = new FormateurRepository(dataContext);
            forrmateurRepository.AddFormateur("test1", "test2");

        }
    }
}
