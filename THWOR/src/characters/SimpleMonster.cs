using System;
using System.Collections.Generic;
using System.Text;
using THWOR.src.core.services;
using THWOR.src.items;

namespace THWOR.src.characters
{
    class SimpleMonster
    {
        #region Java code

        //private String name;
        //private int health;
        //private int strength;
        //private String weakness;
        //private boolean dead;
        //private String pronoun;
        ////    private ArrayList<iItem> items;

        //public SimpleMonster(String name, int health, int strength, String weakness)
        //{

        //    // Gremlin, Goblin, Orc, Troll, etc.
        //    this.name = name;

        //    // Damage multiplier value
        //    this.strength = strength;

        //    // Weakness
        //    this.weakness = weakness;

        //    this.health = health;
        //    this.dead = false;
        //    this.setPronoun(name);
        //}

        //private void setPronoun(String name)
        //{
        //    if (Shared.startsWithVowel(name))
        //    {
        //        this.pronoun = "an";
        //    }
        //    else
        //    {
        //        this.pronoun = "a";
        //    }
        //}

        //public String getPronoun()
        //{
        //    return this.pronoun;
        //}

        //public int takeDamage(int damage, ArrayList<String> damageTypes)
        //{
        //    for (String damageType : damageTypes)
        //    {
        //        if (damageType.equals(weakness))
        //        {
        //            damage = damage * 2;
        //        }
        //    }
        //    this.health = this.health - damage;
        //    if (this.health <= 0)
        //    {
        //        this.health = 0;
        //        this.dead = true;
        //    }
        //    return damage;
        //}

        //public boolean isDead()
        //{
        //    return this.dead;
        //}

        //public int getStrength()
        //{
        //    return this.strength;
        //}

        //public String getName()
        //{
        //    return this.name;
        //}

        ///**
        // * The pronoun + name combo ("an orc")
        // * @return
        // */
        //public String getNameLong()
        //{
        //    return this.pronoun + " " + this.name;
        //}

        #endregion

        public readonly string name;
        private int health;
        private int strength;
        private DamageType weakness;
        private bool dead;
        private string adjective;
        ////    private ArrayList<iItem> items;

        public SimpleMonster(string name, int health, int strength, DamageType weakness)
        {

            // Gremlin, Goblin, Orc, Troll, etc.
            this.name = name;

            // Damage multiplier value
            this.strength = strength;

            // Weakness
            this.weakness = weakness;

            this.health = health;
            dead = false;
            SetAdjective(name);
        }

        private void SetAdjective(string name)
        {
            if (IO.StartsWithVowel(name))
            {
                adjective = "an";
            }
            else
            {
                adjective = "a";
            }
        }

        public int takeDamage(int damage, List<DamageType> damageTypes)
        {
            foreach (DamageType damageType in damageTypes)
            {
                if (damageType == weakness)
                {
                    damage *= 2;
                }
            }
            health -= damage;
            if (health <= 0)
            {
                health = 0;
                dead = true;
            }
            return damage;
        }

        public bool isDead()
        {
            return dead;
        }

        public int getStrength()
        {
            return strength;
        }

        public string getName()
        {
            return name;
        }

        /// <summary>
        /// The adjective + name combo ("an orc")
        /// </summary>
        /// <returns></returns>
        public string getNameLong()
        {
            return adjective + " " + name;
        }
    }
}
