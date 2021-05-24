using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Afonsoft.Ranking.Migrations
{
    public partial class Added_ChampionshipTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AbpUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "AbpUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Celphone",
                table: "AbpUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AbpUsers",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "AbpUsers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "AbpUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "AbpUsers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AllowSubscriptions",
                table: "AbpTenants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlAccess",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserIdMaster",
                table: "AbpTenants",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "AbpChampionship",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpChampionship", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpCalendarChampionship",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    ChampionshipId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Track = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Circuit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpCalendarChampionship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpCalendarChampionship_AbpChampionship_ChampionshipId",
                        column: x => x.ChampionshipId,
                        principalTable: "AbpChampionship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpTeamChampionship",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    ChampionshipId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTeamChampionship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpTeamChampionship_AbpChampionship_ChampionshipId",
                        column: x => x.ChampionshipId,
                        principalTable: "AbpChampionship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserTeamChampionship",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserTeamChampionship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserTeamChampionship_AbpTeamChampionship_TeamId",
                        column: x => x.TeamId,
                        principalTable: "AbpTeamChampionship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpUserTeamChampionship_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpCalendarChampionship_ChampionshipId",
                table: "AbpCalendarChampionship",
                column: "ChampionshipId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpCalendarChampionship_TenantId_ChampionshipId_Id",
                table: "AbpCalendarChampionship",
                columns: new[] { "TenantId", "ChampionshipId", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpChampionship_TenantId",
                table: "AbpChampionship",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTeamChampionship_ChampionshipId",
                table: "AbpTeamChampionship",
                column: "ChampionshipId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpTeamChampionship_TenantId_ChampionshipId_Id",
                table: "AbpTeamChampionship",
                columns: new[] { "TenantId", "ChampionshipId", "Id" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTeamChampionship_TeamId",
                table: "AbpUserTeamChampionship",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTeamChampionship_TenantId_UserId_Id_TeamId",
                table: "AbpUserTeamChampionship",
                columns: new[] { "TenantId", "UserId", "Id", "TeamId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserTeamChampionship_UserId",
                table: "AbpUserTeamChampionship",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpCalendarChampionship");

            migrationBuilder.DropTable(
                name: "AbpUserTeamChampionship");

            migrationBuilder.DropTable(
                name: "AbpTeamChampionship");

            migrationBuilder.DropTable(
                name: "AbpChampionship");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Celphone",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "AllowSubscriptions",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "UrlAccess",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "UserIdMaster",
                table: "AbpTenants");
        }
    }
}
