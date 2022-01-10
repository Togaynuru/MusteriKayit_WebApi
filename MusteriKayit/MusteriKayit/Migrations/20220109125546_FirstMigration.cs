using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusteriKayit.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dogumYeri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firmaSorumlusu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ceptel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    kayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    düzenlemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
