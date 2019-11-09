using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationWebServicesData.Repository;
using FormationWebServicesData.Context;
using Microsoft.EntityFrameworkCore;

namespace FormationWebServicesDataTest
{
    [TestClass]
    public class FormationWebServicicesDataTest
    {

        [TestMethod]
        public void CheckAccess()
        {
             DataContext dataContext = new DataContext( );
            //var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
            //optionsBuilder.UseSqlite("Data Source=blog.db");
            IFormateurRepository forrmateurRepository = new FormateurRepository(dataContext);
            forrmateurRepository.AddFormateur("test1", "test2");
            forrmateurRepository.GetById("2");
            forrmateurRepository.GetByName("test1");
            forrmateurRepository.GetFormateurs();
            forrmateurRepository.GetFormateursBySearchModel();

        }
    }
}
