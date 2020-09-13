using THWOR.src.items.itemBase;

namespace THWOR.src.items
{
    class Excalibur : WeaponBase
    {
        #region Java Code

        ////    private int numAttacks;

        //public Excalibur()
        //{
        //    //        this.numAttacks = 0;
        //}


        //public String getName()
        //{
        //    return "sword";
        //}


        //public String getDescription()
        //{
        //    return "The sword has strange runes carved into the blade and a dark jewel set into the pommel.";
        //}


        //public double getSize()
        //{
        //    return 0;
        //}


        ////    public String getStats() {
        ////        return "Name: EXCALIBVR\n"
        ////                + "Damage: " + this.getDamage() + "\n"
        ////                + "Size: " + Double.toString(this.getSize())
        ////                + "\nThis item requires the use of both hands.";
        ////    }


        //public String toStringShort()
        //{
        //    return "a shining sword";
        //}


        //public int getDamage()
        //{
        //    return 20;
        //}

        //public String getDamageType()
        //{
        //    return "blade";
        //}


        ////    public String getAttackVerb() {
        ////        this.numAttacks++;
        ////        if (this.numAttacks % 3 == 0) {
        ////            return "stab";
        ////        }
        ////        return "slash";
        ////    }

        #endregion

        public Excalibur(
            string name = "sword",
            string description = "The sword has strange runes carved into the blade and a dark jewel set into the pommel.",
            int size = 0,
            int damage = 20,
            DamageType damageType = DamageType.Blade,
            string attackVerb = "slash")
            : base(name, description, size, damage, damageType, attackVerb)
        { }

        // TODO: can this be implemented at all? an overload, maybe?
        ////    public String getAttackVerb() {
        ////        this.numAttacks++;
        ////        if (this.numAttacks % 3 == 0) {
        ////            return "stab";
        ////        }
        ////        return "slash";
        ////    }
    }
}
