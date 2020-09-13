using THWOR.src.core.services;
using THWOR.src.items;
using THWOR.src.titles;
using System.Collections.Generic;

namespace THWOR.src.characters
{
    class Player
    {
        #region Java code

        //public void setName(string name) { this._name = name; }
        //public string getGender() { return this._gender; }
        //public string[] getPronouns()
        //{
        //    return this.pronouns;
        //}
        //private void setGender(string gender)
        //{
        //    switch (gender.toLowerCase())
        //    {
        //        case "female":
        //        case "f":
        //            this._gender = "Female";
        //            this.pronouns = female;
        //            break;
        //        default:
        //            this._gender = "Male";
        //            this.pronouns = male;
        //    }
        //}
        //public int getHealth() { return this._health; }
        //public void setHealth(int newHealth) { this._health = newHealth; }
        //public bool isDead()
        //{
        //    return this.dead;
        //}

        //public ArrayList<iItem> getItemsInHands()
        //{
        //    //        eItem[] retVal = {this.getLHand(), this.getRHand()};
        //    ArrayList<iItem> retVal = new ArrayList<>();
        //    retVal.add(rHand);
        //    retVal.add(lHand);
        //    return retVal;
        //}

        //public iItem getRHand()
        //{
        //    return this.rHand;
        //}
        //public void setRHand(iItem item)
        //{
        //    this.rHand = item;
        //}

        //public iItem getLHand()
        //{
        //    return this.lHand;
        //}
        //public void setLHand(iItem item)
        //{
        //    this.lHand = item;
        //}

        //public int getNumberOfEmptyHands()
        //{
        //    int count = 2;
        //    if (this.getRHand() != null)
        //    {
        //        count--;
        //    }
        //    if (this.getLHand() != null)
        //    {
        //        count--;
        //    }
        //    return count;
        //}

        //// only gets called by a limitedInventory method; no conditions required
        //public double getPocketSpaceRemaining()
        //{
        //    double space = 4.0;
        //    for (iItem item : this.pockets)
        //    {
        //        if (item != null)
        //        {
        //            space = space - item.getSize();
        //        }
        //    }
        //    return space;
        //}

        //public bool takeItem(iItem item)
        //{
        //    if (this.addItemToInventory(item))
        //    {
        //        output("You take the " + item.getName() + ".");
        //        return true;
        //    }
        //    output("You don't have enough space in your inventory for that item.");
        //    return false;
        //}

        //private bool addItemToInventory(iItem item)
        //{
        //    if (this._inventory == null)
        //    {
        //        this._inventory = new ArrayList<>();
        //    }
        //    if (limitedInventory)
        //    {
        //        if (item.getSize() <= this._remainingInventorySpace)
        //        {
        //            //                if (this._inventory == null) {
        //            //                    this._inventory = new ArrayList<>();
        //            //                }
        //            this._inventory.add(item);
        //            this._remainingInventorySpace -= item.getSize();
        //            return true;
        //        }
        //    }
        //    else
        //    {
        //        //            if (this._inventory == null) {
        //        //                this._inventory = new ArrayList<>();
        //        //            }
        //        this._inventory.add(item);
        //        return true;
        //    }
        //    return false;
        //}

        //private bool removeItemFromInventory(iItem item)
        //{
        //    if (this.getInventory().contains(item))
        //    {
        //        this._inventory.remove(item);
        //        if (limitedInventory)
        //        {
        //            this._remainingInventorySpace += item.getSize();
        //        }
        //        return true;
        //    }
        //    return false;
        //}

        //public ArrayList<iItem> getInventory()
        //{
        //    if (this._inventory == null || this._inventory.isEmpty())
        //    {
        //        this._inventory = new ArrayList<>();
        //    }
        //    return this._inventory;
        //}
        //public void setInventory(ArrayList<iItem> items)
        //{
        //    if (items == null)
        //    {
        //        this._inventory = new ArrayList<>();
        //    }
        //    this._inventory = items;
        //}

        //public string showInventory()
        //{
        //    if (this._inventory == null)
        //    {
        //        return "Null inventory??";
        //    }
        //    if (this._inventory.isEmpty())
        //    {
        //        return "You have no items in your inventory.";
        //    }
        //    string inventory = "Player inventory:\n" + Shared.convertItemsInListToString(this._inventory);
        //    if (limitedInventory)
        //    {
        //        inventory += "\nRemaining space: " + Double.toString(this._remainingInventorySpace);
        //    }
        //    return inventory;
        //}

        //public iItem dropItem(string itemName)
        //{
        //    if (this.getInventory() == null || this.getInventory().isEmpty())
        //    {
        //        return null;
        //    }
        //    for (iItem item : this._inventory)
        //    {
        //        if (item.getName().equals(itemName))
        //        {
        //            this.removeItemFromInventory(item);
        //            return item;
        //        }
        //    }
        //    return null;
        //}

        //public string equip(iItem item)
        //{
        //    if (this.getRHand() == null)
        //    {
        //        this.setRHand(item);
        //        this.removeItemFromInventory(item);
        //        return "You are now holding the " + item.getName() + " in your right hand.";
        //    }
        //    else if (this.getLHand() == null)
        //    {
        //        this.setLHand(item);
        //        this.removeItemFromInventory(item);
        //        return "You are now holding the " + item.getName() + " in your left hand.";
        //    }
        //    else
        //    {
        //        return "You do not have a free hand.";
        //    }
        //}

        //public bool pocket(string itemName)
        //{
        //    if ((this.getRHand() != null) && (this.getRHand().getName().equals(itemName)))
        //    {
        //        iItem item = this.getRHand();
        //        if (this.addItemToInventory(item))
        //        {
        //            this.setRHand(null);
        //            output("You pocketed the " + itemName + ".");
        //            return true;
        //        }
        //        output("You don't have space in your inventory to pocket that item.");
        //        return false;
        //    }
        //    else if ((this.getLHand() != null) && (this.getLHand().getName().equals(itemName)))
        //    {
        //        iItem item = this.getLHand();
        //        if (this.addItemToInventory(item))
        //        {
        //            this.setLHand(null);
        //            output("You pocketed the " + itemName + ".");
        //            return true;
        //        }
        //        output("You don't have space in your inventory to pocket that item.");
        //        return false;
        //    }
        //    else
        //    {
        //        output("You do not have that item equipped.");
        //        return false;
        //    }
        //}



        //public void takeDamage(int damage)
        //{
        //    int newHealth = this.getHealth() - damage;
        //    if (newHealth <= 0)
        //    {
        //        this.setHealth(0);
        //        this.dead = true;
        //    }
        //    else
        //    {
        //        this.setHealth(newHealth);
        //    }
        //}






        //public string showStats()
        //{
        //    string stats = "Name: " + this._name + "\n" +
        //            "Gender: " + this._gender + "\n" +
        //            "Health: " + this._health;
        //    if (limitedInventory)
        //    {
        //        stats += "\nInventory: " + this._inventorySize;
        //    }
        //    return stats;
        //}

        //public string showCharacterReport()
        //{
        //    string report = "Character report for " + this._name + ":\n"
        //            + "Gender: " + this._gender + "\n"
        //            + "Health: " + this._health + "\n"
        //            + inHandToString();
        //    if (limitedInventory)
        //    {
        //        report += "Pocket space: " + this.getPocketSpaceRemaining() + "\n"
        //                + "Inventory size: " + this._inventorySize + "\n";
        //    }
        //    report += this.showInventory();
        //    return report;
        //}









        //private string inHandToString()
        //{
        //    string retVal = "Empty hands: " + this.getNumberOfEmptyHands() + "\n";
        //    iItem lHandItem = this.getLHand();
        //    if (lHandItem != null)
        //    {
        //        retVal += "You are holding the " + lHandItem.getName() + " in your left hand.\n";
        //    }
        //    iItem rHandItem = this.getRHand();
        //    if (rHandItem != null)
        //    {
        //        retVal += "You are holding the " + rHandItem.getName() + " in your right hand.\n";
        //    }
        //    return retVal;
        //}

        #endregion

        #region Properties

        private string _name;
        public string GetName() { return _name; }
        private Gender _gender;
        //private string[] pronouns;
        //private string[] male = { "Mister", "He", "His", "His" };// TODO: move to GameStrings
        //private string[] female = { "Miss", "She", "Her", "Hers" };// TODO: move to GameStrings
        private int _health;
        private List<IItem> _inventory;
        private IItem lHand = null;
        private IItem rHand = null;
        public string death = "You are dead."; // TODO: rename "DeathMessage" & store in GameStrings?
        private bool dead;
        public bool isDead()
        {
            return _health <= 0;
        }

        //private bool limitedInventory = false;
        /**
         * Not dealing with inventory space atm.
         * Bottomless. Congrats.
         */
        //private iItem[] pockets = new iItem[4];
        private int _backpackSpaceAvailable = 0;
        //this size is relative, not universal.
        private int _inventorySize;
        //private int _remainingInventorySpace;

        #endregion

        /// <summary>
        /// Constructor (testing/admin constructor; all params)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="genderString"></param>
        /// <param name="health"></param>
        /// <param name="deathMessage"></param>
        public Player(string name, string genderString, int health, string deathMessage)
        {
            _name = name;
            SetGender(genderString);
            _health = health;
            death = deathMessage;
            dead = false;
        }

        /// <summary>
        /// Constructor (main constructor - minimum params)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="genderString"></param>
        public Player(string name, string genderString)
        {
            _name = name;
            SetGender(genderString);
            _health = 100; // TODO: set up min health int value somewhere
            // TODO: set up default death message somewhere

            dead = false;
            _inventory = new List<IItem>();
            //if (limitedInventory)
            //{
            //    _inventorySize = getPocketSpaceRemaining() + _backpackSpaceAvailable;
            //    _remainingInventorySpace = _inventorySize;
            //}
        }

        /// <summary>
        /// Selects the correct Gender enum based on the input string
        /// </summary>
        /// <param name="gender"></param>
        private void SetGender(string gender)
        {
            switch (gender.ToLower())
            {
                case "female":
                case "f":
                    _gender = Gender.Female;
                    //pronouns = female;
                    break;
                default:
                    _gender = Gender.Male;
                    //pronouns = male;
                    break;
            }
        }

        /// <summary>
        /// Displays full character report
        /// </summary>
        /// <returns></returns>
        public string ShowCharacterReport()
        {
            string report = "Character report for " + this._name + ":\n"
                    + "Gender: " + this._gender + "\n"
                    + "Health: " + this._health + "\n"
                    + InHandToString();
            //if (limitedInventory)
            //{
            //    report += "Inventory size: " + this._inventorySize + "\n";
            //    //report += "Pocket space: " + this.getPocketSpaceRemaining() + "\n"
            //    //        + "Inventory size: " + this._inventorySize + "\n";
            //}
            ////report += this.showInventory();
            return report;
        }

        /// <summary>
        /// Displays simplified character report
        /// </summary>
        /// <returns></returns>
        public string ShowStats()
        {
            string stats = "Name: " + _name + "\n" +
                    "Gender: " + _gender + "\n" +
                    "Health: " + _health;
            //if (limitedInventory)
            //{
            //    stats += "\nInventory: " + _inventorySize;
            //}
            return stats;
        }

        #region Inventory

        public bool TakeItem(IItem item)
        {
            if (this.AddItemToInventory(item))
            {
                IO.OutputNewLine("You take the " + item.GetName() + ".");
                return true;
            }
            IO.OutputNewLine("You don't have enough space in your inventory for that item.");
            return false;
        }

        private bool AddItemToInventory(IItem item)
        {
            if (_inventory == null)
            {
                _inventory = new List<IItem>();
            }
            //if (limitedInventory)
            //{
            //    if (item.GetSize() <= _remainingInventorySpace)
            //    {
            //        _inventory.Add(item);
            //        _remainingInventorySpace -= item.GetSize();
            //        return true;
            //    }
            //}
            //else
            //{
                _inventory.Add(item);
                return true;
            //}
            //return false;
        }

        private bool RemoveItemFromInventory(IItem item)
        {
            var retVal = false;
            if (_inventory.Contains(item))
            {
                _inventory.Remove(item);
                //if (limitedInventory)
                //{
                //    this._remainingInventorySpace += item.getSize();
                //}
                retVal = true;
            }
            return retVal;
        }

        //public List<IItem> GetInventory()
        //{
        //    if (_inventory == null || _inventory.Count == 0)
        //    {
        //        _inventory = new List<IItem>();
        //    }
        //    return _inventory;
        //}
        public void SetInventory(List<IItem> items)
        {
            if (items == null)
            {
                _inventory = new List<IItem>();
            }
            _inventory = items;
        }

        public IItem Drop(string itemName)
        {
            if (_inventory == null || _inventory.Count == 0)
            {
                return null;
            }
            foreach (IItem item in _inventory)
            {
                if (item.GetName().Equals(itemName))
                {
                    RemoveItemFromInventory(item);
                    return item;
                }
            }
            return null;
        }

        public string ShowInventory()
        {
            string inventory = "You have no items in your inventory.";
            if (_inventory == null)
            {
                // This is an error state, and a confusing one
                inventory = "Null inventory??";
            }
            else if (_inventory.Count > 0)
            {
                inventory = "Player inventory:\n" + InventoryService.ConvertItemsInListToString(_inventory);
                //if (limitedInventory)
                //{
                //    inventory += "\nRemaining space: " + Double.toString(_remainingInventorySpace);
                //}
            }
            return inventory;
        }

        public string Equip(string itemName)
        {
            string returnMessage = GameStrings.NotInInventory;

            // Validate item
            IItem item = InventoryService.SearchForItemInListByName(itemName, _inventory);
            if (item != null)
            {
                returnMessage = "You do not have a free hand.";
                bool itemEquipped = false;

                // Try right hand
                if (GetRHand() == null)
                {
                    SetRHand(item);
                    itemEquipped = true;
                    returnMessage = "You are now holding the " + item.GetName() + " in your right hand.";
                }
                // Try left hand
                else if (GetLHand() == null)
                {
                    SetLHand(item);
                    itemEquipped = true;
                    returnMessage = "You are now holding the " + item.GetName() + " in your left hand.";
                }
                // If equip was successful, remove from inventory
                if (itemEquipped)
                {
                    RemoveItemFromInventory(item);
                }
            }

            return returnMessage;
        }

        public string Pocket(string itemName)
        {
            string returnMessage = GameStrings.NotEquipped;

            IItem rHItem = GetRHand();
            IItem lHItem = GetLHand();
            if ((rHItem != null) && rHItem.GetName().ToLower().Equals(itemName))
            {
                if (AddItemToInventory(rHItem))
                {
                    SetRHand(null);
                    returnMessage = "You pocket the " + itemName + ".";
                }
                else
                {
                    returnMessage = "You don't have space in your inventory to pocket that item.";
                }
            }
            else if ((lHItem != null) && lHItem.GetName().ToLower().Equals(itemName))
            {
                if (AddItemToInventory(lHItem))
                {
                    SetLHand(null);
                    returnMessage = "You pocket the " + itemName + ".";
                }
                else
                {
                    returnMessage = "You don't have space in your inventory to pocket that item.";
                }
            }

            return returnMessage;
        }

        /// <summary>
        /// View the description of an equipped item.
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns></returns>
        public string View(string itemName)
        {
            string returnMessage = GameStrings.NotEquipped;

            IItem item = InventoryService.SearchForItemInListByName(itemName, GetItemsInHands());
            if (item != null)
            {
                returnMessage = item.GetDescription();
            }

            return returnMessage;
        }

        private string InHandToString()
        {
            string retVal = "";
            string rHMessage = "";
            string lHMessage = "";
            int numEmptyHands = GetNumberOfEmptyHands();
            if (numEmptyHands > 0)
            {
                retVal += "Empty hands: " + numEmptyHands;
                // This is the only time we will see an "empty hands" message AND an "in-hand" message.
                if (numEmptyHands == 1)
                {
                    retVal += "\n";
                }
            }
            IItem lHandItem = GetLHand();
            if (lHandItem != null)
            {
                lHMessage = "In your left hand, you are holding the " + lHandItem.GetName() + ".";
            }
            IItem rHandItem = GetRHand();
            if (rHandItem != null)
            {
                rHMessage = "In your right hand, you are holding the " + rHandItem.GetName() + ".";
            }

            // Splice in possible left hand:
            if (lHMessage.Length > 0)
            {
                retVal += lHMessage;
            }
            // Splice in possible right hand:
            if (rHMessage.Length > 0)
            {
                // Add space if a left hand message exists.
                if (lHMessage.Length > 0)
                {
                    retVal += "\n";
                }
                retVal += rHMessage;
            }
            return retVal;
        }

        public List<IItem> GetItemsInHands()
        {
            List<IItem> retVal = new List<IItem>
            {
                rHand,
                lHand
            };
            return retVal;
        }

        public IItem GetRHand()
        {
            return rHand;
        }
        public void SetRHand(IItem item)
        {
            rHand = item;
        }

        public IItem GetLHand()
        {
            return lHand;
        }
        public void SetLHand(IItem item)
        {
            lHand = item;
        }

        public int GetNumberOfEmptyHands()
        {
            int count = 2;
            if (GetRHand() != null)
            {
                count--;
            }
            if (GetLHand() != null)
            {
                count--;
            }
            return count;
        }

        #endregion

        #region Combat

        /// <summary>
        /// Calculates the total damage from whatever weapons the player has equipped
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int getDamageModifier()
        {
            int retVal = 1;
            if (GetRHand() != null && GetRHand() is IWeapon rhWeapon) {
                retVal += rhWeapon.GetDamage();
            }
            if (GetLHand() != null && GetLHand() is IWeapon lhWeapon)
            {
                retVal += lhWeapon.GetDamage();
            }
            return retVal;
        }

        /**
         * Check equipped items for damage types
         * @param player
         * @return
         */
        public List<DamageType> getDamageTypes()
        {
            List<DamageType> retVal = new List<DamageType>();
            if (GetRHand() != null && GetRHand() is IWeapon rhWeapon)
            {
                retVal.Add(rhWeapon.GetDamageType());
            }
            if (GetLHand() != null && GetLHand() is IWeapon lhWeapon)
            {
                retVal.Add(lhWeapon.GetDamageType());
            }
            return retVal;
        }

        public int takeDamage(int damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                _health = 0;
                dead = true;
            }
            return _health;
        }

        #endregion
    }
}
