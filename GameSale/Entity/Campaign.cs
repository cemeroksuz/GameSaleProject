﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSale.Entity
{
    internal class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName{ get; set; }
        public double CampaignDiscount{ get; set; }
    }
}
