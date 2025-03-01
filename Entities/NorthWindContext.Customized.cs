using Microsoft.EntityFrameworkCore;

namespace Atelier.Ef.Query.Entities
{
    public partial class NorthwindContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Territory>()
                .Navigation(e => e.Region).AutoInclude();

            modelBuilder
                .Entity<Employee>()
                .HasQueryFilter(e => e.EmployeeId == 1);

            modelBuilder
                .Entity<Order>()
                .HasQueryFilter(o => o.EmployeeId == 1);
        }

        public virtual DbSet<SalesByYear> SalesByYear { get; set; }
    }

    [Keyless]
    public class SalesByYear
    {
        public DateTime ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal Subtotal { get; set; }
        public string Year { get; set; }
    }
}
