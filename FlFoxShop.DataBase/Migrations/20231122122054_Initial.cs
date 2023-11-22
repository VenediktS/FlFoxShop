using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FlFoxShop.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shop_Brands",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shop_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shop_Product_Purposes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shop_Product_Purposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shop_Textile_Types",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shop_Textile_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shop_Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shop_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "shop_Textiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Color = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    TextileBase = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    DrawingTextDescription = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    SmallDescription = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    VendorCode = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    BrendId = table.Column<long>(type: "bigint", nullable: true),
                    ProductPurposeId = table.Column<long>(type: "bigint", nullable: true),
                    ProductPurposeId1 = table.Column<int>(type: "integer", nullable: true),
                    BrandId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateddById = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shop_Textiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_shop_Textiles_shop_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "shop_Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_shop_Textiles_shop_Product_Purposes_ProductPurposeId1",
                        column: x => x.ProductPurposeId1,
                        principalTable: "shop_Product_Purposes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_shop_Textiles_shop_Users_CreateddById",
                        column: x => x.CreateddById,
                        principalTable: "shop_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_shop_Textiles_shop_Users_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "shop_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_shop_Textiles_BrandId",
                table: "shop_Textiles",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_shop_Textiles_CreateddById",
                table: "shop_Textiles",
                column: "CreateddById");

            migrationBuilder.CreateIndex(
                name: "IX_shop_Textiles_ProductPurposeId1",
                table: "shop_Textiles",
                column: "ProductPurposeId1");

            migrationBuilder.CreateIndex(
                name: "IX_shop_Textiles_UpdatedById",
                table: "shop_Textiles",
                column: "UpdatedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shop_Textile_Types");

            migrationBuilder.DropTable(
                name: "shop_Textiles");

            migrationBuilder.DropTable(
                name: "shop_Brands");

            migrationBuilder.DropTable(
                name: "shop_Product_Purposes");

            migrationBuilder.DropTable(
                name: "shop_Users");
        }
    }
}
