using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReminderSite.Migrations
{
    public partial class Task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tasks = table.Column<string>(maxLength: 300, nullable: true),
                    TaskDue = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    UserInfoUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Task_UserInfos_UserInfoUserID",
                        column: x => x.UserInfoUserID,
                        principalTable: "UserInfos",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_UserInfoUserID",
                table: "Task",
                column: "UserInfoUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");
        }
    }
}
