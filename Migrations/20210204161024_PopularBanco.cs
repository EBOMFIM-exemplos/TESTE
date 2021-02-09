using Microsoft.EntityFrameworkCore.Migrations;

namespace TESTE01.Migrations
{
    public partial class PopularBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Veiculos(Marca, Modelo, Placa, Eixos) VALUES('SCANIA'  , 'CAMINHÃO TRUCK','GFK-8765',6)");
            migrationBuilder.Sql("INSERT INTO Veiculos(Marca, Modelo, Placa, Eixos) VALUES('MERCEDES', 'CAMINHÃO TRUCK','YHE-8765',5)");
            migrationBuilder.Sql("INSERT INTO Veiculos(Marca, Modelo, Placa, Eixos) VALUES('FORD'    , 'CAMINHÃO TOCO' ,'VCD-1158',4)");
            migrationBuilder.Sql("INSERT INTO Veiculos(Marca, Modelo, Placa, Eixos) VALUES('FORD'    , 'CAMINHÃO'      ,'POI-8943',3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Veiculos");
        }
    }
}
