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

        public DbSet<Camera> Camere {  get; set; }
        public DbSet<Cliente> Clienti {  get; set; }
        public DbSet<Prenotazione> Prenotazioni {  get; set; }
      


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUserRole>().HasOne(ur => ur.User).WithMany(u=> u.ApplicationUserRole).HasForeignKey(ur=> ur.UserId);
            modelBuilder.Entity<ApplicationUserRole>().HasOne(ur => ur.Role).WithMany(u=> u.ApplicationUserRole).HasForeignKey(ur=> ur.RoleId);
            modelBuilder.Entity<ApplicationUserRole>().Property(p => p.Date).HasDefaultValueSql("GETDATE()").IsRequired(true);

            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole() { Id = "E47D581A-E477-40DA-AC5D-276F07F59142", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "E47D581A-E477-40DA-AC5D-276F07F59142" });
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole() { Id = "EB589A41-5B71-41E7-A754-81764E7CCA23", Name = "Supervisor", NormalizedName = "SUPERVISOR", ConcurrencyStamp = "EB589A41-5B71-41E7-A754-81764E7CCA23" });
            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole() { Id = "DB5AE2D5-1966-4885-82BF-05FB79EEDDF5", Name = "Dipendente", NormalizedName = "DIPENDENTE", ConcurrencyStamp = "DB5AE2D5-1966-4885-82BF-05FB79EEDDF5" });

            modelBuilder.Entity<Prenotazione>().HasOne(cl=> cl.Cliente).WithMany(p=> p.Prenotazione).HasForeignKey(fk=> fk.ClienteId);
            modelBuilder.Entity<Prenotazione>().HasOne(ca => ca.Camera).WithMany(p=> p.Prenotazione).HasForeignKey(fk=> fk.CameraId);


            modelBuilder.Entity<Camera>().HasData(
                new Camera { CameraId = Guid.NewGuid(), Numero = "101", Tipo = "Singola", Prezzo = 70.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "102", Tipo = "Doppia", Prezzo = 90.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "103", Tipo = "Tripla", Prezzo = 110.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "104", Tipo = "Quadrupla", Prezzo = 150.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "105", Tipo = "Singola", Prezzo = 70.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "106", Tipo = "Doppia", Prezzo = 90.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "107", Tipo = "Tripla", Prezzo = 110.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "108", Tipo = "Quadrupla", Prezzo = 150.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "109", Tipo = "Singola", Prezzo = 70.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "110", Tipo = "Doppia", Prezzo = 90.00m, IsDisponibile = true },
                new Camera { CameraId = Guid.NewGuid(), Numero = "111", Tipo = "Tripla", Prezzo = 110.00m, IsDisponibile = true }
                );

            modelBuilder.Entity<Cliente>().HasIndex(p => p.Email).IsUnique();
            

        }
    }
}
