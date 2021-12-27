using GameSale.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Abstract
{
    internal interface IGameService
    {
        void GameBuy(PlayersInfo playersInfo, Game game, Campaign campaign);
        void GameGiveBack(PlayersInfo playersInfo, Game game);
     
        
    }
}
