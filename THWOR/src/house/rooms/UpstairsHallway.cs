using THWOR.src.core.services;
using THWOR.src.titles;

namespace THWOR.src.rooms
{
    class UpstairsHallway : RoomBase
    {
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
