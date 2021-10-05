using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Name = "Mount and blade", Price = 60, Stock = 120 };
            Game game2 = new Game() { Name = "football manager 2022", Price = 200, Stock = 320 };
            Gamer gamer1 = new Gamer() { FirstName = "Serhat", LastName="duran", BirthYear=1930,NationaltyId="123" };
            Campaign campaign = new Campaign() { Name = "friday sale", Discount = 20 };

            GameManager gameManager = new GameManager();
            gameManager.add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game1);

            GamerManager gamerManager = new GamerManager();
            gamerManager.add(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.add(gamer1);


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.add(campaign);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, game2, campaign);





        }
    }
}
