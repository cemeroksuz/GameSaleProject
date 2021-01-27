using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Entitiy;
using GameSaleProject.Abstract;

namespace GameSaleProject.Concrete
{
    class GameManager :IGameService , ICampaingService
    {
        public void AddNewCampaign(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanya Eklendi (" + campaign.CampaignName+")");
        }

        public void CampaignApply(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Kampanya Görüntülendi");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Adlı Kampanya Silindi");
        }
      
        public void GameBuy(PlayersInfo player, Game game, Campaign campaign)
        {
            Console.WriteLine(player.Name+" Adlı oyuncu "+game.GameName+" Adlı oyunu "+ campaign.CampaignName+" kampayasında satın aldı");
        }

        public void GameGiveBack(PlayersInfo player, Game game)
        {
            Console.WriteLine(player.Name + " Adlı oyuncu" + game.GameName + " adlı oyunu iade etti");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
