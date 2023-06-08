using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoShop_Dal.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    imgSrc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseProducts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BaseProducts",
                columns: new[] { "Id", "Discriminator", "Name", "Price", "imgSrc" },
                values: new object[,]
                {
                    { 1, "Candle", "Candle1", 80m, "https://ik.imagekit.io/i8gs619wfp/1.jfif?updatedAt=1685827454525" },
                    { 2, "Candle", "Candle2", 90m, "https://ik.imagekit.io/i8gs619wfp/2.jpeg?updatedAt=1685827454853" },
                    { 3, "Candle", "Candle3", 100m, "https://ik.imagekit.io/i8gs619wfp/3.jpg?updatedAt=1685827454580" },
                    { 4, "Candle", "Candle4", 110m, "https://ik.imagekit.io/i8gs619wfp/4.jfif?updatedAt=1685827454594" },
                    { 5, "Candle", "Candle5", 120m, "https://ik.imagekit.io/i8gs619wfp/5.jfif?updatedAt=1685827454567" },
                    { 6, "Filter", "Filter1", 80m, "https://ik.imagekit.io/i8gs619wfp/1_1_.jfif?updatedAt=1685827457946" },
                    { 7, "Filter", "Filter2", 90m, "https://ik.imagekit.io/i8gs619wfp/2_2_.jpg?updatedAt=1685827458352" },
                    { 8, "Filter", "Filter3", 100m, "https://ik.imagekit.io/i8gs619wfp/3.jfif?updatedAt=1685827457943" },
                    { 9, "Filter", "Filter4", 110m, "https://ik.imagekit.io/i8gs619wfp/4_1_.jfif?updatedAt=1685827457685" },
                    { 10, "Filter", "Filter5", 120m, "https://ik.imagekit.io/i8gs619wfp/5_2_.jfif?updatedAt=1685827457863" },
                    { 11, "Oil", "Oil1", 80m, "https://ik.imagekit.io/i8gs619wfp/1_1_.jpg?updatedAt=1685827460666" },
                    { 12, "Oil", "Oil2", 90m, "https://ik.imagekit.io/i8gs619wfp/2_3_.jpg?updatedAt=1685827460895" },
                    { 13, "Oil", "Oil3", 100m, "https://ik.imagekit.io/i8gs619wfp/3_2_.jpg?updatedAt=1685827460952" },
                    { 14, "Oil", "Oil4", 110m, "https://ik.imagekit.io/i8gs619wfp/4_1_.jpg?updatedAt=1685827460517" },
                    { 15, "Oil", "Oil5", 120m, "https://ik.imagekit.io/i8gs619wfp/5_1_.jpg?updatedAt=1685827460692" },
                    { 16, "Pad", "Pad1", 80m, "https://ik.imagekit.io/i8gs619wfp/1.jpg?updatedAt=1685827454696" },
                    { 17, "Pad", "Pad2", 90m, "https://ik.imagekit.io/i8gs619wfp/2.jpg?updatedAt=1685827454879" },
                    { 18, "Pad", "Pad3", 100m, "https://ik.imagekit.io/i8gs619wfp/3.jpeg?updatedAt=1685827454840" },
                    { 19, "Pad", "Pad4", 110m, "https://ik.imagekit.io/i8gs619wfp/4.png?updatedAt=1685827455133" },
                    { 20, "Pad", "Pad5", 120m, "https://ik.imagekit.io/i8gs619wfp/5_1_.jfif?updatedAt=1685827454582" },
                    { 21, "Wiper", "Wiper1", 80m, "https://ik.imagekit.io/i8gs619wfp/2_1_.jpg?updatedAt=1685827457778" },
                    { 22, "Wiper", "Wiper2", 90m, "https://ik.imagekit.io/i8gs619wfp/5.jpg?updatedAt=1685827457699" },
                    { 23, "Wiper", "Wiper3", 100m, "https://ik.imagekit.io/i8gs619wfp/1.webp?updatedAt=1685827457985" },
                    { 24, "Wiper", "Wiper4", 110m, "https://ik.imagekit.io/i8gs619wfp/3_1_.jpg?updatedAt=1685827457654" },
                    { 25, "Wiper", "Wiper5", 120m, "https://ik.imagekit.io/i8gs619wfp/4.jpg?updatedAt=1685827457551" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseProducts");
        }
    }
}
