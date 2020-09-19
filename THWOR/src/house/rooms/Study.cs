using THWOR.src.core.services;
using THWOR.src.housewithoneroom;
using THWOR.src.items;
using THWOR.src.titles;

namespace THWOR.src.rooms
{
    class Study : RoomBase
    {
        #region Java code

        //    //    private final Door[] doors = {
        //    //            new Door(RoomId.HALL.getId(), "\nOn your left, beside the desk, is a dark-colored door.",
        //    //                    new String[]{"left"}, new HallKey(), true),
        //    //            new Door(RoomId.LIBRARY.getId(), "\nBehind you is the door to the library.",
        //    //                    new String[]{"back", "backward", "backwards"})};

        //    private static final int id = RoomId.STUDY.getId();
        //    private static final String name = "Study";
        //private boolean hasBeenSearched = false;
        //    private boolean deskHasBeenSearched = false;
        //    private boolean fireplaceHasBeenSearched = false;
        //    private boolean hallDoorIsLocked = true;
        //    private final int[] neighbors = {
        //    RoomId.LIBRARY.getId(), RoomId.HALL.getId()};

        //    private final String description = RoomDescriptions.study;
        //private final String firstSearchDescription = 
        //        RoomDescriptions.studyFirstSearch;
        //private final String deskFirstSearchDescription = 
        //        RoomDescriptions.studyDeskFirstSearch;
        //private final String deskOtherSearchDescription = 
        //        RoomDescriptions.studyDeskOtherSearch;
        //private final String fireplaceFirstSearchDescription = 
        //        RoomDescriptions.studyFireplaceFirstSearch;
        //private final String fireplaceOtherSearchDescription = 
        //        RoomDescriptions.studyFireplaceOtherSearch;

        ///**
        // * Constructor for the Study
        // */
        //public Study() { }

        //    /***********************
        //     * Getters and setters *
        //     ***********************/

        //    private boolean getHasBeenSearched()
        //    {
        //        return this.hasBeenSearched;
        //    }
        //    private void setHasBeenSearched()
        //    {
        //        if (!this.hasBeenSearched)
        //        {
        //            this.hasBeenSearched = true;
        //            //starts as false but can never go back
        //        }
        //    }
        //    private boolean getDeskHasBeenSearched()
        //    {
        //        return this.deskHasBeenSearched;
        //    }
        //    private void setDeskHasBeenSearched()
        //    {
        //        if (!this.deskHasBeenSearched)
        //        {
        //            this.deskHasBeenSearched = true;
        //            this.addItemToItems(new HallKey());
        //        }
        //    }
        //    private boolean getFireplaceHasBeenSearched()
        //    {
        //        return this.fireplaceHasBeenSearched;
        //    }
        //    private void setFireplaceHasBeenSearched()
        //    {
        //        if (!this.fireplaceHasBeenSearched)
        //        {
        //            this.fireplaceHasBeenSearched = true;
        //            this.addItemToItems(new Message());
        //        }
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
        //        if (!this.getHasBeenSearched())
        //        {
        //            this.setHasBeenSearched();
        //            return Shared.appendDescriptionToItemsString(
        //                    this.firstSearchDescription, itemsInRoom);
        //        }
        //        return Shared.appendDescriptionToItemsString(
        //                    RoomDescriptions.defaultSearchDescription, itemsInRoom);
        //    }
        //    private String search(String[] inputs)
        //    {
        //        if (inputs[1] == null)
        //        {
        //            return "Bad input; try again.";
        //        }
        //        switch (inputs[1])
        //        {
        //            case "desk":
        //                return this.searchDesk();
        //            case "fireplace":
        //            case "fp":
        //                return this.searchFireplace();
        //            default:
        //                return "Bad input; try again.";
        //        }
        //    }
        //    private String searchDesk()
        //    {
        //        if (!this.getDeskHasBeenSearched())
        //        {
        //            this.setDeskHasBeenSearched();
        //            return this.deskFirstSearchDescription;
        //        }
        //        return this.deskOtherSearchDescription;
        //    }
        //    private String searchFireplace()
        //    {
        //        if (!this.getFireplaceHasBeenSearched())
        //        {
        //            this.setFireplaceHasBeenSearched();
        //            return this.fireplaceFirstSearchDescription;
        //        }
        //        return this.fireplaceOtherSearchDescription;
        //    }

        //    /******************
        //     * Custom methods *
        //     ******************/

        //    public void performCustomMethods(String[] inputs)
        //    {
        //        switch (inputs[0])
        //        {
        //            case "s":
        //            case "search":
        //                if (inputs.length > 1)
        //                {
        //                    output(this.search(inputs));
        //                }
        //                else
        //                {
        //                    output(this.search());
        //                }
        //                break;
        //            case "u":
        //            case "unlock":
        //                tryUnlockingDoor(inputs);
        //                break;
        //            default:
        //                output(GameStrings.PerformCustomMethodsBadInput);
        //        }
        //    }

        //    /*****************
        //     *    MOVEMENT   *
        //     *****************/

        //    private int tryMovingIntoHall()
        //    {
        //        if (!this.hallDoorIsLocked)
        //        {
        //            return this.neighbors[1];
        //        }
        //        else
        //        {
        //            output(GameStrings.DoorIsLocked);
        //            return -2;
        //        }
        //    }

        //    /**
        //     * unlocks the door to the hall if the player has the right key equipped
        //     */
        //    private void tryUnlockingDoor(String[] inputs)
        //    {
        //        // Validate input
        //        if (inputs.length == 1)
        //        {
        //            output("What would you like to unlock?");
        //        }
        //        else if (inputs.length == 2)
        //        {
        //            if (inputs[1].equals("door"))
        //            {
        //                output("Which door would you like to unlock?");
        //            }
        //            else
        //            {
        //                output(GameStrings.PerformCustomMethodsBadInput);
        //            }
        //        }
        //        else if (inputs.length == 3)
        //        {
        //            if (inputs[1].equals("left"))
        //            {
        //                if (inputs[2].equals("door"))
        //                {
        //                    unlockHallDoor();
        //                }
        //                else
        //                {
        //                    output("try: 'unlock left door'");
        //                }
        //            }
        //            else
        //            {
        //                output(GameStrings.PerformCustomMethodsBadInput);
        //            }
        //        }
        //        else
        //        {
        //            output(GameStrings.PerformCustomMethodsBadInput);
        //        }

        //    }

        //    private void unlockHallDoor()
        //    {
        //        //check hands for black key
        //        if (Game.player.getRHand() != null && Game.player.getRHand() instanceof iKey) {
        //            iKey key = (iKey)Game.player.getRHand();
        //            if (key.unlocks() == neighbors[1])
        //            {
        //                Game.player.setRHand(null);
        //                output("You use the black key to unlock the door on the left.");
        //                this.hallDoorIsLocked = false;
        //            }
        //        } else if (Game.player.getLHand() != null && Game.player.getLHand() instanceof iKey) {
        //            iKey key = (iKey)Game.player.getLHand();
        //            if (key.unlocks() == neighbors[1])
        //            {
        //                Game.player.setLHand(null);
        //                output("You use the black key to unlock the door on the left.");
        //                this.hallDoorIsLocked = false;
        //            }
        //        } else
        //        {
        //            output("You do not have the right key equipped.");
        //        }
        //    }

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private readonly RoomId[] Neighbors = {
            RoomId.Library, 
            RoomId.Hall
        };
        private bool HallDoorIsLocked = true;
        private bool DeskHasBeenSearched = false;
        private bool FireplaceHasBeenSearched = false;
        private readonly string DeskFirstSearchDescription = RoomDescriptions.StudyDeskFirstSearch;
        private readonly string DeskOtherSearchDescription = RoomDescriptions.StudyDeskOtherSearch;
        private readonly string FireplaceFirstSearchDescription = RoomDescriptions.StudyFireplaceFirstSearch;
        private readonly string FireplaceOtherSearchDescription = RoomDescriptions.StudyFireplaceOtherSearch;

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public Study(
            RoomId id = RoomId.Study,
            string name = RoomDescriptions.StudyName,
            string description = RoomDescriptions.Study,
            string firstSearchDescription = RoomDescriptions.StudyFirstSearch,
            bool hasBeenSearched = false)
            : base(id, name, description, firstSearchDescription, hasBeenSearched)
        {
            // TODO: anything here?

            // Note: special searches are implemented as room-methods
        }

        #region Inventory Methods

        /*************
         * INVENTORY * 
         *************/

        public string Search(string objectName)
        {
            string returnMessage = GameStrings.BadInput;

            if (objectName != null)
            {
                switch (objectName)
                {
                    case "desk":
                        returnMessage = SearchDesk();
                        break;
                    case "fireplace":
                    case "fp":
                        returnMessage = SearchFireplace();
                        break;
                }
            }

            return returnMessage;
        }

        private string SearchDesk()
        {
            string returnMessage = DeskOtherSearchDescription;

            if (!DeskHasBeenSearched)
            {
                DeskHasBeenSearched = true;
                AddItem(new HallKey());
                returnMessage = DeskFirstSearchDescription;
            }

            return returnMessage;
        }

        private string SearchFireplace()
        {
            string returnMessage = FireplaceOtherSearchDescription;

            if (!FireplaceHasBeenSearched)
            {
                FireplaceHasBeenSearched = true;
                AddItem(new Message());
                returnMessage = FireplaceFirstSearchDescription;
            }

            return returnMessage;
        }

        #endregion

        #region Navigation

        /**************
         * NAVIGATION *
         **************/

        public override RoomId Go(string direction)
        {
            var roomId = RoomId.NoRoom;
            switch (direction)
            {
                case "left":
                    roomId = TryMovingIntoHall();
                    break;
                case "back":
                case "backward":
                case "backwards":
                    roomId = Neighbors[0];
                    break;
            }
            return roomId;
        }

        private RoomId TryMovingIntoHall()
        {
            RoomId retVal;
            if (HallDoorIsLocked)
            {
                retVal = RoomId.RoomIsLocked;
            }
            else
            {
                retVal = Neighbors[1];
            }
            return retVal;
        }

        /// <summary>
        /// Unlocks the door to the hall if the player has the right key equipped
        /// </summary>
        /// <param name="inputs"></param>
        private string TryUnlockingDoor(string[] inputs)
        {
            string returnMessage = GameStrings.PerformCustomMethodsBadInput;

            // Validate input
            if (inputs.Length == 1)
            {
                returnMessage = "What would you like to unlock?";
            }
            else if (inputs.Length == 2)
            {
                if (inputs[1].ToLower().Equals("door"))
                {
                    returnMessage = "Which door would you like to unlock?";
                }
            }

            // Valid input must be this format: "{keyword} {door color} door"
            // . . . a.k.a. "unlock black door"
            else if (inputs.Length == 3)
            {
                if (inputs[1].ToLower().Equals("black"))
                {
                    if (inputs[2].ToLower().Equals("door"))
                    {
                        returnMessage = UnlockHallDoor();
                    }
                    else
                    {
                        returnMessage = "try: 'unlock black door'";
                    }
                }
            }

            return returnMessage;
        }

        private string UnlockHallDoor()
        {
            string returnMessage = GameStrings.CorrectKeyNotEquipped;

            //check hands for black key
            if (Game.Player.GetRHand() != null && Game.Player.GetRHand() is IKey keyRH)
            {
                if (keyRH.Unlocks() == Neighbors[1])
                {
                    Game.Player.SetRHand(null);
                    HallDoorIsLocked = false;
                }
            }
            else if (Game.Player.GetLHand() != null && Game.Player.GetLHand() is IKey keyLH)
            {
                if (keyLH.Unlocks() == Neighbors[1])
                {
                    Game.Player.SetLHand(null);
                    HallDoorIsLocked = false;
                }
            }
            
            if (!HallDoorIsLocked)
            {
                returnMessage = "You use the black key to unlock the black door.";
            }

            return returnMessage;
        }

        #endregion

        #region Monster/Combat

        ///**
        // * If the room itself contains a monster, this returns a reference to that monster
        // * Used to decide if the player is able to leave a room
        // * @return reference to the monster contained by the room
        // */
        //SimpleMonster getMonster();

        // TODO: probably shouldn't be void...?
        //public void Attack()
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        #region CustomMethods

        public override void PerformCustomMethods(string[] inputs)
        {
            switch (inputs[0])
            {
                case "s":
                case "search":
                    if (inputs.Length > 1)
                    {
                        IO.OutputNewLine(Search(inputs[1]));
                    }
                    else
                    {
                        IO.OutputNewLine(SearchBasic());
                    }
                    break;
                case "u":
                case "unlock":
                    IO.OutputNewLine(TryUnlockingDoor(inputs));
                    break;
                default:
                    IO.OutputNewLine(GameStrings.PerformCustomMethodsBadInput);
                    break;
            }
        }

        #endregion
    }
}
