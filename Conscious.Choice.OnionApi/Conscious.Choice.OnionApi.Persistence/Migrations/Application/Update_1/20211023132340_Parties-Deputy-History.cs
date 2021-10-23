using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Conscious.Choice.OnionApi.Persistence.Migrations.Application.Update_1
{
    public partial class PartiesDeputyHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Deputies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsRealDeputy",
                table: "Deputies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Convocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConvocationNumber = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLeaderDeputy = table.Column<int>(type: "int", nullable: true),
                    IdParentParty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parties_Deputies_IdLeaderDeputy",
                        column: x => x.IdLeaderDeputy,
                        principalTable: "Deputies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parties_Parties_IdParentParty",
                        column: x => x.IdParentParty,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeputyPartyMovingsHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDeputy = table.Column<int>(type: "int", nullable: false),
                    IdParty = table.Column<int>(type: "int", nullable: false),
                    EntranceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCurrentParty = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeputyPartyMovingsHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeputyPartyMovingsHistories_Deputies_IdDeputy",
                        column: x => x.IdDeputy,
                        principalTable: "Deputies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeputyPartyMovingsHistories_Parties_IdParty",
                        column: x => x.IdParty,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartyConvocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdParty = table.Column<int>(type: "int", nullable: false),
                    IdConvocation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyConvocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartyConvocations_Convocations_IdConvocation",
                        column: x => x.IdConvocation,
                        principalTable: "Convocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartyConvocations_Parties_IdParty",
                        column: x => x.IdParty,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeputyPartyMovingsHistories_IdDeputy",
                table: "DeputyPartyMovingsHistories",
                column: "IdDeputy");

            migrationBuilder.CreateIndex(
                name: "IX_DeputyPartyMovingsHistories_IdParty",
                table: "DeputyPartyMovingsHistories",
                column: "IdParty");

            migrationBuilder.CreateIndex(
                name: "IX_Parties_IdLeaderDeputy",
                table: "Parties",
                column: "IdLeaderDeputy");

            migrationBuilder.CreateIndex(
                name: "IX_Parties_IdParentParty",
                table: "Parties",
                column: "IdParentParty");

            migrationBuilder.CreateIndex(
                name: "IX_PartyConvocations_IdConvocation",
                table: "PartyConvocations",
                column: "IdConvocation");

            migrationBuilder.CreateIndex(
                name: "IX_PartyConvocations_IdParty",
                table: "PartyConvocations",
                column: "IdParty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeputyPartyMovingsHistories");

            migrationBuilder.DropTable(
                name: "PartyConvocations");

            migrationBuilder.DropTable(
                name: "Convocations");

            migrationBuilder.DropTable(
                name: "Parties");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Deputies");

            migrationBuilder.DropColumn(
                name: "IsRealDeputy",
                table: "Deputies");
        }
    }
}
