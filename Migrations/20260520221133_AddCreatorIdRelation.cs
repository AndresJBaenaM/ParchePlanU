using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiParchePlanU.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatorIdRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatorId",
                table: "Parches",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-0001-0001-0001-000000000001",
                column: "ConcurrencyStamp",
                value: "5447eafa-6b95-47a8-9df5-005b0ff2bd09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-0001-0001-0001-000000000002",
                column: "ConcurrencyStamp",
                value: "7b2de6de-c2ba-4104-91fd-2577ec797e30");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf9ce6ee-4e39-45cf-9d65-842d422087af", "aa44c85b-594c-45ac-a689-a40a301102af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0002",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54a87016-abaf-4eca-8326-fd66682e690a", "d6449372-fd44-43cc-a569-afc7d32115d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0003",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4855275-edc8-4d04-9ced-1718b39d4b2c", "e9eb99f2-91d2-44f7-929d-1808d96b4741" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0004",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b5e2593-7d58-46d9-bf27-5d0401296798", "24e49ade-bfcf-4f72-b751-96cd3ddac609" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0005",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbfebc89-922b-4387-9707-e8ed623465a6", "9cfaf10f-b889-4155-8ac7-d275f8c782dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0006",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "928d26a6-6bb8-4adb-8ca9-bc41cea917e2", "4c6c95ef-9f9b-4ae2-ac48-dab82fa9bbbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0007",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "453dc99f-7a5f-4a38-85ed-f8b94396600c", "b63dd0b1-e5b1-465e-9bb9-7d11272f7de3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1fdd574e-3b60-4406-947c-41e95d27234a", "b0085e3a-f804-45f8-968d-c445a0213305" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0009",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02674d81-5494-4769-a2a0-1fbdd2bc70f9", "f96a235f-abb8-40f4-889d-79f7018634c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-0010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e5dceab-293c-49aa-913b-b373ed52a270", "b060edf9-9b35-4d8a-9c1f-51dc3da22d6e" });

            migrationBuilder.CreateIndex(
                name: "IX_Parches_CreatorId",
                table: "Parches",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parches_AspNetUsers_CreatorId",
                table: "Parches",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parches_AspNetUsers_CreatorId",
                table: "Parches");

            migrationBuilder.DropIndex(
                name: "IX_Parches_CreatorId",
                table: "Parches");

            migrationBuilder.AlterColumn<string>(
                name: "CreatorId",
                table: "Parches",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
        }
    }
}
