using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Entity
{
    internal class PlayersInfo
    {
        public int PlayerId { get; set; }
        public string PlayerIdentityNumber { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastname { get; set; }
        public string PlayerNickName { get; set; }
        public string Password{ get; set; }
        public DateTime PlayerBirthDate { get; set; }
    }
}
