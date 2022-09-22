// dotnet ef database update
using Microsoft.EntityFrameworkCore.Migrations;

namespace Commander.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commands",   //name of table, comes from dbcontext class in CommanderContext.cs
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)    
                        .Annotation("SqlServer:Identity", "1, 1"), //when a row is inserted, increament+1
                    HowTo = table.Column<string>(maxLength: 250, nullable: false),  //the rest: not nullable
                    Line = table.Column<string>(nullable: false),
                    Platform = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.Id); //ID = PRIMARY KEY
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
