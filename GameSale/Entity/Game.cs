﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Entity
{
    internal class Game
    {
        public int GameId { get; set; }
        public string GameName{ get; set; }
        public string GameType { get; set; }
        public double GamePrice{ get; set; }

    }
}
