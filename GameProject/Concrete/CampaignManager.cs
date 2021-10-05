using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService

    {
        public void add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyasi eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyasi silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "kampanyasi guncellendi");
        }
    }
}
