using THWOR.src.core.services;
using THWOR.src.titles;

namespace THWOR.src.rooms
{
    class DiningRoom : RoomBase
    {
        #region Java code

        //    private static final int id = RoomId.DININGROOM.getId();
        //    private final int[] neighbors = { RoomId.HALL.getId(), RoomId.KITCHEN.getId() };
        //    private static final String name = "Dining Room";
        //private final String description = RoomDescriptions.dining;
        //private ArrayList<iItem> items;

        //    private boolean hasBeenSearched = false;

        //    /**
        //     * Constructor for the DiningRoom
        //     */
        //    DiningRoom()
        //    {
        //        this.items = new ArrayList<>();
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

        //    public ArrayList<iItem> getItems()
        //    {
        //        if (this.items == null)
        //        {
        //            this.items = new ArrayList<>();
        //            return this.items;
        //        }
        //        return this.items;
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
        //        }

        //        return Shared.appendDescriptionToItemsString(
        //                    RoomDescriptions.defaultSearchDescription, itemsInRoom);
        //    }

        //    /*************************
        //     * RoomInventory Methods *
        //     *************************/

        //    public void removeItemFromItems(iItem item)
        //    {
        //        this.items.remove(item);
        //    }

        //    public void addItemToItems(iItem item)
        //    {
        //        this.items.add(item);
        //    }

        //    /******************
        //     * Custom methods *
        //     ******************/

        //    public void performCustomMethods(
        //            String[] inputs)
        //    {
        //        switch (inputs[0])
        //        {
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
        //                return this.neighbors[0];
        //            case "forward":
        //            case "ahead":
        //            case "forwards":
        //                return this.neighbors[1];
        //            default:
        //                return -1;
        //        }
        //    }

        //    /******************
        //     *      Other     *
        //     ******************/

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private readonly RoomId[] Neighbors = {
            RoomId.Hall,
            RoomId.Kitchen
        };

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public DiningRoom(
            RoomId id = RoomId.DiningRoom,
            string name = RoomDescriptions.DiningName,
            string description = RoomDescriptions.Dining,
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
                case "ahead":
                case "forward":
                case "forwards":
                case "straight":
                    roomId = Neighbors[1];
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
                case "s":
                case "search":
                    IO.OutputNewLine(SearchBasic());
                    break;
                default:
                    IO.OutputNewLine(GameStrings.PerformCustomMethodsBadInput);
                    break;
            }
        }

        #endregion
    }
}
