using GameSale.Abstract;
using GameSale.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Concrete
{
    internal class GameManager : IGameService
    {
       

        public void GameBuy(PlayersInfo playersInfo, Game game, Campaign campaign)
        {
            double gamePrice = (game.GamePrice * campaign.CampaignDiscount) /100;
            Console.WriteLine(playersInfo.PlayerNickName +" Kullanıcı adlı oyuncu "+ campaign.CampaignName+" kampanyası ile " + game.GameName +" isimli oyunu satın aldı. Tutar: "+ gamePrice);
        }

        public void GameGiveBack(PlayersInfo playersInfo, Game game)
        {
            Console.WriteLine(playersInfo.PlayerNickName + " Kullanıcı adlı oyuncu " + game.GameName + " isimli oyunu iade etti");
        }


    }
}
