using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PushNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ7vsQ87hL64dYCv53oQN7McuPipgKNw_5Z6A&s");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://inproject.org/wp-content/uploads/2023/02/divchuna-qa-1024x683.jpg");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROSsJYCBw-B3S44zjkaA9otdPX8o5GO2QyEQ&s");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Jobs");
        }
    }
}
