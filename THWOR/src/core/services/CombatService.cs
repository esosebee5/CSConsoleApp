using System;
using System.Collections.Generic;
using System.Text;
using THWOR.src.characters;
using THWOR.src.housewithoneroom;
using THWOR.src.items;

namespace THWOR.src.core.services
{
    class CombatService
    {
        public static string Attack(SimpleMonster monster)
        {
            int damage;
            int weaponDamage;
            string message = $"You miss the {monster.name} with your attack.";

            damage = DiceRoller.getDamage();
            if (damage > 0)
            {
                weaponDamage = damage * Game.Player.getDamageModifier();
                List<DamageType> damageTypes = Game.Player.getDamageTypes();
                int damageDealt = monster.takeDamage(weaponDamage, damageTypes);
                message = $"You hit the {monster.name} for {damageDealt} damage.";
            }

            return message;
        }

        public static string Defend(SimpleMonster monster)
        {
            int damage;
            int weaponDamage;
            string message = $"The {monster.name} misses you with its attack.";

            damage = DiceRoller.getDamage();
            if (damage > 0)
            {
                weaponDamage = damage * monster.getStrength();
                Game.Player.takeDamage(weaponDamage);
                message = $"The {monster.name} hit you for {weaponDamage} damage."; ;
            }

            return message;
        }







        //public static void attack(Player user, Player npc)
        //{
        //    int damage;
        //    int weaponDamage;

        //    damage = DiceRoller.getDamage();
        //    weaponDamage = damage * getDamageModifier(user);
        //    npc.takeDamage(weaponDamage);
        //    outputLn("You hit " + npc.getName() +
        //            " for " + weaponDamage + " damage.\n" +
        //            npc.getName() + "'s health is now " + npc.getHealth() + ".");
        //}

        //public static void defend(Player user, Player npc)
        //{
        //    int damage;
        //    int weaponDamage;

        //    damage = DiceRoller.getDamage();
        //    weaponDamage = damage * getDamageModifier(npc);
        //    user.takeDamage(weaponDamage);
        //    outputLn(npc.getName() + " hit you for " +
        //            weaponDamage + " damage.\n" +
        //            "Your health is now " + user.getHealth() + ".");
        //}
    }
}
