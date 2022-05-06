using Spectre.Console;

public class Machine
{
    public static void TableBuild(Table table)
    {
        table.AddColumn("Products");
        table.AddRow("Test");
    }
    public static void Main(string[] args)
    {
        var MachineTable = new Table();

        TableBuild(MachineTable);
        AnsiConsole.Write(MachineTable);


        Console.ReadKey();
    }
}