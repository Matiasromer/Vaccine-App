namespace Vaccine_Api
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VaccineContext : DbContext
    {
        public VaccineContext()
            : base("name=VaccineContext")
        {
        }

        public virtual DbSet<Barn> Barn { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Historik> Historik { get; set; }
        public virtual DbSet<Kalender> Kalender { get; set; }
        public virtual DbSet<Vaccine> Vaccine { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
