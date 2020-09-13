using THWOR.src.items.itemBase;

namespace THWOR.src.items
{
    class Knife : WeaponBase
    {
        #region Java Code


        //private String name = "knife";
        //private String description = "A small, sharp, folding " +
        //        "pocketknife with a wooden handle.";
        //private int size = 1;
        //private int damage = 2;
        //private String damageType = "blade";

        //public Knife() { }


        //public String getName()
        //{
        //    return name;
        //}

        //public String getDescription()
        //{
        //    return description;
        //}

        //public double getSize()
        //{
        //    return size;
        //}

        ////    public String getStats() {
        ////        return "Name: " + this.getName() +
        ////                "\nDamage: " + this.getDamage() +
        ////                "\nSize: " + Double.toString(this.getSize());
        ////    }

        //public String toStringShort()
        //{
        //    return "a " + this.name;
        //}

        //public int getDamage()
        //{
        //    return damage;
        //}

        //public String getDamageType()
        //{
        //    return damageType;
        //}


        ////    public String getAttackVerb() {
        ////        return "slash";
        ////    }

        #endregion

        public Knife(
            string name = "knife",
            string description = "A small, sharp, folding pocketknife with a wooden handle.",
            int size = 1,
            int damage = 2,
            DamageType damageType = DamageType.Blade,
            string attackVerb = "slash")
            : base(name, description, size, damage, damageType, attackVerb)
        { }
    }
}