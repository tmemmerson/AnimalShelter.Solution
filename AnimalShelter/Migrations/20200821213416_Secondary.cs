using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                columns: new[] { "PetAdmissionDate", "PetBreed", "PetDescription", "PetName", "PetTaxonomy" },
                values: new object[] { "44044", "German Shepherd", "loves to cuddle", "Barkley", "Dog" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "PetAdmissionDate", "PetBreed", "PetDescription", "PetName", "PetTaxonomy" },
                values: new object[,]
                {
                    { 28, "43894", "Maine Coon", "bad with kids", "Daisy", "Cat" },
                    { 29, "43965", "Rat Terrier", "single pet home", "Maggie", "Dog" },
                    { 30, "43997", "Maine Coon", "loves long walks", "Sophie", "Cat" },
                    { 31, "44044", "Rat Terrier", "loves to cuddle", "Sadie", "Dog" },
                    { 32, "44035", "Bulldog", "very affectionate", "Chloe", "Dog" },
                    { 33, "43954", "Maine Coon", "good with kids", "Bailey", "Cat" },
                    { 34, "44000", "Calico", "bad with kids", "Lola", "Cat" },
                    { 35, "43978", "Siamese", "single pet home", "Zoe", "Cat" },
                    { 36, "43941", "Siamese", "loves long walks", "Abby", "Cat" },
                    { 37, "43938", "Persian", "loves to cuddle", "Ginger", "Cat" },
                    { 38, "43986", "Poodle", "very affectionate", "Roxy", "Dog" },
                    { 39, "43935", "Persian", "good with kids", "Gracie", "Cat" },
                    { 40, "43905", "Golden Retriever", "bad with kids", "Coco", "Dog" },
                    { 41, "44044", "Bengal", "single pet home", "Sasha", "Cat" },
                    { 42, "44035", "Sphynx", "loves long walks", "Lily", "Cat" },
                    { 43, "43954", "Sphynx", "loves to cuddle", "Angel", "Cat" },
                    { 44, "44000", "Beagle", "very affectionate", "Princess", "Dog" },
                    { 45, "43978", "Rottweiler", "good with kids", "Emma", "Dog" },
                    { 46, "43941", "Doberman", "bad with kids", "Annie", "Dog" },
                    { 47, "43938", "Calico", "single pet home", "Rosie", "Cat" },
                    { 48, "43894", "German Shepherd", "loves long walks", "Ruby", "Dog" },
                    { 27, "43938", "Siberian Husky", "good with kids", "Molly", "Dog" },
                    { 26, "43941", "Siberian Husky", "very affectionate", "Lucy", "Dog" },
                    { 25, "43978", "Daschund", "loves to cuddle", "Bella", "Dog" },
                    { 24, "44000", "Bengal", "loves long walks", "Sammy", "Cat" },
                    { 2, "44035", "Bulldog", "very affectionate", "Max", "Dog" },
                    { 3, "43954", "Calico", "good with kids", "Charlie", "Cat" },
                    { 4, "44000", "Scottish Fold", "bad with kids", "Buddy", "Cat" },
                    { 5, "43978", "Calico", "single pet home", "Rocky", "Cat" },
                    { 6, "43941", "Poodle", "loves long walks", "Jake", "Dog" },
                    { 7, "43938", "Labrador Retriever", "loves to cuddle", "Jack", "Dog" },
                    { 8, "43894", "Calico", "very affectionate", "Toby", "Cat" },
                    { 9, "43965", "Beagle", "good with kids", "Cody", "Dog" },
                    { 10, "43997", "Calico", "bad with kids", "Buster", "Cat" },
                    { 11, "44044", "Daschund", "single pet home", "Duke", "Dog" },
                    { 49, "43965", "Bulldog", "loves to cuddle", "Gladys", "Dog" },
                    { 12, "44035", "Calico", "loves long walks", "Cooper", "Cat" },
                    { 14, "44000", "Scottish Fold", "very affectionate", "Harley", "Cat" },
                    { 15, "43978", "French Bulldog", "good with kids", "Bear", "Dog" },
                    { 16, "43941", "Persian", "bad with kids", "Tucker", "Cat" },
                    { 17, "43938", "Rottweiler", "single pet home", "Murphy", "Dog" },
                    { 18, "43986", "Siamese", "loves long walks", "Lucky", "Cat" },
                    { 19, "43935", "Rottweiler", "loves to cuddle", "Oliver", "Dog" },
                    { 20, "43905", "Bengal", "very affectionate", "Sam", "Cat" },
                    { 21, "44044", "Scottish Fold", "good with kids", "Oscar", "Cat" },
                    { 22, "44035", "Maine Coon", "bad with kids", "Teddy", "Cat" },
                    { 23, "43954", "French Bulldog", "single pet home", "Winston", "Dog" },
                    { 13, "43954", "Siberian Husky", "loves to cuddle", "Riley", "Dog" },
                    { 50, "43967", "Persian", "very affectionate", "Mark", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                columns: new[] { "PetAdmissionDate", "PetBreed", "PetDescription", "PetName", "PetTaxonomy" },
                values: new object[] { "8/13/2020", "Calico", "Don't look Mark straight in the eyes. He likes to get scratchy.", "Mark", "Cat" });
        }
    }
}
