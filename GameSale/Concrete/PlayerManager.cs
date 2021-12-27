using GameSale.Abstract;
using GameSale.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Concrete
{
    internal class PlayerManager : IPlayerService
    {
        public void DeleteAccount(PlayersInfo playersInfo)
        {
            Console.WriteLine(playersInfo.PlayerNickName + " adlı kullanıcın hesabı silindi.");
        }

        public void LogIn(PlayersInfo playersInfo)
        {
            Console.WriteLine(playersInfo.PlayerNickName + " adlı kullanıcı oturum açtı.");
        }

        public void SignUp(PlayersInfo playersInfo)
        {
            if(playersInfo.PlayerNickName == "Myth" && playersInfo.Password == "123456")
            {
                Console.WriteLine("Doğrulama İşlemi Başarılı. " +playersInfo.PlayerNickName + " adlı kullanıcı kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Doğrulama İşlemi Başarısız.");
            }
        }

        public void UpdateAccount(PlayersInfo playersInfo)
        {
            Console.WriteLine(playersInfo.PlayerNickName + " adlı kullanıcının bilgileri güncellendi.");
        }
    }
}
