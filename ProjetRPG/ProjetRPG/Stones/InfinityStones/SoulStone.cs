﻿using ProjetRPG;
using ProjetRPG.Stones;
using ProjetRPG.Stones.InfinityStones;
using ProjetRPG.Characters;
using ProjetRPG.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG.Stones.InfinityStones
{
    class SoulStone : InfinityStone
    {
        #region Constructeurs

        public SoulStone()
        {
            name = "Pierre de l'Âme";
            invIndex = 4;
            power = 5;
            stoneLifePoints = 5;
            stoneForcePoints = 1;
            stoneStaminaPoints = 3;
            description = "Un des six Pierres d'Infinité.\nAméliore votre santé maximal de " + stoneLifePoints +
                " points, votre force de " + stoneForcePoints + " points, et votre endurance de " + stoneStaminaPoints + " points." +
                "\nAttaque spéciale : inflige " + power * 4 + " points de dégâts à l'adversaire et " + power + " à vous-même.";
            type = StoneType.Infinity;
        }

        #endregion
    }
}
