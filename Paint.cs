using System.Diagnostics;
using System.Drawing;

internal class Paint
{
    static Graphics graphics; 

    static Paint instance;

    private Paint() {
        graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);
    }

    public Graphics Graphics { get => graphics; }

    public static Paint GetInstance()
    { 
        if (instance == null)
            instance = new Paint();
        return instance;
    }
}