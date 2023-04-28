using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Product> GetProduct()
    {
        return new List<Product>()
        {
            new Product
            {
                Id = 1,
                Title = "歧路旅人",
                Description =
                    "《歧路旅人》（日語：オクトパス トラベラー，英語：Octopath Traveler，官方譯為「OCTOPATH TRAVELER 歧路旅人」）是由史克威爾艾尼克斯和Acquire開發的一款電子角色扮演遊戲，於2018年7月13日在任天堂Switch平台發售[2]，後於2019年6月7日推出繁簡中文更新檔[3][4]；也於2019年6月8日透過Steam平台發售支援繁簡中文的Windows版本[5]。遊戲使用虛幻引擎4開發，畫面採用結合復古像素點陣與3DCG的風格，官方稱該風格為「HD-2D」[6]。遊戲的故事發生在奧魯斯特拉（オルステラ，Orsterra）大陸，玩家需要扮演出身迥異，各懷絕技而又各有所求的八名旅人之一，踏上他/她的旅途。",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/zh/1/1a/OCTOPATH_TRAVELER2018_Cover.jpg",
                Price = 9.99m,
            },
            new Product
            {
                Id = 2,
                Title = "最後生還者",
                Description =
                    "《最後生還者》（英語：The Last of Us，又譯作「美國末日」）是由頑皮狗工作室開發，索尼電腦娛樂發行的動作冒險生存恐怖遊戲，於2013年發行。遊戲以被真菌感染者為題材。遊戲設定在末日之後的美國，玩家將操控喬爾，護送少女艾莉橫跨美國，他們在旅程中相扶持作戰以求存活。《最後生還者》以第三人稱視角進行。玩家可使用槍枝和簡易武器，並可以使用潛行來抵禦敵對的人類和被蟲草屬變異真菌感染的食人生物。在多人遊戲模式中，最多8名玩家參與合作和競爭玩法。",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/zh/c/c5/The-last-of-us-cover.png",
                Price = 7.99m,
            },
            new Product
            {
                Id = 3,
                Title = "秘境探險：黃金城秘寶",
                Description =
                    "《秘境探險：黃金城秘寶》（英語：Uncharted: Drake's Fortune，中國大陸譯作「神秘海域：德雷克船長的寶藏」）為頑皮狗所開發的動作冒險遊戲，由索尼互動娛樂發行，為秘境探險系列的首作，其續篇為《秘境探險2：盜亦有道》。2015年在PS4平台推出包含前3代作品的《秘境探險：奈森德瑞克合輯》。",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/zh/5/5b/Uncharted_Drake%27s_Fortune.jpg",
                Price = 6.99m,
            },
        };
    }
}