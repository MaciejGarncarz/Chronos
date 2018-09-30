using Chronos.Models;

namespace Chronos.Database
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<FinanceItem> FinanceItems { get; set; }
        public virtual  DbSet<Plan> Plans { get; set; }
        public virtual  DbSet<RecurrencePlan> RecurrencePlans { get; set; }
    }
}