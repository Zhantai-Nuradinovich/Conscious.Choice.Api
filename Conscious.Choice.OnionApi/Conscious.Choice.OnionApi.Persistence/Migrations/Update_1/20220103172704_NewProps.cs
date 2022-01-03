using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Conscious.Choice.OnionApi.Persistence.Migrations.Update_1
{
    public partial class NewProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "055ab531-b1af-45d4-a600-b5a7b90090e9", "99130742-6d5c-4376-b9df-74703f12c67e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3568cf5e-f95c-446c-ad49-ab265fadcb8c", "99130742-6d5c-4376-b9df-74703f12c67e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "944b9091-9479-4c6e-a1e0-deb8bfc660cd", "99130742-6d5c-4376-b9df-74703f12c67e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9994e316-1b78-48ee-ab65-bea0e4322fb1", "99130742-6d5c-4376-b9df-74703f12c67e" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9994e316-1b78-48ee-ab65-bea0e4322fb1", "b547a355-f6ba-4d8d-a79f-52b449be4a66" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "055ab531-b1af-45d4-a600-b5a7b90090e9");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3568cf5e-f95c-446c-ad49-ab265fadcb8c");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "944b9091-9479-4c6e-a1e0-deb8bfc660cd");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9994e316-1b78-48ee-ab65-bea0e4322fb1");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "99130742-6d5c-4376-b9df-74703f12c67e");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "b547a355-f6ba-4d8d-a79f-52b449be4a66");

            migrationBuilder.AddColumn<bool>(
                name: "HasWon",
                schema: "Identity",
                table: "PartyConvocations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                schema: "Identity",
                table: "Parties",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartyStatus",
                schema: "Identity",
                table: "Parties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Information",
                schema: "Identity",
                table: "Deputies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "77c1c5ec-b377-4764-9a5a-d741d749d72a", "e32df527-ca13-43d9-9daa-139466fe474c", "SuperAdmin", "SuperAdmin" },
                    { "07719d36-3c25-48ef-9785-ebda3325522b", "9d4c5e14-3bcc-4cda-838a-d4dfd1fbf7c2", "Admin", "Admin" },
                    { "d9bb9f5e-fb27-4603-8e1d-d06ccbc31fb6", "e6cb9041-6da6-4db1-b09c-38241ad27904", "Moderator", "Moderator" },
                    { "2279c1fe-1452-47fc-9b3c-6bf3119b3915", "57aa5b2e-7e3e-4460-83cf-ab715ca8f9d8", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2de7f8f7-ff1c-4566-90f5-9e52925b1e02", 0, "2dda8516-08e4-49c9-a4a7-ab2fe4e5964f", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "0d2cfd4d-620d-4cbe-aea0-bdc9b5899e76", false, "superadmin" },
                    { "0766a4a8-c697-4a2e-9fd6-69bfd6223722", 0, "4031f367-e4ff-4369-8b14-fcabeabc96ff", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "e4985979-e7b6-40fb-a815-d779fd5406f5", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "77c1c5ec-b377-4764-9a5a-d741d749d72a", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" },
                    { "07719d36-3c25-48ef-9785-ebda3325522b", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" },
                    { "d9bb9f5e-fb27-4603-8e1d-d06ccbc31fb6", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" },
                    { "2279c1fe-1452-47fc-9b3c-6bf3119b3915", "0766a4a8-c697-4a2e-9fd6-69bfd6223722" },
                    { "2279c1fe-1452-47fc-9b3c-6bf3119b3915", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2279c1fe-1452-47fc-9b3c-6bf3119b3915", "0766a4a8-c697-4a2e-9fd6-69bfd6223722" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07719d36-3c25-48ef-9785-ebda3325522b", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2279c1fe-1452-47fc-9b3c-6bf3119b3915", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77c1c5ec-b377-4764-9a5a-d741d749d72a", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d9bb9f5e-fb27-4603-8e1d-d06ccbc31fb6", "2de7f8f7-ff1c-4566-90f5-9e52925b1e02" });

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "07719d36-3c25-48ef-9785-ebda3325522b");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2279c1fe-1452-47fc-9b3c-6bf3119b3915");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "77c1c5ec-b377-4764-9a5a-d741d749d72a");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "Role",
                keyColumn: "Id",
                keyValue: "d9bb9f5e-fb27-4603-8e1d-d06ccbc31fb6");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "0766a4a8-c697-4a2e-9fd6-69bfd6223722");

            migrationBuilder.DeleteData(
                schema: "Identity",
                table: "User",
                keyColumn: "Id",
                keyValue: "2de7f8f7-ff1c-4566-90f5-9e52925b1e02");

            migrationBuilder.DropColumn(
                name: "HasWon",
                schema: "Identity",
                table: "PartyConvocations");

            migrationBuilder.DropColumn(
                name: "Logo",
                schema: "Identity",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "PartyStatus",
                schema: "Identity",
                table: "Parties");

            migrationBuilder.DropColumn(
                name: "Information",
                schema: "Identity",
                table: "Deputies");

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "944b9091-9479-4c6e-a1e0-deb8bfc660cd", "8052e4aa-ab62-4d30-b9e4-54ca43b3efb5", "SuperAdmin", "SuperAdmin" },
                    { "055ab531-b1af-45d4-a600-b5a7b90090e9", "d698b572-ed73-4c20-af50-54e0f5db839c", "Admin", "Admin" },
                    { "3568cf5e-f95c-446c-ad49-ab265fadcb8c", "45b42207-5d71-4511-8e48-c4cf3e8c6015", "Moderator", "Moderator" },
                    { "9994e316-1b78-48ee-ab65-bea0e4322fb1", "92db907b-0881-41e1-8743-d692c21f3350", "Basic", "Basic" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "99130742-6d5c-4376-b9df-74703f12c67e", 0, "6a063a78-05d8-41e1-b31c-ee14e9741064", "superadmin@gmail.com", true, "Amit", "Naik", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "a20a7003-615b-4386-b54e-6c43248c35e9", false, "superadmin" },
                    { "b547a355-f6ba-4d8d-a79f-52b449be4a66", 0, "6dfcc565-f989-4933-85a4-e40b871e9361", "basicuser@gmail.com", true, "Basic", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, true, "cd111262-ea4b-4819-918d-9deb5984268b", false, "basicuser" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "944b9091-9479-4c6e-a1e0-deb8bfc660cd", "99130742-6d5c-4376-b9df-74703f12c67e" },
                    { "055ab531-b1af-45d4-a600-b5a7b90090e9", "99130742-6d5c-4376-b9df-74703f12c67e" },
                    { "3568cf5e-f95c-446c-ad49-ab265fadcb8c", "99130742-6d5c-4376-b9df-74703f12c67e" },
                    { "9994e316-1b78-48ee-ab65-bea0e4322fb1", "b547a355-f6ba-4d8d-a79f-52b449be4a66" },
                    { "9994e316-1b78-48ee-ab65-bea0e4322fb1", "99130742-6d5c-4376-b9df-74703f12c67e" }
                });
        }
    }
}
