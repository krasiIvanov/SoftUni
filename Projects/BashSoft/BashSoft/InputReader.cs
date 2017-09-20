using System;

namespace BashSoft
{
    public static class InputReader
    {
        private const string endCommand = "quit";

        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessages($"{SessionData.currentPath}>");
            string input = Console.ReadLine();
            input = input.Trim();
            while (input != endCommand)
            {
                CommandInterpreter.InterpreterCommand(input);
                OutputWriter.WriteMessages($"{SessionData.currentPath}>");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }
}