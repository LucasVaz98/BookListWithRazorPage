using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

//use add-migration AddBookToDb, this will create this script to create the database
//use update-database, this will run the script in database. It worked
// I had created the DB wrog, column Author must be String, but it was int. Didnt make any change in this file, but in data base 
//Alter table dbo.Books alter column Author string NOT NULL

namespace BookListWithRazor.Migrations
{
    public partial class AddBookToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
