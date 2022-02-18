using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DelfimTec.Migrations
{
    public partial class PopularProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)/* */
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImageUrl,IsProdutoPreferido,Nome,Preco) VALUES(1,'GALAX - GeForce RTX 3070, 1-Click OC, 8GB GDDR6','Para a série OC, temos um design de ventoinha inovador que cria uma nova tendência no resfriamento da GPU com as ventoinhas gêmeas de 102 mm junto com nossa Fan Blade.',1, 'https://images.kabum.com.br/produtos/fotos/229411/placa-de-video-galax-nvidia-geforce-rtx-3070-1-click-oc-8gb-gddr6-dlss-lhr-ray-tracing-preto-37nsl6md2kch_1631640318_gg.jpg','https://img.terabyteshop.com.br/produto/g/placa-de-video-galax-geforce-rtx-3070-ex-white-1-click-oc-8gb-gddr6-256bit_104212.png', 0 ,'GALAX - RTX 3070 ', 6249.99)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImageUrl,IsProdutoPreferido,Nome,Preco) VALUES(1,'ASUS TUF Gaming - GTX 1660 Super, 6GB GDDR6, OC edition','ASUS TUF Gaming GeForce GTX 1660 Edição OC: Boost Clock 1845 MHz (Modo OC) / 1815 MHz (Modo Gaming) • A GeForce GTX 1660 SUPER é até 20% mais rápida do que a GTX 1660 original',1,'https://images.kabum.com.br/produtos/fotos/211056/placa-de-video-asus-nvidia-geforce-tuf-gtx-1660-super-o6g-gaming-oc-6gb-gddr6-ip5x-preto_1630093241_gg.jpg','https://media.pichau.com.br/media/catalog/product/cache/2f958555330323e505eba7ce930bdf27/t/u/tuf-gtx1660s-o6g-gaming4.jpg',0,'Asus TUF - GTX 1660', 3349.99)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImageUrl,IsProdutoPreferido,Nome,Preco) VALUES(2,'AMD Power Color Radeon RX 6700 XT 12GB DDR6 192 Bitsa','Projetado Para Desempenho E Confiabilidade PowerColor Red Devil RX 6700 XT é equipado com design de ventilador triplo (100 mm x 90 mm x 100 mm).',1,'https://images.kabum.com.br/produtos/fotos/sync_mirakl/157073/Placa-de-V-deo-Powercolor-Red-Devil-RX-6700XT-12GB-GDDR6-HDMI-AXRX-6700XT-12GBD6-3DHE-OC_1642163623_gg.jpg','https://images.kabum.com.br/produtos/fotos/sync_mirakl/157073/Placa-de-V-deo-Powercolor-Red-Devil-RX-6700XT-12GB-GDDR6-HDMI-AXRX-6700XT-12GBD6-3DHE-OC_1642163626_gg.jpg',0,'POWERCOLOR - 6700 XT 12GB', 6799.99)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImageUrl,IsProdutoPreferido,Nome,Preco) VALUES(2,'AMD Power Color Radeon RX 550 4GB Red Dragon','Baseia-se na mais recente arquitetura GCN 4 da AMD, projetada para o GloFo 14nm FinFET, que oferece capacidade premium de VR, maior nível de desempenho.',1,'https://images.kabum.com.br/produtos/fotos/sync_mirakl/175039/Placa-De-V-deo-Powercolor-Radeon-Rx-550-4gb-Red-Dragon_1625250447_gg.jpg','https://images.kabum.com.br/produtos/fotos/sync_mirakl/175039/Placa-De-V-deo-Powercolor-Radeon-Rx-550-4gb-Red-Dragon_1625250451_gg.jpg',1,'POWERCOLOR - Radeon RX 550 4GB', 939.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
