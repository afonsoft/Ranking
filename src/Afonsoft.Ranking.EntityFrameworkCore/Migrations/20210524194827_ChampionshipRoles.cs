using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Afonsoft.Ranking.Migrations
{
    public partial class ChampionshipRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "RoleId",
                table: "AbpChampionship",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AbpCalendarResult",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    CalendarId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    Hour = table.Column<int>(type: "int", nullable: false),
                    Minute = table.Column<int>(type: "int", nullable: false),
                    Second = table.Column<int>(type: "int", nullable: false),
                    Milliseconds = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    Laps = table.Column<int>(type: "int", nullable: false),
                    UserTeamChampionshipId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AbpCalendarResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpCalendarResult_AbpCalendarChampionship_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "AbpCalendarChampionship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpCalendarResult_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbpCalendarResult_AbpUserTeamChampionship_UserTeamChampionshipId",
                        column: x => x.UserTeamChampionshipId,
                        principalTable: "AbpUserTeamChampionship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpRoleChampionship",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: false),
                    ChampionshipId = table.Column<long>(type: "bigint", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AbpRoleChampionship", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpRoleChampionship_AbpChampionship_ChampionshipId",
                        column: x => x.ChampionshipId,
                        principalTable: "AbpChampionship",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpChampionship_RoleId",
                table: "AbpChampionship",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpCalendarResult_CalendarId",
                table: "AbpCalendarResult",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpCalendarResult_TenantId_CalendarId_Id_UserId",
                table: "AbpCalendarResult",
                columns: new[] { "TenantId", "CalendarId", "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpCalendarResult_UserId",
                table: "AbpCalendarResult",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpCalendarResult_UserTeamChampionshipId",
                table: "AbpCalendarResult",
                column: "UserTeamChampionshipId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleChampionship_ChampionshipId",
                table: "AbpRoleChampionship",
                column: "ChampionshipId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleChampionship_TenantId_ChampionshipId_Id",
                table: "AbpRoleChampionship",
                columns: new[] { "TenantId", "ChampionshipId", "Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_AbpChampionship_AbpRoleChampionship_RoleId",
                table: "AbpChampionship",
                column: "RoleId",
                principalTable: "AbpRoleChampionship",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpChampionship_AbpTenants_TenantId",
                table: "AbpChampionship",
                column: "TenantId",
                principalTable: "AbpTenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpChampionship_AbpRoleChampionship_RoleId",
                table: "AbpChampionship");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpChampionship_AbpTenants_TenantId",
                table: "AbpChampionship");

            migrationBuilder.DropTable(
                name: "AbpCalendarResult");

            migrationBuilder.DropTable(
                name: "AbpRoleChampionship");

            migrationBuilder.DropIndex(
                name: "IX_AbpChampionship_RoleId",
                table: "AbpChampionship");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AbpChampionship");
        }
    }
}
