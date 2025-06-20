using Spectre.Console;

namespace Utilities.GoldRino456
{
    public static class DisplayUtils
    {
        /// <summary>
        /// Prompts the user for a selection from a dictionary of choices that correspond to an enum cast as an integer value.
        /// </summary>
        /// <param name="menuPrompt"></param>
        /// <param name="choices"> Best to think of this as Dictionary<string, (int)enum> </param>
        /// <returns>integer value returned is assumed to be equivalent of some Enum type corresponding to the string choices.</returns>
        public static int PromptUserForSingleSelection(string menuPrompt, Dictionary<string, int> choices)
        {
            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title(menuPrompt)
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to see additional options)[/]")
                .AddChoices(choices.Keys.ToArray()));

            return choices[selection];
        }

        public static void DisplayElementsAsTable(string[] columns, List<string[]> rows)
        {
            var table = new Table();

            table.AddColumns(columns);

            foreach (var row in rows)
            {
                table.AddRow(row);
            }
        }
    }
}
