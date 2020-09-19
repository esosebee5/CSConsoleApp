using THWOR.src.housewithoneroom;
using THWOR.src.titles;

namespace THWOR.src.core.services
{
    class CommandProcessingService
    {
        /// <summary>
        /// Takes the user input and applies the appropriate method
        /// </summary>
        /// <param name="commands">array of inputs from the user</param>
        /// <returns></returns>
        public static void ParseInput(string[] commands)
        {
            string verb = commands[0];
            switch (verb)
            {
                //////////
                // ROOM //
                //////////
                case "a":
                case "attack":
                    DisplayMessage(Game.TryToAttack());
                    break;
                case "c":
                case "character":
                    DisplayMessage(Game.Player.ShowCharacterReport());
                    break;
                //////////
                // ROOM //
                //////////
                case "desc":
                case "describe":
                case "description":
                    Game.DisplayCurrentRoomDescription();
                    break;
                case "d":
                case "drop":
                    if (ValidateNoun(commands))
                    {
                        Game.TryDroppingItem(commands[1]);
                    }
                    else
                    {
                        DisplayMessage("Try including an item after 'drop'.");
                    }
                    break;
                case "e":
                case "equip":
                    if (ValidateNoun(commands))
                    {
                        Game.TryEquippingItem(commands[1]);
                    }
                    else
                    {
                        DisplayMessage("Try including an item after 'equip'.");
                    }
                    break;
                case "exit":
                case "x":
                    Game.ExitGame();
                    break;
                //////////?????????????
                // ROOM //?????????????
                //////////?????????????
                case "g":
                case "go":
                case "move":
                    if (ValidateNoun(commands))
                    {
                        Game.TryGoing(commands[1]);
                    }
                    else
                    {
                        DisplayMessage("Try including a direction after 'go'.");
                    }
                    break;
                case "generate":
                    if (ValidateNoun(commands))
                    {
                        DisplayMessage(Game.GenerateMonster(commands[1]));
                    }
                    else
                    {
                        DisplayMessage("Name the monster you would like to generate.");
                    }
                    break;
                case "h":
                case "help":
                    ShowHelpDialogue();
                    break;
                case "i":
                case "inventory":
                    DisplayMessage(Game.Player.ShowInventory());
                    break;
                //case "load":
                //tryLoadingPlayer();
                //break;
                case "pocket":
                    if (ValidateNoun(commands))
                    {
                        Game.TryPocketingItem(commands[1]);
                    }
                    else
                    {
                        DisplayMessage("Try including an equipped item after 'pocket'.");
                    }
                    break;
                //////////
                // ROOM //
                //////////
                //            case "ra":
                //                Game.CurrentRoom.roomActions();
                //                break;
                //            case "stats":
                //                if (ValidateNoun(commands)) {
                //                    showItemStats(commands[1]);
                //                } 
                //                else {
                //                    DisplayLine("Try including an item from your inventory \n"
                //                            + "after 'stats'.");
                //                }
                //                break;
                //case "save":
                //trySavingPlayer();
                //break;
                case "t":
                case "get":
                case "take":
                    if (ValidateNoun(commands))
                    {
                        Game.TryTakingItem(commands[1]);
                    }
                    else
                    {
                        DisplayMessage("Try including an item after 'take'.");
                    }
                    break;
                case "v":
                case "view":
                case "inspect":
                    if (ValidateNoun(commands))
                    {
                        Game.TryViewingItem(commands[1]);
                    }
                    else
                    {
                        DisplayMessage("Try adding an item name from your inventory \n"
                                + "after 'view'.");
                    }
                    break;
                //////////
                // ROOM //
                //////////
                default:
                    Game.PassCommandsToCurrentRoom(commands);
                    break;
            }
        }

        /// <summary>
        /// Displays an informative dialogue about possible actions
        /// </summary>
        private static void ShowHelpDialogue()
        {
            DisplayMessage(GameStrings.HelpDialogue);
        }

        public static bool ValidateNoun(string[] inputs)
        {
            bool retVal = false;
            if (inputs.Length > 1)
            {
                if (inputs[1] != null && inputs[1].Length > 0)
                {
                    retVal = true;
                }
                // TODO: I believe the following line is for DEBUG only. Validate.
                //DisplayMessage(GameStrings.InvalidNoun);
            }
            return retVal;
        }

        private static void DisplayMessage(string message = "")
        {
            IO.OutputNewLine(message);
        }

    }
}
