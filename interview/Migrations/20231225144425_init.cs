using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace interview.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reviewSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionID = table.Column<int>(type: "int", nullable: false),
                    ClientComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TherapistRating = table.Column<int>(type: "int", nullable: false),
                    SubmissionDateTim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LikeToContact = table.Column<bool>(type: "bit", nullable: false),
                    Question1Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Question2Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Question3Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Question4Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviewSessions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reviewSessions");
        }
    }
}
