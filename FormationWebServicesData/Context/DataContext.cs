using FormationWebServicesData.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormationWebServicesData.Context
{
    public class DataContext : DbContext
    {
        //public DataContext() : base()
        //{

        //    Database.EnsureCreated();
        //}

        //protected override void OnModelCreating(ModelBuilder builder)
        //{

        //    builder.Entity<Formation>();
        //    builder.Entity<User>();
        //    builder.Entity<Formatteur>();
        //    builder.Entity<Formation>();
        //    builder.Entity<Formation>();
        //    base.OnModelCreating(builder);
        //}

        //public virtual void Save()
        //{
        //    base.SaveChanges();
        //}
        //public string UserProvider
        //{
        //    get
        //    {
        //        return "user";
        //    }
        //}

        //public Func<DateTime> TimestampProvider { get; set; } = ()
        //    => DateTime.UtcNow;
        //public override int SaveChanges()
        //{
        //    TrackChanges();
        //    return base.SaveChanges();
        //}

        //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    TrackChanges();
        //    return await base.SaveChangesAsync(cancellationToken);
        //}

        //private void TrackChanges()
        //{
        //    //foreach (var entry in this.ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
        //    //{
        //    //    if (entry.Entity is IAuditable)
        //    //    {
        //    //        var auditable = entry.Entity as IAuditable;
        //    //        if (entry.State == EntityState.Added)
        //    //        {
        //    //            auditable.CreatedBy = UserProvider;//  
        //    //            auditable.CreatedOn = TimestampProvider();
        //    //            auditable.UpdatedOn = TimestampProvider();
        //    //        }
        //    //        else
        //    //        {
        //    //            auditable.UpdatedBy = UserProvider;
        //    //            auditable.UpdatedOn = TimestampProvider();
        //    //        }
        //    //    }
        //    //}
        //}
        DbSet<Formation> Formation { get; set; }
        DbSet<Formatteur> Formatter { get; set; }
        DbSet<Organisateur> Organisateur { get; set; }
        DbSet<Participant> Participateur { get; set; }

    }
}
