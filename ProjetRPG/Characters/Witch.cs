﻿using ProjetRPG;
using ProjetRPG.Stones;
using ProjetRPG.Stones.InfinityStones;
using ProjetRPG.Characters;
using ProjetRPG.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetRPG
{
    class Witch : Ennemy
    {
        #region Variables

        protected int mana; //energie d'attaque de la Sorcière
        protected int spirit; //regen Mana

        #endregion

        #region Constructeurs

        public Witch()
        {
            name = "Sorcière pathétique";
            lifePoints = 10;
            maxLifePoints = lifePoints;
            force = 1;
            stamina = 3;
            mana = 6;
            spirit = 4;
            drop = DropType();
        }

        #endregion

        #region Methodes
        
        public virtual void Spell(Fighter cible)
        {
            cible.lifePoints -= spirit;
            mana -= spirit;
        }

        public void Heal()
        {
            lifePoints += spirit;
        }

        public void RegenMana()
        {
            mana += spirit/2;
        }

        public override void Attack(Fighter cible)
        {
            if (mana - spirit < 0)
                base.Attack(cible);
            else
                Spell(cible);
        }

        #endregion
    }
}
