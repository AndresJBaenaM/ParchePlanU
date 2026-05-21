using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiParchePlanU.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Programa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InviteCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rankings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcheId = table.Column<int>(type: "int", nullable: false),
                    OrganizerScore = table.Column<int>(type: "int", nullable: false),
                    GhosScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rankings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParcheMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParcheId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParcheMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParcheMembers_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ParcheMembers_Parches_ParcheId",
                        column: x => x.ParcheId,
                        principalTable: "Parches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartVoting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndVoting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<int>(type: "int", nullable: false),
                    ParcheId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_Parches_ParcheId",
                        column: x => x.ParcheId,
                        principalTable: "Parches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lugar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanOptions_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    PlanOptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => new { x.UserId, x.PlanId });
                    table.ForeignKey(
                        name: "FK_Votes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Votes_PlanOptions_PlanOptionId",
                        column: x => x.PlanOptionId,
                        principalTable: "PlanOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Votes_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1b2c3d4-0001-0001-0001-000000000001", "e7b5969a-51cf-4a34-ad5f-1ba2139cc38d", "Admin", "ADMIN" },
                    { "a1b2c3d4-0001-0001-0001-000000000002", "bd8a04ab-620e-445f-b5b5-7b76726e00cf", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AvatarUrl", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NombreCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Programa", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user-0001", 0, "https://i.pravatar.cc/150?img=1", "39626576-458d-438f-b0ad-ec7b7fc039ab", "miguelg@universidad.edu.co", true, false, null, "Miguel Gomez", "MIGUELG@UNIVERSIDAD.EDU.CO", "MIGUELG", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería de Sistemas", "31e9b909-a79c-4998-8759-4171f6a38c1d", false, "miguelg" },
                    { "user-0002", 0, "https://i.pravatar.cc/150?img=2", "1906e9c6-1da0-4829-abaa-a5edf8f5123a", "andresb@universidad.edu.co", true, false, null, "Andres Baena", "ANDRESB@UNIVERSIDAD.EDU.CO", "ANDRESB", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería de Sistemas", "4da1932f-4bd5-4e2d-bdbb-0387093afb80", false, "andresb" },
                    { "user-0003", 0, "https://i.pravatar.cc/150?img=3", "b7ea4a82-be19-4962-85d3-df1f99a3e892", "laurart@universidad.edu.co", true, false, null, "Laura Torres", "LAURART@UNIVERSIDAD.EDU.CO", "LAURART", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería de Sistemas", "52f30551-1e04-4cf4-8c18-6222db6a58a6", false, "laurart" },
                    { "user-0004", 0, "https://i.pravatar.cc/150?img=4", "29506520-6d48-4930-81d5-73209541a4dc", "carlosr@universidad.edu.co", true, false, null, "Carlos Ruiz", "CARLOSR@UNIVERSIDAD.EDU.CO", "CARLOSR", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería de Sistemas", "66ea2981-3650-4e5b-8e49-707cc9eb753f", false, "carlosr" },
                    { "user-0005", 0, "https://i.pravatar.cc/150?img=5", "523a09f8-7597-4c44-b26e-9bcc9c84e0a2", "marial@universidad.edu.co", true, false, null, "Maria Lopez", "MARIAL@UNIVERSIDAD.EDU.CO", "MARIAL", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería de Sistemas", "76f17f3c-072b-4f75-b6bf-2452c94a7bd0", false, "marial" },
                    { "user-0006", 0, "https://i.pravatar.cc/150?img=6", "b7bf73f4-2160-40d3-9f47-2003d33885f2", "juanp@universidad.edu.co", true, false, null, "Juan Perez", "JUANP@UNIVERSIDAD.EDU.CO", "JUANP", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería Industrial", "6471a6b8-2e64-4b24-9f02-aa76ea1dd606", false, "juanp" },
                    { "user-0007", 0, "https://i.pravatar.cc/150?img=7", "cac46c39-2fe3-449b-879e-2a13d7bf9efa", "sofiad@universidad.edu.co", true, false, null, "Sofia Diaz", "SOFIAD@UNIVERSIDAD.EDU.CO", "SOFIAD", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería Industrial", "e15c3964-e6b6-48dc-8a24-1dd80696d918", false, "sofiad" },
                    { "user-0008", 0, "https://i.pravatar.cc/150?img=8", "7def790d-889c-43db-ab40-6231d04ac89f", "danielc@universidad.edu.co", true, false, null, "Daniel Castro", "DANIELC@UNIVERSIDAD.EDU.CO", "DANIELC", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería Industrial", "18dcef97-42f6-435a-8d8f-f6f42910ace4", false, "danielc" },
                    { "user-0009", 0, "https://i.pravatar.cc/150?img=9", "694a5933-a249-41b6-94a6-f2be01ccda4c", "valentinag@universidad.edu.co", true, false, null, "Valentina Gil", "VALENTINAG@UNIVERSIDAD.EDU.CO", "VALENTINAG", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería Industrial", "1246c7c6-40f0-445c-9397-927cae0ee44e", false, "valentinag" },
                    { "user-0010", 0, "https://i.pravatar.cc/150?img=10", "2d3de34f-9513-4f88-87f8-3b4e7bcedb59", "camilov@universidad.edu.co", true, false, null, "Camilo Vargas", "CAMILOV@UNIVERSIDAD.EDU.CO", "CAMILOV", "AQAAAAIAAYagAAAAEP52pK7DjOO3RRlghXyWLLccWFImunrp5ujtLWHMCg29f+DoSb4U81DUEtxBBdrSBw==", null, false, "Ingeniería Industrial", "a6408e84-8151-4d03-b9e0-acffb4c8a9c2", false, "camilov" }
                });

            migrationBuilder.InsertData(
                table: "Parches",
                columns: new[] { "Id", "CoverImageUrl", "Description", "InviteCode", "Name" },
                values: new object[,]
                {
                    { 1, "https://picsum.photos/seed/sistemas/400/200", "El parche de Ingeniería de Sistemas", "SIS2026", "Parche Sistemas" },
                    { 2, "https://picsum.photos/seed/industrial/400/200", "El parche de Ingeniería Industrial", "IND2026", "Parche Industrial" }
                });

            migrationBuilder.InsertData(
                table: "ParcheMembers",
                columns: new[] { "Id", "ParcheId", "Role", "UsuarioId", "userId" },
                values: new object[,]
                {
                    { 1, 1, 0, "user-0001", null },
                    { 2, 1, 2, "user-0002", null },
                    { 3, 1, 2, "user-0003", null },
                    { 4, 1, 2, "user-0004", null },
                    { 5, 1, 2, "user-0005", null },
                    { 6, 2, 0, "user-0006", null },
                    { 7, 2, 2, "user-0007", null },
                    { 8, 2, 2, "user-0008", null },
                    { 9, 2, 2, "user-0009", null },
                    { 10, 2, 2, "user-0010", null }
                });

            migrationBuilder.InsertData(
                table: "Plans",
                columns: new[] { "Id", "CreatorId", "Description", "EndVoting", "ParcheId", "StartVoting", "State", "Title" },
                values: new object[,]
                {
                    { 1, "user-0001", "Plan de cine grupal", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Cine en el campus" },
                    { 2, "user-0002", "Partido en la cancha", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Partido de fútbol" },
                    { 3, "user-0001", "Almorzamos juntos", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Almuerzo grupal" },
                    { 4, "user-0003", "Gaming night", new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Noche de videojuegos" },
                    { 5, "user-0002", "Cultura universitaria", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Visita al museo" },
                    { 6, "user-0001", "Caminata por el cerro", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Senderismo" },
                    { 7, "user-0004", "Música en vivo", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Concierto en el parque" },
                    { 8, "user-0005", "Preparación parciales", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Estudio grupal" },
                    { 9, "user-0006", "Competencia interna", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Torneo de ping pong" },
                    { 10, "user-0007", "Viaje de un día", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Salida a Guatapé" },
                    { 11, "user-0006", "Asado grupal", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "BBQ en la finca" },
                    { 12, "user-0008", "Noche de karaoke", new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Karaoke" },
                    { 13, "user-0009", "Bowling universitario", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tarde de bowling" },
                    { 14, "user-0006", "Visita a la feria", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Feria de emprendimiento" },
                    { 15, "user-0010", "Recorrido en bici", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ciclovía grupal" }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "Id", "PlanId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 0, "user-0001" },
                    { 2, 1, 0, "user-0002" },
                    { 3, 1, 2, "user-0003" },
                    { 4, 2, 0, "user-0004" },
                    { 5, 2, 1, "user-0005" },
                    { 6, 2, 0, "user-0001" },
                    { 7, 3, 2, "user-0002" },
                    { 8, 3, 0, "user-0003" },
                    { 9, 4, 0, "user-0004" },
                    { 10, 4, 0, "user-0005" },
                    { 11, 5, 1, "user-0001" },
                    { 12, 5, 0, "user-0002" },
                    { 13, 6, 0, "user-0003" },
                    { 14, 6, 2, "user-0004" },
                    { 15, 7, 0, "user-0005" },
                    { 16, 7, 0, "user-0001" },
                    { 17, 8, 1, "user-0002" },
                    { 18, 8, 0, "user-0003" },
                    { 19, 1, 0, "user-0004" },
                    { 20, 1, 2, "user-0005" },
                    { 21, 9, 0, "user-0006" },
                    { 22, 9, 0, "user-0007" },
                    { 23, 9, 2, "user-0008" },
                    { 24, 10, 0, "user-0009" },
                    { 25, 10, 1, "user-0010" },
                    { 26, 10, 0, "user-0006" },
                    { 27, 11, 2, "user-0007" },
                    { 28, 11, 0, "user-0008" },
                    { 29, 12, 0, "user-0009" },
                    { 30, 12, 0, "user-0010" },
                    { 31, 13, 1, "user-0006" },
                    { 32, 13, 0, "user-0007" },
                    { 33, 14, 0, "user-0008" },
                    { 34, 14, 2, "user-0009" },
                    { 35, 15, 0, "user-0010" },
                    { 36, 15, 0, "user-0006" },
                    { 37, 12, 1, "user-0007" },
                    { 38, 13, 0, "user-0008" },
                    { 39, 9, 2, "user-0009" },
                    { 40, 9, 0, "user-0010" }
                });

            migrationBuilder.InsertData(
                table: "PlanOptions",
                columns: new[] { "Id", "Lugar", "PlanId", "Time" },
                values: new object[,]
                {
                    { 1, "Campus Universidad", 1, new DateTime(2026, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Parque El Poblado", 1, new DateTime(2026, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Centro Comercial", 1, new DateTime(2026, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Cancha Principal", 2, new DateTime(2026, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Cancha Secundaria", 2, new DateTime(2026, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Parque Deportivo", 2, new DateTime(2026, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Cafetería Central", 3, new DateTime(2026, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Restaurante Cerca", 3, new DateTime(2026, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Patio de Comidas", 3, new DateTime(2026, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Sala de Sistemas", 4, new DateTime(2026, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Apartamento", 4, new DateTime(2026, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Sala Comunal", 4, new DateTime(2026, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Museo de Antioquia", 5, new DateTime(2026, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "Museo Arte Moderno", 5, new DateTime(2026, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Casa de la Cultura", 5, new DateTime(2026, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Cerro El Volador", 6, new DateTime(2026, 4, 5, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Cerro Nutibara", 6, new DateTime(2026, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Parque Arví", 6, new DateTime(2026, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Parque Norte", 7, new DateTime(2026, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Plaza Mayor", 7, new DateTime(2026, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Teatro Metropolitano", 7, new DateTime(2026, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Biblioteca Central", 8, new DateTime(2026, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Sala de Estudio", 8, new DateTime(2026, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Aula Virtual", 8, new DateTime(2026, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Sala de Juegos", 9, new DateTime(2026, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "Gimnasio", 9, new DateTime(2026, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Patio Central", 9, new DateTime(2026, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Guatapé Centro", 10, new DateTime(2026, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "La Piedra", 10, new DateTime(2026, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Embalse", 10, new DateTime(2026, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Finca Privada", 11, new DateTime(2026, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Parque Recreativo", 11, new DateTime(2026, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Club Campestre", 11, new DateTime(2026, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Bar Karaoke Centro", 12, new DateTime(2026, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Restaurante Bar", 12, new DateTime(2026, 4, 6, 21, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Terraza Laureles", 12, new DateTime(2026, 4, 7, 22, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Bolera El Tesoro", 13, new DateTime(2026, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Bolera Unicentro", 13, new DateTime(2026, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Bolera Mayorca", 13, new DateTime(2026, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Plaza de Ferias", 14, new DateTime(2026, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Centro de Eventos", 14, new DateTime(2026, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Pabellón Expo", 14, new DateTime(2026, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Ciclovía Avenida", 15, new DateTime(2026, 4, 5, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "Parque Lineal", 15, new DateTime(2026, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Ruta Montaña", 15, new DateTime(2026, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "PlanId", "UserId", "PlanOptionId" },
                values: new object[,]
                {
                    { 1, "user-0001", 1 },
                    { 5, "user-0001", 14 },
                    { 6, "user-0001", 16 },
                    { 1, "user-0002", 2 },
                    { 2, "user-0002", 4 },
                    { 6, "user-0002", 17 },
                    { 2, "user-0003", 5 },
                    { 3, "user-0003", 7 },
                    { 7, "user-0003", 19 },
                    { 3, "user-0004", 8 },
                    { 4, "user-0004", 10 },
                    { 7, "user-0004", 20 },
                    { 4, "user-0005", 11 },
                    { 5, "user-0005", 13 },
                    { 8, "user-0005", 22 },
                    { 9, "user-0006", 25 },
                    { 13, "user-0006", 38 },
                    { 14, "user-0006", 40 },
                    { 9, "user-0007", 26 },
                    { 10, "user-0007", 28 },
                    { 14, "user-0007", 41 },
                    { 15, "user-0007", 43 },
                    { 10, "user-0008", 29 },
                    { 11, "user-0008", 31 },
                    { 15, "user-0008", 44 },
                    { 8, "user-0009", 23 },
                    { 11, "user-0009", 32 },
                    { 12, "user-0009", 34 },
                    { 12, "user-0010", 35 },
                    { 13, "user-0010", 37 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_PlanId",
                table: "Attendances",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_UserId",
                table: "Attendances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcheMembers_ParcheId",
                table: "ParcheMembers",
                column: "ParcheId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcheMembers_userId",
                table: "ParcheMembers",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanOptions_PlanId",
                table: "PlanOptions",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_ParcheId",
                table: "Plans",
                column: "ParcheId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PlanId",
                table: "Votes",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PlanOptionId",
                table: "Votes",
                column: "PlanOptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "ParcheMembers");

            migrationBuilder.DropTable(
                name: "Rankings");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PlanOptions");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Parches");
        }
    }
}
