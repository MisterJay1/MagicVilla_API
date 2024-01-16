using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SigmaVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "DateCreated", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedCreated" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set on a beautiful street with an amazing view to a sunset.", "https://cf.bstatic.com/xdata/images/hotel/max1280x900/295090917.jpg?k=d17621b71b0eaa0c7a37d8d8d02d33896cef75145f61e7d96d296d88375a7d39&o=&hp=1", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set on a green street.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCwKconmBwaneB1wv1YNzCNnq9u013ul1l8FW07Y9XEY5WTIAS_75cb_vbz4FyU2nyzCM&usqp=CAU", "Green Villa", 7, 300.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set on a blue street.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/301483778.jpg?k=b1f449beb857de98e8287c34956b672956926c2d03ac185ff8d9a348622c157a&o=&hp=1", "Blue Villa", 9, 500.0, 950, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set on a red street.", "https://image.architonic.com/prj2-3/20714433/swissfineline-reference--villalakezurich-pic01-villa-zurichsee-1-arcit18.jpg", "Red Villa", 11, 700.0, 1150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set on an orange street.", "https://www.myistria.com/UserDocsImages/app/objekti/1384/slika_hd/06052022024444_Villa-in-Pula-Villa%20Old%20Olive%20I%20-%20n3.jpg?preset=carousel-1-webp", "Orange Villa", 31, 900.0, 1350, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
