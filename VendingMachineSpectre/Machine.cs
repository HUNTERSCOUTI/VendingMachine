using Spectre.Console;
using VendingMachineSpectre;
using System.Runtime.InteropServices;


public class MachineProgram
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

    public static void Main(string[] args)
    {
        Console.Title = "Match 3";
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        ShowWindow(ThisConsole, MAXIMIZE);

        var machine = new MachineFunc();
        machine.Run();
    }
}

public class MachineFunc
{
    MachineDbContext data = new MachineDbContext();
    public bool UserAction = false;
    public List<Product>? Products
    {
        get
        {
            return data.Products.Local.ToList<Product>();
        }
    }

    public void Run()
    {
        do
        {
            Print();
        } while (UserAction);
    }

    public void Print()
    {
        TableDraw();
    }

    public void TableDraw()
    {
        var MachineTable = new Table();

        MachineTable.AddColumn(" \n\n\n\n\n\n");
        MachineTable.AddColumn(new TableColumn(" "));
        MachineTable.AddRow(" \n\n\n\n\n\n");

        MachineTable.Width(40);

        AnsiConsole.Write(MachineTable);
    }


}