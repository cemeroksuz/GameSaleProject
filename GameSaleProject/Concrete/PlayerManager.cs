using System;
using System.Collections.Generic;
using System.Text;
using GameSaleProject.Entitiy;
using GameSaleProject.Abstract;

namespace GameSaleProject.Concrete
{
    public class PlayerManager : IPlayerService
    {


        public void DeleteAccount(PlayersInfo playersInfo)
        {
            Console.WriteLine(playersInfo.Name + " İsimli Kullanıcı Silindi.");
        }

        public void Login(PlayersInfo playersInfo)
        {
            Console.WriteLine(playersInfo.Name + " İsimli  Giriş Yaptı.");
        }

        public void SignUp(PlayersInfo playersInfo)
        {
            if (playersInfo.Birthday < 1993 && playersInfo.IdentityNo.Length == 1234)
            {
                Console.WriteLine(playersInfo.Name + " " + playersInfo.Surname + " Doğrulama İşlemi Başarılı.Kayıt Olunduz.");
            }
            else
            {
                Console.WriteLine("Malesef Doğrulama Yapılamadı. Kayıt Başarısız");
            }
        }

        public void UpdateAccaount(PlayersInfo playersInfo)
        {
            Console.WriteLine(playersInfo.Name + " İsimli Kullanıcı güncelleme işlemi yaptı.");
        }


    }
}
