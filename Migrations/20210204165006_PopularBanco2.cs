using Microsoft.EntityFrameworkCore.Migrations;

namespace TESTE01.Migrations
{
    public partial class PopularBanco2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Motoristas(Nome, SobreNome, Endereco, Referencia, Bairro, Numero, Complemento, CEP, Cidade, Estado, Pais, VeiculoId) VALUES ('Jose Carlos', 'Medeiros da silva'   , 'Rua Tatiaia Campos'  , 'Região Oeste. Perto do Mercado Sete', 'Jardim Roseira', 345 , 'Casa de Fundo', '13048-522', 'Campinas'  , 'SP', 'Brasil', 15)");
            migrationBuilder.Sql("INSERT INTO Motoristas(Nome, SobreNome, Endereco, Referencia, Bairro, Numero, Complemento, CEP, Cidade, Estado, Pais, VeiculoId) VALUES ('Clemilson  ', 'Duarte Gonçaves'     , 'Rua Maranhão'        , 'Perto do Bara da Praia'             , 'Centro'        , 1100, ''             , '12300-102', 'Jaguariuna', 'SP', 'Brasil', 15)");
            migrationBuilder.Sql("INSERT INTO Motoristas(Nome, SobreNome, Endereco, Referencia, Bairro, Numero, Complemento, CEP, Cidade, Estado, Pais, VeiculoId) VALUES ('Rosana'     , 'Silveira Alburqueque', 'Rua do Porto Bonito' , 'Rua sem Saida'                      , 'Centro'        ,  765, ''             , '1100-522',  'Santos'    , 'SP', 'Brasil', 13)");
            migrationBuilder.Sql("INSERT INTO Motoristas(Nome, SobreNome, Endereco, Referencia, Bairro, Numero, Complemento, CEP, Cidade, Estado, Pais, VeiculoId) VALUES ('Francisco'  , 'Antonio da Luz'      , 'Rua Miranda Chamuska', ''                                   , 'Jardim Itatiaia', 58,  ''             , '1100-000' , 'São Paulo' , 'SP', 'Brasil', 14)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Motoristas");

        }
    }
}
