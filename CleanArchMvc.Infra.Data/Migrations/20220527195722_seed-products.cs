using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class seedproducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" 
                + "VALUES('Caderno espiral','caderno espiral 100 folhas',7.45,50,'caderno.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)"
               + "VALUES('Borracha','borracha pequena',9,12,'borracha.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)"
               + "VALUES('calculadora','calc simples',50,10,'calc.jpg',2)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)"
               + "VALUES('Mouse sem fio','mouse reddragon',200,5,'mouse.jpg',3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
