using System;
using System.Collections.Generic;
using System.Text;

namespace THWOR.src.core.services
{
    class DiceRoller
    {
        #region Java code

        //static Random rand = new Random();

        //public static int getValue1to10()
        //{
        //    return rand.nextInt(10);
        //}

        //public static int getValue1to5()
        //{
        //    return rand.nextInt(5);
        //}

        //public static int getDamage()
        //{
        //    return getValue1to5();
        //}

        #endregion

        static readonly Random rand = new Random();

        public static int getValue1to10()
        {
            return getRandomValue(10);
        }

        public static int getValue1to5()
        {
            return getRandomValue(5);
        }

        private static int getRandomValue(int max)
        {
            return rand.Next(max);
        }

        public static int getDamage()
        {
            return getValue1to5();
        }
    }
}
