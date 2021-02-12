using Fyro.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fyro.Data
{
    public class FyroDbContext : DbContext
    {
        public FyroDbContext(DbContextOptions<FyroDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<CompetitionEntity> Competitions { get; set; }

        public DbSet<CondoEntity> Condos { get; set; }

        public DbSet<CourseEntity> Courses { get; set; }

        public DbSet<DufferCondoEntity> DufferCondos { get; set; }

        public DbSet<DufferEntity> Duffers { get; set; }

        public DbSet<EventEntity> Events { get; set; }

        public DbSet<EventLodgingEntity> EventLodgings { get; set; }

        public DbSet<GolfAwardEntity> GolfAwards { get; set; }

        public DbSet<GolfEntity> Golfs { get; set; }

        public DbSet<HoleEntity> Holes { get; set; }

        public DbSet<HoleScoreEntity> HoleScores { get; set; }

        public DbSet<IndividualAwardEntity> IndividualAwards { get; set; }

        public DbSet<LodgingEntity> Lodgings { get; set; }

        public DbSet<PairingAwardEntity> PairingAwards { get; set; }

        public DbSet<PairingEntity> Pairings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GolfEntity>()
                .HasMany(g => g.Pairings)
                .WithOne(p => p.Golf);
        }

    }
}
