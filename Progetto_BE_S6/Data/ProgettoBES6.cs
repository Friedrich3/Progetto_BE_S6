using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Progetto_BE_S6.Models;

namespace Progetto_BE_S6.Data
{
    public class ProgettoBES6 : IdentityDbContext<ApplicationUser,ApplicationRole,string,IdentityUserClaim<string>,ApplicationUserRole,IdentityUserLogin<string>, IdentityRoleClaim<string>,IdentityUserToken<string>>
    {
        public ProgettoBES6(DbContextOptions<ProgettoBES6> options) : base(options) {}

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUserRole>().HasOne(ur => ur.User).WithMany(u=> u.ApplicationUserRole).HasForeignKey(ur=> ur.UserId);
            modelBuilder.Entity<ApplicationUserRole>().HasOne(ur => ur.Role).WithMany(u=> u.ApplicationUserRole).HasForeignKey(ur=> ur.RoleId);
            modelBuilder.Entity<ApplicationUserRole>().Property(p => p.Date).HasDefaultValueSql("GETDATE()").IsRequired(true);

            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole() { Id = "E47D581A-E477-40DA-AC5D-276F07F59142", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "E47D581A-E477-40DA-AC5D-276F07F59142" });
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole() { Id = "EB589A41-5B71-41E7-A754-81764E7CCA23", Name = "SuperVisor", NormalizedName = "SUPERVISOR", ConcurrencyStamp = "EB589A41-5B71-41E7-A754-81764E7CCA23" });
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole() { Id = "DB5AE2D5-1966-4885-82BF-05FB79EEDDF5", Name = "Dipendente", NormalizedName = "DIPENDENTE", ConcurrencyStamp = "DB5AE2D5-1966-4885-82BF-05FB79EEDDF5" });

            modelBuilder.Entity<Prenotazione>().HasOne(cl=> cl.Cliente).WithMany(p=> p.Prenotazione).HasForeignKey(fk=> fk.ClienteId);
            modelBuilder.Entity<Prenotazione>().HasOne(ca => ca.Camera).WithMany(p=> p.Prenotazione).HasForeignKey(fk=> fk.CameraId);

        }
    }
}
