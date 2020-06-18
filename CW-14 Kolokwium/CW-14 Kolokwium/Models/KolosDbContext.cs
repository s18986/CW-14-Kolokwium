using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW_14_Kolokwium.Models
{
    public class KolosDbContext : DbContext
    {
        public DbSet<Championship> championships { get; set; }
        public DbSet<Championhip_Team> championship_Teams { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player_Team> player_Teams { get; set; }
        public DbSet<Player> players { get; set; }
        public KolosDbContext(DbContextOptions options) : base(options)
        {
        }

        public KolosDbContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Player>(opt =>
            {
                opt.HasKey(p => p.IdPlayer);
                opt.Property(p => p.FirstName).IsRequired();
                opt.Property(p => p.LastName).IsRequired();
                opt.HasMany(p => p.player_Teams).WithOne(p => p.player).HasForeignKey(p => p.IdPlayer);
            });
            modelBuilder.Entity<Player_Team>(opt =>
            {
                opt.HasKey(p => p.IdPlayer);
                opt.HasKey(p => p.IdTeam);
                opt.Property(p => p.comment).IsRequired();
            });
            modelBuilder.Entity<Team>(opt =>
            {
                opt.HasKey(p => p.IdTeam);
                opt.Property(p => p.TeamName).IsRequired();
                opt.HasMany(p => p.championhip_Teams).WithOne(p => p.team).HasForeignKey(p => p.idTeam);
                opt.HasMany(p => p.player_Teams).WithOne(p => p.team).HasForeignKey(p => p.IdTeam);

                var Teams = new List<Team>
                {
                    new Team
                    {
                       IdTeam=1,
                       TeamName="Legia Warszawa",
                     MaxAge = 20
                     }
                };
                opt.HasData(Teams);
            });
            modelBuilder.Entity<Championhip_Team>(opt =>
            {
                opt.HasKey(p => p.idTeam);
                opt.HasKey(p => p.idChampionship);
            });
            modelBuilder.Entity<Championship>(opt =>
            {
                opt.HasKey(p => p.IdChampionShip);
                opt.Property(p => p.OfficialName).IsRequired();
                opt.HasMany(p => p.championhip_Teams).WithOne(p => p.championship).HasForeignKey(p => p.idChampionship);
            });


        }
    }
}
