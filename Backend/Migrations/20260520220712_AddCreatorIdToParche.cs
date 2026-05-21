using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiParchePlanU.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatorIdToParche : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_AspNetUsers_UserId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_ParcheMembers_AspNetUsers_userId",
                table: "ParcheMembers");

            migrationBuilder.DropIndex(
                name: "IX_ParcheMembers_userId",
                table: "ParcheMembers");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "ParcheMembers");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Rankings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatorId",
                table: "Plans",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverImageUrl",
                table: "Parches",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "Parches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "ParcheMembers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-0001-0001-0001-000000000001",
                column: "ConcurrencyStamp",
                value: "c0dee45e-8fd0-40b2-ba22-9c27619191e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-0001-0001-0001-000000000002",
                column: "ConcurrencyStamp",
                value: "55dc4945-d184-4a7b-8e52-41fc7c3091da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61634e69-3f9c-4075-875b-7a55482f2e1e", "30ca33c5-c48b-4aaf-907f-77242167fcc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f9a692c-b4ec-4de9-aebe-25867f8aea6d", "367db611-ae51-41a1-94d9-6e7e7d2202d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "179a6ae6-090c-4eaa-aaaf-c5416a25d5ad", "8dc48d0d-d19a-4a66-9da1-61ca5aed055b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0004",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4205eca5-da19-41df-aea3-318c07e39933", "8806076c-a4ca-49a8-9ae6-11e7729d1bb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0005",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8018adb7-b911-4ba1-a68d-fcda5205d3d5", "66b94545-523a-4fc5-a9a0-3b443805e164" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0006",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c65efef9-82a4-45b3-8608-e35551046328", "0e8bc488-76ff-444d-9324-935cb2dfe66e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0007",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "761652e4-be86-4ac1-8285-37ecc10079a7", "1f78e631-07f5-40f6-9275-4dadaecfbe3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6dbbe494-db38-4d2a-a8b5-b567c2f33628", "d091456a-0947-49b8-a9dc-41c5aaacf729" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0009",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e63dc1bb-d514-43ef-a139-903973d60f50", "4a369671-4a9f-4bba-a7e3-246a705c897a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa091e8a-2801-4389-b3bf-017b1e2be22b", "15e5556f-ccc4-4a18-a4f8-c8955890d576" });

            migrationBuilder.UpdateData(
                table: "Parches",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatorId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Parches",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatorId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Plans_CreatorId",
                table: "Plans",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ParcheMembers_UsuarioId",
                table: "ParcheMembers",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_AspNetUsers_UserId",
                table: "Attendances",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParcheMembers_AspNetUsers_UsuarioId",
                table: "ParcheMembers",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_AspNetUsers_CreatorId",
                table: "Plans",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_AspNetUsers_UserId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_ParcheMembers_AspNetUsers_UsuarioId",
                table: "ParcheMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Plans_AspNetUsers_CreatorId",
                table: "Plans");

            migrationBuilder.DropIndex(
                name: "IX_Plans_CreatorId",
                table: "Plans");

            migrationBuilder.DropIndex(
                name: "IX_ParcheMembers_UsuarioId",
                table: "ParcheMembers");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Rankings");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Parches");

            migrationBuilder.AlterColumn<string>(
                name: "CreatorId",
                table: "Plans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverImageUrl",
                table: "Parches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioId",
                table: "ParcheMembers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "ParcheMembers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-0001-0001-0001-000000000001",
                column: "ConcurrencyStamp",
                value: "e7b5969a-51cf-4a34-ad5f-1ba2139cc38d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-0001-0001-0001-000000000002",
                column: "ConcurrencyStamp",
                value: "bd8a04ab-620e-445f-b5b5-7b76726e00cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39626576-458d-438f-b0ad-ec7b7fc039ab", "31e9b909-a79c-4998-8759-4171f6a38c1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1906e9c6-1da0-4829-abaa-a5edf8f5123a", "4da1932f-4bd5-4e2d-bdbb-0387093afb80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7ea4a82-be19-4962-85d3-df1f99a3e892", "52f30551-1e04-4cf4-8c18-6222db6a58a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0004",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29506520-6d48-4930-81d5-73209541a4dc", "66ea2981-3650-4e5b-8e49-707cc9eb753f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0005",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "523a09f8-7597-4c44-b26e-9bcc9c84e0a2", "76f17f3c-072b-4f75-b6bf-2452c94a7bd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0006",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7bf73f4-2160-40d3-9f47-2003d33885f2", "6471a6b8-2e64-4b24-9f02-aa76ea1dd606" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0007",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cac46c39-2fe3-449b-879e-2a13d7bf9efa", "e15c3964-e6b6-48dc-8a24-1dd80696d918" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7def790d-889c-43db-ab40-6231d04ac89f", "18dcef97-42f6-435a-8d8f-f6f42910ace4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0009",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "694a5933-a249-41b6-94a6-f2be01ccda4c", "1246c7c6-40f0-445c-9397-927cae0ee44e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d3de34f-9513-4f88-87f8-3b4e7bcedb59", "a6408e84-8151-4d03-b9e0-acffb4c8a9c2" });

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 1,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 2,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 3,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 4,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 5,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 6,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 7,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 8,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 9,
                column: "userId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ParcheMembers",
                keyColumn: "Id",
                keyValue: 10,
                column: "userId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ParcheMembers_userId",
                table: "ParcheMembers",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_AspNetUsers_UserId",
                table: "Attendances",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParcheMembers_AspNetUsers_userId",
                table: "ParcheMembers",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
