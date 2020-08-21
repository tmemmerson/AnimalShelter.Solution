using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PetName = table.Column<string>(nullable: true),
                    PetAdmissionDate = table.Column<string>(nullable: true),
                    PetTaxonomy = table.Column<string>(nullable: true),
                    PetBreed = table.Column<string>(nullable: true),
                    PetDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "PetAdmissionDate", "PetBreed", "PetDescription", "PetName", "PetTaxonomy" },
                values: new object[] { 1, "8/13/2020", "Calico", "Don't look Mark straight in the eyes. He likes to get scratchy.", "Mark", "Cat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
