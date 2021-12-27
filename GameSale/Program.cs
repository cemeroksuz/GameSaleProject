using GameSale.Concrete;
using GameSale.Entity;
using System;
using System.Collections.Generic;

namespace GameSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayersInfo player1 = new PlayersInfo() { PlayerId = 1, PlayerFirstName = "Cem", PlayerLastname = "Eröksüz", PlayerBirthDate = new DateTime(1993, 12, 13), Password="123456", PlayerIdentityNumber="12345678910", PlayerNickName="Myth"};
            PlayersInfo player2= new PlayersInfo() { PlayerId = 2, PlayerFirstName = "Murat", PlayerLastname = "Üstünova", PlayerBirthDate = new DateTime(1995, 1, 12), Password="741236", PlayerIdentityNumber="10987654321", PlayerNickName="Flatcher"};
            PlayersInfo player3 = new PlayersInfo() { PlayerId = 3, PlayerFirstName = "Mustafa", PlayerLastname = "Saka", PlayerBirthDate = new DateTime(1996, 5, 20), Password="654321", PlayerIdentityNumber="578514148932", PlayerNickName="Thindy"};

            PlayerManager playerManager = new PlayerManager();
            playerManager.SignUp(player1);
            playerManager.SignUp(player2);
            playerManager.LogIn(player1);

            Game game1 = new Game() { GameId = 1, GameName = "CS:GO", GamePrice = 70, GameType = "FPS" };
            Game game2 = new Game() { GameId = 2, GameName = "GTA V", GamePrice = 160, GameType = "TPS" };
            Game game3 = new Game() { GameId = 3, GameName = "Forza 5", GamePrice = 350, GameType = "Race" };           

            Campaign campaignWinter = new Campaign() { CampaignId = 1, CampaignName = "Winter", CampaignDiscount = 25 };
            Campaign campaignSummer = new Campaign() { CampaignId = 2, CampaignName = "Summer", CampaignDiscount = 35 };
            Campaign campaignLegend = new Campaign() { CampaignId = 3, CampaignName = "Legend", CampaignDiscount = 50 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddNewCampaign(campaignWinter);
            campaignManager.AddNewCampaign(campaignSummer);
            campaignManager.AddNewCampaign(campaignLegend);

            GameManager gameManager = new GameManager();
            gameManager.GameBuy(player1, game2, campaignWinter);
            gameManager.GameBuy(player2, game1, campaignSummer);
            gameManager.GameBuy(player3, game3, campaignLegend);

            gameManager.GameGiveBack(player1, game2);

            List<PlayersInfo> players = new List<PlayersInfo>();
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            List<Game> games = new List<Game>();
            games.Add(game1);
            games.Add(game2);
            games.Add(game3);

            List<Campaign> campaigns = new List<Campaign>();
            campaigns.Add(campaignWinter);
            campaigns.Add(campaignSummer);
            campaigns.Add(campaignLegend);

            playerManager.DeleteAccount(player3);
            playerManager.UpdateAccount(player1);

            campaignManager.DeleteCampaign(campaignWinter);
            campaignManager.UpdateCampaign(campaignLegend);
            


        }
    }
}
