using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId1",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId1",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId1",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerId1",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId1",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ProducerId1",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId1",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProducerId1",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId1",
                table: "Movies",
                column: "CinemaId1");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId1",
                table: "Movies",
                column: "ProducerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId1",
                table: "Movies",
                column: "CinemaId1",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId1",
                table: "Movies",
                column: "ProducerId1",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
