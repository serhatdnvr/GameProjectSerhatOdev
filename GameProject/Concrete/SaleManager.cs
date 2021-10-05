using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleManager
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName +" "+ gamer.LastName+ " adli oyuncu "+ game.Name+ " ISIMLI oyunu "
                + campaign.Name + " kampanyasini "+ " kullanarak satin almisitir ");
        }
    }
}
