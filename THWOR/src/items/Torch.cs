using THWOR.src.items.itemBase;

namespace THWOR.src.items
{
    class Torch : WeaponBase
    {
        #region Java Code

        //private String name = "torch";
        //private String description = "The torch has a wooden handle " +
        //        "with a cloth wrapped around one end. The cloth is " +
        //        "burning slowly but brightly.";
        //private int size = 1;
        //private int damage = 10;
        //private String damageType = "fire";

        //public Torch() { }

        //public int getDamage()
        //{
        //    return damage;
        //}

        //public String getDamageType()
        //{
        //    return damageType;
        //}

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

        #endregion

        public Torch(
            string name = "torch",
            string description = "The torch has a wooden handle " +
                "with a cloth wrapped around one end. The cloth is " +
                "burning slowly but brightly.",
            int size = 1,
            int damage = 10,
            DamageType damageType = DamageType.Fire,
            string attackVerb = "burn")
            : base(name, description, size, damage, damageType, attackVerb)
        { }
    }
}