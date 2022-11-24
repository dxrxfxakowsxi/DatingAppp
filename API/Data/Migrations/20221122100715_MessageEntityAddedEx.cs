using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class MessageEntityAddedEx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Messages");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceipientId",
                table: "Messages",
                column: "ReceipientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ReceipientId",
                table: "Messages",
                column: "ReceipientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ReceipientId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ReceipientId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "RecipientId",
                table: "Messages",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_RecipientId",
                table: "Messages",
                column: "RecipientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages",
                column: "RecipientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
