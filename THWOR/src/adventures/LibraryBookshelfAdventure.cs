using THWOR.src.core.services;
using THWOR.src.titles;

namespace THWOR.src.adventures
{
    class LibraryBookshelfAdventure
    {
        public static void BrowseLibrary()
        {
            IO.OutputNewLine(ShowBookTitles());
            IO.OutputNewLine();

            string[] actionsArray = IO.SplitAndSanitizeInput(IO.GetInput());

            while (!actionsArray[0].Equals("leave"))
            {
                // Empty line buffer after getting input
                IO.OutputNewLine();

                switch (actionsArray[0])
                {
                    case "read":
                        if (CommandProcessingService.ValidateNoun(actionsArray))
                        {
                            IO.OutputNewLine(ReadBook(actionsArray));
                        }
                        else
                        {
                            IO.OutputNewLine("Try including a title after 'read'.");
                        }
                        break;
                    default:
                        IO.OutputNewLine("enter 'leave' to leave");
                        break;
                }

                // Empty line buffer before getting next input
                IO.OutputNewLine();

                actionsArray = IO.SplitAndSanitizeInput(IO.GetInput());
            }

        }

        private static string ShowBookTitles()
        {
            return Excerpts.bookTitlesInLibrary;
        }

        private static string ReadBook(string[] commands)
        {
            string message;

            switch (commands[1])
            {
                case "m":
                case "mcever":
                    message = Excerpts.mcEver;
                    break;
                case "l":
                case "legenn":
                case "jon":
                    message = Excerpts.legenn;
                    break;
                case "f":
                case "fogarty":
                    message = Excerpts.fogarty;
                    break;
                case "c":
                case "clocktower":
                    message = Excerpts.clocktower;
                    break;
                default:
                    message = "Try 'm', 'l', 'f', or 'c'.";
                    break;
            }

            return message;
        }
    }
}
