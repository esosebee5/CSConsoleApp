namespace THWOR.src.items.itemBase
{
    abstract class WeaponBase : ItemBase, IWeapon
    {
        private readonly int Damage;
        private readonly DamageType DamageType;
        private readonly string AttackVerb;

        public WeaponBase(
            string name,
            string description,
            int size,
            int damage,
            DamageType damageType,
            string attackVerb)
            : base(name, description, size)
        {
            Damage = damage;
            DamageType = damageType;
            AttackVerb = attackVerb;
        }

        public int GetDamage()
        {
            return Damage;
        }

        public DamageType GetDamageType()
        {
            return DamageType;
        }

        public string GetAttackVerb()
        {
            return AttackVerb;
        }
    }
}
