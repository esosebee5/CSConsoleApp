using THWOR.src.core.services;
using THWOR.src.titles;

namespace THWOR.src.rooms
{
    class ComputerRoom : RoomBase
    {
        #region Java code

        //    private static final int id = RoomId.COMPUTERROOM.getId();
        //    private static final String name = "Computer Room";
        //private boolean hasBeenSearched = false;
        //    private boolean computerIsLocked = true;
        //    private boolean lightIsOn = false;
        //    private final int[] neighbors = { RoomId.HALL.getId() };

        //    private static final String description = RoomDescriptions.compRoom;
        //private static final String firstSearchNoLight = 
        //        RoomDescriptions.compSearchNoLight;
        //private static final String firstSearchWithLight = 
        //        RoomDescriptions.compFirstSearchWithLight;
        //private static final String otherSearchWithLight = 
        //        RoomDescriptions.compOtherSearchWithLight;

        ///**
        // * Constructor for the Minesweeper Simulation room
        // */
        //ComputerRoom() { }

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
        //        if (!this.getLightIsOn())
        //        {
        //            return description;
        //        }
        //        return firstSearchWithLight;
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
        //    public boolean getComputerIsLocked()
        //    {
        //        return this.computerIsLocked;
        //    }
        //    public void setComputerIsLocked(boolean tf)
        //    {
        //        //possibly additional code in here later.
        //        this.computerIsLocked = tf;
        //    }
        //    private boolean getLightIsOn()
        //    {
        //        return this.lightIsOn;
        //    }
        //    private boolean toggleLights()
        //    {
        //        //possibly additional code in here later.
        //        if (this.lightIsOn)
        //        {
        //            this.lightIsOn = false;
        //            return false;
        //        }
        //        else
        //        {
        //            this.lightIsOn = true;
        //            return true;
        //        }
        //    }

        //    /******************
        //     * Search methods *
        //     ******************/
        //    private String search()
        //    {
        //        if (this.lightIsOn)
        //        {
        //            if (!this.getHasBeenSearched())
        //            {
        //                setHasBeenSearched();
        //                return firstSearchWithLight;
        //            }
        //            return otherSearchWithLight;
        //        }
        //        else
        //        {
        //            //            if (!this.getHasBeenSearched()) {
        //            //                setHasBeenSearched(true);
        //            //                return firstSearchNoLight;
        //            //            }
        //            return firstSearchNoLight;
        //        }
        //    }

        //    /******************
        //     * Custom methods *
        //     ******************/
        //    //flip lightswitch/turn light(s) on/etc.

        //    public void performCustomMethods(String[] inputs)
        //    {
        //        switch (inputs[0])
        //        {
        //            case "flip":
        //            case "turn":
        //            case "toggle":
        //                output(tryFlippingLightswitch(inputs));
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
        //        switch (direction)
        //        {
        //            case "back":
        //            case "backward":
        //            case "backwards":
        //                return this.neighbors[0];
        //            default:
        //                return -1;
        //        }
        //    }

        //    /************************
        //     *  CUSTOM TRY METHODS  *
        //     ************************/
        //    private String tryFlippingLightswitch(String[] inputs)
        //    {
        //        if (validateNoun(inputs))
        //        {
        //            String noun = inputs[1];
        //            switch (noun)
        //            {
        //                case "light":
        //                case "lights":
        //                case "lightswitch":
        //                case "switch":
        //                    boolean light = this.toggleLights();
        //                    if (light)
        //                    {
        //                        return "Bright bars of light in the ceiling "
        //                                + "flicker on.";
        //                    }
        //                    return "The lights shut off, plunging you back "
        //                            + "into the dark.";
        //                default:
        //                    return "Try including the title of the object you wish \n"
        //                            + "to interact with.";
        //            }
        //        }
        //        return "Try including an object to interact with after the verb.";

        //    }

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private readonly RoomId[] Neighbors = {
            RoomId.Hall
        };
        private bool LightIsOn = false;

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public ComputerRoom(
            RoomId id = RoomId.ComputerRoom,
            string name = RoomDescriptions.ComputerRoomName,
            string description = RoomDescriptions.ComputerRoom,
            string firstSearchDescription = RoomDescriptions.DefaultSearchDescription,
            bool hasBeenSearched = false)
            : base(id, name, description, firstSearchDescription, hasBeenSearched)
        {

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
                case "back":
                case "backward":
                case "backwards":
                    roomId = Neighbors[0];
                    break;
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
                case "flip":
                case "turn":
                case "toggle":
                    IO.OutputNewLine(TryFlippingLightswitch(inputs));
                    break;
                case "s":
                case "search":
                    IO.OutputNewLine(Search());
                    break;
                default:
                    IO.OutputNewLine(GameStrings.PerformCustomMethodsBadInput);
                    break;
            }
        }

        private string Search()
        {
            string returnMessage = RoomDescriptions.CompSearchNoLight;

            if (LightIsOn)
            {
                if (HasBeenSearched)
                {
                    returnMessage = RoomDescriptions.CompOtherSearchWithLight;
                }
                else
                {
                    HasBeenSearched = true;
                    returnMessage = RoomDescriptions.CompFirstSearchWithLight;
                }
            }

            return returnMessage;
        }

        private string TryFlippingLightswitch(string[] inputs)
        {
            string message = "Try including an object to interact with after the verb.";

            if (CommandProcessingService.ValidateNoun(inputs))
            {
                string noun = inputs[1];
                switch (noun)
                {
                    case "light":
                    case "lights":
                    case "lightswitch":
                    case "switch":
                        message = ToggleLights();
                        break;
                    default:
                        message = "Try including the title of the object you wish \n"
                                + "to interact with.";
                        break;
                }
            }

            return message;
        }

        private string ToggleLights()
        {
            string message;

            //possibly additional code in here later.
            if (LightIsOn)
            {
                LightIsOn = false;
                message = "The lights shut off, plunging you back into the dark.";
            }
            else
            {
                LightIsOn = true;
                message = "Bright bars of light in the ceiling flicker on.";
            }

            return message;
        }

        #endregion

        #region OVERRIDE

        public override string GetDescription()
        {
            string description = RoomDescriptions.ComputerRoom;
            if (LightIsOn)
            {
                description = RoomDescriptions.CompFirstSearchWithLight;
            }
            return description;
        }

        #endregion
    }
}
