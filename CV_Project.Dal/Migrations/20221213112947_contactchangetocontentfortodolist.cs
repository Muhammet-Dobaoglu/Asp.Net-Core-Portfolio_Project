using Microsoft.EntityFrameworkCore.Migrations;

namespace CV_Project.Dal.Migrations
{
    public partial class contactchangetocontentfortodolist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "ToDoLists",
                newName: "Content");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ToDoLists",
                newName: "Contact");
        }
    }
}
