using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class DataContext : DbContext
    {
        DbSet<Formation> Formation { get; set; }
        DbSet<Formatteur> Formatter { get; set; }
        DbSet<Organisateur> Organisateur { get; set; }
        DbSet<Participant> Participateur { get; set; }

    }
}
