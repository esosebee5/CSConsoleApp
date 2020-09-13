using THWOR.src.core.services;
using THWOR.src.titles;

namespace THWOR.src.rooms
{
    class UpstairsHallway : RoomBase
    {
        #region Java code

        //    private static final int id = RoomId.UPSTAIRSHALLWAY.getId();
        //    private static final String name = "Upstairs Hallway";
        //private static final String description = RoomDescriptions.upstairsHallway;
        //private final int[] neighbors = { RoomId.HALL.getId() };

        //    /**
        //     * Constructor for the UpstairsHallway
        //     */
        //    public UpstairsHallway() { }

        //    @Override
        //public int getId()
        //    {
        //        return id;
        //    }

        //    @Override
        //public String getName()
        //    {
        //        return name;
        //    }

        //    @Override
        //public String getDescription()
        //    {
        //        return description;
        //    }

        //    @Override
        //public int go(String direction)
        //    {
        //        switch (direction)
        //        {
        //            case "back":
        //            case "backward":
        //            case "backwards":
        //            case "down":
        //                return this.neighbors[0];
        //            default:
        //                return -1;
        //        }
        //    }

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private readonly RoomId[] Neighbors = {
            RoomId.Hall
        };

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public UpstairsHallway(
            RoomId id = RoomId.UpstairsHallway,
            string name = RoomDescriptions.UpstairsHallwayName,
            string description = RoomDescriptions.UpstairsHallway,
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
