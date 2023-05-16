using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AromaShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class addSpecificationTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Specification_SpecificationId",
                table: "ProductSpecifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specification",
                table: "Specification");

            migrationBuilder.RenameTable(
                name: "Specification",
                newName: "Specifications");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specifications",
                table: "Specifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Specifications_SpecificationId",
                table: "ProductSpecifications",
                column: "SpecificationId",
                principalTable: "Specifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecifications_Specifications_SpecificationId",
                table: "ProductSpecifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Specifications",
                table: "Specifications");

            migrationBuilder.RenameTable(
                name: "Specifications",
                newName: "Specification");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Specification",
                table: "Specification",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecifications_Specification_SpecificationId",
                table: "ProductSpecifications",
                column: "SpecificationId",
                principalTable: "Specification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
