using Spectre.Console;

public class Machine
{
    public static void TableBuild(Table table)
    {
        TableDraw();
    }

    public void TableDraw()
    {
        Console.Title = "Match 3";
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        ShowWindow(ThisConsole, MAXIMIZE);

        var MachineTable = new Table();

        MachineTable.AddColumn("Products");
        MachineTable.AddRow("Test");

        MachineTable.Width(50);

        AnsiConsole.Write(MachineTable);
    }


}