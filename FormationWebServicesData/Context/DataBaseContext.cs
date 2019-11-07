using FormationWebServicesData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationWebServicesData.Context
{
    class DataBaseContext :DbContext
    {

        DbSet<User> Users { get; set; }
        DbSet<Formation> Formation { get; set; }
        DbSet<Formatteur> Formatter { get; set; }
        DbSet<Organisateur> Organisateur { get; set; }
        DbSet<Participant> Participateur { get; set; }

    }
}
