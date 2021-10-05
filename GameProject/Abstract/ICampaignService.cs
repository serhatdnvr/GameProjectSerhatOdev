using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampaignService
    {
        void add(Campaign campaign);
        void Delete(Campaign campaign);

        void Update(Campaign campaign);
    }
}
