namespace PoliceDepartmentIS;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        using (var splash = new SplashForm())
        {
            splash.ShowDialog();
        }

        Application.Run(new MainForm());
    }    
}
