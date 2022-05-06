using Spectre.Console;

public class Machine
{
    #region Fullscreen Variables
    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern IntPtr GetConsoleWindow();
    private static IntPtr ThisConsole = GetConsoleWindow();
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    private const int HIDE = 0;
    private const int MAXIMIZE = 3;
    private const int MINIMIZE = 6;
    private const int RESTORE = 9;
    #endregion

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

    public static void TableBuild(Table table)
    {
        table.AddColumn("Products");
        table.AddRow("Test");
    }
}