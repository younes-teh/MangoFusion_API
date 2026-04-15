using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoFusion_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedMenuItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "images/spring_roll.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Name" },
                values: new object[] { "images/samosa.jpg", "Samosa" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Name" },
                values: new object[] { "images/soup.jpg", "Soup" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Name" },
                values: new object[] { "images/noodles.jpg", "Noodles" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Name" },
                values: new object[] { "images/pav_bhaji.jpg", "Pav Bhaji" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "images/pizza.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Dessert", "images/mango_paradise.jpg", "Mango Paradise" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "images/carrot_love.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Name" },
                values: new object[] { "images/sweet_rolls.jpg", "Sweet Rolls" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://dotnetmasteryimages.blob.core.windows.net/redmango/spring roll.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://dotnetmasteryimages.blob.core.windows.net/redmango/idli.jpg", "Idli" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://dotnetmasteryimages.blob.core.windows.net/redmango/pani puri.jpg", "Panu Puri" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://dotnetmasteryimages.blob.core.windows.net/redmango/hakka noodles.jpg", "Hakka Noodles" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://dotnetmasteryimages.blob.core.windows.net/redmango/malai kofta.jpg", "Malai Kofta" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://dotnetmasteryimages.blob.core.windows.net/redmango/paneer pizza.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Image", "Name" },
                values: new object[] { "Entrée", "https://dotnetmasteryimages.blob.core.windows.net/redmango/paneer tikka.jpg", "Paneer Tikka" });

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://dotnetmasteryimages.blob.core.windows.net/redmango/carrot love.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://dotnetmasteryimages.blob.core.windows.net/redmango/rasmalai.jpg", "Rasmalai" });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "SpecialTag" },
                values: new object[] { 10, "Dessert", "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "https://dotnetmasteryimages.blob.core.windows.net/redmango/sweet rolls.jpg", "Sweet Rolls", 3.9900000000000002, "Top Rated" });
        }
    }
}
