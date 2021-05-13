using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya listesinden silindi.");
        }

       
        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya listesi kaydedildi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya listesi güncellendi.");
        }

    }
}

