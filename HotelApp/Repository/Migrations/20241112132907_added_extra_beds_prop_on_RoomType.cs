using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApp.Reposiroty.Migrations
{
    /// <inheritdoc />
    public partial class added_extra_beds_prop_on_RoomType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraBeds",
                table: "RoomsTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraBeds",
                table: "RoomsTypes");
        }
    }
}
