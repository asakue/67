namespace PoliceDepartmentIS;

internal partial class SplashForm : Form
{
    public SplashForm()
    {
        InitializeComponent();
    }

    private void SplashForm_Shown(object sender, EventArgs e)
    {
        timer.Start();
    }

    private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        timer.Stop();
    }

    private void Timer_Tick(object sender, EventArgs e) => Close();
}
