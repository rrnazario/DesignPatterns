﻿using DesignPatterns.Composition.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composition.Model
{
    /// <summary>
    /// Showing how composition are made. To add more attacks, insert an item on "CharacterEnums.TypeAttack",
    /// add a property to check if the instance is able to perform the new attack and add another property
    /// to return the new attack damage.
    /// </summary>
    public class Character
    {
        private Dictionary<CharacterEnums.TypeAttack, int> Attacks { get; set; }

        public bool CanBite => Attacks.ContainsKey(CharacterEnums.TypeAttack.Bit);
        public bool CanKick => Attacks.ContainsKey(CharacterEnums.TypeAttack.Kick);
        public bool CanPunch => Attacks.ContainsKey(CharacterEnums.TypeAttack.Punch);

        public int PunchDamage
        {
            get
            {
                if (!CanPunch)
                    throw new NotSupportedException("This attack is not available");

                return Attacks[CharacterEnums.TypeAttack.Punch];
            }
        }

        public int KickDamage
        {
            get
            {
                if (!CanKick)
                    throw new NotSupportedException("This attack is not available");

                return Attacks[CharacterEnums.TypeAttack.Kick];
            }
        }

        public int BiteDamage
        {
            get
            {
                if (!CanBite)
                    throw new NotSupportedException("This attack is not available");

                return Attacks[CharacterEnums.TypeAttack.Bit];
            }
        }

        public Character()
        {
            Attacks = new Dictionary<CharacterEnums.TypeAttack, int>();
        }
        public Character(CharacterEnums.TypeAttack attack, int damage) : this()
        {
            AddAttack(attack, damage);
        }

        public Character(Dictionary<CharacterEnums.TypeAttack, int> attacks)
        {
            Attacks = attacks;
        }

        public void AddAttack(CharacterEnums.TypeAttack attack, int damage)
        {
            if (!Attacks.ContainsKey(attack))
                Attacks.Add(attack, damage);
            else 
                Attacks[attack] = damage;
        }
    }    
}
