using System;
using System.Windows.Forms;
using ThreeCee.Forms;

namespace ThreeCee;

// TODO: Form: Add vehicle; connect to button
// TODO: about screen linked in help menu with link to github, license, description, year

internal static class Program
{
    public static MainForm mainForm;
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        mainForm = new MainForm();
        Application.Run(mainForm);
    }
}