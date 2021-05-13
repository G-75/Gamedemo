using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Game game, Campaign campaign)
        {
            int campaignPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);
            Console.WriteLine
                (game.GameName + gamer.FirstName + "tarafından " + campaign.CampaignName + "kampanyasında" + campaignPrice +"satın alındı.");
        }
    }
}
