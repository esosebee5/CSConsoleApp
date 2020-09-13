namespace THWOR.src.items
{
    interface IWeapon
    {
        #region Java Code

        //   /**
        //*
        //* @return the item's damage
        //*/
        //   int getDamage();

        //   /**
        //    *
        //    * @return type of damage
        //    */
        //   String getDamageType();

        //   /**
        //    *
        //    * @return the item's attack verb
        //    */
        //   //    String getAttackVerb();

        #endregion

        /// <summary>
        /// Returns the amount of damage that this weapon can inflict
        /// </summary>
        /// <returns></returns>
        int GetDamage();

        /// <summary>
        /// Returns the type of damage inflicted by this weapon
        /// -> TODO: make this an enum
        /// </summary>
        /// <returns></returns>
        DamageType GetDamageType();

        /// <summary>
        /// Returns the item's attack verb
        /// </summary>
        /// <returns></returns>
        string GetAttackVerb();
    }
}
