using THWOR.src.adventures;
using THWOR.src.characters;
using THWOR.src.core.services;
using THWOR.src.housewithoneroom;
using THWOR.src.items;
using THWOR.src.rooms;
using THWOR.src.titles;

namespace THWOR.src.core.models.rooms
{
    class Library : RoomBase
    {
        #region Java code

        //    //    private final Door[] doors = {new Door(RoomId.STUDY.getId(),
        //    //            "\nStraight ahead in the distance, you see a wooden door.",
        //    //            new String[]{"straight", "ahead", "forward", "forwards"})};

        //    private static final int id = RoomId.LIBRARY.getId();
        //    private static final String name = "Library";
        //    private SimpleMonster monster;
        //    private final String description = RoomDescriptions.library;
        //private final String firstSearchDescription =
        //        RoomDescriptions.libraryFirstSearch;
        //private boolean hasBeenSearched;



        //    public Library()
        //    {
        //        this.hasBeenSearched = false;
        //        this.addItemToItems(new Flashlight());
        //        this.addItemToItems(new Knife());
        //        //        this.items.add(eItem.MATCHES);
        //        this.monster = new SimpleMonster("gremlin", 50, 5, "blade");
        //        if (admin)
        //        {
        //            this.addItemToItems(new Excalibur());
        //        }
        //    }

        //    /***********************
        //     * Getters and setters *
        //     ***********************/

        //    public int getId()
        //    {
        //        return id;
        //    }

        //    public String getName()
        //    {
        //        return name;
        //    }

        //    public String getDescription()
        //    {
        //        String retVal = description;
        //        //        for (Door door : doors) {
        //        //            retVal += door.getDescription();
        //        //        }
        //        if (monster != null)
        //        {
        //            if (monster.isDead())
        //            {
        //                retVal += "\nThere is a dead " + monster.getName() + " here.";
        //            }
        //            else
        //            {
        //                retVal += "\nThere is " + monster.getNameLong() + " here.";
        //            }
        //        }
        //        return retVal;
        //    }

        //    public SimpleMonster getMonster()
        //    {
        //        return this.monster;
        //    }

        //    /******************
        //     * Search methods *
        //     ******************/
        //    private String search()
        //    {
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
        //    }

        //    /******************
        //     * Custom methods *
        //     ******************/
        //    public void performCustomMethods(
        //            String[] inputs)
        //    {
        //        switch (inputs[0])
        //        {
        //            case "b":
        //            case "browse":
        //                LibraryBookshelfAdventure.browseLibrary();
        //                break;
        //            case "r":
        //            case "read":
        //                break;
        //            case "s":
        //            case "search":
        //                output(this.search());
        //                break;
        //            default:
        //                output(GameStrings.PerformCustomMethodsBadInput);
        //        }
        //    }

        //    /******************
        //     *    Attacking   *
        //     ******************/
        //    //    public void attack() {
        //    //        // First, check if there is a monster to fight
        //    //        if (monster == null) {
        //    //            output(GameStrings.NothingToAttackHereString);
        //    //            return;
        //    //        } else if (monster.isDead()) {
        //    //            output("The " + monster.getName() + " is dead.");
        //    //        } else {
        //    //            // If a monster exists, attack it
        //    //            Shared.attack(monster);
        //    //            if (monster.isDead()) {
        //    //                output("You have slain the " + monster.getName() + ".");
        //    //            } else {
        //    //                // If the monster is still alive, defend against its attack:
        //    //                Shared.defend(monster);
        //    //                if (Game.player.isDead()) {
        //    //                    Game.state = false;
        //    //                    output(Game.player.death);
        //    //                }
        //    //            }
        //    //        }
        //    //    }

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private readonly RoomId[] Neighbors = {
            RoomId.Study
        };

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public Library(
            RoomId id = RoomId.Library,
            string name = RoomDescriptions.LibraryName,
            string description = RoomDescriptions.Library,
            string firstSearchDescription = RoomDescriptions.LibraryFirstSearch,
            bool hasBeenSearched = false)
            : base(id, name, description, firstSearchDescription, hasBeenSearched)
        {
            AddItem(new Knife());
            AddItem(new Flashlight());
            if (Game.admin == true)
            {
                AddItem(new Excalibur());
            }
            monster = new SimpleMonster("gremlin", 50, 5, DamageType.Blade);
        }

        #region Navigation

        /**************
         * NAVIGATION *
         **************/

        public override RoomId Go(string direction)
        {
            var roomId = RoomId.NoRoom;
            switch (direction)
            {
                case "ahead":
                case "forward":
                case "forwards":
                case "straight":
                    roomId = Neighbors[0];
                    break;
            }
            return roomId;
        }

        #endregion

        #region Monster/Combat

        // So far, all of this is handled by RoomBase

        #endregion

        #region CustomMethods

        public override void PerformCustomMethods(string[] inputs)
        {
            switch (inputs[0])
            {
                case "b":
                case "browse":
                    LibraryBookshelfAdventure.BrowseLibrary();
                    break;
                case "r":
                case "read":
                    // was there ever anything here?
                    IO.OutputNewLine("'Read' not implemented.");
                    break;
                case "s":
                case "search":
                    IO.OutputNewLine(SearchBasic());
                    break;
                default:
                    IO.OutputNewLine(GameStrings.PerformCustomMethodsBadInput);
                    break;
            }


            //        switch (inputs[0])
            //        {
            //            case "b":
            //            case "browse":
            //                LibraryBookshelfAdventure.browseLibrary();
            //                break;
            //            case "r":
            //            case "read":
            //                break;
            //            case "s":
            //            case "search":
            //                output(this.search());
            //                break;
            //            default:
            //                output(GameStrings.PerformCustomMethodsBadInput);

        }

        #endregion
    }
}