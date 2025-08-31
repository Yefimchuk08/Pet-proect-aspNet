using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EditData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "We are looking for a skilled Software Developer to join our dynamic team. You will be responsible for designing, coding, and maintaining web applications using modern technologies. The ideal candidate should have experience with C#, ASP.NET Core, and SQL databases, as well as a strong understanding of software design principles. You will work closely with product managers and designers to deliver high-quality features.");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Join our QA team to ensure the highest quality of our software solutions. As a QA Engineer, you will create and execute test cases, identify and document bugs, and collaborate with developers to resolve issues. Experience in manual testing is required, and knowledge of automated testing tools (Selenium, Postman) is a plus. Strong attention to detail and analytical skills are essential.");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "We are seeking a talented UI/UX Designer to create intuitive and visually appealing interfaces for our web and mobile applications. Your role will include user research, wireframing, prototyping, and collaborating with developers to implement your designs. The ideal candidate should have experience with Figma, Adobe XD, or similar tools, and a good understanding of user-centered design principles.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Develop web apps");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Test software");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Design interfaces");
        }
    }
}
