using Spectre.Console;

namespace Utilities.GoldRino456
{
    public static class DisplayUtils
    {
        public static string PromptUserForSingleSelection(string menuPrompt, string[] choices)
        {
            var selection = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title(menuPrompt)
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to see additional options)[/]")
                .AddChoices(choices));

            return selection;
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
