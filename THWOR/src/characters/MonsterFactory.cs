using System;
using System.Collections.Generic;
using System.Text;
using THWOR.src.items;

namespace THWOR.src.characters
{
    class MonsterFactory
    {
        public static SimpleMonster GenerateMonster(MonsterType type)
        {
            return GenerateMonster(type, null);
        }

        public static SimpleMonster GenerateMonster(MonsterType type, string deathMessage)
        {
            SimpleMonster monster = null;
            switch (type)
            {
                case MonsterType.Gremlin:
                    monster = new SimpleMonster
                    (
                        "gremlin",
                        50,
                        5,
                        new List<DamageType> { DamageType.Blade, DamageType.Fire },
                        deathMessage
                    );
                    break;
                case MonsterType.Orc:
                    monster = new SimpleMonster("orc", 50, 5, new List<DamageType> { DamageType.Blade }, deathMessage);
                    break;
                case MonsterType.Wraith:
                    monster = new SimpleMonster("wraith", 100, 10, new List<DamageType> { DamageType.Fire }, deathMessage);
                    break;
            }
            return monster;
        }

        public static SimpleMonster GenerateGremlin()
        {
            return GenerateMonster(MonsterType.Gremlin);
        }

        public static SimpleMonster GenerateWraith()
        {
            return GenerateMonster(MonsterType.Wraith);
        }

        public static SimpleMonster GenerateGuardian()
        {
            return GenerateMonster(MonsterType.Wraith, "The dark form dissolves in a cloud of mist.");
        }
    }
}
