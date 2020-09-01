using THWOR.src.core.services;
using THWOR.src.items;
using THWOR.src.titles;

namespace THWOR.src.rooms
{
    class Hall : RoomBase
    {
        #region Java code

        //    private static final int id = RoomId.HALL.getId();
        //    private static final String name = "Hall";
        //private boolean hasBeenSearched = false;
        //    private boolean guardianIsAngry = false;
        //    private boolean guardianIsDead = false;
        //    private boolean computerRoomIsLocked = true;
        //    private final String computerRoomPassword = "CoconutCavalry";
        //private int guardianHealth;
        //    private final int[] neighbors = {RoomId.STUDY.getId(), RoomId.DININGROOM.getId(),
        //        RoomId.COMPUTERROOM.getId(), RoomId.UPSTAIRSHALLWAY.getId()};

        //    private final String description = RoomDescriptions.hall;
        //private final String guardianAliveSearch = 
        //        RoomDescriptions.hallFirstSearch;
        //private final String roomSearch =
        //        RoomDescriptions.hallOtherSearch;

        //public Player guardian;

        //    /**
        //     * Constructor for the Hall
        //     */
        //    public Hall()
        //    {
        //        this.guardianHealth = 1;
        //        this.guardian = new Player("The Guardian", 100,
        //                "The dark form dissolves in a cloud of mist.");
        //        this.addItemToItems(new Torch());
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
        //        return this.description;
        //    }

        //    private boolean getHasBeenSearched()
        //    {
        //        return this.hasBeenSearched;
        //    }
        //    private void setHasBeenSearched()
        //    {
        //        if (!this.hasBeenSearched)
        //        {
        //            this.hasBeenSearched = true;
        //        }
        //    }
        //    private boolean getGuardianIsAngry()
        //    {
        //        return this.guardianIsAngry;
        //    }
        //    private void setGuardianIsAngry()
        //    {
        //        if (!this.guardianIsAngry)
        //        {
        //            this.guardianIsAngry = true;
        //        }
        //    }

        //    /******************
        //     * Search methods *
        //     ******************/
        //    private String search()
        //    {
        //        if (!this.getHasBeenSearched())
        //        {
        //            this.setHasBeenSearched();
        //            if (!this.guardianIsDead)
        //            {
        //                this.setGuardianIsAngry();
        //                return this.guardianAliveSearch;
        //            }
        //        }
        //        // ES TEST: I think this clause is unnecessary
        //        //        if (!this.guardianIsDead) {
        //        //            return this.roomSearch;
        //        //        }
        //        ArrayList<iItem> itemsInRoom = this.getItems();
        //        if (itemsInRoom.isEmpty())
        //        {
        //            return "There are no items to be found here.";
        //        }
        //        return this.roomSearch;
        //    }

        //    /******************
        //     * Custom methods *
        //     ******************/

        //    public void performCustomMethods(
        //            String[] inputs)
        //    {
        //        switch (inputs[0])
        //        {
        //            case "keypad":
        //                this.viewKeypad();
        //                break;
        //            case "s":
        //            case "search":
        //                output(this.search());
        //                break;
        //            default:
        //                output(GameStrings.PerformCustomMethodsBadInput);
        //        }
        //    }

        //    /*****************
        //     *    MOVEMENT   *
        //     *****************/

        //    public int go(String direction)
        //    {
        //        if (this.getGuardianIsAngry())
        //        {
        //            output(RoomDescriptions.guardianIsAngryCannotLeave);
        //            return -2;
        //        }
        //        switch (direction)
        //        {
        //            case "ahead":
        //            case "forward":
        //            case "forwards":
        //            case "straight":
        //                return Game.endGame();
        //            case "back":
        //            case "backwards":
        //                return this.neighbors[0];
        //            case "left":
        //                return this.neighbors[1];
        //            case "right":
        //                return tryComputerRoomDoor();
        //            case "up":
        //            case "upstairs":
        //            case "upwards":
        //                return this.neighbors[3];
        //            default:
        //                return -1;
        //        }
        //    }

        //    private int tryComputerRoomDoor()
        //    {
        //        if (!this.computerRoomIsLocked)
        //        {
        //            return this.neighbors[2];
        //        }
        //        output("The door is locked.");
        //        return -2;
        //    }

        //    /******************
        //     *    Attacking   *
        //     ******************/

        //    public void attack()
        //    {
        //        String battleScript = GameStrings.NothingToAttackHereString;
        //        if (!this.guardianIsDead && this.guardianIsAngry)
        //        {
        //            Shared.attack(Game.player, this.guardian);
        //            if (this.guardian.getHealth() == 0)
        //            {
        //                this.guardianIsDead = true;
        //                this.guardianIsAngry = false;
        //                outputLn(guardian.death);
        //            }
        //            else
        //            {
        //                Shared.defend(Game.player, this.guardian);
        //                if (Game.player.getHealth() == 0)
        //                {
        //                    Game.state = false;
        //                    output(Game.player.death);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            outputLn(battleScript);
        //        }
        //    }

        //    /******************
        //     *      Other     *
        //     ******************/

        //    private void viewKeypad()
        //    {
        //        output("There is a simple touch-screen 'QWERTY' keyboard set into the wall. " +
        //                "The screen below it says:");
        //        outputForInput("> ENTER PASSWORD: ");

        //        String password = IOService.getNextLine();
        //        if (password.equals(this.computerRoomPassword))
        //        {
        //            this.computerRoomIsLocked = false;
        //            output("You hear a soft click from the wall behind the keypad.");
        //        }
        //        else
        //        {
        //            output("> INCORRECT PASSWORD");
        //        }
        //    }

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private readonly RoomId[] Neighbors = {
            RoomId.Study,
            RoomId.DiningRoom,
            RoomId.ComputerRoom,
            RoomId.UpstairsHallway
        };
        //private int guardianHealth;

        private bool ComputerRoomIsLocked = true;
        private readonly string ComputerRoomPassword = "CoconutCavalry";
        private readonly string description = RoomDescriptions.Hall;
        private readonly string guardianAliveSearch = RoomDescriptions.hallFirstSearch;
        private readonly string roomSearch = RoomDescriptions.hallOtherSearch;

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public Hall(
            RoomId id = RoomId.Hall,
            string name = RoomDescriptions.HallName,
            string description = RoomDescriptions.Hall,
            string firstSearchDescription = RoomDescriptions.DefaultSearchDescription,
            //string firstSearchDescription = RoomDescriptions.hallFirstSearch,
            bool hasBeenSearched = false)
            : base(id, name, description, firstSearchDescription, hasBeenSearched)
        {
            AddItem(new Torch());
        }

        #region Navigation

        /**************
         * NAVIGATION *
         **************/

        public override bool CanLeave()
        {
            return true; // TODO: fill out when MONSTER is implemented
        }

        public override RoomId Go(string direction)
        {
            var roomId = RoomId.NoRoom;
            switch (direction)
            {
                case "ahead":
                case "forward":
                case "forwards":
                case "straight":
                    roomId = RoomId.EndGame;
                    break;
                case "left":
                    roomId = Neighbors[1];
                    break;
                case "right":
                    roomId = TryComputerRoomDoor();
                    break;
                case "back":
                case "backward":
                case "backwards":
                    roomId = Neighbors[0];
                    break;
                case "up":
                case "upstairs":
                case "upwards":
                    roomId = Neighbors[3];
                    break;
            }
            return roomId;
        }

        private RoomId TryComputerRoomDoor()
        {
            RoomId roomId = RoomId.RoomIsLocked;
            if (!ComputerRoomIsLocked)
            {
                roomId = Neighbors[2];
            }
            return roomId;
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
                case "keypad":
                    IO.OutputNewLine(ViewKeypad());
                    break;
                case "s":
                case "search":
                    IO.OutputNewLine(SearchBasic());
                    break;
                default:
                    IO.OutputNewLine(GameStrings.PerformCustomMethodsBadInput);
                    break;
            }
        }

        private string ViewKeypad()
        {
            string message = "> UNLOCKED";
            IO.OutputNewLine("There is a simple touch-screen 'QWERTY' keyboard set into the wall. " +
                    "The screen below it says:");

            if (ComputerRoomIsLocked)
            {
                IO.OutputSameLine("> ENTER PASSWORD: ");

                string password = IO.GetInput();
                if (password.Equals(ComputerRoomPassword))
                {
                    ComputerRoomIsLocked = false;
                    IO.OutputNewLine("> SUCCESS");
                    IO.OutputNewLine();
                    message = "You hear a soft click from the wall behind the keypad.";
                }
                else
                {
                    message = "> INCORRECT PASSWORD";
                }
            }

            return message;
        }

        #endregion
    }
}