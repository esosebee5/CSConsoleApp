using System;

namespace THWOR.src.core.services
{
    /// <summary>
    /// Handles input and output for the application
    /// </summary>
    class IO
    {
        /// <summary>
        /// Displays the message on its own line
        /// </summary>
        /// <param name="message"></param>
        public static void OutputNewLine(string message = null)
        {
            if (message == null || message.Trim().Length == 0) Console.WriteLine();
            else Console.WriteLine(message);
        }

        /// <summary>
        /// Displays the message in the same line
        /// </summary>
        /// <param name="message"></param>
        public static void OutputSameLine(string message)
        {
            Console.Write(message);
        }

        /// <summary>
        /// Read a line of input from the user
        /// </summary>
        /// <returns></returns>
        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static string PromptAndGetInput()
        {
            OutputSameLine("> ");
            return GetInput();
        }

        /// <summary>
        /// Sanitizes input (toLowerCase) and splits it into separate words
        /// </summary>
        /// <param name="input">the user input that needs to be split and sanitized</param>
        /// <returns>an array of words</returns>
        public static string[] SplitAndSanitizeInput(string input)
        {
            string sanitizedInput = input.ToLower();
            //        String[] infoArray = sanitizedInput.split("\\s+");
            return sanitizedInput.Split(" ");
        }

        /// <summary>
        /// Check if a specific word starts with a vowel
        /// - for adjective agreement ("a" vs. "an")
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool StartsWithVowel(string word)
        {
            bool retVal = false;
            if (word.StartsWith('a') ||
                word.StartsWith('e') ||
                word.StartsWith('i') ||
                word.StartsWith('o') ||
                word.StartsWith('u'))
            {
                retVal = true;
            }
            return retVal;
        }
    }
}
