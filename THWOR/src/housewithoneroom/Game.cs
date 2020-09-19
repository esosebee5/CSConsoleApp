using THWOR.src.characters;
using THWOR.src.core.models.rooms;
using THWOR.src.core.services;
using THWOR.src.items;
using THWOR.src.rooms;
using THWOR.src.titles;
using System.Collections.Generic;

namespace THWOR.src.housewithoneroom
{
    class Game
    {
        #region Java code

        //public static Player player;
        //public static iRoom currentRoom;
        //public static House house = new House();
        //public static LinkedList<iRoom> visitedRooms = new LinkedList<>();
        //public int numberOfVisitedRooms = 0;
        //public static boolean state = true;

        //public static void NewGame()
        //{
        //    house = new House();
        //    currentRoom = house.getCorridor().getFirst();
        //}

        //public Game(int roomId)
        //{
        //    house = new House();
        //    currentRoom = house.getCorridor().get(roomId);
        //}

        //public static void exitGame()
        //{
        //    output("Are you sure you want to exit? [y/n] ");
        //    if (IOService.getNextLine().equals("y"))
        //    {
        //        state = false;
        //        outputLn();
        //        output(GameStrings.getEOGUser());
        //    }
        //    else
        //    {
        //        outputLn();
        //        output("Good.");
        //    }
        //}

        //public static int endGame()
        //{
        //    state = false;
        //    output(GameStrings.endGameWin);
        //    return -99;
        //}

        #endregion

        #region Properties

        public static bool admin = false;
        //public static bool admin = true;

        public static Player Player;
        private static IRoom CurrentRoom
        {
            get;
            set;
        }

        public static House House
        {
            get;
            set;
        }

        private static List<IRoom> VisitedRooms = new List<IRoom>();
        private static bool state;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new blank game starting in the specified room
        /// </summary>
        /// <param name="roomId"></param>
        public Game(int roomId)
        {
            state = true;

            // TODO: implement
            //house = new House();
            //currentRoom = house.getCorridor().get(roomId);
        }

        #endregion

        /// <summary>
        /// Initializes a new blank game with default settings
        /// </summary>
        private static void NewGame()
        {
            // Set the "running" state
            state = true;

            // Generate the House
            House = new House();

            // Initialize Player
            InitializePlayer();

            if (admin)
            {
                IO.OutputSameLine("Enter starting room id: ");
                string roomIdString = IO.GetInput();
                IO.OutputNewLine();
                if (int.TryParse(roomIdString, out int roomIdInt))
                {
                    var roomId = (RoomId)roomIdInt;
                    MoveToRoom(roomId);
                    IO.OutputNewLine();
                }
            }
            else
            {
                // Set the Player's position within the House
                MoveToRoom(House.GetFirstRoom().GetId());
                IO.OutputNewLine();
                //CurrentRoom = House.GetFirstRoom();
                //VisitedRooms.Add(CurrentRoom);
            }
        }

        public static void Start(bool isNew = true)
        {
            // Start game process
            GreetUser();

            // Reset properties if this is a new game
            if (isNew == true) NewGame();

            //// Show the player where they are:
            //DisplayCurrentRoomDescription();

            // TODO:
            // -
        }

        /// <summary>
        /// Gets input from the user to create the Player
        /// </summary>
        private static void InitializePlayer()
        {
            //in order to make startup easier for myself:
            if (admin)
            {
                Player = new Player("CoconutCavalry", "male");
                IO.OutputNewLine("Welcome, " + Player.GetName() + ".\n");
            }
            else
            {
                IO.OutputSameLine("Enter name: ");
                string name = IO.GetInput();
                IO.OutputSameLine("Male or female? ");
                string gender = IO.GetInput();
                Player = new Player(name, gender);
                IO.OutputNewLine("\nWelcome, " + Player.GetName() + ".\n");
                //IO.OutputNewLine("\nWelcome, " + Player.getPronouns()[0] + " " + Player.GetName() + ".\n");
            }

            IO.OutputNewLine(Player.ShowCharacterReport());
            IO.OutputNewLine();


            //    // Show starting stats
            //    output(Game.player.showCharacterReport());
            //    outputLn();
        }

        private static void GreetUser()
        {
            // Greet Player
            IO.OutputNewLine(GameStrings.GetWelcome());
            IO.OutputNewLine();
            IO.OutputNewLine(GameStrings.GetHouse());
            IO.OutputNewLine();
        }

        /// <summary>
        /// Returns the boolean state of the game
        /// </summary>
        /// <returns></returns>
        public static bool GetState()
        {
            return state;
        }

        #region Exit Game methods

        /// <summary>
        /// Initiates the "Would you like to end the game?" sequence
        /// </summary>
        public static void ExitGame()
        {
            IO.OutputSameLine("Are you sure you want to exit? [y/n] ");
            if (IO.GetInput() == "y")
            {
                state = false;
                IO.OutputNewLine();
                IO.OutputNewLine(GameStrings.EOGUser);
            }
            else
            {
                IO.OutputNewLine();

                IO.OutputNewLine("Good.");
            }
        }

        /// <summary>
        /// Generates an end-game sequence for a win???
        /// </summary>
        /// <returns></returns>
        public static string EndGame(bool win = false)
        {
            state = false;
            // TODO: implement "false" param...
            //if (win == true) IO.OutputNewLine(GameStrings.EndGameWin);
            return GameStrings.EndGameWin;
        }

        #endregion

        #region Navigation

        /// <summary>
        /// Initiates movememnt from one room to another, if possible.
        /// </summary>
        /// <param name="direction"></param>
        public static void TryGoing(string direction)
        {
            // TODO: implement Monster/CanLeave stuff
            // TODO: push monster check into RoomBase???
            var monster = CurrentRoom.getMonster();
            if (monster == null || monster.isDead())
            {
                RoomId roomId = CurrentRoom.Go(direction);
                if (roomId > RoomId.NoRoom)
                {
                    MoveToRoom(roomId);
                }
                else
                {
                    switch (roomId)
                    {
                        case RoomId.EndGame:
                            IO.OutputNewLine(EndGame(true));
                            break;
                        case RoomId.NoRoom:
                            IO.OutputNewLine(GameStrings.GoInvalidDirection);
                            break;
                        case RoomId.RoomIsLocked:
                            IO.OutputNewLine(GameStrings.DoorIsLocked);
                            break;
                    }
                }
            }
            else
            {
                IO.OutputNewLine($"The {monster.name} blocks your path." +
                    $"\nYou cannot leave while the {monster.name} is alive.");
            }
        }

        /// <summary>
        /// Handles the logic around updating the CurrentRoom
        /// </summary>
        /// <param name="roomId"></param>
        public static void MoveToRoom(RoomId roomId)
        {
            var newRoom = House.GetRoomById(roomId);
            if (newRoom != null)
            {
                CurrentRoom = newRoom;
                if (VisitedRooms.Contains(CurrentRoom))
                {
                    IO.OutputNewLine("You are now in the "
                            + CurrentRoom.GetName() + ".");
                }
                else
                {
                    VisitedRooms.Add(CurrentRoom);
                    DisplayCurrentRoomDescription();
                }
            }
            else
            {
                // This should only be useful for debugging... should not happen during a normal game.
                IO.OutputNewLine("That room does not exist");
            }
        }

        // method to show current room description
        //....
        public static void DisplayCurrentRoomDescription()
        {
            IO.OutputNewLine(CurrentRoom.GetDescription());
        }

        #endregion

        #region Command Service Methods

        /// <summary>
        /// Passes the user input array and the current player into the room
        /// to perform room-specific actions
        /// </summary>
        /// <param name="inputs"></param>
        public static void PassCommandsToCurrentRoom(string[] inputs)
        {
            CurrentRoom.PerformCustomMethods(inputs);
        }

        public static void TryTakingItem(string itemName)
        {
            List<IItem> itemsInRoom = CurrentRoom.GetItems();
            if (itemsInRoom == null)
            {
                IO.OutputNewLine(GameStrings.NoItemsSeen);
            }
            else
            {
                foreach (IItem item in itemsInRoom)
                {
                    if (item.GetName() == itemName)
                    {

                        // remove the item from the room if taken by player
                        if (Player.TakeItem(item))
                        {
                            CurrentRoom.RemoveItem(item);
                            return;
                        }
                        return;
                    }
                }
            }
            IO.OutputNewLine(GameStrings.NoItemAvailable);
        }

        public static void TryDroppingItem(string itemName)
        {
            // try to drop from inventory
            IItem droppedItem = Player.Drop(itemName);
            if (droppedItem != null)
            {
                // print result of action
                IO.OutputNewLine("You dropped the " + itemName + ".");

                // then add back to current room
                CurrentRoom.AddItem(droppedItem);
            }
            else
            {
                IO.OutputNewLine(GameStrings.NotInInventory);
            }
        }

        public static void TryEquippingItem(string itemName)
        {
            IO.OutputNewLine(Player.Equip(itemName));
        }

        public static void TryPocketingItem(string itemName)
        {
            IO.OutputNewLine(Player.Pocket(itemName));
        }

        public static void TryViewingItem(string itemName)
        {
            IO.OutputNewLine(Player.View(itemName));
        }

        public static string TryToAttack()
        {
            string message = GameStrings.NothingToAttackHereString;

            var monster = CurrentRoom.getMonster();

            // First, check if there is a monster to fight
            if (monster != null)
            {
                if (monster.isDead())
                {
                    message = $"The {monster.name} is dead.";
                }
                else
                {
                    // If a monster exists, attack it
                    message = CombatService.Attack(monster);
                    if (monster.isDead())
                    {
                        message += $"\n{monster.deathMessage}";
                    }
                    else
                    {
                        // If the monster is still alive, defend against its attack:
                        message += "\n" + CombatService.Defend(monster);
                        if (Player.isDead())
                        {
                            state = false;
                            message += "\n" + Player.death;
                        }
                    }
                }
            }

            return message;
        }

        public static string GenerateMonster(string name)
        {
            // Pass directly into current room
            return CurrentRoom.GenerateMonster(name);
        }

        #endregion
    }
}
