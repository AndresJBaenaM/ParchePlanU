using ApiParchePlanU.Models;
using ApiParchePlanU.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiParchePlanU.DAO
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        //Constructor que recibe las opciones de conexión a la bd para tener contexto de esta
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //listado de clases -> a tablas en la base de datos
        //Los DB Set nos ayudan a mapear las clases como Entidades
        //Es decir que Entity Framework lee este archivo para tomar del modelo el esquema de las tablas

        public DbSet<Parche> Parches { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<ParcheMember> ParcheMembers { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<PlanOption> PlanOptions { get; set; }
        public DbSet<Ranking> Rankings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vote>()
                .HasKey(v => new { v.UserId, v.PlanId });

            modelBuilder.Entity<Vote>()
                .HasOne(v => v.user)
                .WithMany()
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Vote>()
                .HasOne(v => v.plan)
                .WithMany(p => p.Votes)
                .HasForeignKey(v => v.PlanId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Vote>()
                .HasOne(v => v.PlanOption)
                .WithMany()
                .HasForeignKey(v => v.PlanOptionId)
                .OnDelete(DeleteBehavior.NoAction);


            //  PARCHES
            modelBuilder.Entity<Parche>().HasData(
                new Parche
                {
                    Id = 1,
                    Name = "Parche Futbol",
                    Description = "Jugamos fútbol",
                    CoverImageUrl = "img1.jpg",
                    InviteCode = "FUT123"
                },
                new Parche
                {
                    Id = 2,
                    Name = "Parche Cine",
                    Description = "Amantes del cine",
                    CoverImageUrl = "img2.jpg",
                    InviteCode = "CINE123"
                }
            );

            // PLANES
            modelBuilder.Entity<Plan>().HasData(
                new Plan
                {
                    Id = 1,
                    Title = "Partido sábado",
                    Description = "Fútbol en cancha",
                    CreatorId = null,
                    StartVoting = new DateTime(2026, 3, 16, 10, 0, 0),
                    EndVoting = new DateTime(2026, 3, 17, 10, 0, 0),
                    State = PlanState.VotingOpen,
                    ParcheId = 1
                },
                new Plan
                {
                    Id = 2,
                    Title = "Ir a cine",
                    Description = "Ver película",
                    CreatorId = null,
                    StartVoting = new DateTime(2026, 3, 18, 10, 0, 0),
                    EndVoting = new DateTime(2026, 3, 19, 10, 0, 0),
                    State = PlanState.Draft,
                    ParcheId = 2
                }
            );

            // PLAN OPTIONS
            modelBuilder.Entity<PlanOption>().HasData(
                new PlanOption { Id = 1, PlanId = 1, Lugar = "Cancha A" },
                new PlanOption { Id = 2, PlanId = 1, Lugar = "Cancha B" },
                new PlanOption { Id = 3, PlanId = 2, Lugar = "Cine 1" },
                new PlanOption { Id = 4, PlanId = 2, Lugar = "Cine 2" }
            );

            // PARCHE MEMBERS
            modelBuilder.Entity<ParcheMember>().HasData(
                new ParcheMember { Id = 1, UsuarioId = "user1", ParcheId = 1 },
                new ParcheMember { Id = 2, UsuarioId = "user2", ParcheId = 1 },
                new ParcheMember { Id = 3, UsuarioId = "user2", ParcheId = 2 }
            );

            // ATTENDANCES
            modelBuilder.Entity<Attendance>().HasData(
                new Attendance { Id = 1, PlanId = 1, UserId = "user1" },
                new Attendance { Id = 2, PlanId = 2, UserId = "user2" }
            );

            // VOTES (CLAVE COMPUESTA)
            modelBuilder.Entity<Vote>().HasData(
                new Vote
                {
                    UserId = "user1",
                    PlanId = 1,
                    PlanOptionId = 1
                },
                new Vote
                {
                    UserId = "user2",
                    PlanId = 2,
                    PlanOptionId = 3
                }
            );
        }
     }
}
