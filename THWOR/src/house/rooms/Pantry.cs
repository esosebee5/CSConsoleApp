using THWOR.src.core.services;
using THWOR.src.titles;

namespace THWOR.src.rooms
{
    class Pantry : RoomBase
    {
        #region Java code

        //    private static final int id = RoomId.PANTRY.getId();
        //    private static final String name = "Pantry";
        //private final int[] neighbors = { RoomId.KITCHEN.getId() };
        //    private final String description = RoomDescriptions.pantry;

        ///**
        // * Constructor for the Pantry
        // */
        //public Pantry() { }

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

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private readonly RoomId[] Neighbors = {
            RoomId.Kitchen
        };

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public Pantry(
            RoomId id = RoomId.Pantry,
            string name = RoomDescriptions.PantryName,
            string description = RoomDescriptions.Pantry,
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
