using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ThreeCee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e) => ExitApp();

        private void ExitApp()
        {
            Application.Exit();
        }

        //DrawItem event handler for your ListBox
        void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //add new vehicle here (new screen)
            Debug.WriteLine("Add new vehicle!");
        }

        private void gitHubRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens github repo (Help > GitHub Repository)
            string target = "https://github.com/leysont/ThreeCee";
            System.Diagnostics.Process.Start(target);
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reroutes click on menu 'Add Vehicle' to actual function
            toolStripButton1_Click(sender, e);
        }
    }
}