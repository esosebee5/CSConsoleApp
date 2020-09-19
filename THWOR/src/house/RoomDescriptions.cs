namespace THWOR.src.rooms
{
    class RoomDescriptions
    {
        #region Java code

        //        tring defaultSearchDescription = "You see ";

        //        /*****************
        //         *    LIBRARY    *
        //         *****************/
        //        public static final String library = "" +
        //            "You are in a large room, surrounded by a labyrinth of " +
        //            "tall bookshelves made of a magnificent dark wood. " +
        //            "Golden autumnal light floods the place from high " +
        //            "windows somewhere outside of your field of vision." +
        //            "\nStraight ahead in the distance, you see a wooden door.";
        //    public static final String libraryFirstSearch = "" +
        //            "You wander about the room for a minute, glancing at " +
        //            "the titles of the old, worn books. Lying about on the " +
        //            "shelves and between the novels, you see ";

        //    /***************
        //     *    STUDY    *
        //     ***************/
        //    public static final String study = "" +
        //            "You are in a small, dimly lit room. A high-backed " +
        //            "armchair sits behind a large oak desk on one side. " +
        //            "The other side has a fireplace, in which some struggling" +
        //            " embers fight to produce a meager source of heat." +
        //            "\nOn your left, beside the desk, is a dark-colored door." +
        //            "\nBehind you is the door to the library.";
        //    public static final String studyFirstSearch = "" +
        //            "You see ";
        //    public static final String studyDeskFirstSearch = "" +
        //            "You rummage through the drawers of the large desk. In the " +
        //            "bottom of the last one, under an army of cobwebs, you find " +
        //            "an old black iron key.";
        //    public static final String studyDeskOtherSearch = "" +
        //            "It is a large, dusty oak desk, with many drawers.";
        //    public static final String studyFireplaceFirstSearch = "" +
        //            "You run your hands across the old stone mantlepiece, and you " +
        //            "feel a certain rock give way beneath your fingers. You see a " +
        //            "small scrap of paper flutter between your fingers towards the " +
        //            "burning coals. You fumble with the torn scrap for a second and " +
        //            "it lands on the stone hearth.";
        //    public static final String studyFireplaceOtherSearch = "" +
        //            "It is an old stone fireplace, with some coals burning on the grate.";

        //    /**************
        //     *    HALL    *
        //     **************/
        //    public static final String hall = "" +
        //            "You are in a long hall lit by flickering torchlight." +
        //            "\nThere are stairs going upward to the railing of a second floor " +
        //            "above you." +
        //            "\nOn your left is a plain-looking door." +
        //            "\nOn your right is a metallic door with a keypad set into the wall beside it." +
        //            "\nIn front of you is a high, ornately carved arched doorway." +
        //            "\nThe door to the Study is behind you.";
        //    public static final String hallFirstSearch = "" +
        //            "A shadowy figure steps towards you out of the dark corner. The " +
        //            "face is obscured by a dark cowl and bony hands reach up as if to " +
        //            "grab you.";
        //    public static final String hallOtherSearch = "" +
        //            "One of the torches on the wall looks loose.";
        //    public static final String guardianIsAngryCannotLeave = "" +
        //            "The shadowy form laughs an eerie, haunting laugh that sends chills " +
        //            "down your spine." +
        //            "\n'You have angered the Guardian,' it says." +
        //            "\n'You shall not leave.'";

        //    /*********************
        //     *    DINING ROOM    *
        //     *********************/
        //    public static final String dining = "" +
        //            "You are in a dim, candle-lit dining room. A table in front of you " +
        //            "is set for seven, but the seventh set of dishes and utensils, at " +
        //            "the far end of the table, is old, cracked, and covered in a thick " +
        //            "layer of dust." +
        //            "\n'Who could live here?' you ask yourself." +
        //            "\nThere is a swinging door in the far wall ahead of you." +
        //            "\nThe door to the Hall is behind you.";
        ////    public static final String diningFirstSearch = "" +
        ////            "There is nothing here.";

        //    /***********************
        //     *    COMPUTER ROOM    *
        //     ***********************/
        //    public static final String compRoom = "" +
        //            "You are in a wide, dark room. An electronic hum comes from a wall " +
        //            "on your left, where hundreds of tiny lights blink blue, red, orange, " +
        //            "and green." +
        //            "\nBehind you is the door to the Hall.";
        //    public static final String compSearchNoLight = "" +
        //            "There is a lightswitch on the wall beside the door.";
        //    public static final String compFirstSearchWithLight = "" +
        //            "The left wall of the wide room is covered by computer monitors from " +
        //            "floor to ceiling. The monitor screens are sectioned into grids which " +
        //            "are all blank, except for a few flickering lights in the corners of " +
        //            "the small frames. A sticky-note on the center-most monitor has 'RAG??' " +
        //            "written on it in jagged, angular handwriting with permanent marker. " +
        //            "Four benches, oddly similar to hospital beds, are spaced evenly across " +
        //            "the rest of the room." +
        //            "\n" + compSearchNoLight;
        //    public static final String compOtherSearchWithLight = "" +
        //            "Computer monitors with flickering lights cover the left wall. A " +
        //            "sticky-note in the middle reads 'RAG??'. Four beds are spread across " +
        //            "the room." +
        //            "\n" + compSearchNoLight;

        //    /*****************
        //     *    KITCHEN    *
        //     *****************/
        //    public static final String kitchen = "" +
        //            "You are in a large, old fashioned kitchen with a black-and-white " +
        //            "checkerboard floor." +
        //            "\nTo your right is a plain wooden door." +
        //            "\nBehind you is the door to the dining room.";

        //    /****************
        //     *    PANTRY    *
        //     ****************/
        //    public static final String pantry = "" +
        //            "You are in a long pantry room with floor-to-ceiling wooden shelves " +
        //            "running the length of the room." +
        //            "\nBehind you is the door to the kitchen.";

        //    /**************************
        //     *    UPSTAIRS HALLWAY    *
        //     **************************/
        //    public static final String upstairsHallway = "" +
        //            "You are in a long, empty hallway. To your right is a railing, beyond which " +
        //            "you can see the torchlit hall below." +
        //            "\nBehind you is the staircase leading down to the hall.";

        #endregion

        public const string DefaultSearchDescription = "You see ";

        /*****************
         *    LIBRARY    *
         *****************/
        public const string LibraryName = "Library";
        public const string Library = "" +
            "You are in a large room, surrounded by a labyrinth of " +
            "tall bookshelves made of a magnificent dark wood. " +
            "Golden autumnal light floods the place from high " +
            "windows somewhere outside of your field of vision." +
            "\nStraight ahead in the distance, you see a wooden door.";
        public const string LibraryFirstSearch = "" +
            "You wander about the room for a minute, glancing at " +
            "the titles of the old, worn books. Lying about on the " +
            "shelves and between the novels, you see ";

        /***************
         *    STUDY    *
         ***************/
        public const string StudyName = "Study";
        public const string Study = "" +
            "You are in a small, dimly lit room. A high-backed " +
            "armchair sits behind a large oak desk on one side. " +
            "The other side has a fireplace, in which some struggling" +
            " embers fight to produce a meager source of heat." +
            "\nOn your left, beside the desk, is a black door." +
            "\nBehind you is the door to the library.";
        public const string StudyFirstSearch = "" +
            "You see ";
        public const string StudyDeskFirstSearch = "" +
            "You rummage through the drawers of the large desk. In the " +
            "bottom of the last one, under an army of cobwebs, you find " +
            "an old black iron key.";
        public const string StudyDeskOtherSearch = "" +
            "It is a large, dusty oak desk, with many drawers.";
        public const string StudyFireplaceFirstSearch = "" +
            "You run your hands across the old stone mantlepiece, and you " +
            "feel a certain rock give way beneath your fingers. You see a " +
            "small scrap of paper flutter between your fingers towards the " +
            "burning coals. You fumble with the torn scrap for a second and " +
            "it lands on the stone hearth.";
        public const string StudyFireplaceOtherSearch = "" +
            "It is an old stone fireplace, with some coals burning on the grate.";

        /**************
         *    HALL    *
         **************/
        public const string HallName = "Hall";
        public const string Hall = "" +
            "You are in a long hall lit by flickering torchlight." +
            "\nThere are stairs going upward to the railing of a second floor " +
            "above you." +
            "\nOn your left is a plain-looking door." +
            "\nOn your right is a metallic door with a keypad set into the wall beside it." +
            "\nIn front of you is a high, ornately carved arched doorway." +
            "\nThe door to the Study is behind you.";
        public const string GuardianEntrance = "" +
            "A shadowy figure steps towards you out of the dark corner. The " +
            "face is obscured by a dark cowl and bony hands reach up as if to " +
            "grab you.";
        public const string hallOtherSearch = "" +
            "One of the torches on the wall looks loose.";
        public const string guardianIsAngryCannotLeave = "" +
            "The shadowy form laughs an eerie, haunting laugh that sends chills " +
            "down your spine." +
            "\n'You have angered the Guardian,' it says." +
            "\n'You shall not leave.'";

        /*********************
         *    DINING ROOM    *
         *********************/
        public const string DiningName = "Dining Room";
        public const string Dining = "" +
            "You are in a dim, candle-lit dining room. A table in front of you " +
            "is set for seven, but the seventh set of dishes and utensils, at " +
            "the far end of the table, is old, cracked, and covered in a thick " +
            "layer of dust." +
            "\n'Who could live here?' you ask yourself." +
            "\nThere is a swinging door in the far wall ahead of you." +
            "\nThe door to the Hall is behind you.";

        /***********************
         *    COMPUTER ROOM    *
         ***********************/
        public const string ComputerRoomName = "Computer Room";
        public const string ComputerRoom = "" +
            "You are in a wide, dark room. An electronic hum comes from a wall " +
            "on your left, where hundreds of tiny lights blink blue, red, orange, " +
            "and green." +
            "\nBehind you is the door to the Hall.";
        public const string CompSearchNoLight = "" +
            "There is a lightswitch on the wall beside the door.";
        public const string CompFirstSearchWithLight = "" +
            "The left wall of the wide room is covered by computer monitors from " +
            "floor to ceiling. The monitor screens are sectioned into grids which " +
            "are all blank, except for a few flickering lights in the corners of " +
            "the small frames. A sticky-note on the center-most monitor has 'RAG??' " +
            "written on it in jagged, angular handwriting with permanent marker. " +
            "Four benches, oddly similar to hospital beds, are spaced evenly across " +
            "the rest of the room." +
            "\n" + CompSearchNoLight;
        public const string CompOtherSearchWithLight = "" +
            "Computer monitors with flickering lights cover the left wall. A " +
            "sticky-note in the middle reads 'RAG??'. Four beds are spread across " +
            "the room." +
            "\n" + CompSearchNoLight;

        /*****************
         *    KITCHEN    *
         *****************/
        public const string KitchenName = "Kitchen";
        public const string Kitchen = "" +
            "You are in a large, old fashioned kitchen with a black-and-white " +
            "checkerboard floor." +
            "\nTo your right is a plain wooden door." +
            "\nBehind you is the door to the dining room.";

        /****************
         *    PANTRY    *
         ****************/
        public const string PantryName = "Pantry";
        public const string Pantry = "" +
            "You are in a long pantry room with floor-to-ceiling wooden shelves " +
            "running the length of the room." +
            "\nBehind you is the door to the kitchen.";

        /**************************
         *    UPSTAIRS HALLWAY    *
         **************************/
        public const string UpstairsHallwayName = "Upstairs Hallway";
        public const string UpstairsHallway = "" +
            "You are in a long, empty hallway. To your right is a railing, beyond which " +
            "you can see the torchlit hall below." +
            "\nBehind you is the staircase leading down to the hall.";
    }
}
