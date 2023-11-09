using System;
using System.Windows.Forms;
using ThreeCee.Forms;

namespace ThreeCee;

// TODO: Form: Add vehicle; connect to button
// TODO: Form: Edit vehicle; connect to button
// TODO: connect remove vehicle to button

internal static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}