using GameSale.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Abstract
{
    internal interface IPlayerService
    {
        void SignUp(PlayersInfo playerInfo);
        void LogIn(PlayersInfo playersInfo);
        void UpdateAccount(PlayersInfo playersInfo);
        void DeleteAccount(PlayersInfo playersInfo);


    }
}
