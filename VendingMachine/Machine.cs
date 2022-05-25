using VendingMachineSpectre;
using System.Text;
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
    
    public static bool UserAction = false;

    public static void Run()
    {
        do
        {
            MachineFunc.Print();
            
        } while (UserAction);
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.GetEncoding(20127);
        Console.Title = "Vending Machine";
        
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        ShowWindow(ThisConsole, MAXIMIZE);
        

        Run();

        Console.ReadKey();
    }
}

public class MachineFunc
{
    MachineDbContext data = new MachineDbContext();
    public List<Product>? Products
    {
        get
        {
            return data.Products.Local.ToList<Product>();
        }
    }

    public static void Print()
    {
        TableDraw draw = new TableDraw();
        draw.DrawTop();
        draw.DrawMidSpacer();
        draw.DrawMiddle();
        draw.DrawMidSpacer();
        draw.DrawMiddle();
        draw.DrawMidSpacer();
        draw.DrawBottom();
    }
}