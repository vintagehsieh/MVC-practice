using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LAB01_EventSite.Models.EFModels
{
    // Model1Ä~©ÓDbContext
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        // ³s¨ìRegistersªºTABLE
        public virtual DbSet<Register> Registers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
