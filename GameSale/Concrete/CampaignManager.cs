using GameSale.Abstract;
using GameSale.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void AddNewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli Kampaya Sisteme Eklendi.");
        }
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli Kampanya Silindi.");
        }
        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli Kampanya Güncellendi.");
        }
    }
}
