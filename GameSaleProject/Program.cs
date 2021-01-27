using System;
using System.Collections.Generic;
using GameSaleProject.Concrete;
using GameSaleProject.Entitiy;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersInfo player1 = new PlayersInfo() { Name = "Cem", Surname = "Eröksüz", Birthday = 1993, IdentityNo = "123456789", Password = "1234" };
            PlayersInfo player2 = new PlayersInfo() { Name = "Engin", Surname = "Demiroğ", Birthday = 1985, IdentityNo = "987654321", Password = "4321" };
            PlayersInfo player3 = new PlayersInfo() { Name = "Can", Surname = "Baran", Birthday = 1998, IdentityNo = "963258741", Password = "1111" };

            PlayerManager playerManager = new PlayerManager();
            playerManager.SignUp(player1);
            playerManager.SignUp(player3);
            playerManager.Login(player1);

            Game game1 = new Game() { GameName = "CS:GO", GamePrice = 75 };
            Game game2 = new Game() { GameName = "GTA", GamePrice = 180 };
            Game game3 = new Game() { GameName = "NFS", GamePrice = 278 };

            Campaign winter = new Campaign() { CampaignName = "Winter", CampaignType = "%25" };
            Campaign summer = new Campaign() { CampaignName = "Summer", CampaignType = "%35" };
            Campaign legend = new Campaign() { CampaignName = "LegendNovember", CampaignType = "%15" };


            GameManager gameManager = new GameManager();
            gameManager.GameBuy(player1, game2, winter);
            gameManager.GameBuy(player2, game1, legend);

            playerManager.DeleteAccount(player3);



            List<PlayersInfo> players = new List<PlayersInfo>();
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Reverse();



            List<Game> games = new List<Game>();
            games.Add(game1);
            games.Add(game2);
            games.Add(game3);



            List<Campaign> campaigns = new List<Campaign>();
            campaigns.Add(winter);
            campaigns.Add(summer);
            campaigns.Add(legend);
        }
    }
}
