﻿using DereckRPG.entities.bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DereckRPG.entities
{
    public class Monster : EtreVivant
    {
        private List<Items> loot;

        public List<Items> Loot
        {
            get { return loot; }
            set { loot = value; }
        }
    }
}
