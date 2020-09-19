using THWOR.src.core.models.rooms;
using THWOR.src.core.services;
using THWOR.src.items;
using THWOR.src.titles;
using System.Collections.Generic;
using THWOR.src.characters;

namespace THWOR.src.rooms
{
    abstract class RoomBase : IRoom
    {
        #region Java code

        //public int getId()
        //{
        //    return 0;
        //    //throw new NotImplementedException();
        //}

        //public String getName()
        //{
        //    return "";
        //    //throw new NotImplementedException();
        //}

        //public String getDescription()
        //{
        //    return "";
        //    //throw new NotImplementedException();
        //}

        //public ArrayList<iItem> getItems()
        //{
        //    return null;
        //    //throw new NotImplementedException();
        //}

        //public void removeItemFromItems(iItem item)
        //{
        //    //throw new NotImplementedException();
        //}

        //public void addItemToItems(iItem item)
        //{
        //    //throw new NotImplementedException();
        //}

        //public void performCustomMethods(String[] inputs)
        //{
        //    //        switch (inputs[0]) {
        //    //            case "s":
        //    //            case "search":
        //    //                output(this.search());
        //    //                break;
        //    //            default:
        //    output(GameStrings.PerformCustomMethodsBadInput);
        //    //        }
        //}

        ////    private String search() {
        ////        ArrayList<iItem> itemsInRoom = this.getItems();
        ////        if (itemsInRoom.isEmpty()) {
        ////            return "There are no items to be found here.";
        ////        }
        ////        if (!this.hasBeenSearched) {
        ////            this.hasBeenSearched = true;
        ////        }
        ////        return Shared.appendDescriptionToItemsString(
        ////                RoomDescriptions.defaultSearchDescription, itemsInRoom);
        ////    }

        ///**
        // *
        // * @return null for now because there is no monster yet
        // */
        //public SimpleMonster getMonster()
        //{
        //    return null;
        //}

        //public int go(String direction)
        //{
        //    return -1;
        //}

        //public void attack()
        //{
        //    // First, check if there is a monster to fight
        //    SimpleMonster monster = this.getMonster();
        //    if (monster == null)
        //    {
        //        output(GameStrings.NothingToAttackHereString);
        //        return;
        //    }
        //    else if (monster.isDead())
        //    {
        //        output("The " + monster.getName() + " is dead.");
        //    }
        //    else
        //    {
        //        // If a monster exists, attack it
        //        Shared.attack(monster);
        //        if (monster.isDead())
        //        {
        //            output("You have slain the " + monster.getName() + ".");
        //        }
        //        else
        //        {
        //            // If the monster is still alive, defend against its attack:
        //            Shared.defend(monster);
        //            if (Game.player.isDead())
        //            {
        //                Game.state = false;
        //                output(Game.player.death);
        //            }
        //        }
        //    }
        //}

        #endregion

        #region Properties

        private readonly RoomId Id;
        private readonly string Name;
        private readonly string Description;
        private readonly string FirstSearchDescription;

        protected bool HasBeenSearched;
        protected SimpleMonster monster;
        
        public List<IItem> Inventory;

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public RoomBase(
            RoomId id,
            string name,
            string description,
            string firstSearchDescription,
            bool hasBeenSearched)
        {
            Id = id;
            Name = name;
            Description = description;
            FirstSearchDescription = firstSearchDescription;
            HasBeenSearched = hasBeenSearched;
            Inventory = new List<IItem>();
        }

        #region Room Info

        public RoomId GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public virtual string GetDescription()
        {
            string message = Description;
            if (monster != null)
            {
                if (monster.isDead())
                {
                    message += $"\nThere is a dead {monster.name} here.";
                }
                else
                {
                    message += $"\nThere is {monster.getNameLong()} here.";
                }
            }
            return message;
        }

        #endregion

        #region Inventory Methods

        /*************
         * INVENTORY * 
         *************/

        public List<IItem> GetItems()
        {
            // TODO: refactor this to be smooth
            List<IItem> copy = new List<IItem>();
            foreach (IItem item in Inventory)
            {
                copy.Add(item);
            }
            return copy;
        }

        public bool AddItem(IItem item)
        {
            bool success = false;
            // TODO: validate incoming item
            if (Inventory == null) Inventory = new List<IItem>();
            Inventory.Add(item);
            success = true;
            return success;
        }

        public bool RemoveItem(IItem item)
        {
            bool success = false;
            // TODO: validate incoming item
            // search for item to remove
            // remove the item
            Inventory.Remove(item);
            success = true;
            return success;
        }

        public string SearchBasic(string objectName = null)
        {
            List<IItem> itemsInRoom = GetItems();

            // FLOW::
            // 1) If there are no items in the room, return default "no items to be found" string
            // 2) If the room has been searched, return the default "You see . . ." string appended to the list of the available items.
            // 3) If the room has NOT been searched, return the Room's "first-search-string" appended to the list of the available items.

            // 1
            string searchResults = GameStrings.NoItemsInRoom;

            if (itemsInRoom.Count > 0)
            {
                var itemsStringList = InventoryService.ConvertItemsInListToString(itemsInRoom);
                // 2
                if (HasBeenSearched == true)
                {
                    searchResults = RoomDescriptions.DefaultSearchDescription; // TODO: implement items-to-list
                }

                // 3
                else
                {
                    HasBeenSearched = true;
                    searchResults = FirstSearchDescription; // TODO: implement items-to-list
                }

                searchResults += itemsStringList;
            }
            if (monster != null)
            {
                if (monster.isDead())
                {
                    searchResults += $"\nThere is a dead {monster.name} here.";
                }
                else
                {
                    searchResults += $"\nThere is a {monster.name} here.";
                }
            }
            //        ArrayList<iItem> itemsInRoom = this.getItems();
            //        if (itemsInRoom.isEmpty())
            //        {
            //            return "There are no items to be found here.";
            //        }
            //        if (!this.hasBeenSearched)
            //        {
            //            this.hasBeenSearched = true;
            //            return Shared.appendDescriptionToItemsString(
            //                    this.firstSearchDescription, itemsInRoom);
            //        }

            //        return Shared.appendDescriptionToItemsString(
            //                    RoomDescriptions.defaultSearchDescription, itemsInRoom);
            return searchResults;
        }

        #endregion

        #region Navigation

        /**************
         * NAVIGATION *
         **************/

        //public bool CanLeave()
        //{
        //    var canLeave = true;

        //    if (monster != null && !monster.isDead())
        //    {
        //        DisplayMonsterInPath();
        //        canLeave = false;
        //    }

        //    return canLeave;
        //}

        //protected virtual void DisplayMonsterInPath()
        //{
        //    // if monster
        //    if (monster != null && !monster.isDead())
        //    {
        //        IO.OutputNewLine($"The {monster.name} blocks your path." +
        //                $"\nYou cannot leave while the {monster.name} is alive.");
        //    }
        //}

        /// <summary>
        /// Must be implemented by the individual room
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public abstract RoomId Go(string direction);

        #endregion

        #region Monster/Combat

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SimpleMonster getMonster()
        {
            return monster;
        }

        public string GenerateMonster(string name)
        {
            string message;
            if (monster != null && !monster.isDead())
            {
                message = $"There is already a {monster.name} here.";
            }
            else
            {
                var generateSuccessful = false;
                switch (name)
                {
                    case "gremlin":
                        monster = MonsterFactory.GenerateGremlin();
                        generateSuccessful = true;
                        break;
                }
                if (generateSuccessful)
                {
                    message = $"Generate successful. There is now a {monster.name} here.";
                }
                else
                {
                    message = "Generate unsuccessful. Try again.";
                }
            }
            return message;
        }

        #endregion

        #region CustomMethods

        public abstract void PerformCustomMethods(string[] inputs);

        #endregion
    }
}
