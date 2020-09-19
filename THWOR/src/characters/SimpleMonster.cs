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
        public readonly string deathMessage;
        private int health;
        private int strength;
        private readonly List<DamageType> weaknesses;
        private bool dead;
        private string adjective;
        ////    private ArrayList<iItem> items;

        public SimpleMonster(
            string _name,
            int _health,
            int _strength,
            List<DamageType> _weaknesses,
            string _deathMessage = null
        )
        {
            // Gremlin, Goblin, Orc, Troll, etc.
            name = _name;

            // Damage multiplier value
            strength = _strength;

            // Weakness
            weaknesses = new List<DamageType>();
            foreach (DamageType weakness in _weaknesses)
            {
                weaknesses.Add(weakness);
            }

            health = _health;
            dead = false;
            SetAdjective(_name);

            if (_deathMessage != null && _deathMessage.Length > 0)
            {
                deathMessage = _deathMessage;
            }
            else
            {
                deathMessage = $"You have slain the {name}.";
            }
        }

        //public SimpleMonster(string name, int health, int strength, List<DamageType> _weaknesses)
        //{
        //    new SimpleMonster(name, health, strength, _weaknesses, null);
        //}

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
                var weakness = weaknesses.Find(x => x == damageType);
                if (weakness != DamageType.NONE)
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
