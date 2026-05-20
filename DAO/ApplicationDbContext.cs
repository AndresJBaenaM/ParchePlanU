using ApiParchePlanU.Models;
using ApiParchePlanU.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); // Indispensable para Identity

            // 1. SEMILLA PARA ROLES
            string adminRoleId = "a1b2c3d4-0001-0001-0001-000000000001";
            string userRoleId = "a1b2c3d4-0001-0001-0001-000000000002";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" }
            );

            // 2. SEMILLA PARA USUARIOS (10)
            // Hash fijo para "Password123!" - no cambia entre builds
            string passwordHash = "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==";

            builder.Entity<User>().HasData(
                new User { Id = "user-0001", UserName = "miguelg", NormalizedUserName = "MIGUELG", Email = "miguelg@universidad.edu.co", NormalizedEmail = "MIGUELG@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Miguel Gomez", Programa = "Ingeniería de Sistemas", AvatarUrl = "https://i.pravatar.cc/150?img=1", PasswordHash = passwordHash },
                new User { Id = "user-0002", UserName = "andresb", NormalizedUserName = "ANDRESB", Email = "andresb@universidad.edu.co", NormalizedEmail = "ANDRESB@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Andres Baena", Programa = "Ingeniería de Sistemas", AvatarUrl = "https://i.pravatar.cc/150?img=2", PasswordHash = passwordHash },
                new User { Id = "user-0003", UserName = "laurart", NormalizedUserName = "LAURART", Email = "laurart@universidad.edu.co", NormalizedEmail = "LAURART@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Laura Torres", Programa = "Ingeniería de Sistemas", AvatarUrl = "https://i.pravatar.cc/150?img=3", PasswordHash = passwordHash },
                new User { Id = "user-0004", UserName = "carlosr", NormalizedUserName = "CARLOSR", Email = "carlosr@universidad.edu.co", NormalizedEmail = "CARLOSR@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Carlos Ruiz", Programa = "Ingeniería de Sistemas", AvatarUrl = "https://i.pravatar.cc/150?img=4", PasswordHash = passwordHash },
                new User { Id = "user-0005", UserName = "marial", NormalizedUserName = "MARIAL", Email = "marial@universidad.edu.co", NormalizedEmail = "MARIAL@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Maria Lopez", Programa = "Ingeniería de Sistemas", AvatarUrl = "https://i.pravatar.cc/150?img=5", PasswordHash = passwordHash },
                new User { Id = "user-0006", UserName = "juanp", NormalizedUserName = "JUANP", Email = "juanp@universidad.edu.co", NormalizedEmail = "JUANP@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Juan Perez", Programa = "Ingeniería Industrial", AvatarUrl = "https://i.pravatar.cc/150?img=6", PasswordHash = passwordHash },
                new User { Id = "user-0007", UserName = "sofiad", NormalizedUserName = "SOFIAD", Email = "sofiad@universidad.edu.co", NormalizedEmail = "SOFIAD@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Sofia Diaz", Programa = "Ingeniería Industrial", AvatarUrl = "https://i.pravatar.cc/150?img=7", PasswordHash = passwordHash },
                new User { Id = "user-0008", UserName = "danielc", NormalizedUserName = "DANIELC", Email = "danielc@universidad.edu.co", NormalizedEmail = "DANIELC@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Daniel Castro", Programa = "Ingeniería Industrial", AvatarUrl = "https://i.pravatar.cc/150?img=8", PasswordHash = passwordHash },
                new User { Id = "user-0009", UserName = "valentinag", NormalizedUserName = "VALENTINAG", Email = "valentinag@universidad.edu.co", NormalizedEmail = "VALENTINAG@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Valentina Gil", Programa = "Ingeniería Industrial", AvatarUrl = "https://i.pravatar.cc/150?img=9", PasswordHash = passwordHash },
                new User { Id = "user-0010", UserName = "camilov", NormalizedUserName = "CAMILOV", Email = "camilov@universidad.edu.co", NormalizedEmail = "CAMILOV@UNIVERSIDAD.EDU.CO", EmailConfirmed = true, NombreCompleto = "Camilo Vargas", Programa = "Ingeniería Industrial", AvatarUrl = "https://i.pravatar.cc/150?img=10", PasswordHash = passwordHash }
            );

            // 3. SEMILLA PARA PARCHES (2)
            builder.Entity<Parche>().HasData(
                new Parche { Id = 1, Name = "Parche Sistemas", Description = "El parche de Ingeniería de Sistemas", CoverImageUrl = "https://picsum.photos/seed/sistemas/400/200", InviteCode = "SIS2026" },
                new Parche { Id = 2, Name = "Parche Industrial", Description = "El parche de Ingeniería Industrial", CoverImageUrl = "https://picsum.photos/seed/industrial/400/200", InviteCode = "IND2026" }
            );

            // 4. SEMILLA PARA MIEMBROS
            builder.Entity<ParcheMember>().HasData(
                new ParcheMember { Id = 1, UsuarioId = "user-0001", ParcheId = 1, Role = ParcheRole.Owner },
                new ParcheMember { Id = 2, UsuarioId = "user-0002", ParcheId = 1, Role = ParcheRole.Member },
                new ParcheMember { Id = 3, UsuarioId = "user-0003", ParcheId = 1, Role = ParcheRole.Member },
                new ParcheMember { Id = 4, UsuarioId = "user-0004", ParcheId = 1, Role = ParcheRole.Member },
                new ParcheMember { Id = 5, UsuarioId = "user-0005", ParcheId = 1, Role = ParcheRole.Member },
                new ParcheMember { Id = 6, UsuarioId = "user-0006", ParcheId = 2, Role = ParcheRole.Owner },
                new ParcheMember { Id = 7, UsuarioId = "user-0007", ParcheId = 2, Role = ParcheRole.Member },
                new ParcheMember { Id = 8, UsuarioId = "user-0008", ParcheId = 2, Role = ParcheRole.Member },
                new ParcheMember { Id = 9, UsuarioId = "user-0009", ParcheId = 2, Role = ParcheRole.Member },
                new ParcheMember { Id = 10, UsuarioId = "user-0010", ParcheId = 2, Role = ParcheRole.Member }
            );

            // 5. SEMILLA PARA PLANES (15)
            builder.Entity<Plan>().HasData(
                new Plan { Id = 1, Title = "Cine en el campus", Description = "Plan de cine grupal", CreatorId = "user-0001", StartVoting = new DateTime(2026, 3, 1), EndVoting = new DateTime(2026, 4, 1), State = PlanState.VotingOpen, ParcheId = 1 },
                new Plan { Id = 2, Title = "Partido de fútbol", Description = "Partido en la cancha", CreatorId = "user-0002", StartVoting = new DateTime(2026, 3, 2), EndVoting = new DateTime(2026, 4, 2), State = PlanState.VotingOpen, ParcheId = 1 },
                new Plan { Id = 3, Title = "Almuerzo grupal", Description = "Almorzamos juntos", CreatorId = "user-0001", StartVoting = new DateTime(2026, 3, 3), EndVoting = new DateTime(2026, 4, 3), State = PlanState.Draft, ParcheId = 1 },
                new Plan { Id = 4, Title = "Noche de videojuegos", Description = "Gaming night", CreatorId = "user-0003", StartVoting = new DateTime(2026, 3, 4), EndVoting = new DateTime(2026, 4, 4), State = PlanState.VotingOpen, ParcheId = 1 },
                new Plan { Id = 5, Title = "Visita al museo", Description = "Cultura universitaria", CreatorId = "user-0002", StartVoting = new DateTime(2026, 3, 5), EndVoting = new DateTime(2026, 4, 5), State = PlanState.VotingClosed, ParcheId = 1 },
                new Plan { Id = 6, Title = "Senderismo", Description = "Caminata por el cerro", CreatorId = "user-0001", StartVoting = new DateTime(2026, 3, 6), EndVoting = new DateTime(2026, 4, 6), State = PlanState.Scheduled, ParcheId = 1 },
                new Plan { Id = 7, Title = "Concierto en el parque", Description = "Música en vivo", CreatorId = "user-0004", StartVoting = new DateTime(2026, 3, 7), EndVoting = new DateTime(2026, 4, 7), State = PlanState.VotingOpen, ParcheId = 1 },
                new Plan { Id = 8, Title = "Estudio grupal", Description = "Preparación parciales", CreatorId = "user-0005", StartVoting = new DateTime(2026, 3, 8), EndVoting = new DateTime(2026, 4, 8), State = PlanState.Draft, ParcheId = 1 },
                new Plan { Id = 9, Title = "Torneo de ping pong", Description = "Competencia interna", CreatorId = "user-0006", StartVoting = new DateTime(2026, 3, 1), EndVoting = new DateTime(2026, 4, 1), State = PlanState.VotingOpen, ParcheId = 2 },
                new Plan { Id = 10, Title = "Salida a Guatapé", Description = "Viaje de un día", CreatorId = "user-0007", StartVoting = new DateTime(2026, 3, 2), EndVoting = new DateTime(2026, 4, 2), State = PlanState.VotingOpen, ParcheId = 2 },
                new Plan { Id = 11, Title = "BBQ en la finca", Description = "Asado grupal", CreatorId = "user-0006", StartVoting = new DateTime(2026, 3, 3), EndVoting = new DateTime(2026, 4, 3), State = PlanState.Draft, ParcheId = 2 },
                new Plan { Id = 12, Title = "Karaoke", Description = "Noche de karaoke", CreatorId = "user-0008", StartVoting = new DateTime(2026, 3, 4), EndVoting = new DateTime(2026, 4, 4), State = PlanState.VotingClosed, ParcheId = 2 },
                new Plan { Id = 13, Title = "Tarde de bowling", Description = "Bowling universitario", CreatorId = "user-0009", StartVoting = new DateTime(2026, 3, 5), EndVoting = new DateTime(2026, 4, 5), State = PlanState.VotingOpen, ParcheId = 2 },
                new Plan { Id = 14, Title = "Feria de emprendimiento", Description = "Visita a la feria", CreatorId = "user-0006", StartVoting = new DateTime(2026, 3, 6), EndVoting = new DateTime(2026, 4, 6), State = PlanState.Scheduled, ParcheId = 2 },
                new Plan { Id = 15, Title = "Ciclovía grupal", Description = "Recorrido en bici", CreatorId = "user-0010", StartVoting = new DateTime(2026, 3, 7), EndVoting = new DateTime(2026, 4, 7), State = PlanState.VotingOpen, ParcheId = 2 }
            );

            // 6. SEMILLA PARA OPCIONES DE PLANES (3 por plan)
            builder.Entity<PlanOption>().HasData(
                new PlanOption { Id = 1, Lugar = "Campus Universidad", Time = new DateTime(2026, 4, 5, 14, 0, 0), PlanId = 1 },
                new PlanOption { Id = 2, Lugar = "Parque El Poblado", Time = new DateTime(2026, 4, 6, 16, 0, 0), PlanId = 1 },
                new PlanOption { Id = 3, Lugar = "Centro Comercial", Time = new DateTime(2026, 4, 7, 18, 0, 0), PlanId = 1 },
                new PlanOption { Id = 4, Lugar = "Cancha Principal", Time = new DateTime(2026, 4, 5, 10, 0, 0), PlanId = 2 },
                new PlanOption { Id = 5, Lugar = "Cancha Secundaria", Time = new DateTime(2026, 4, 6, 11, 0, 0), PlanId = 2 },
                new PlanOption { Id = 6, Lugar = "Parque Deportivo", Time = new DateTime(2026, 4, 7, 12, 0, 0), PlanId = 2 },
                new PlanOption { Id = 7, Lugar = "Cafetería Central", Time = new DateTime(2026, 4, 5, 12, 0, 0), PlanId = 3 },
                new PlanOption { Id = 8, Lugar = "Restaurante Cerca", Time = new DateTime(2026, 4, 6, 13, 0, 0), PlanId = 3 },
                new PlanOption { Id = 9, Lugar = "Patio de Comidas", Time = new DateTime(2026, 4, 7, 14, 0, 0), PlanId = 3 },
                new PlanOption { Id = 10, Lugar = "Sala de Sistemas", Time = new DateTime(2026, 4, 5, 18, 0, 0), PlanId = 4 },
                new PlanOption { Id = 11, Lugar = "Apartamento", Time = new DateTime(2026, 4, 6, 19, 0, 0), PlanId = 4 },
                new PlanOption { Id = 12, Lugar = "Sala Comunal", Time = new DateTime(2026, 4, 7, 20, 0, 0), PlanId = 4 },
                new PlanOption { Id = 13, Lugar = "Museo de Antioquia", Time = new DateTime(2026, 4, 5, 10, 0, 0), PlanId = 5 },
                new PlanOption { Id = 14, Lugar = "Museo Arte Moderno", Time = new DateTime(2026, 4, 6, 11, 0, 0), PlanId = 5 },
                new PlanOption { Id = 15, Lugar = "Casa de la Cultura", Time = new DateTime(2026, 4, 7, 12, 0, 0), PlanId = 5 },
                new PlanOption { Id = 16, Lugar = "Cerro El Volador", Time = new DateTime(2026, 4, 5, 7, 0, 0), PlanId = 6 },
                new PlanOption { Id = 17, Lugar = "Cerro Nutibara", Time = new DateTime(2026, 4, 6, 8, 0, 0), PlanId = 6 },
                new PlanOption { Id = 18, Lugar = "Parque Arví", Time = new DateTime(2026, 4, 7, 9, 0, 0), PlanId = 6 },
                new PlanOption { Id = 19, Lugar = "Parque Norte", Time = new DateTime(2026, 4, 5, 17, 0, 0), PlanId = 7 },
                new PlanOption { Id = 20, Lugar = "Plaza Mayor", Time = new DateTime(2026, 4, 6, 18, 0, 0), PlanId = 7 },
                new PlanOption { Id = 21, Lugar = "Teatro Metropolitano", Time = new DateTime(2026, 4, 7, 19, 0, 0), PlanId = 7 },
                new PlanOption { Id = 22, Lugar = "Biblioteca Central", Time = new DateTime(2026, 4, 5, 8, 0, 0), PlanId = 8 },
                new PlanOption { Id = 23, Lugar = "Sala de Estudio", Time = new DateTime(2026, 4, 6, 9, 0, 0), PlanId = 8 },
                new PlanOption { Id = 24, Lugar = "Aula Virtual", Time = new DateTime(2026, 4, 7, 10, 0, 0), PlanId = 8 },
                new PlanOption { Id = 25, Lugar = "Sala de Juegos", Time = new DateTime(2026, 4, 5, 15, 0, 0), PlanId = 9 },
                new PlanOption { Id = 26, Lugar = "Gimnasio", Time = new DateTime(2026, 4, 6, 16, 0, 0), PlanId = 9 },
                new PlanOption { Id = 27, Lugar = "Patio Central", Time = new DateTime(2026, 4, 7, 17, 0, 0), PlanId = 9 },
                new PlanOption { Id = 28, Lugar = "Guatapé Centro", Time = new DateTime(2026, 4, 5, 8, 0, 0), PlanId = 10 },
                new PlanOption { Id = 29, Lugar = "La Piedra", Time = new DateTime(2026, 4, 6, 9, 0, 0), PlanId = 10 },
                new PlanOption { Id = 30, Lugar = "Embalse", Time = new DateTime(2026, 4, 7, 10, 0, 0), PlanId = 10 },
                new PlanOption { Id = 31, Lugar = "Finca Privada", Time = new DateTime(2026, 4, 5, 12, 0, 0), PlanId = 11 },
                new PlanOption { Id = 32, Lugar = "Parque Recreativo", Time = new DateTime(2026, 4, 6, 13, 0, 0), PlanId = 11 },
                new PlanOption { Id = 33, Lugar = "Club Campestre", Time = new DateTime(2026, 4, 7, 14, 0, 0), PlanId = 11 },
                new PlanOption { Id = 34, Lugar = "Bar Karaoke Centro", Time = new DateTime(2026, 4, 5, 20, 0, 0), PlanId = 12 },
                new PlanOption { Id = 35, Lugar = "Restaurante Bar", Time = new DateTime(2026, 4, 6, 21, 0, 0), PlanId = 12 },
                new PlanOption { Id = 36, Lugar = "Terraza Laureles", Time = new DateTime(2026, 4, 7, 22, 0, 0), PlanId = 12 },
                new PlanOption { Id = 37, Lugar = "Bolera El Tesoro", Time = new DateTime(2026, 4, 5, 16, 0, 0), PlanId = 13 },
                new PlanOption { Id = 38, Lugar = "Bolera Unicentro", Time = new DateTime(2026, 4, 6, 17, 0, 0), PlanId = 13 },
                new PlanOption { Id = 39, Lugar = "Bolera Mayorca", Time = new DateTime(2026, 4, 7, 18, 0, 0), PlanId = 13 },
                new PlanOption { Id = 40, Lugar = "Plaza de Ferias", Time = new DateTime(2026, 4, 5, 10, 0, 0), PlanId = 14 },
                new PlanOption { Id = 41, Lugar = "Centro de Eventos", Time = new DateTime(2026, 4, 6, 11, 0, 0), PlanId = 14 },
                new PlanOption { Id = 42, Lugar = "Pabellón Expo", Time = new DateTime(2026, 4, 7, 12, 0, 0), PlanId = 14 },
                new PlanOption { Id = 43, Lugar = "Ciclovía Avenida", Time = new DateTime(2026, 4, 5, 7, 0, 0), PlanId = 15 },
                new PlanOption { Id = 44, Lugar = "Parque Lineal", Time = new DateTime(2026, 4, 6, 8, 0, 0), PlanId = 15 },
                new PlanOption { Id = 45, Lugar = "Ruta Montaña", Time = new DateTime(2026, 4, 7, 9, 0, 0), PlanId = 15 }
            );

            // 7. SEMILLA PARA VOTOS (30)
            builder.Entity<Vote>().HasData(
                new Vote { UserId = "user-0001", PlanId = 1, PlanOptionId = 1 },
                new Vote { UserId = "user-0002", PlanId = 1, PlanOptionId = 2 },
                new Vote { UserId = "user-0002", PlanId = 2, PlanOptionId = 4 },
                new Vote { UserId = "user-0003", PlanId = 2, PlanOptionId = 5 },
                new Vote { UserId = "user-0003", PlanId = 3, PlanOptionId = 7 },
                new Vote { UserId = "user-0004", PlanId = 3, PlanOptionId = 8 },
                new Vote { UserId = "user-0004", PlanId = 4, PlanOptionId = 10 },
                new Vote { UserId = "user-0005", PlanId = 4, PlanOptionId = 11 },
                new Vote { UserId = "user-0005", PlanId = 5, PlanOptionId = 13 },
                new Vote { UserId = "user-0001", PlanId = 5, PlanOptionId = 14 },
                new Vote { UserId = "user-0001", PlanId = 6, PlanOptionId = 16 },
                new Vote { UserId = "user-0002", PlanId = 6, PlanOptionId = 17 },
                new Vote { UserId = "user-0003", PlanId = 7, PlanOptionId = 19 },
                new Vote { UserId = "user-0004", PlanId = 7, PlanOptionId = 20 },
                new Vote { UserId = "user-0005", PlanId = 8, PlanOptionId = 22 },
                new Vote { UserId = "user-0006", PlanId = 9, PlanOptionId = 25 },
                new Vote { UserId = "user-0007", PlanId = 9, PlanOptionId = 26 },
                new Vote { UserId = "user-0007", PlanId = 10, PlanOptionId = 28 },
                new Vote { UserId = "user-0008", PlanId = 10, PlanOptionId = 29 },
                new Vote { UserId = "user-0008", PlanId = 11, PlanOptionId = 31 },
                new Vote { UserId = "user-0009", PlanId = 11, PlanOptionId = 32 },
                new Vote { UserId = "user-0009", PlanId = 12, PlanOptionId = 34 },
                new Vote { UserId = "user-0010", PlanId = 12, PlanOptionId = 35 },
                new Vote { UserId = "user-0010", PlanId = 13, PlanOptionId = 37 },
                new Vote { UserId = "user-0006", PlanId = 13, PlanOptionId = 38 },
                new Vote { UserId = "user-0006", PlanId = 14, PlanOptionId = 40 },
                new Vote { UserId = "user-0007", PlanId = 14, PlanOptionId = 41 },
                new Vote { UserId = "user-0007", PlanId = 15, PlanOptionId = 43 },
                new Vote { UserId = "user-0008", PlanId = 15, PlanOptionId = 44 },
                new Vote { UserId = "user-0009", PlanId = 8, PlanOptionId = 23 }
            );

            // 8. SEMILLA PARA ASISTENCIAS (40)
            builder.Entity<Attendance>().HasData(
                new Attendance { Id = 1, UserId = "user-0001", PlanId = 1, Status = AttendanceStatus.Yes },
                new Attendance { Id = 2, UserId = "user-0002", PlanId = 1, Status = AttendanceStatus.Yes },
                new Attendance { Id = 3, UserId = "user-0003", PlanId = 1, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 4, UserId = "user-0004", PlanId = 2, Status = AttendanceStatus.Yes },
                new Attendance { Id = 5, UserId = "user-0005", PlanId = 2, Status = AttendanceStatus.No },
                new Attendance { Id = 6, UserId = "user-0001", PlanId = 2, Status = AttendanceStatus.Yes },
                new Attendance { Id = 7, UserId = "user-0002", PlanId = 3, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 8, UserId = "user-0003", PlanId = 3, Status = AttendanceStatus.Yes },
                new Attendance { Id = 9, UserId = "user-0004", PlanId = 4, Status = AttendanceStatus.Yes },
                new Attendance { Id = 10, UserId = "user-0005", PlanId = 4, Status = AttendanceStatus.Yes },
                new Attendance { Id = 11, UserId = "user-0001", PlanId = 5, Status = AttendanceStatus.No },
                new Attendance { Id = 12, UserId = "user-0002", PlanId = 5, Status = AttendanceStatus.Yes },
                new Attendance { Id = 13, UserId = "user-0003", PlanId = 6, Status = AttendanceStatus.Yes },
                new Attendance { Id = 14, UserId = "user-0004", PlanId = 6, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 15, UserId = "user-0005", PlanId = 7, Status = AttendanceStatus.Yes },
                new Attendance { Id = 16, UserId = "user-0001", PlanId = 7, Status = AttendanceStatus.Yes },
                new Attendance { Id = 17, UserId = "user-0002", PlanId = 8, Status = AttendanceStatus.No },
                new Attendance { Id = 18, UserId = "user-0003", PlanId = 8, Status = AttendanceStatus.Yes },
                new Attendance { Id = 19, UserId = "user-0004", PlanId = 1, Status = AttendanceStatus.Yes },
                new Attendance { Id = 20, UserId = "user-0005", PlanId = 1, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 21, UserId = "user-0006", PlanId = 9, Status = AttendanceStatus.Yes },
                new Attendance { Id = 22, UserId = "user-0007", PlanId = 9, Status = AttendanceStatus.Yes },
                new Attendance { Id = 23, UserId = "user-0008", PlanId = 9, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 24, UserId = "user-0009", PlanId = 10, Status = AttendanceStatus.Yes },
                new Attendance { Id = 25, UserId = "user-0010", PlanId = 10, Status = AttendanceStatus.No },
                new Attendance { Id = 26, UserId = "user-0006", PlanId = 10, Status = AttendanceStatus.Yes },
                new Attendance { Id = 27, UserId = "user-0007", PlanId = 11, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 28, UserId = "user-0008", PlanId = 11, Status = AttendanceStatus.Yes },
                new Attendance { Id = 29, UserId = "user-0009", PlanId = 12, Status = AttendanceStatus.Yes },
                new Attendance { Id = 30, UserId = "user-0010", PlanId = 12, Status = AttendanceStatus.Yes },
                new Attendance { Id = 31, UserId = "user-0006", PlanId = 13, Status = AttendanceStatus.No },
                new Attendance { Id = 32, UserId = "user-0007", PlanId = 13, Status = AttendanceStatus.Yes },
                new Attendance { Id = 33, UserId = "user-0008", PlanId = 14, Status = AttendanceStatus.Yes },
                new Attendance { Id = 34, UserId = "user-0009", PlanId = 14, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 35, UserId = "user-0010", PlanId = 15, Status = AttendanceStatus.Yes },
                new Attendance { Id = 36, UserId = "user-0006", PlanId = 15, Status = AttendanceStatus.Yes },
                new Attendance { Id = 37, UserId = "user-0007", PlanId = 12, Status = AttendanceStatus.No },
                new Attendance { Id = 38, UserId = "user-0008", PlanId = 13, Status = AttendanceStatus.Yes },
                new Attendance { Id = 39, UserId = "user-0009", PlanId = 9, Status = AttendanceStatus.Maybe },
                new Attendance { Id = 40, UserId = "user-0010", PlanId = 9, Status = AttendanceStatus.Yes }
            );

            // =====================
            // CONFIGURACIÓN DE RELACIONES
            // =====================
            builder.Entity<Vote>()
                .HasKey(v => new { v.UserId, v.PlanId });

            builder.Entity<Vote>()
                .HasOne(v => v.user)
                .WithMany()
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Vote>()
                .HasOne(v => v.plan)
                .WithMany(p => p.Votes)
                .HasForeignKey(v => v.PlanId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Vote>()
                .HasOne(v => v.PlanOption)
                .WithMany(o => o.Votes)
                .HasForeignKey(v => v.PlanOptionId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.Entity<ParcheMember>()
                .HasOne(m => m.user)
                .WithMany()
                .HasForeignKey(m => m.UsuarioId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Attendance>()
                .HasOne(a => a.user)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Plan>()
                .HasOne(p => p.Creator)
                .WithMany()
                .HasForeignKey(p => p.CreatorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Parche>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(p => p.CreatorId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
