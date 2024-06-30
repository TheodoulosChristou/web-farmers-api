using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_farmers_api.Migrations
{
    /// <inheritdoc />
    public partial class CreateFarmEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farm",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FARMNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LOCATION = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FARMSIZE = table.Column<int>(type: "int", nullable: false),
                    FARMER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Farm_Farmer_FARMER_ID",
                        column: x => x.FARMER_ID,
                        principalTable: "Farmer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Farm_FARMER_ID",
                table: "Farm",
                column: "FARMER_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Farm");
        }
    }
}
