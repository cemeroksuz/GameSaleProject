using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Entitiy;

namespace GameSaleProject.Abstract
{
    public interface IPlayerService
    {
        void SignUp(PlayersInfo playersInfo);
        void Login(PlayersInfo playersInfo);
        void UpdateAccaount(PlayersInfo playersInfo);
        void DeleteAccount(PlayersInfo playersInfo);
    }
}
