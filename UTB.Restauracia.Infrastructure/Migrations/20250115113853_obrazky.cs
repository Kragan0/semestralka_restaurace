using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UTB.Restauracia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class obrazky : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageSrc",
                value: "/img/food/halusky.jpg");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageSrc",
                value: "img/food/halusky.jpg");
        }
    }
}
