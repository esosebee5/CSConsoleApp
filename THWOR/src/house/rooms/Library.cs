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
            monster = MonsterFactory.GenerateMonster(MonsterType.Gremlin);
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